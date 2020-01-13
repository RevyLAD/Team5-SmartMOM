using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MasterCreate frm = new MasterCreate();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();

        }
    }
}
