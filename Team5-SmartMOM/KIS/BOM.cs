using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.KIS
{
    public partial class BOM : Team5_SmartMOM.BaseGridForm
    {
        public BOM()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            BOM_detail frm = new BOM_detail();
            frm.ShowDialog();
        }

        private void Btn_newitem_Click_1(object sender, EventArgs e)
        {
            BOM_detail frm = new BOM_detail();
            frm.ShowDialog();
        }
    }
}
