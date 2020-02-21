using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_Pop
{
    public partial class FacControl : UserControl
    {
        public FacControl(string FAC_Name)
        {
            InitializeComponent();
            this.FAC_Name = FAC_Name;
        }
        PopService service;
        string FAC_Name;
        private void GoodAmount_TextChanged(object sender, EventArgs e)
        {
            TotalAmount.Text = Convert.ToString((Convert.ToInt32(GoodAmount.Text.Trim()) + Convert.ToInt32(BadAmount.Text.Trim())).ToString("0000"));
            RestAmount.Text = Convert.ToString((Convert.ToInt32(Order_Amount.Text.Trim()) - Convert.ToInt32(GoodAmount.Text.Trim())).ToString("0000"));
        }

        private void ControlTimer_Tick(object sender, EventArgs e)
        {
            service = new PopService();

            int Signal = 0;
            switch (service.GetFACSignal(groupBox1.Text.Trim()))
            {
                case "가동":
                    Signal = 1;
                    break;
                case "비가동":
                    Signal = 2;
                    break;
                case "일시정지":
                    Signal = 3;
                    break;
            }

            switch (Signal)
            {
                case 1:
                    this.RunningSginal_IMG.Image = RunningImg.Images[0];
                    break;
                case 2:
                    this.RunningSginal_IMG.Image = RunningImg.Images[2];
                    break;
                case 3:
                    this.RunningSginal_IMG.Image = RunningImg.Images[1];
                    break;
            }

            if (Signal == 1 || Signal == 3)
            {
                string WO_ID = service.GetWO_ID(groupBox1.Text.Trim());
                List<ControlVO> thisvo = service.GetInfoForControl(groupBox1.Text.Trim(), WO_ID);
                if (thisvo.Count >0 && thisvo != null)
                {
                    Order_Amount.Text = Convert.ToString(thisvo[0].directQty.ToString("0000"));
                    Work_ID.Text = thisvo[0].WO_ID;
                    ITEM_Name.Text = thisvo[0].ITEM_Code;
                    GoodAmount.Text = Convert.ToString(thisvo[0].GoodQty.ToString("0000"));
                    BadAmount.Text = Convert.ToString(thisvo[0].BadQty.ToString("0000"));
                }
            }

            ImageList img = new ImageList();
            //RunningSginal_IMG.Image = img.Images[Signal];
        }

        private void FacControl_Load(object sender, EventArgs e)
        {
            //this.Name = FacName;
            ControlTimer.Start();
        }
    }
}
