namespace Team5_SmartMOM
{
    partial class I
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
            this.cbo_InspectionType = new System.Windows.Forms.ComboBox();
            this.btn_newitem = new System.Windows.Forms.Button();
            this.btn_Copy = new System.Windows.Forms.Button();
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
            this.splitContainer1.SplitterDistance = 51;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbo_InspectionType);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 51);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 534);
            this.splitContainer2.SplitterDistance = 52;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.btn_newitem);
            this.panelMid.Controls.Add(this.btn_Copy);
            this.panelMid.Size = new System.Drawing.Size(1202, 52);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_Copy, 0);
            this.panelMid.Controls.SetChildIndex(this.btn_newitem, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(961, 19);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1012, 19);
            this.button2.Size = new System.Drawing.Size(104, 24);
            this.button2.Text = "양식다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1122, 19);
            this.button1.Size = new System.Drawing.Size(77, 24);
            this.button1.Text = "Excel등록";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.Text = "검사기준정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(453, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ검사종류";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1045, 16);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(138, 23);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(95, 16);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(214, 21);
            this.txt_item.TabIndex = 3;
            // 
            // cbo_InspectionType
            // 
            this.cbo_InspectionType.FormattingEnabled = true;
            this.cbo_InspectionType.Location = new System.Drawing.Point(539, 16);
            this.cbo_InspectionType.Name = "cbo_InspectionType";
            this.cbo_InspectionType.Size = new System.Drawing.Size(241, 20);
            this.cbo_InspectionType.TabIndex = 4;
            // 
            // btn_newitem
            // 
            this.btn_newitem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_newitem.Location = new System.Drawing.Point(859, 19);
            this.btn_newitem.Name = "btn_newitem";
            this.btn_newitem.Size = new System.Drawing.Size(45, 24);
            this.btn_newitem.TabIndex = 12;
            this.btn_newitem.Text = "등록";
            this.btn_newitem.UseVisualStyleBackColor = true;
            // 
            // btn_Copy
            // 
            this.btn_Copy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Copy.Location = new System.Drawing.Point(910, 19);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.Size = new System.Drawing.Size(45, 24);
            this.btn_Copy.TabIndex = 11;
            this.btn_Copy.Text = "복사";
            this.btn_Copy.UseVisualStyleBackColor = true;
            // 
            // I
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "I";
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

        private System.Windows.Forms.ComboBox cbo_InspectionType;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btn_newitem;
        protected System.Windows.Forms.Button btn_Copy;
    }
}
