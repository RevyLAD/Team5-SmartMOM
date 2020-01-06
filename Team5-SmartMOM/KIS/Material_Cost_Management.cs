using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.KIS
{
    public partial class Material_Cost_Management : Team5_SmartMOM.BaseGridForm
    {
        public Material_Cost_Management()
        {
            InitializeComponent();
        }

        private void Btn_newitem_Click(object sender, EventArgs e)
        {
            Material_Cost_Management_detail frm = new Material_Cost_Management_detail();
            frm.ShowDialog();
        }
    }
}
