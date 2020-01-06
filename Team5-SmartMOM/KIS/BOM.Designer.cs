namespace Team5_SmartMOM.KIS
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
            this.g = new System.Windows.Forms.Button();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 84;
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
            this.panelTop.Size = new System.Drawing.Size(1202, 84);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 501);
            this.splitContainer2.SplitterDistance = 49;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.btn_newitem);
            this.panelMid.Controls.Add(this.g);
            this.panelMid.Size = new System.Drawing.Size(1202, 49);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.g, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_newitem, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(944, 19);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(995, 19);
            this.button2.Size = new System.Drawing.Size(107, 24);
            this.button2.Text = "약식 다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1108, 19);
            this.button1.Size = new System.Drawing.Size(91, 24);
            this.button1.Text = "Excel 등록";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.Text = "BOM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기존일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ사용유무";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(389, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ품목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(752, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
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
            // g
            // 
            this.g.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.g.Location = new System.Drawing.Point(893, 19);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(45, 24);
            this.g.TabIndex = 9;
            this.g.Text = "복사";
            this.g.UseVisualStyleBackColor = true;
            // 
            // btn_newitem
            // 
            this.btn_newitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newitem.Location = new System.Drawing.Point(842, 19);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(45, 24);
            this.btn_newitem.TabIndex = 10;
            this.btn_newitem.Text = "등록";
            this.btn_newitem.UseVisualStyleBackColor = true;
            this.btn_newitem.Click += new System.EventHandler(this.Btn_newitem_Click_1);
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
            // 
            // BOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "BOM";
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
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
        protected System.Windows.Forms.Button btn_newitem;
        protected System.Windows.Forms.Button g;
        private System.Windows.Forms.Button btn_Search;
    }
}
