﻿using Project_DAC;
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
    public partial class EnterpriseRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public EnterpriseRegister()
        {
            InitializeComponent();
        }

        EnterpriseVO thisvo;
        public EnterpriseRegister(EnterpriseVO vo)
        {
            InitializeComponent();

            this.thisvo = vo;
        }

        private void panelDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCOM_Code.Text.Trim() != null && txtCOM_Name.Text.Trim() != null &&
                cboCOM_Type.Text.Trim() != null && cbo_UseOrNot.Text.Trim() != null && txtComNo.Text.Trim() != null)
            {
                EnterpriseVO vo = new EnterpriseVO();

                vo.COM_No = txtComNo.Text.Trim();
                vo.COM_Code = txtCOM_Code.Text.Trim();
                vo.COM_Email = txtCOM_Email.Text.Trim();
                vo.COM_Information = txtInformation.Text;
                vo.COM_Manager = txtCOM_Manager.Text.Trim();
                vo.COM_Modifier = txtModifier.Text.Trim();
                vo.COM_ModifiyDate = txtModifiyDate.Text.Trim();
                vo.COM_Name = txtCOM_Name.Text.Trim();
                vo.COM_Owner = txtCOM_Owner.Text.Trim();
                vo.COM_Phone = txtCOM_Phone.Text.Trim();
                vo.COM_Sector = txtCOM_Sector.Text.Trim();
                vo.COM_Type = cboCOM_Type.Text.Trim();
                vo.COM_UseOrNot = cbo_UseOrNot.Text.Trim();

                HSC_Service service = new HSC_Service();
                if (thisvo != null)
                {
                    service.UpdateEnterprise(vo);
                    MessageBox.Show("성공적으로 수정되었습니다");
                }
                else
                {
                    service.InsertEnterprise(vo);
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

        }

        private void EnterpriseRegister_Load(object sender, EventArgs e)
        {
            CommonCodeService codeService = new CommonCodeService();
            CommonUtil.ComboBinding(cbo_UseOrNot, codeService.GetUse(), "Common_Key", "Common_Value");
            CommonUtil.ComboBinding(cboCOM_Type, codeService.GetVENDOR(), "Common_Key", "Common_Value");

            if(this.thisvo != null)
            {
                txtComNo.Text = thisvo.COM_No;
                txtCOM_Code.Text = thisvo.COM_Code;
                txtCOM_Email.Text = thisvo.COM_Email;
                txtInformation.Text = thisvo.COM_Information;
                txtCOM_Manager.Text = thisvo.COM_Manager;
                txtModifier.Text = thisvo.COM_Modifier;
                txtModifiyDate.Text = thisvo.COM_ModifiyDate;
                txtCOM_Name.Text = thisvo.COM_Name;
                txtCOM_Owner.Text = thisvo.COM_Owner;
                txtCOM_Phone.Text = thisvo.COM_Phone;
                txtCOM_Sector.Text = thisvo.COM_Sector;
                cboCOM_Type.Text = thisvo.COM_Type;
                cbo_UseOrNot.Text = thisvo.COM_UseOrNot;
            }

        }
    }

    public class InsertVO
    {
        public string EntCode;
        public string EntName;
        public string EntType;
        public string Owner;
        public string No;
        public string WorkType;
        public string UpTae;
        public string Manager;
        public string Email;
        public string UMU;
        public string StartDate;
        public string EndDate;
        public string Phone;
        public string Fax;
        public string Auto;
        public string GoUMU;
        public string UseUMU;
        public string Modi;
        public string ModiDate;
        public string Info;
    }
}