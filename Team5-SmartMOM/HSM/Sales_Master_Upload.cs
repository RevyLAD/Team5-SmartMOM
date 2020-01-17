using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master_Upload : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master_Upload()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasterCreate frm = new MasterCreate();
            frm.StartPosition = FormStartPosition.CenterScreen;
            

            if(frm.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = frm.ExcelData;
                dataGridView1.DataSource = dt;
            }
        }
    }
}
