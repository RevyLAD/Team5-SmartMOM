namespace Team5_SmartMOM
{
    partial class Material_Cost_Management
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
            this.dtp_ExistingDate = new System.Windows.Forms.DateTimePicker();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.cbo_Company = new System.Windows.Forms.ComboBox();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
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
            this.splitContainer1.SplitterDistance = 44;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.cbo_Company);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.dtp_ExistingDate);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 44);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 541);
            this.splitContainer2.SplitterDistance = 53;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.btn_copy);
            this.panelMid.Controls.Add(this.btn_newitem);
            this.panelMid.Controls.Add(this.btn_delete);
            this.panelMid.Size = new System.Drawing.Size(1202, 53);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_delete, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_newitem, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_copy, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(935, 19);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(986, 19);
            this.button2.Size = new System.Drawing.Size(109, 24);
            this.button2.Text = "양식 다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1101, 19);
            this.button1.Size = new System.Drawing.Size(98, 24);
            this.button1.Text = "Excel등록";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.Text = "자재단가관리";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기준일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(706, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ업체";
            // 
            // dtp_ExistingDate
            // 
            this.dtp_ExistingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExistingDate.Location = new System.Drawing.Point(120, 13);
            this.dtp_ExistingDate.Name = "dtp_ExistingDate";
            this.dtp_ExistingDate.Size = new System.Drawing.Size(177, 21);
            this.dtp_ExistingDate.TabIndex = 3;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(441, 13);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(208, 21);
            this.txt_item.TabIndex = 4;
            // 
            // cbo_Company
            // 
            this.cbo_Company.FormattingEnabled = true;
            this.cbo_Company.Location = new System.Drawing.Point(794, 13);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(207, 20);
            this.cbo_Company.TabIndex = 5;
            // 
            // btn_newitem
            // 
            this.btn_newitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newitem.Location = new System.Drawing.Point(782, 19);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(45, 24);
            this.btn_newitem.TabIndex = 14;
            this.btn_newitem.Text = "등록";
            this.btn_newitem.UseVisualStyleBackColor = true;
            this.btn_newitem.Click += new System.EventHandler(this.Btn_newitem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_delete.Location = new System.Drawing.Point(833, 19);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(45, 24);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "삭제";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_copy
            // 
            this.btn_copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copy.Location = new System.Drawing.Point(884, 19);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(45, 24);
            this.btn_copy.TabIndex = 15;
            this.btn_copy.Text = "복사";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1072, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(104, 23);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // Material_Cost_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Material_Cost_Management";
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Company;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.DateTimePicker dtp_ExistingDate;
        private System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Button btn_copy;
        protected System.Windows.Forms.Button btn_newitem;
        protected System.Windows.Forms.Button btn_delete;
    }
}
