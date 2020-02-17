namespace Team5_Pop
{
    partial class FacControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacControl));
            this.ITEM_Name = new System.Windows.Forms.TextBox();
            this.Order_Amount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.FacImg = new System.Windows.Forms.PictureBox();
            this.GoodAmount = new System.Windows.Forms.TextBox();
            this.TotalAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.RestAmount = new System.Windows.Forms.TextBox();
            this.BadAmount = new System.Windows.Forms.TextBox();
            this.RunningSginal_IMG = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Work_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ControlTimer = new System.Windows.Forms.Timer(this.components);
            this.RunningImg = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.FacImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningSginal_IMG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ITEM_Name
            // 
            this.ITEM_Name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ITEM_Name.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ITEM_Name.Location = new System.Drawing.Point(97, 193);
            this.ITEM_Name.Name = "ITEM_Name";
            this.ITEM_Name.Size = new System.Drawing.Size(123, 27);
            this.ITEM_Name.TabIndex = 4;
            this.ITEM_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Order_Amount
            // 
            this.Order_Amount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Order_Amount.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Order_Amount.Location = new System.Drawing.Point(97, 224);
            this.Order_Amount.Name = "Order_Amount";
            this.Order_Amount.Size = new System.Drawing.Size(123, 27);
            this.Order_Amount.TabIndex = 5;
            this.Order_Amount.Text = "0000";
            this.Order_Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(7, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "제작 품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(7, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "지시 수량";
            // 
            // FacImg
            // 
            this.FacImg.Location = new System.Drawing.Point(6, 32);
            this.FacImg.Name = "FacImg";
            this.FacImg.Size = new System.Drawing.Size(214, 122);
            this.FacImg.TabIndex = 3;
            this.FacImg.TabStop = false;
            // 
            // GoodAmount
            // 
            this.GoodAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GoodAmount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GoodAmount.ForeColor = System.Drawing.Color.LightGreen;
            this.GoodAmount.Location = new System.Drawing.Point(159, 257);
            this.GoodAmount.Name = "GoodAmount";
            this.GoodAmount.Size = new System.Drawing.Size(60, 29);
            this.GoodAmount.TabIndex = 10;
            this.GoodAmount.Text = "0";
            this.GoodAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.GoodAmount.TextChanged += new System.EventHandler(this.GoodAmount_TextChanged);
            // 
            // TotalAmount
            // 
            this.TotalAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TotalAmount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TotalAmount.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TotalAmount.Location = new System.Drawing.Point(51, 257);
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.Size = new System.Drawing.Size(59, 29);
            this.TotalAmount.TabIndex = 9;
            this.TotalAmount.Text = "0";
            this.TotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(7, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "제작";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(115, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "양품";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(7, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "잔여";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(115, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "불량";
            // 
            // RestAmount
            // 
            this.RestAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RestAmount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.RestAmount.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.RestAmount.Location = new System.Drawing.Point(51, 289);
            this.RestAmount.Name = "RestAmount";
            this.RestAmount.Size = new System.Drawing.Size(60, 29);
            this.RestAmount.TabIndex = 14;
            this.RestAmount.Text = "0";
            this.RestAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BadAmount
            // 
            this.BadAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BadAmount.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BadAmount.ForeColor = System.Drawing.Color.Red;
            this.BadAmount.Location = new System.Drawing.Point(159, 289);
            this.BadAmount.Name = "BadAmount";
            this.BadAmount.Size = new System.Drawing.Size(60, 29);
            this.BadAmount.TabIndex = 13;
            this.BadAmount.Text = "0";
            this.BadAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BadAmount.TextChanged += new System.EventHandler(this.GoodAmount_TextChanged);
            // 
            // RunningSginal_IMG
            // 
            this.RunningSginal_IMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RunningSginal_IMG.Location = new System.Drawing.Point(198, 3);
            this.RunningSginal_IMG.Name = "RunningSginal_IMG";
            this.RunningSginal_IMG.Size = new System.Drawing.Size(23, 22);
            this.RunningSginal_IMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RunningSginal_IMG.TabIndex = 18;
            this.RunningSginal_IMG.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.Work_ID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RunningSginal_IMG);
            this.groupBox1.Controls.Add(this.FacImg);
            this.groupBox1.Controls.Add(this.ITEM_Name);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Order_Amount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.RestAmount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BadAmount);
            this.groupBox1.Controls.Add(this.TotalAmount);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.GoodAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 326);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "설비명";
            // 
            // Work_ID
            // 
            this.Work_ID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Work_ID.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Work_ID.Location = new System.Drawing.Point(97, 162);
            this.Work_ID.Name = "Work_ID";
            this.Work_ID.Size = new System.Drawing.Size(123, 27);
            this.Work_ID.TabIndex = 19;
            this.Work_ID.Text = "0";
            this.Work_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(7, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 20;
            this.label1.Text = "지시 번호";
            // 
            // ControlTimer
            // 
            this.ControlTimer.Interval = 200;
            this.ControlTimer.Tick += new System.EventHandler(this.ControlTimer_Tick);
            // 
            // RunningImg
            // 
            this.RunningImg.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("RunningImg.ImageStream")));
            this.RunningImg.TransparentColor = System.Drawing.Color.Transparent;
            this.RunningImg.Images.SetKeyName(0, "start.png");
            this.RunningImg.Images.SetKeyName(1, "pause.png");
            this.RunningImg.Images.SetKeyName(2, "stop.png");
            // 
            // FacControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Controls.Add(this.groupBox1);
            this.Name = "FacControl";
            this.Size = new System.Drawing.Size(231, 327);
            this.Load += new System.EventHandler(this.FacControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FacImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunningSginal_IMG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox FacImg;
        public System.Windows.Forms.TextBox ITEM_Name;
        public System.Windows.Forms.TextBox Order_Amount;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox GoodAmount;
        public System.Windows.Forms.TextBox TotalAmount;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox RestAmount;
        public System.Windows.Forms.TextBox BadAmount;
        public System.Windows.Forms.PictureBox RunningSginal_IMG;
        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer ControlTimer;
        public System.Windows.Forms.TextBox Work_ID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList RunningImg;
    }
}
