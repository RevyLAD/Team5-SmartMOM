using Project_DAC;
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
    public partial class FactoryRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public FactoryRegister()
        {
            InitializeComponent();
            mode = 1;
        }

        public FactoryRegister(FactoryVO select_vo)
        {
            InitializeComponent();
            update_vo = select_vo;
            mode = 2;
        }

        int mode;
        // 1 : 신규 생성
        // 2 : 정보 수정

        FactoryVO update_vo;

        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cboFacCrow.Text.Trim() != "" &&
                cboHighFac.Text.Trim() != "" &&
                txtFacCode.Text.Trim() != "" &&
                cboFacCate.Text.Trim() != "" &&
                cboUse.Text.Trim() != "")
            {
                FactoryVO fvo = new FactoryVO();
                fvo.FACT_Class = cboFacCate.Text.Trim();
                fvo.FACT_Code = txtFacCode.Text.Trim();
                fvo.FACT_Group = cboFacCrow.Text.Trim();
                fvo.FACT_Type = cboFacCate.DisplayMember.Trim();
                fvo.FACT_Information = txtExplain.Text.Trim();
                fvo.FACT_MATDeducation = cboMaterials.Text.Trim();
                fvo.FACT_Modifier = txtModifier.Text.Trim();
                fvo.FACT_ModifyDate = Convert.ToDateTime(txtModifyTime.Text.Trim());
                fvo.FACT_Name = txtFacName.Text.Trim();
                fvo.FACT_Parent = cboHighFac.Text.Trim();
                //fvo.FACT_Type = 
                fvo.FACT_UseOrNot = cboUse.Text.Trim();

                HSC_Service service = new HSC_Service();
                if (mode == 1)
                {
                    service.InsertFactory(fvo);
                    MessageBox.Show("성공적으로 등록되었습니다");
                }
                else if(mode == 2)
                {
                    service.UpdateFactory(fvo, txtFacCode.Text);
                    MessageBox.Show("성공적으로 수정되었습니다");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("필수 입력 사항을 모두 입력해주세요");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelFull_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FactoryRegister_Load(object sender, EventArgs e)
        {
            ComboLoad();
            HSC_Service service = new HSC_Service();

            if (mode == 1)
                txtModifyTime.Text = DateTime.Now.ToString();
            else if (mode == 2)
            {
                txtFacCode.Text= update_vo.FACT_Class;
                txtFacName.Text = update_vo.FACT_Name;
                txtModifier.Text = update_vo.FACT_Modifier;
                txtExplain.Text = update_vo.FACT_Information;
                cboFacCrow.Text = update_vo.FACT_Group;
                cboHighFac.Text = update_vo.FACT_Parent;
                cboMaterials.Text = update_vo.FACT_MATDeducation;
                cboFacCate.Text = update_vo.FACT_Type;
                cboUse.Text = update_vo.FACT_UseOrNot;
                txtModifyTime.Text = service.GetModiTime(txtFacCode.Text.Trim());
            }

        }

        private void ComboLoad()
        {
            HSC_Service service = new HSC_Service();
            CommonCodeService cmservice = new CommonCodeService();
            CommonUtil.ComboBinding(cboFacCate, cmservice.GetFacilityType(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboFacCrow, cmservice.GetFacilityClass(), "Common_Key", "Common_Value");

            CommonUtil.ComboBinding(cboSuse, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboGuse, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboUse, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboMaterials, cmservice.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboUMU, cmservice.GetOffer(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboCompany, cmservice.GetCompanyList(), "COM_Code", "COM_Name");
            CommonUtil.ComboBinding(cboHighFac, cmservice.GetFactoryList(), "FACT_Code", "FACT_Name");
        }
    }
}
