using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM
{
    public partial class BORRegister : Team5_SmartMOM.BasePopUpDialog
    {
        BORVO thisvo;
        public BORRegister()
        {
            InitializeComponent();
        }
        public BORRegister(BORVO vo)
        {
            InitializeComponent();

            this.thisvo = vo;
        }


        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboITEMCode.Text.Trim()!=""&&
                cboFacCode.Text.Trim()!=""&&
                cboFACG_Code.Text.Trim()!=""&&
                txtPriority.Text.Trim()!=""&&
                cboUMU.Text.Trim()!="")
            {
                HSC_Service service = new HSC_Service();
                thisvo.BOR_Ohters = txtExplain.Text;
                thisvo.BOR_Priority = Convert.ToInt32(txtPriority.Text);
                thisvo.BOR_TactTime = Convert.ToInt32(txtTacTime.Text);
                thisvo.BOR_UseOrNot = cboUMU.Text;
                thisvo.BOR_yeild = Convert.ToInt32(txtYeild.Text.Trim());
                thisvo.FACG_Code = cboFACG_Code.Text.Trim();
                thisvo.FAC_Code = cboFacCode.Text;
                thisvo.ITEM_Code = cboITEMCode.Text;

                if (thisvo != null)
                {
                    service.UpdateBOR(thisvo);
                    MessageBox.Show("성공적으로 수정되었습니다");
                }
                else
                {
                    service.InsertBOR(thisvo);
                    MessageBox.Show("성공적으로 등록되었습니다");

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("필수 항목을 모두 입력해주세요");
            }
        }

        private void panelFull_Paint(object sender, PaintEventArgs e)
        {
            CommonCodeService cmservice = new CommonCodeService();
            HSC_Service service = new HSC_Service();
            KIS_Service kser = new KIS_Service();

            CommonUtil.ComboBinding(cboITEMCode, kser.ShowITEM(), "ITEM_Code", "ITEM_Name");
            CommonUtil.ComboBinding(cboUMU, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboFACG_Code, cmservice.GetROUTE(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboFacCode, service.GetAllFacilitiesDetail(), "FAC_Code", "FAC_Name");
        }

        private void BORRegister_Load(object sender, EventArgs e)
        {
            if(thisvo != null)
            {
                txtExplain.Text = thisvo.BOR_Ohters;
                txtPriority.Text = Convert.ToString(thisvo.BOR_Priority);
                txtTacTime.Text= Convert.ToString(thisvo.BOR_TactTime);
                cboUMU.Text = thisvo.BOR_UseOrNot;
                txtYeild.Text = Convert.ToString(thisvo.BOR_yeild);
                cboFACG_Code.Text = thisvo.FACG_Code;
                cboFacCode.Text= thisvo.FAC_Code;
                cboITEMCode.Text = thisvo.ITEM_Code;
                cboITEMCode.Enabled = false;
            }
        }
    }
}
