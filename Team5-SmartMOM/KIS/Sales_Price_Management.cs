using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Sales_Price_Management : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Price_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Sales_Price_Management_detail frm = new Sales_Price_Management_detail();
            frm.ShowDialog();

        }
    }
}
