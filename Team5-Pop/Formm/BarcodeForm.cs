using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_Pop
{
    public partial class BarcodeForm : Form
    {
        String msg;
        #region 시리얼포트 연결
        /* 시리얼포트 정의 */
        private SerialPort _Port;
        /// <summary>
        /// 시리얼포트 컨트롤 객체
        /// </summary>
        private SerialPort Port
        {
            get
            {
                if (_Port == null)
                {
                    _Port = new SerialPort();
                    _Port.PortName = "COM3";
                    _Port.BaudRate = 9600;
                    _Port.DataBits = 8;
                    _Port.Parity = Parity.None;
                    _Port.Handshake = Handshake.None;
                    _Port.StopBits = StopBits.One;
                    _Port.Encoding = Encoding.UTF8;
                    _Port.DataReceived += Port_DataReceived;
                }
                return _Port;
            }
        }
        /// <summary>
        /// 시리얼포트 상태 및 컨트롤 제어
        /// </summary>
        private Boolean IsOpen
        {
            get { return Port.IsOpen; }
            set
            {
                if (value)
                {
                    Strings = "연결 됨";
                }
                else
                {
                    Strings = "연결 해제됨";
                }
            }
        }
        /* 로그 제어 */
        private StringBuilder _Strings;
        /// <summary>
        /// 로그 객체
        /// </summary>
        private String Strings
        {
            set
            {
            //    if (_Strings != null)
            //        _Strings.Clear();
                if (_Strings == null)
                    _Strings = new StringBuilder(1024);
           // 로그 길이가 1024자가 되면 이전 로그 삭제
                if (_Strings.Length >= (1024 - value.Length))
                _Strings.Clear();
            // 로그 추가 및 화면 표시
            _Strings.Append(value);
                txtWorkOrderID.Text = _Strings.ToString();
                
            }
        }


        #endregion

        private void SerialPortConnecting()
        {
            //if (!Port.IsOpen)
            //{
            //    현재 시리얼이 연결된 상태가 아니면 연결.
            //    Port.PortName = "COM3";
            //    Port.BaudRate = 9600;
            //    Port.DataBits = 8;
            //    Port.Parity = Parity.None;
            //    Port.Handshake = Handshake.None;

                try
                {
                    // 연결
                    Port.Open();
                }
                catch (Exception ex) { MessageBox.Show("[ERR] {0}", ex.Message); }
            //}
            // 상태 변경
            IsOpen = Port.IsOpen;
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            msg = Port.ReadExisting();
            MessageBox.Show(msg);

            this.Invoke(new EventHandler(delegate
            {
                Strings = String.Format("{0}", msg);
            }));
   
  
        }


        public BarcodeForm()
        {
            InitializeComponent();
        }

        private void BarcodeForm_Load(object sender, EventArgs e)
        {
            SerialPortConnecting();
        }

        private void BarcodeForm_Activated(object sender, EventArgs e)
        {
            
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void BarcodeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Port.Close();
        }

    }
}
