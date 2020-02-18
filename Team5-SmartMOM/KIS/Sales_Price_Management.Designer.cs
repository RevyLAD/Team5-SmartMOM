namespace Team5_SmartMOM.KIS
{
    partial class Sales_Price_Management
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.btn_Copy = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.Btn_newitem = new System.Windows.Forms.Button();
            this.txt_date = new Team5_SmartMOM.Textbox();
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
            this.panelMid.Controls.Add(this.btn_Delete);
            this.panelMid.Controls.Add(this.btn_Copy);
            this.panelMid.Size = new System.Drawing.Size(1202, 31);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_Copy, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_Delete, 0);
            this.panelMid.Controls.SetChildIndex(this.Btn_newitem, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(933, 0);
            this.button3.Size = new System.Drawing.Size(57, 27);
            this.button3.Text = "엑셀";
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(990, 0);
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.Text = "양식다운로드";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.Text = "Excel등록";
            this.button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Size = new System.Drawing.Size(1202, 81);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txt_date);
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 61);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 538);
            this.splitContainer2.SplitterDistance = 53;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1145, 538);
            this.splitContainer1.SplitterDistance = 560;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(135, 27);
            this.label1.Text = "영업단가관리";
            // 
            // lblArrow
            // 
            this.lblArrow.Size = new System.Drawing.Size(16, 27);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 21);
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
            this.label3.Location = new System.Drawing.Point(351, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ품목";
            // 
            // btn_Search
            // 
            this.btn_Search.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1100, 8);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(93, 39);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(430, 17);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(208, 21);
            this.txt_item.TabIndex = 1;
            // 
            // btn_Copy
            // 
            this.btn_Copy.BackColor = System.Drawing.Color.Snow;
            this.btn_Copy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Copy.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Copy.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btn_Copy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Copy.Location = new System.Drawing.Point(876, 0);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(57, 27);
            this.btn_Copy.TabIndex = 5;
            this.btn_Copy.Text = "복사";
            this.btn_Copy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Copy.UseVisualStyleBackColor = false;
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Snow;
            this.btn_Delete.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Delete.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Delete.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(819, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(57, 27);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // Btn_newitem
            // 
            this.Btn_newitem.BackColor = System.Drawing.Color.Snow;
            this.Btn_newitem.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_newitem.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btn_newitem.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.Btn_newitem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_newitem.Location = new System.Drawing.Point(762, 0);
            this.Btn_newitem.Name = "Btn_newitem";
            this.Btn_newitem.Size = new System.Drawing.Size(57, 27);
            this.Btn_newitem.TabIndex = 3;
            this.Btn_newitem.Text = "등록";
            this.Btn_newitem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_newitem.UseVisualStyleBackColor = false;
            this.Btn_newitem.Click += new System.EventHandler(this.Btn_newitem_Click);
            // 
            // txt_date
            // 
            this.txt_date.BackColor = System.Drawing.Color.Transparent;
            this.txt_date.Location = new System.Drawing.Point(123, 17);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(193, 23);
            this.txt_date.TabIndex = 0;
            // 
            // Sales_Price_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Sales_Price_Management";
            this.Load += new System.EventHandler(this.Sales_Price_Management_Load);
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

        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_item;
        protected System.Windows.Forms.Button Btn_newitem;
        protected System.Windows.Forms.Button btn_Delete;
        protected System.Windows.Forms.Button btn_Copy;
        private Textbox txt_date;
    }
}
