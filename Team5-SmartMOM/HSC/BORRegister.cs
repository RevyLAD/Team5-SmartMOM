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
            if(cboFacCrow.Text.Trim()!=""&&
                cboFacCate.Text.Trim()!=""&&
                cboHighFac.Text.Trim()!=""&&
                cboUMU.Text.Trim()!=""&&
                cboUse.Text.Trim()!="")
            {
                BORVO vo = new BORVO();
                HSC_Service service = new HSC_Service();
                vo.BOR_Ohters = txtExplain.Text;
                vo.BOR_Priority = Convert.ToInt32(cboUMU.Text);
                vo.BOR_TactTime = Convert.ToInt32(txtFacName.Text);
                vo.BOR_UseOrNot = cboUse.Text;
                vo.BOR_yeild = Convert.ToInt32(txtYeild.Text);
                vo.FACG_Code = cboHighFac.Text.Trim();
                vo.FAC_Code = cboFacCate.Text;
                vo.ITEM_Code = cboFacCrow.Text;
                service.InsertBOR(vo);
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

            CommonUtil.ComboBinding(cboFacCrow, cmservice.GetFacilityClass(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboUse, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboUMU, cmservice.GetOffer(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboHighFac, cmservice.GetROUTE(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboFacCate, service.GetAllFacilitiesDetail(), "FAC_Code", "FAC_Name");
        }
    }
}
