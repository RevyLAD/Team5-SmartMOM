﻿namespace Team5_SmartMOM.HSM
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 163;
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
            this.panelTop.Size = new System.Drawing.Size(1202, 163);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 422);
            this.splitContainer2.SplitterDistance = 41;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Controls.Add(this.button4);
            this.panelMid.Size = new System.Drawing.Size(1202, 41);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button4, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(770, 9);
            this.button3.Size = new System.Drawing.Size(90, 24);
            this.button3.Text = "B2B1 I/F";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(866, 9);
            this.button2.Size = new System.Drawing.Size(101, 24);
            this.button2.Text = "영업마스터생성";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(973, 9);
            this.button1.Size = new System.Drawing.Size(93, 24);
            this.button1.Text = "수요계획생성";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.Text = "영업마스터";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1073, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "등록";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1131, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "엑셀";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ고객납기일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ㆍModelSuffix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "ㆍ고객사라인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
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
            this.txtModelSuffix.Location = new System.Drawing.Point(162, 49);
            this.txtModelSuffix.Name = "txtModelSuffix";
            this.txtModelSuffix.Size = new System.Drawing.Size(229, 21);
            this.txtModelSuffix.TabIndex = 4;
            // 
            // cboCustomerLine
            // 
            this.cboCustomerLine.FormattingEnabled = true;
            this.cboCustomerLine.Location = new System.Drawing.Point(162, 86);
            this.cboCustomerLine.Name = "cboCustomerLine";
            this.cboCustomerLine.Size = new System.Drawing.Size(229, 20);
            this.cboCustomerLine.TabIndex = 5;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(162, 121);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(229, 20);
            this.cboState.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "ㆍ고객사";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(425, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "ㆍ품목";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(425, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "ㆍ등록일";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 22);
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
            this.cboOrdering.Location = new System.Drawing.Point(516, 121);
            this.cboOrdering.Name = "cboOrdering";
            this.cboOrdering.Size = new System.Drawing.Size(190, 20);
            this.cboOrdering.TabIndex = 5;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(516, 49);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(190, 21);
            this.txtProduct.TabIndex = 6;
            // 
            // dtpEnrollment
            // 
            this.dtpEnrollment.Location = new System.Drawing.Point(516, 87);
            this.dtpEnrollment.Name = "dtpEnrollment";
            this.dtpEnrollment.Size = new System.Drawing.Size(190, 21);
            this.dtpEnrollment.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(749, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "ㆍ고객주문번호";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(749, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "ㆍ도착지";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(749, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 22);
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
            this.cboDestination.Location = new System.Drawing.Point(871, 50);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(150, 20);
            this.cboDestination.TabIndex = 9;
            // 
            // cboRemaining
            // 
            this.cboRemaining.FormattingEnabled = true;
            this.cboRemaining.Location = new System.Drawing.Point(871, 86);
            this.cboRemaining.Name = "cboRemaining";
            this.cboRemaining.Size = new System.Drawing.Size(150, 20);
            this.cboRemaining.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Location = new System.Drawing.Point(1073, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 27);
            this.btnSearch.TabIndex = 10;
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

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Button btnSearch;
    }
}