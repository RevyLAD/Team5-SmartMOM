using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Facilities : Team5_SmartMOM.BaseGridForm
    {
        public Facilities()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacilitiesCrowRegister frm = new FacilitiesCrowRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void panelMid_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
