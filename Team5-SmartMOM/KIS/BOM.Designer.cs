namespace Team5_SmartMOM
{
    partial class BOM
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ExistingDate = new System.Windows.Forms.DateTimePicker();
            this.cbo_UseorNot = new System.Windows.Forms.ComboBox();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.cbo_Deployement = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Controls.Add(this.button4);
            this.panelMid.Controls.Add(this.button6);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button6, 0);
            this.panelMid.Controls.SetChildIndex(this.button4, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(904, 0);
            this.button3.Size = new System.Drawing.Size(70, 24);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(974, 0);
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.Text = "약식 다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.Text = "Excel 등록";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 110);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.cbo_Deployement);
            this.panelTop.Controls.Add(this.txt_Item);
            this.panelTop.Controls.Add(this.cbo_UseorNot);
            this.panelTop.Controls.Add(this.dtp_ExistingDate);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 90);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 501);
            this.splitContainer2.SplitterDistance = 49;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1149, 501);
            this.splitContainer1.SplitterDistance = 801;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.Text = "BOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기존일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ사용유무";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(389, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ품목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(752, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "ㆍ전개방식";
            // 
            // dtp_ExistingDate
            // 
            this.dtp_ExistingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExistingDate.Location = new System.Drawing.Point(88, 14);
            this.dtp_ExistingDate.Name = "dtp_ExistingDate";
            this.dtp_ExistingDate.Size = new System.Drawing.Size(162, 21);
            this.dtp_ExistingDate.TabIndex = 5;
            // 
            // cbo_UseorNot
            // 
            this.cbo_UseorNot.FormattingEnabled = true;
            this.cbo_UseorNot.Location = new System.Drawing.Point(88, 51);
            this.cbo_UseorNot.Name = "cbo_UseorNot";
            this.cbo_UseorNot.Size = new System.Drawing.Size(162, 20);
            this.cbo_UseorNot.TabIndex = 6;
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(451, 14);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(204, 21);
            this.txt_Item.TabIndex = 7;
            // 
            // cbo_Deployement
            // 
            this.cbo_Deployement.FormattingEnabled = true;
            this.cbo_Deployement.Location = new System.Drawing.Point(827, 14);
            this.cbo_Deployement.Name = "cbo_Deployement";
            this.cbo_Deployement.Size = new System.Drawing.Size(162, 20);
            this.cbo_Deployement.TabIndex = 8;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1054, 55);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(128, 23);
            this.btn_Search.TabIndex = 17;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(847, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 24);
            this.button6.TabIndex = 15;
            this.button6.Text = "삭제";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(733, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 24);
            this.button5.TabIndex = 17;
            this.button5.Text = "등록";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Btn_newitem_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(790, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 24);
            this.button4.TabIndex = 16;
            this.button4.Text = "복사";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Btn_newitem_Click_1);
            // 
            // BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "BOM";
            this.Load += new System.EventHandler(this.BOM_Load);
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Deployement;
        private System.Windows.Forms.TextBox txt_Item;
        private System.Windows.Forms.ComboBox cbo_UseorNot;
        private System.Windows.Forms.DateTimePicker dtp_ExistingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button4;
        protected System.Windows.Forms.Button button6;
    }
}
