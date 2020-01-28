namespace Team5_SmartMOM.HSC
{
    partial class ShipmentStatus
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
            this.cboMoney = new System.Windows.Forms.ComboBox();
            this.cboDestination = new System.Windows.Forms.ComboBox();
            this.cboCancelQuantity = new System.Windows.Forms.ComboBox();
            this.cboCustomerStore = new System.Windows.Forms.ComboBox();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtOrderDivision = new System.Windows.Forms.TextBox();
            this.txtOrderStatus = new System.Windows.Forms.TextBox();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtMarket = new System.Windows.Forms.TextBox();
            this.cboShippingProcessor = new System.Windows.Forms.ComboBox();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
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
            this.panelMid.Size = new System.Drawing.Size(1202, 33);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 0);
            this.button3.Size = new System.Drawing.Size(86, 29);
            this.button3.Text = "출하취소";
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1059, 0);
            this.button2.Size = new System.Drawing.Size(82, 29);
            this.button2.Text = "출하취소";
            // 
            // button1
            // 
            this.button1.Size = new System.Drawing.Size(57, 29);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 33);
            this.panel2.Size = new System.Drawing.Size(1202, 191);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.label15);
            this.panelTop.Controls.Add(this.cboMoney);
            this.panelTop.Controls.Add(this.cboDestination);
            this.panelTop.Controls.Add(this.cboCancelQuantity);
            this.panelTop.Controls.Add(this.cboCustomerStore);
            this.panelTop.Controls.Add(this.cboCustomer);
            this.panelTop.Controls.Add(this.txtOrderDivision);
            this.panelTop.Controls.Add(this.txtOrderStatus);
            this.panelTop.Controls.Add(this.txtOrderNum);
            this.panelTop.Controls.Add(this.txtMarket);
            this.panelTop.Controls.Add(this.cboShippingProcessor);
            this.panelTop.Controls.Add(this.cboProduct);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.dtpDueDate2);
            this.panelTop.Controls.Add(this.dtpDueDate);
            this.panelTop.Controls.Add(this.label14);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label13);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label12);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTop.Size = new System.Drawing.Size(1202, 171);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 409);
            this.splitContainer2.SplitterDistance = 33;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1165, 409);
            this.splitContainer1.SplitterDistance = 813;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(186, 29);
            this.label1.Text = "출하현황";
            // 
            // lblArrow
            // 
            this.lblArrow.Size = new System.Drawing.Size(16, 29);
            // 
            // cboMoney
            // 
            this.cboMoney.FormattingEnabled = true;
            this.cboMoney.Location = new System.Drawing.Point(539, 129);
            this.cboMoney.Name = "cboMoney";
            this.cboMoney.Size = new System.Drawing.Size(178, 20);
            this.cboMoney.TabIndex = 49;
            // 
            // cboDestination
            // 
            this.cboDestination.FormattingEnabled = true;
            this.cboDestination.Location = new System.Drawing.Point(539, 94);
            this.cboDestination.Name = "cboDestination";
            this.cboDestination.Size = new System.Drawing.Size(178, 20);
            this.cboDestination.TabIndex = 48;
            // 
            // cboCancelQuantity
            // 
            this.cboCancelQuantity.FormattingEnabled = true;
            this.cboCancelQuantity.Location = new System.Drawing.Point(870, 129);
            this.cboCancelQuantity.Name = "cboCancelQuantity";
            this.cboCancelQuantity.Size = new System.Drawing.Size(178, 20);
            this.cboCancelQuantity.TabIndex = 47;
            // 
            // cboCustomerStore
            // 
            this.cboCustomerStore.FormattingEnabled = true;
            this.cboCustomerStore.Location = new System.Drawing.Point(870, 20);
            this.cboCustomerStore.Name = "cboCustomerStore";
            this.cboCustomerStore.Size = new System.Drawing.Size(178, 20);
            this.cboCustomerStore.TabIndex = 46;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(539, 22);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(178, 20);
            this.cboCustomer.TabIndex = 45;
            // 
            // txtOrderDivision
            // 
            this.txtOrderDivision.Location = new System.Drawing.Point(870, 93);
            this.txtOrderDivision.Name = "txtOrderDivision";
            this.txtOrderDivision.Size = new System.Drawing.Size(178, 21);
            this.txtOrderDivision.TabIndex = 44;
            // 
            // txtOrderStatus
            // 
            this.txtOrderStatus.Location = new System.Drawing.Point(870, 57);
            this.txtOrderStatus.Name = "txtOrderStatus";
            this.txtOrderStatus.Size = new System.Drawing.Size(178, 21);
            this.txtOrderStatus.TabIndex = 43;
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(539, 57);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(178, 21);
            this.txtOrderNum.TabIndex = 42;
            // 
            // txtMarket
            // 
            this.txtMarket.Location = new System.Drawing.Point(144, 129);
            this.txtMarket.Name = "txtMarket";
            this.txtMarket.Size = new System.Drawing.Size(209, 21);
            this.txtMarket.TabIndex = 41;
            // 
            // cboShippingProcessor
            // 
            this.cboShippingProcessor.FormattingEnabled = true;
            this.cboShippingProcessor.Location = new System.Drawing.Point(144, 95);
            this.cboShippingProcessor.Name = "cboShippingProcessor";
            this.cboShippingProcessor.Size = new System.Drawing.Size(209, 20);
            this.cboShippingProcessor.TabIndex = 40;
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(144, 58);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(209, 20);
            this.cboProduct.TabIndex = 39;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1103, 121);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(240, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "~";
            // 
            // dtpDueDate2
            // 
            this.dtpDueDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate2.Location = new System.Drawing.Point(269, 24);
            this.dtpDueDate2.Name = "dtpDueDate2";
            this.dtpDueDate2.Size = new System.Drawing.Size(84, 21);
            this.dtpDueDate2.TabIndex = 35;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(144, 23);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(84, 21);
            this.dtpDueDate.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(739, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "ㆍB2BI취소수량";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(408, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "ㆍ환종";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(40, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 29;
            this.label8.Text = "ㆍMARKET";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(739, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 28;
            this.label13.Text = "ㆍ주문구분";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(408, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 27;
            this.label9.Text = "ㆍ도착지";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(40, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "ㆍ출하처리자";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(739, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 19);
            this.label12.TabIndex = 25;
            this.label12.Text = "ㆍ주문상태";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(408, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "ㆍ고객주문번호";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "ㆍ품목";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(739, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 19);
            this.label11.TabIndex = 33;
            this.label11.Text = "ㆍ고객창고";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(408, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "ㆍ고객사";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(40, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 50;
            this.label15.Text = "ㆍ기간";
            // 
            // ShipmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ShipmentStatus";
            this.Load += new System.EventHandler(this.ShipmentStatus_Load);
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

        private System.Windows.Forms.ComboBox cboMoney;
        private System.Windows.Forms.ComboBox cboDestination;
        private System.Windows.Forms.ComboBox cboCancelQuantity;
        private System.Windows.Forms.ComboBox cboCustomerStore;
        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtOrderDivision;
        private System.Windows.Forms.TextBox txtOrderStatus;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtMarket;
        private System.Windows.Forms.ComboBox cboShippingProcessor;
        private System.Windows.Forms.ComboBox cboProduct;
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDate2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
    }
}
