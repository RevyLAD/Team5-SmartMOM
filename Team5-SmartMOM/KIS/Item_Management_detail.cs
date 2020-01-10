using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Item_Management_detail : Team5_SmartMOM.BasePopUpDialog
    {
        public Item_Management_detail()
        {
            InitializeComponent();
        }

        private void Item_Management_detail_Load(object sender, EventArgs e)
        {
            txt_edit_date.Text = DateTime.Now.ToString();
        }
    }
}
