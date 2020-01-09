using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Item_Management : Team5_SmartMOM.BaseGridForm
    {
        public Item_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Item_Management_detail frm = new Item_Management_detail();
            frm.ShowDialog();
        }
    }
}
