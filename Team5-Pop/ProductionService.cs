using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Data.SqlClient;
using System.Configuration;

namespace Team5_Pop
{
    public partial class ProductionService : ServiceBase
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

        public ProductionService()
        {
            InitializeComponent();
        }

        //protected override void OnStart(string[] args)
        public void OnStart()
        {
            Console.WriteLine("서비스 시작");
            AsyncEchoServer().Wait();
        }

        async Task AsyncEchoServer()
        {
            TcpListener listener = new TcpListener(IPAddress.Any, 7000);
            listener.Start();
            while (true)
            { 
                TcpClient tc = await listener.AcceptTcpClientAsync().ConfigureAwait(false);
                await Task.Factory.StartNew(AsyncTcpProcess, tc);
            }
        }

        private async void AsyncTcpProcess(object o)
        {
            TcpClient tc = (TcpClient)o;
            NetworkStream stream = tc.GetStream();

            byte[] buff = new byte[1024];
            var readTask = stream.ReadAsync(buff, 0, buff.Length);
            int nbytes = readTask.Result;
            if (nbytes > 0)
            {
                //20200204 12:01:20 Machine7/65/4/0
                string[] arrData = Encoding.ASCII.GetString(buff, 0, nbytes).Split('/');
                if (arrData.Length == 5)
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = new SqlConnection(strConn);
                        cmd.CommandText = "insert into WorkQtyLog(ProductID, MachineID, Qty, BadQty) values (@ProductID, @MachineID, @Qty, @BadQty)";

                        cmd.Parameters.AddWithValue("@ProductID", int.Parse(arrData[2]));
                        cmd.Parameters.AddWithValue("@MachineID", int.Parse(arrData[1]));
                        cmd.Parameters.AddWithValue("@Qty", int.Parse(arrData[3]));
                        cmd.Parameters.AddWithValue("@BadQty", int.Parse(arrData[4]));

                        cmd.Connection.Open();
                        cmd.ExecuteNonQuery();
                        cmd.Connection.Close();
                    }
                }



                Console.WriteLine(Encoding.ASCII.GetString(buff, 0, nbytes));
                Program.Log.WriteInfo(Encoding.ASCII.GetString(buff, 0, nbytes));

                await stream.WriteAsync(buff, 0, nbytes).ConfigureAwait(false);
            }

            stream.Close();
            tc.Close();
        }

        protected override void OnStop()
        {
        }
    }
}
