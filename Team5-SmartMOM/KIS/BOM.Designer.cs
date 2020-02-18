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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ExistingDate = new System.Windows.Forms.DateTimePicker();
            this.txt_Item = new System.Windows.Forms.TextBox();
            this.cbo_Deployement = new System.Windows.Forms.ComboBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_newitem = new System.Windows.Forms.Button();
            this.Btn_Copy = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_reset = new System.Windows.Forms.Button();
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
            this.panelMid.Controls.Add(this.Btn_newitem);
            this.panelMid.Controls.Add(this.Btn_Copy);
            this.panelMid.Controls.Add(this.Btn_Delete);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.Btn_Delete, 0);
            this.panelMid.Controls.SetChildIndex(this.Btn_Copy, 0);
            this.panelMid.Controls.SetChildIndex(this.Btn_newitem, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(904, 0);
            this.button3.Size = new System.Drawing.Size(70, 24);
            this.button3.Text = "엑셀";
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(974, 0);
            this.button2.Size = new System.Drawing.Size(120, 24);
            this.button2.Text = "약식 다운로드";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Size = new System.Drawing.Size(104, 24);
            this.button1.Text = "Excel 등록";
            this.button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 82);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btn_reset);
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.cbo_Deployement);
            this.panelTop.Controls.Add(this.txt_Item);
            this.panelTop.Controls.Add(this.dtp_ExistingDate);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 62);
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
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기존일자";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(307, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ품목";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(604, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "ㆍ전개방식";
            // 
            // dtp_ExistingDate
            // 
            this.dtp_ExistingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExistingDate.Location = new System.Drawing.Point(88, 21);
            this.dtp_ExistingDate.Name = "dtp_ExistingDate";
            this.dtp_ExistingDate.Size = new System.Drawing.Size(162, 21);
            this.dtp_ExistingDate.TabIndex = 1;
            // 
            // txt_Item
            // 
            this.txt_Item.Location = new System.Drawing.Point(369, 21);
            this.txt_Item.Name = "txt_Item";
            this.txt_Item.Size = new System.Drawing.Size(204, 21);
            this.txt_Item.TabIndex = 2;
            // 
            // cbo_Deployement
            // 
            this.cbo_Deployement.FormattingEnabled = true;
            this.cbo_Deployement.Location = new System.Drawing.Point(679, 21);
            this.cbo_Deployement.Name = "cbo_Deployement";
            this.cbo_Deployement.Size = new System.Drawing.Size(162, 20);
            this.cbo_Deployement.TabIndex = 3;
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1103, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 30);
            this.btn_Search.TabIndex = 4;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Snow;
            this.Btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Delete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Delete.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Delete.Location = new System.Drawing.Point(834, 0);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(70, 24);
            this.Btn_Delete.TabIndex = 7;
            this.Btn_Delete.Text = "삭제";
            this.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_newitem
            // 
            this.Btn_newitem.BackColor = System.Drawing.Color.Snow;
            this.Btn_newitem.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_newitem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_newitem.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.Btn_newitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_newitem.Location = new System.Drawing.Point(694, 0);
            this.Btn_newitem.Name = "Btn_newitem";
            this.Btn_newitem.Size = new System.Drawing.Size(70, 24);
            this.Btn_newitem.TabIndex = 5;
            this.Btn_newitem.Text = "등록";
            this.Btn_newitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_newitem.UseVisualStyleBackColor = false;
            this.Btn_newitem.Click += new System.EventHandler(this.Btn_newitem_Click_1);
            // 
            // Btn_Copy
            // 
            this.Btn_Copy.BackColor = System.Drawing.Color.Snow;
            this.Btn_Copy.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Copy.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_Copy.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.Btn_Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Copy.Location = new System.Drawing.Point(764, 0);
            this.Btn_Copy.Name = "Btn_Copy";
            this.Btn_Copy.Size = new System.Drawing.Size(70, 24);
            this.Btn_Copy.TabIndex = 6;
            this.Btn_Copy.Text = "복사";
            this.Btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Copy.UseVisualStyleBackColor = false;
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(1002, 16);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(92, 30);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "전체조회";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
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
        private System.Windows.Forms.DateTimePicker dtp_ExistingDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Search;
        protected System.Windows.Forms.Button Btn_newitem;
        protected System.Windows.Forms.Button Btn_Copy;
        protected System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_reset;
    }
}
