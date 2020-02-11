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
    public partial class FacilitiesCrowRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public FacilitiesCrowRegister()
        {
            InitializeComponent();
        }

        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FacilitiesCrowRegister_Load(object sender, EventArgs e)
        {
            CommonCodeService cmservice = new CommonCodeService();
            CommonUtil.ComboBinding(cboUMU, cmservice.GetUse(), "Common_Key", "Common_Value");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNo.Text.Trim()!=""&& txtFacName.Text.Trim() != "" && txtCode.Text.Trim() != "")
            {
                HSC_Service service = new HSC_Service();
                FacilitieVO vo = new FacilitieVO();

                vo.FACG_No = Convert.ToInt32(txtNo.Text.Trim());
                vo.FACG_Code = txtCode.Text.Trim();
                vo.FACG_Information = txtExplain.Text.Trim();
                vo.FACG_Modifier = txtModi.Text.Trim();
                vo.FACG_ModifyDate = dateTimePicker1.Value ;
                vo.FACG_Name = txtFacName.Text.Trim();
                vo.FACG_UseOrNot = cboUMU.Text.Trim();

                service.InsertFacilities(vo);
                MessageBox.Show("성공적으로 등록되었습니다");
                this.Close();
            }
            else
            {
                MessageBox.Show("필수정보를 입력해주세요");
            }
        }

        private void panelFull_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
