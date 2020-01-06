using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.HSM
{
    public partial class MasterUpload_PO_ : Team5_SmartMOM.BaseOnlyGridForm
    {
        public MasterUpload_PO_()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MasterCreate frm = new MasterCreate();
            frm.Show();
        }
    }
}
