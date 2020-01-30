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
    public partial class FacilitiesRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public FacilitiesRegister()
        {
            InitializeComponent();
        }

        private void panelDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilitiesRegister_Load(object sender, EventArgs e)
        { 
            CommonCodeService cmservice = new CommonCodeService();
            HSC_Service service = new HSC_Service();
            List < CommonCodeVO > list = cmservice.GetFacilityType();
            List<CommonCodeVO> list_1 = new List<CommonCodeVO>();
            List<CommonCodeVO> list_2 = new List<CommonCodeVO>();

            foreach (CommonCodeVO item in list)
            {
                list_1.Add(item);
                list_2.Add(item);
            }

            CommonUtil.ComboBinding(cboBadWareHouse, list_2, "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboOutWareHouse, list_1, "Common_Key", "Common_Value");

            list.RemoveAt(5);
            CommonUtil.ComboBinding(cboInWareHouse, list, "Common_Key", "Common_Value");

            CommonUtil.ComboBinding(cboUse, cmservice.GetUse(), "Common_Key", "Common_Value");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FACG_Code.Text.Trim() != "" &&
                FAC_Code.Text.Trim() != "" &&
                txtFac_Name.Text.Trim() != "" &&
                cboOutWareHouse.Text.Trim() != "" &&
                cboInWareHouse.Text.Trim() != "")
            {
                FacilitieDetailVO vo = new FacilitieDetailVO();
                HSC_Service service = new HSC_Service();

                vo.FACG_Code = FACG_Code.Text.Trim();
                vo.FAC_BadWareHouse = cboBadWareHouse.Text.Trim();
                vo.FAC_InWareHouse = cboInWareHouse.Text.Trim();
                vo.FAC_Modifier = txtModifier.Text.Trim();
                vo.FAC_ModifiyDate = Convert.ToDateTime(txtModifiyDate.Text.Trim());
                vo.FAC_Code = FAC_Code.Text.Trim();
                vo.FAC_Name = txtFac_Name.Text.Trim();
                vo.FAC_Others = txtOthers.Text;
                vo.FAC_Remark = txtRemark.Text;
                vo.FAC_UseOrNot = cboUse.Text.Trim();
                vo.FAC_OutWareHouse = cboOutWareHouse.Text.Trim();

                service.InsertFacilitieDetail(vo);

                MessageBox.Show("성공적으로 등록되었습니다");
                this.Close();
            }
            else
            {
                MessageBox.Show("필수 사항을 모두 입력해주세요");
            }
        }
    }
}
