using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
{
    public partial class Enterprise : Team5_SmartMOM.BaseGridForm
    {
        public Enterprise()
        {
            InitializeComponent();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            EnterpriseRegister frm = new EnterpriseRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void Enterprise_Load(object sender, EventArgs e)
        {

        }

        private void DataLoad()
        {
            HSC_Service service = new HSC_Service();
        }
    }
}
