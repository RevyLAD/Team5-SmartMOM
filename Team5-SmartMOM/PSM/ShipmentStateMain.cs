using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.HSC;

namespace Team5_SmartMOM.PSM
{
    public partial class ShipmentStateMain : Form
    {
        ShipmentStatus so;
        DeadLineState ds;
        public ShipmentStateMain()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShipmentStateMain_Load(object sender, EventArgs e)
        {
            so = new ShipmentStatus();
            so.TopLevel = false;
            so.Dock = DockStyle.Fill;
            so.FormBorderStyle = FormBorderStyle.None;
            so.Show();


            ds = new DeadLineState();
            ds.TopLevel = false;
            ds.Dock = DockStyle.Fill;
            ds.FormBorderStyle = FormBorderStyle.None;
            ds.Show();

            splitContainer1.Panel1.Controls.Add(so);
            splitContainer1.Panel2.Controls.Add(ds);
        }
    }
}
