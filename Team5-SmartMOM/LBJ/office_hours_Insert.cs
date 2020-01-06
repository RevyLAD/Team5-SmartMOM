using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours_Insert : Team5_SmartMOM.BasePopUpDialog
    {
        public office_hours_Insert()
        {
            InitializeComponent();
        }

        private void office_hours_Insert_Load(object sender, EventArgs e)
        {
            txtReviceDay.Text = DateTime.Now.ToString(); 
        }
    }
}
