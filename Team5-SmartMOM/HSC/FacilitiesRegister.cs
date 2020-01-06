using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class FacilitiesRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public FacilitiesRegister()
        {
            InitializeComponent();
        }

        private void panelDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
