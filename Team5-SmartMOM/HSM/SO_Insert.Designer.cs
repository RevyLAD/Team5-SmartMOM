namespace Team5_SmartMOM.HSM
{
    partial class SO_Insert
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCustomerWO = new System.Windows.Forms.TextBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.txtCancelQuantity = new System.Windows.Forms.TextBox();
            this.txtShippingQuantity = new System.Windows.Forms.TextBox();
            this.cboOrderDivision = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.panelFull.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelDock.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Size = new System.Drawing.Size(601, 421);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.None;
            this.panelMain.Size = new System.Drawing.Size(579, 405);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 357);
            this.panelBottom.Size = new System.Drawing.Size(579, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.dtpDueDate);
            this.panelDock.Controls.Add(this.txtNote);
            this.panelDock.Controls.Add(this.txtShippingQuantity);
            this.panelDock.Controls.Add(this.txtCancelQuantity);
            this.panelDock.Controls.Add(this.txtOrderQuantity);
            this.panelDock.Controls.Add(this.cboOrderDivision);
            this.panelDock.Controls.Add(this.cboProduct);
            this.panelDock.Controls.Add(this.cboCustomer);
            this.panelDock.Controls.Add(this.txtCustomerWO);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.label15);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label13);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(579, 357);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(579, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(579, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.Text = "S/O";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(291, 10);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 10);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(552, 10);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(17, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "ㆍ납기일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(17, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "ㆍ고객사";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Orange;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ㆍ고객WO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "ㆍ출고 수량";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(291, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "ㆍ발주 구분";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "ㆍ비고";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(291, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 22);
            this.label12.TabIndex = 4;
            this.label12.Text = "ㆍ취소 수량";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Orange;
            this.label13.Location = new System.Drawing.Point(291, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "ㆍ품목";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Orange;
            this.label15.Location = new System.Drawing.Point(291, 95);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 22);
            this.label15.TabIndex = 1;
            this.label15.Text = "ㆍ주문 수량";
            // 
            // txtCustomerWO
            // 
            this.txtCustomerWO.Location = new System.Drawing.Point(127, 16);
            this.txtCustomerWO.Name = "txtCustomerWO";
            this.txtCustomerWO.Size = new System.Drawing.Size(140, 21);
            this.txtCustomerWO.TabIndex = 5;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(127, 55);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(140, 20);
            this.cboCustomer.TabIndex = 6;
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(412, 55);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(140, 20);
            this.cboProduct.TabIndex = 6;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.Location = new System.Drawing.Point(412, 95);
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(140, 21);
            this.txtOrderQuantity.TabIndex = 7;
            // 
            // txtCancelQuantity
            // 
            this.txtCancelQuantity.Location = new System.Drawing.Point(412, 138);
            this.txtCancelQuantity.Name = "txtCancelQuantity";
            this.txtCancelQuantity.Size = new System.Drawing.Size(140, 21);
            this.txtCancelQuantity.TabIndex = 7;
            // 
            // txtShippingQuantity
            // 
            this.txtShippingQuantity.Location = new System.Drawing.Point(127, 136);
            this.txtShippingQuantity.Name = "txtShippingQuantity";
            this.txtShippingQuantity.Size = new System.Drawing.Size(140, 21);
            this.txtShippingQuantity.TabIndex = 7;
            // 
            // cboOrderDivision
            // 
            this.cboOrderDivision.FormattingEnabled = true;
            this.cboOrderDivision.Location = new System.Drawing.Point(412, 19);
            this.cboOrderDivision.Name = "cboOrderDivision";
            this.cboOrderDivision.Size = new System.Drawing.Size(140, 20);
            this.cboOrderDivision.TabIndex = 6;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(127, 180);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(425, 116);
            this.txtNote.TabIndex = 7;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(127, 95);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(140, 21);
            this.dtpDueDate.TabIndex = 8;
            // 
            // SO_Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(601, 421);
            this.Name = "SO_Insert";
            this.Load += new System.EventHandler(this.SO_Insert_Load);
            this.panelFull.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelDock.ResumeLayout(false);
            this.panelDock.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtShippingQuantity;
        private System.Windows.Forms.TextBox txtCancelQuantity;
        private System.Windows.Forms.TextBox txtOrderQuantity;
        private System.Windows.Forms.ComboBox cboOrderDivision;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtCustomerWO;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
    }
}
