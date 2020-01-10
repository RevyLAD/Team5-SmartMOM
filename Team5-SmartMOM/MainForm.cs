using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Team5_SmartMOM.LBJ;

namespace Team5_SmartMOM
{
    public partial class MainForm : Form
    {
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);

        public MainForm()
        {
            InitializeComponent();
        }

        public Bitmap CloseImage { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form_Gradient(object sender, PaintEventArgs e)
        {
            LinearGradientBrush br = new LinearGradientBrush(this.panelSideMenu.ClientRectangle,
                                                                Color.FromArgb(155, 155, 155),
                                                                Color.FromArgb(200, 200, 200),
                                                                0,
                                                                false);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
        private void SidePanel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(0, 0, 0);
            Color middleColor = Color.FromArgb(121, 159, 229);
            Color endColor = Color.FromArgb(0, 0, 0);

            LinearGradientBrush br = new LinearGradientBrush(this.panelSideMenu.ClientRectangle,
                                                                Color.Black,
                                                                Color.Black,
                                                                0,
                                                                false);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 2f, 1 };
            cb.Colors = new[] { startColor, middleColor, endColor };

            br.InterpolationColors = cb;
            br.RotateTransform(45);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }

        private void SubPanel_Gradient(object sender, PaintEventArgs e)
        {

        }


        #region Slide Menu Design

        //private void hideSubMenu()
        //{
        //    if (panelSubMenu1.Visible == true)
        //        panelSubMenu1.Visible = false;
        //    if (panelSubMenu2.Visible == true)
        //        panelSubMenu2.Visible = false;
        //    if (panelSubMenu3.Visible == true)
        //        panelSubMenu3.Visible = false;
        //}

        //private void showSubMenu(Panel subMenu)
        //{
        //    if (subMenu.Visible == false)
        //    {
        //        hideSubMenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //        subMenu.Visible = false;
        //}
        private void btnOpenList1_Click(object sender, EventArgs e)
        {
            if (SubPanel1.Visible == true)
                SubPanel1.Visible = false;
            else
                SubPanel1.Visible = true;
        }

        private void btnOpenList2_Click(object sender, EventArgs e)
        {
            if (panelSubMenu2.Visible == true)
                panelSubMenu2.Visible = false;
            else
                panelSubMenu2.Visible = true;
        }

        private void btnOpenList3_Click(object sender, EventArgs e)
        {
            if (panelSubMenu3.Visible == true)
                panelSubMenu3.Visible = false;
            else
                panelSubMenu3.Visible = true;
        }

        private void btnOpenList4_Click(object sender, EventArgs e)
        {
            if (panelSubMenu4.Visible == true)
                panelSubMenu4.Visible = false;
            else
                panelSubMenu4.Visible = true;
        }

        private void btnOpenList5_Click(object sender, EventArgs e)
        {
            if (panelSubMenu5.Visible == true)
                panelSubMenu5.Visible = false;
            else
                panelSubMenu5.Visible = true;
        }

        private void btnOpenList6_Click(object sender, EventArgs e)
        {
            if (panelSubMenu6.Visible == true)
                panelSubMenu6.Visible = false;
            else
                panelSubMenu6.Visible = true;
        }

        private void btnOpenList7_Click(object sender, EventArgs e)
        {
            if (panelSubMenu7.Visible == true)
                panelSubMenu7.Visible = false;
            else
                panelSubMenu7.Visible = true;
        }

        private void btnOpenList8_Click(object sender, EventArgs e)
        {
            if (panelSubMenu8.Visible == true)
                panelSubMenu8.Visible = false;
            else
                panelSubMenu8.Visible = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            panelSideMenu.Visible = !panelSideMenu.Visible;
        }

        #endregion

        
        private void CreateTabPages(string text, Form OpenForm)
        {
            foreach (TabPage childForm in this.tabControl1.TabPages)
            {
                if (childForm.Text == text)
                {
                    tabControl1.SelectedTab = childForm;
                    return;
                }
            }

            TabPage myTabPage = new TabPage();
            myTabPage.Text = text;
            myTabPage.ImageIndex = 1;
            tabControl1.Controls.Add(myTabPage);


            myTabPage.Focus();

            OpenForm.TopLevel = false;
            OpenForm.Parent = this;
            myTabPage.Controls.Add(OpenForm);
            //창이 열리면서 최대화

            OpenForm.Dock = DockStyle.Fill;
            OpenForm.FormBorderStyle = FormBorderStyle.None;
            OpenForm.Show();

            tabControl1.SelectedTab = myTabPage;
        }


        private void btnMatList_Click(object sender, EventArgs e)
        {
            BaseGridForm frm = new BaseGridForm();
            CreateTabPages(btnMatList.Text, frm);

        }

        private void 공장관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("공장관리", new FactoryManager());

        }

        private void 설비관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("설비관리", new FacilitiesMain());
        }

        private void 업체관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("업체관리", new Enterprise());
        }

        private void bORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("BOR", new BOR());
        }

        private void shift기준정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("Shift 기준 정보", new office_hours());
        }

        private void shift스케줄관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("Shift 스케줄 관리", new office_hours_management());
        }

        private void 수입검사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("수입 검사 현황", new Import_check());
        }
    }
}
