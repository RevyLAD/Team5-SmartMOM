using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    //폼이름
    public partial class FactoryManager : Team5_SmartMOM.BaseGridForm
    {
        public FactoryManager()
        {

            InitializeComponent();
        }

        private void panelMid_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FactoryRegister frm = new FactoryRegister();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }
    }
}
