using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class FacilitiesDetail : Team5_SmartMOM.Facilities
    {
        public FacilitiesDetail()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FacilitiesRegister frm = new FacilitiesRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
