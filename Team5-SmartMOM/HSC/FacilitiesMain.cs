using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class FacilitiesMain : Form
    {
        public FacilitiesMain()
        {
            InitializeComponent();
        }

        private void FacilitiesMain_Load(object sender, EventArgs e)
        {
            Facilities fac = new Facilities();
            fac.TopLevel = false;
            fac.Dock = DockStyle.Fill;
            fac.FormBorderStyle = FormBorderStyle.None;
            fac.Show();

            FacilitiesDetail fcr = new FacilitiesDetail();
            fcr.TopLevel = false;
            fcr.Dock = DockStyle.Fill;
            fcr.FormBorderStyle = FormBorderStyle.None;
            fcr.Show();

            splitContainer1.Panel1.Controls.Add(fac);
            splitContainer1.Panel2.Controls.Add(fcr);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

