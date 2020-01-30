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
    public partial class PoPMain : Form
    {
        public PoPMain()
        {
            InitializeComponent();
        }

        private void PoPMain_Load(object sender, EventArgs e)
        {
            //현재 시간 상단 출력
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblNowDate.Text = DateTime.Now.ToLongDateString();
            lblNowTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
