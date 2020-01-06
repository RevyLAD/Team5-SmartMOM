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
    public partial class WorkOrderList : Form
    {
        public WorkOrderList()
        {
            InitializeComponent();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            RegisterPopUp frm = new RegisterPopUp();
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            RegisterPopUp frm = new RegisterPopUp();
            frm.ShowDialog();
        }
    }
}
