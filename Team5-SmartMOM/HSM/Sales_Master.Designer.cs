namespace Team5_SmartMOM.HSM
{
    partial class Sales_Master
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
            this.dtpDueDateStart = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDateEnd = new System.Windows.Forms.DateTimePicker();
            this.txtModelSuffix = new System.Windows.Forms.TextBox();
            this.cboCustomerLine = new System.Windows.Forms.ComboBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboOrdering = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.dtpEnrollment = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboRemaining = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.panelMid.Size = new System.Drawing.Size(1202, 29);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(859, 0);
            this.button3.Size = new System.Drawing.Size(96, 25);
            this.button3.Text = "B2B1 I/F";
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(955, 0);
            this.button2.Size = new System.Drawing.Size(129, 25);
            this.button2.Text = "영업마스터생성";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1084, 0);
            this.button1.Size = new System.Drawing.Size(114, 25);
            this.button1.Text = "수요계획생성";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Size = new System.Drawing.Size(1202, 168);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.cboRemaining);
            this.panelTop.Controls.Add(this.cboDestination);
            this.panelTop.Controls.Add(this.txtOrderNum);
            this.panelTop.Controls.Add(this.dtpEnrollment);
            this.panelTop.Controls.Add(this.txtProduct);
            this.panelTop.Controls.Add(this.cboState);
            this.panelTop.Controls.Add(this.cboOrdering);
            this.panelTop.Controls.Add(this.cboCustomer);
            this.panelTop.Controls.Add(this.cboCustomerLine);
            this.panelTop.Controls.Add(this.txtModelSuffix);
            this.panelTop.Controls.Add(this.dtpDueDateEnd);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.dtpDueDateStart);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label13);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label12);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 148);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 422);
            this.splitContainer2.SplitterDistance = 41;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1157, 422);
            this.splitContainer1.SplitterDistance = 807;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.Text = "영업마스터";
            // 
            // lblArrow
            // 
            this.lblArrow.Size = new System.Drawing.Size(16, 25);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ고객납기일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ㆍModelSuffix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "ㆍ고객사라인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ㆍ상태";
            // 
            // dtpDueDateStart
            // 
            this.dtpDueDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDateStart.Location = new System.Drawing.Point(162, 13);
            this.dtpDueDateStart.Name = "dtpDueDateStart";
            this.dtpDueDateStart.Size = new System.Drawing.Size(101, 21);
            this.dtpDueDateStart.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(270, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "~";
            // 
            // dtpDueDateEnd
            // 
            this.dtpDueDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDateEnd.Location = new System.Drawing.Point(291, 13);
            this.dtpDueDateEnd.Name = "dtpDueDateEnd";
            this.dtpDueDateEnd.Size = new System.Drawing.Size(100, 21);
            this.dtpDueDateEnd.TabIndex = 3;
            // 
            // txtModelSuffix
            // 
            this.txtModelSuffix.Location = new System.Drawing.Point(162, 44);
            this.txtModelSuffix.Name = "txtModelSuffix";
            this.txtModelSuffix.Size = new System.Drawing.Size(229, 21);
            this.txtModelSuffix.TabIndex = 4;
            // 
            // cboCustomerLine
            // 
            this.cboCustomerLine.FormattingEnabled = true;
            this.cboCustomerLine.Location = new System.Drawing.Point(162, 77);
            this.cboCustomerLine.Name = "cboCustomerLine";
            this.cboCustomerLine.Size = new System.Drawing.Size(229, 20);
            this.cboCustomerLine.TabIndex = 5;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(162, 109);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(229, 20);
            this.cboState.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "ㆍ고객사";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "ㆍ품목";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "ㆍ등록일";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 0;
            this.label10.Text = "ㆍ발주구분";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(516, 13);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(190, 20);
            this.cboCustomer.TabIndex = 5;
            // 
            // cboOrdering
            // 
            this.cboOrdering.FormattingEnabled = true;
            this.cboOrdering.Location = new System.Drawing.Point(516, 109);
            this.cboOrdering.Name = "cboOrdering";
            this.cboOrdering.Size = new System.Drawing.Size(190, 20);
            this.cboOrdering.TabIndex = 5;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(516, 44);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(190, 21);
            this.txtProduct.TabIndex = 6;
            // 
            // dtpEnrollment
            // 
            this.dtpEnrollment.Location = new System.Drawing.Point(516, 78);
            this.dtpEnrollment.Name = "dtpEnrollment";
            this.dtpEnrollment.Size = new System.Drawing.Size(190, 21);
            this.dtpEnrollment.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(749, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "ㆍ고객주문번호";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(749, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "ㆍ도착지";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(749, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "ㆍ잔량";
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(871, 12);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(150, 21);
            this.txtOrderNum.TabIndex = 8;
            // 
            // cboDestination
            // 
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(871, 45);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(150, 20);
            this.cboDestination.TabIndex = 9;
            // 
            // cboRemaining
            // 
            this.cboRemaining.FormattingEnabled = true;
            this.cboRemaining.Location = new System.Drawing.Point(871, 77);
            this.cboRemaining.Name = "cboRemaining";
            this.cboRemaining.Size = new System.Drawing.Size(150, 20);
            this.cboRemaining.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1090, 67);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 39);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // Sales_Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Sales_Master";
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
        private System.Windows.Forms.ComboBox cboRemaining;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.DateTimePicker dtpEnrollment;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.ComboBox cboOrdering;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.ComboBox cboCustomerLine;
        private System.Windows.Forms.TextBox txtModelSuffix;
        private System.Windows.Forms.DateTimePicker dtpDueDateEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDateStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Button btnSearch;
    }
}
