using Project_DAC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class EnterpriseRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public EnterpriseRegister()
        {
            InitializeComponent();
        }

        private void panelDock_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != null && textBox2.Text.Trim() != null &&
                comboBox1.Text.Trim() != null && comboBox2.Text.Trim() != null &&
                comboBox3.Text.Trim() != null && comboBox4.Text.Trim() != null)
            {
                EnterpriseDAC dac = new EnterpriseDAC();

                InsertVO vo = new InsertVO();

                vo.EntCode = textBox1.Text.Trim();
                vo.EntName = textBox2.Text.Trim();
                vo.EntType = comboBox1.Text.Trim();
                vo.Owner = textBox5.Text.Trim();
                vo.No = textBox6.Text.Trim();
                vo.WorkType = textBox7.Text.Trim();
                vo.UpTae = textBox8.Text.Trim();
                vo.Manager = txtTurn.Text.Trim();
                vo.Email = textBox9.Text.Trim();

                //vo.UMU = ;
                //vo.StartDate;
                //vo.EndDate;
                //vo.Phone;
                //vo.Fax;
                //vo.Auto;
                //vo.GoUMU;
                //vo.UseUMU;
                //vo.Modi;
                //vo.ModiDate;
                //vo.Info;

                //dac.InsertEnterprise(vo);
            }
            else
            {
                MessageBox.Show("필수 항목을 모두 입력해주세요");
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