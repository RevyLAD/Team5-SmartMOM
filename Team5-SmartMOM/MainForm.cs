using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.LBJ;

namespace Team5_SmartMOM
{
    public partial class MainForm : Form
    {
        private readonly DrawItemEventHandler tabControl1_DrawItem;
        private Point _imageLocation = new Point(13, 5);
        private Point _imgHitArea = new Point(13, 2);

        public MainForm()
        {
            InitializeComponent();
        }

        public Bitmap CloseImage { get; private set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.menuStrip1.BackColor = Color.FromArgb(255, 255, 230);

            tabControl1.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl1.DrawItem += tabControl1_DrawItem;
            CloseImage = Properties.Resources.delete;
            tabControl1.Padding = new Point(10, 3);


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

        #region 탭페이지 이미지, x버튼
        private void metroTabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                Image img = new Bitmap(CloseImage);
                Rectangle r = e.Bounds;
                r = this.tabControl1.GetTabRect(e.Index);
                r.Offset(2, 2);
                Brush TitleBrush = new SolidBrush(Color.Black);
                Font f = this.Font;
                string title = this.tabControl1.TabPages[e.Index].Text;

                e.Graphics.DrawString(title, f, TitleBrush, new PointF(r.X, r.Y));

                if (tabControl1.SelectedIndex >= 1)
                {
                    e.Graphics.DrawImage(img, new Point(r.X + (this.tabControl1.GetTabRect(e.Index).Width - _imageLocation.X)-7, _imageLocation.Y));
                }
            }
            catch (Exception) { }
        }

        private void metroTabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            TabControl tc = (TabControl)sender;
            Point p = e.Location;
            int _tabWidth = 0;
            _tabWidth = this.tabControl1.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X);
            Rectangle r = this.tabControl1.GetTabRect(tc.SelectedIndex);
            r.Offset(_tabWidth, _imgHitArea.Y);
            r.Width = 16;
            r.Height = 16;
            if (tabControl1.SelectedIndex >= 1)
            {
                if (r.Contains(p))
                {
                    TabPage TabP = (TabPage)tc.TabPages[tc.SelectedIndex];
                    tc.TabPages.Remove(TabP);
                }

            }
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
            CreateTabPages("Shift기준정보", new office_hours());
        }

        private void shift스케줄관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("Shift스케줄 관리", new office_hours_management());
        }

        private void 수입검사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("수입검사현황", new Import_check());
        }
    }
}
