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
using Team5_SmartMOM.HSC;
using Team5_SmartMOM.PSM;
using Team5_SmartMOM.HSM;
using Team5_SmartMOM.KIS;
using System.Reflection;
using Team5_SmartMOM.Properties;

namespace Team5_SmartMOM
{
    public partial class MainForm : Form
    {

        bool check = false;
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
            Color startColor = Color.FromArgb(250, 250, 250);
            Color middleColor = Color.FromArgb(121, 159, 229);
            Color endColor = Color.FromArgb(250, 250, 250);

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
        private void toolStripButton_Click(object sender, EventArgs e)
        {
            panelSideMenu.Visible = !panelSideMenu.Visible;
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {

                ToolStripButton button = (ToolStripButton)sender;
                char sp = '.';
                char sp2 = ',';
                string[] start;
                string[] end;
                string sub = button.Tag.ToString();
                start = button.Tag.ToString().Split(sp);
                end = start[2].Split(sp2);


                string form = sub.Substring(0, 18);
                string namespaced = end[0];
                Assembly cuasm = Assembly.GetExecutingAssembly();
                Form frm = (Form)cuasm.CreateInstance(string.Format("{0}.{1}", form, namespaced));
                check = true;
                CreateTabPages(button.Name, frm);

                start = null;
                end = null;
            
          
        }

        #endregion


        private void CreateTabPages(string text, Form OpenForm)
        {
            string first;
            foreach (TabPage childForm in this.tabControl1.TabPages)
            {
                if (childForm.Text == text)
                {
                    tabControl1.SelectedTab = childForm;
                    return;
                }
            }
            TabPage myTabPage = new TabPage();
            myTabPage = new TabPage();
            myTabPage.Text = text;
            myTabPage.ImageIndex = 0;
            
            first = OpenForm.ToString();
            myTabPage.Tag = first.ToString();
            
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

        #region 탭페이지 생성
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
            CreateTabPages("업체관리", new EnterPriseMain());
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
            CreateTabPages("수입 검사 현황", new Import_Check_state());
        }

        private void 정규발주ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("정규발주", new Purchasing());
        }

        private void 발주현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("발주현황", new Purchasing_State());
        }

        private void 입고대기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("입고대기", new Supplier());
        }

        private void 자재입고ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재입고", new Material_Ledger());
        }

        private void 자재입고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재입고현황", new Material_Ledger_State());
        }

        private void 자재재고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재재고현황", new Stock_State());
        }

        private void 자재불출요청ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재불출요청", new Materia_Request());
        }

        private void 원자재불출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("원자재불출", new Material_Ledger_Export());
        }

        private void 입출고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("입출고현황", new Stock_RF_State());
        }

        private void 자재소요계호기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재소요계획", new Meterial_Plan());
        }

        private void 생산계획ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("생산계획", new Product_Plan());
        }

        private void 외주계획ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("외주계획", new OutSourcing_Plan());
        }

        private void 영업마스터ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("영업마스터", new Sales_Master());
        }
        private void 제품출하ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("고객주문별재고현황", new CustomerOrderStatus());
        }

        private void 출하현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("출하현황", new ShipmentStatus());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTabPages("영업마스터업로드", new Sales_Master_Upload());
        }

        private void BOMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("BOM", new BOM());
        }

        private void 품목관리ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTabPages("품목관리", new Item_Management());
        }

        private void 수요계획ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("수요계획", new Demand_Plan());
        }

        private void 작업지시생성ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTabPages("작업지시생성", new WorkOrder());
        }

        private void 작업지시현황ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CreateTabPages("작업지시현황", new WorkOrderList());
        }

        private void 영업단가관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("영업단가관리", new Sales_Price_Management());
        }

        private void 자재단가관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("자재단가관리", new Material_Cost_Management());
        }
        private void 출하및매출마감ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("출하및매출마감", new ShipmentOrder());
        }

        #endregion
        private void ToolStripButton4_Click(object sender, EventArgs e)
        {
            bool truefalse = true;
            ToolStripButton button = new ToolStripButton();
            ToolStripSeparator separator = new ToolStripSeparator();
            if (tabControl1.TabPages.Count == 0)
            {
                MessageBox.Show("현재 출력되어있는 화면이 없어 즐겨찾기를 등록할수 없습니다!","경고");
                truefalse = false;
            }

            else
            {
                for (int i = 0; i < ts.Items.Count; i++)
                {
                    if (tabControl1.SelectedTab.Text == ts.Items[i].Text)
                    {
                        MessageBox.Show("즐겨찾기 중 중복된 태그가 있습니다. ");
                        truefalse = false;
                    }
                }
                if (truefalse)
                {

                    Random rnd = new Random();
                    MessageBox.Show("즐겨찾기에 새로운 목록을 생성했습니다.", "확인");
                    button.Name = tabControl1.SelectedTab.Text;
                    button.Tag = tabControl1.SelectedTab.Tag;
                    button.Text = tabControl1.SelectedTab.Text;
                    button.Click += new System.EventHandler(this.toolStripButton1_Click);
                    button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
                    button.Image = imageList1.Images[rnd.Next(0, 52)];

                    ts.Items.Add(button);
                    ts.Items.Add(separator);
                }
            }
        }

        private void tsBtnCal_Click(object sender, EventArgs e) // 계산기 실행
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void tsBtnNote_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void 공정재고현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabPages("공정재고현황", new Stack_Status());
        }
    }
}
