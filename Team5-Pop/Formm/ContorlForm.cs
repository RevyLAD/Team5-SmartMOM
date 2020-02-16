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
    public partial class ContorlForm : Form
    {
        MainPoPForm mainform;
        public ContorlForm(MainPoPForm frm)
        {
            InitializeComponent();
            mainform = frm;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void TimeMangemer_Tick(object sender, EventArgs e)
        {
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void ContorlForm_Load(object sender, EventArgs e)
        {
            foreach(Control fc in this.Controls)
            {
                if (fc is FacControl)
                {
                   //((FacControl)fc).RunningSginal_IMG.Image = SignalIMG.Images[1];
                }
            }

            facControl1.groupBox1.Text = "";
            facControl2.groupBox1.Text = "";
            facControl3.groupBox1.Text = "";
            facControl4.groupBox1.Text = "";
            facControl5.groupBox1.Text = "";

        }
    }
}
