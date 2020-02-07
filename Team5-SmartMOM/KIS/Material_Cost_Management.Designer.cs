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
            this.txt_item = new System.Windows.Forms.TextBox();
            this.cbo_Company = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_NewItem = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.dtp_ExistingDate = new Team5_SmartMOM.Textbox();
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
            this.panelMid.Controls.Add(this.btn_NewItem);
            this.panelMid.Controls.Add(this.btn_delete);
            this.panelMid.Controls.Add(this.btn_copy);
            this.panelMid.Size = new System.Drawing.Size(1202, 32);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_copy, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_delete, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_NewItem, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(934, 0);
            this.button3.Size = new System.Drawing.Size(57, 28);
            this.button3.Text = "엑셀";
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 0);
            this.button2.Size = new System.Drawing.Size(109, 28);
            this.button2.Text = "양식 다운로드";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1100, 0);
            this.button1.Size = new System.Drawing.Size(98, 28);
            this.button1.Text = "Excel등록";
            this.button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Size = new System.Drawing.Size(1202, 78);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.dtp_ExistingDate);
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.cbo_Company);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 58);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 541);
            this.splitContainer2.SplitterDistance = 53;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1145, 541);
            this.splitContainer1.SplitterDistance = 524;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.Text = "자재단가관리";
            // 
            // lblArrow
            // 
            this.lblArrow.Size = new System.Drawing.Size(16, 28);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기준일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(357, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(706, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ업체";
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
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1100, 12);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 39);
            this.btn_Search.TabIndex = 6;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // btn_NewItem
            // 
            this.btn_NewItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_NewItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_NewItem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_NewItem.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btn_NewItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_NewItem.Location = new System.Drawing.Point(763, 0);
            this.btn_NewItem.Name = "btn_NewItem";
            this.btn_NewItem.Size = new System.Drawing.Size(57, 28);
            this.btn_NewItem.TabIndex = 21;
            this.btn_NewItem.Text = "등록";
            this.btn_NewItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_NewItem.UseVisualStyleBackColor = false;
            this.btn_NewItem.Click += new System.EventHandler(this.Btn_newitem_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_delete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_delete.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(820, 0);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(57, 28);
            this.btn_delete.TabIndex = 20;
            this.btn_delete.Text = "삭제";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.btn_copy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_copy.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_copy.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btn_copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_copy.Location = new System.Drawing.Point(877, 0);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(57, 28);
            this.btn_copy.TabIndex = 19;
            this.btn_copy.Text = "복사";
            this.btn_copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_copy.UseVisualStyleBackColor = false;
            // 
            // dtp_ExistingDate
            // 
            this.dtp_ExistingDate.BackColor = System.Drawing.Color.Transparent;
            this.dtp_ExistingDate.Location = new System.Drawing.Point(112, 13);
            this.dtp_ExistingDate.Name = "dtp_ExistingDate";
            this.dtp_ExistingDate.Size = new System.Drawing.Size(193, 23);
            this.dtp_ExistingDate.TabIndex = 14;
            // 
            // Material_Cost_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Material_Cost_Management";
            this.Load += new System.EventHandler(this.Material_Cost_Management_Load);
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

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Company;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Button btn_NewItem;
        protected System.Windows.Forms.Button btn_delete;
        protected System.Windows.Forms.Button btn_copy;
        private Textbox dtp_ExistingDate;
    }
}
