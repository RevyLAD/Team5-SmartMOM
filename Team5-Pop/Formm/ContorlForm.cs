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

            PopService service = new PopService();
            List<NewControlVO> newlist = service.GetNewControl();

            List<FacControl> frmlist = new List<FacControl>();

            for (int i=0; i<newlist.Count; i++)
            {
                frmlist.Add(new FacControl(newlist[i].FAC_Name));
            }

            int x = 50;
            int rowcount = 100;

            for (int i = 1; i <= frmlist.Count; i++)
            {
                frmlist[i-1].BackColor = System.Drawing.SystemColors.InactiveBorder;
                frmlist[i-1].Location = new System.Drawing.Point(x, rowcount);

                x += 300;

                if (i % 3 == 0)
                {
                    rowcount += 400;
                    x = 50;
                }

                frmlist[i-1].Name = "facControl"+i;
                frmlist[i-1].Size = new System.Drawing.Size(235, 350);
                frmlist[i-1].TabIndex = i;
                frmlist[i-1].groupBox1.Text = newlist[i-1].FAC_Name;
                frmlist[i - 1].FacImg.Image = FacilityIMG.Images[newlist[i-1].FAC_Name];
                this.Controls.Add(frmlist[i-1]);
            }
        }
    }
}
