using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_Pop
{
    public partial class ProductionRegister : Form
    {
        public ProductionRegister()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            RegisterPopUp frm = new RegisterPopUp();
            frm.ShowDialog();
        }
    }
}
