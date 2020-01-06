using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.LBJ
{
    public partial class office_hours : Team5_SmartMOM.BaseGridForm
    {
        public office_hours()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            office_hours_Insert frm = new office_hours_Insert();
            frm.Show();
        }

        private void office_hours_Load(object sender, EventArgs e)
        {
        }
    }
}
