//namespace Team5_Pop
//{
//    partial class MainPOP
//    {
//        /// <summary>
//        /// 필수 디자이너 변수입니다.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// 사용 중인 모든 리소스를 정리합니다.
//        /// </summary>
//        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form 디자이너에서 생성한 코드

//        /// <summary>
//        /// 디자이너 지원에 필요한 메서드입니다. 
//        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            this.panelFull = new System.Windows.Forms.Panel();
//            this.panelMain = new System.Windows.Forms.Panel();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.lblTimeNow = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.timer1 = new System.Windows.Forms.Timer(this.components);
//            this.metroTile4 = new MetroFramework.Controls.MetroTile();
//            this.metroTile3 = new MetroFramework.Controls.MetroTile();
//            this.metroTile2 = new MetroFramework.Controls.MetroTile();
//            this.metroTile1 = new MetroFramework.Controls.MetroTile();
//            this.label2 = new System.Windows.Forms.Label();
//            this.panelFull.SuspendLayout();
//            this.panel2.SuspendLayout();
//            this.panel1.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // panelFull
//            // 
//            this.panelFull.Controls.Add(this.panelMain);
//            this.panelFull.Controls.Add(this.panel2);
//            this.panelFull.Controls.Add(this.panel1);
//            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelFull.Location = new System.Drawing.Point(10, 10);
//            this.panelFull.Name = "panelFull";
//            this.panelFull.Size = new System.Drawing.Size(1038, 494);
//            this.panelFull.TabIndex = 0;
//            // 
//            // panelMain
//            // 
//            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
//            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
//            this.panelMain.Location = new System.Drawing.Point(112, 71);
//            this.panelMain.Name = "panelMain";
//            this.panelMain.Size = new System.Drawing.Size(926, 423);
//            this.panelMain.TabIndex = 2;
//            // 
//            // panel2
//            // 
//            this.panel2.Controls.Add(this.metroTile4);
//            this.panel2.Controls.Add(this.metroTile3);
//            this.panel2.Controls.Add(this.metroTile2);
//            this.panel2.Controls.Add(this.metroTile1);
//            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
//            this.panel2.Location = new System.Drawing.Point(0, 71);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(112, 423);
//            this.panel2.TabIndex = 1;
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
//            this.panel1.Controls.Add(this.label2);
//            this.panel1.Controls.Add(this.lblTimeNow);
//            this.panel1.Controls.Add(this.label1);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(1038, 71);
//            this.panel1.TabIndex = 0;
//            // 
//            // lblTimeNow
//            // 
//            this.lblTimeNow.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
//            this.lblTimeNow.ForeColor = System.Drawing.Color.Gold;
//            this.lblTimeNow.Location = new System.Drawing.Point(841, 11);
//            this.lblTimeNow.Name = "lblTimeNow";
//            this.lblTimeNow.Size = new System.Drawing.Size(194, 57);
//            this.lblTimeNow.TabIndex = 1;
//            this.lblTimeNow.Text = "2020-01-06 13:00:52";
//            this.lblTimeNow.TextAlign = System.Drawing.ContentAlignment.TopRight;
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
//            this.label1.ForeColor = System.Drawing.Color.White;
//            this.label1.Location = new System.Drawing.Point(279, 11);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(468, 37);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "생산지점관리시스템(POP)";
//            // 
//            // timer1
//            // 
//            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
//            // 
//            // metroTile4
//            // 
//            this.metroTile4.ActiveControl = null;
//            this.metroTile4.Location = new System.Drawing.Point(3, 321);
//            this.metroTile4.Name = "metroTile4";
//            this.metroTile4.Size = new System.Drawing.Size(104, 100);
//            this.metroTile4.Style = MetroFramework.MetroColorStyle.Silver;
//            this.metroTile4.TabIndex = 1;
//            this.metroTile4.Text = "생산실적등록";
//            this.metroTile4.TileImage = global::Team5_Pop.Properties.Resources.server;
//            this.metroTile4.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.metroTile4.UseSelectable = true;
//            this.metroTile4.UseStyleColors = true;
//            this.metroTile4.UseTileImage = true;
//            this.metroTile4.Click += new System.EventHandler(this.metroTile4_Click);
//            // 
//            // metroTile3
//            // 
//            this.metroTile3.ActiveControl = null;
//            this.metroTile3.Location = new System.Drawing.Point(3, 215);
//            this.metroTile3.Name = "metroTile3";
//            this.metroTile3.Size = new System.Drawing.Size(104, 100);
//            this.metroTile3.Style = MetroFramework.MetroColorStyle.Silver;
//            this.metroTile3.TabIndex = 1;
//            this.metroTile3.Text = "모니터링";
//            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
//            this.metroTile3.TileImage = global::Team5_Pop.Properties.Resources.layout;
//            this.metroTile3.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.metroTile3.UseSelectable = true;
//            this.metroTile3.UseStyleColors = true;
//            this.metroTile3.UseTileImage = true;
//            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
//            // 
//            // metroTile2
//            // 
//            this.metroTile2.ActiveControl = null;
//            this.metroTile2.Location = new System.Drawing.Point(3, 109);
//            this.metroTile2.Name = "metroTile2";
//            this.metroTile2.Size = new System.Drawing.Size(104, 100);
//            this.metroTile2.Style = MetroFramework.MetroColorStyle.Silver;
//            this.metroTile2.TabIndex = 1;
//            this.metroTile2.Text = "작업지시현황";
//            this.metroTile2.TileImage = global::Team5_Pop.Properties.Resources.check_list;
//            this.metroTile2.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.metroTile2.UseSelectable = true;
//            this.metroTile2.UseStyleColors = true;
//            this.metroTile2.UseTileImage = true;
//            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
//            // 
//            // metroTile1
//            // 
//            this.metroTile1.ActiveControl = null;
//            this.metroTile1.BackColor = System.Drawing.Color.Brown;
//            this.metroTile1.Location = new System.Drawing.Point(3, 3);
//            this.metroTile1.Name = "metroTile1";
//            this.metroTile1.Size = new System.Drawing.Size(104, 100);
//            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
//            this.metroTile1.TabIndex = 1;
//            this.metroTile1.Text = "작업지시등록";
//            this.metroTile1.TileImage = global::Team5_Pop.Properties.Resources.presentation;
//            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.TopCenter;
//            this.metroTile1.UseSelectable = true;
//            this.metroTile1.UseStyleColors = true;
//            this.metroTile1.UseTileImage = true;
//            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
//            // 
//            // label2
//            // 
//            this.label2.Image = global::Team5_Pop.Properties.Resources.Free_Sample_By_Wix;
//            this.label2.Location = new System.Drawing.Point(1, 0);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(111, 68);
//            this.label2.TabIndex = 3;
//            // 
//            // MainPOP
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
//            this.ClientSize = new System.Drawing.Size(1058, 514);
//            this.Controls.Add(this.panelFull);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
//            this.Name = "MainPOP";
//            this.Padding = new System.Windows.Forms.Padding(10);
//            this.Load += new System.EventHandler(this.MainPOP_Load);
//            this.panelFull.ResumeLayout(false);
//            this.panel2.ResumeLayout(false);
//            this.panel1.ResumeLayout(false);
//            this.panel1.PerformLayout();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.Panel panelFull;
//        private System.Windows.Forms.Panel panel2;
//        private MetroFramework.Controls.MetroTile metroTile1;
//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Label label1;
//        private MetroFramework.Controls.MetroTile metroTile3;
//        private MetroFramework.Controls.MetroTile metroTile2;
//        private MetroFramework.Controls.MetroTile metroTile4;
//        private System.Windows.Forms.Panel panelMain;
//        private System.Windows.Forms.Label lblTimeNow;
//        private System.Windows.Forms.Timer timer1;
//        private System.Windows.Forms.Label label2;
//    }
//}

