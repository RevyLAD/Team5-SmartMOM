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
        int mode;
        public BORRegister(int mode)
        {
            InitializeComponent();

            this.mode = mode;
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
                BORVO vo = new BORVO();
                HSC_Service service = new HSC_Service();
                vo.BOR_Ohters = txtExplain.Text;
                vo.BOR_Priority = Convert.ToInt32(txtPriority.Text);
                vo.BOR_TactTime = Convert.ToInt32(txtTacTime.Text);
                vo.BOR_UseOrNot = cboUMU.Text;
                vo.BOR_yeild = Convert.ToInt32(txtYeild.Text);
                vo.FACG_Code = cboFACG_Code.Text.Trim();
                vo.FAC_Code = cboFacCode.Text;
                vo.ITEM_Code = cboITEMCode.Text;
                service.InsertBOR(vo);
                MessageBox.Show("성공적으로 등록되었습니다");
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
    }
}
