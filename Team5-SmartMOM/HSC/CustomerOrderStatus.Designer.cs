namespace Team5_SmartMOM.HSC
{
    partial class CustomerOrderStatus
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
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDate2 = new System.Windows.Forms.DateTimePicker();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cboFromStore = new System.Windows.Forms.ComboBox();
            this.cboToStore = new System.Windows.Forms.ComboBox();
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(976, 0);
            this.button3.Size = new System.Drawing.Size(77, 24);
            this.button3.Text = "이동처리";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1053, 0);
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.Text = "상세조회";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1128, 0);
            this.button1.Size = new System.Drawing.Size(70, 24);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 126);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.cboToStore);
            this.panelTop.Controls.Add(this.cboFromStore);
            this.panelTop.Controls.Add(this.txtProduct);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.dtpDueDate2);
            this.panelTop.Controls.Add(this.dtpDueDate);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 106);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(200, 24);
            this.label1.Text = "고객주문별 재고현황";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ납기일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "ㆍ품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orange;
            this.label4.Location = new System.Drawing.Point(378, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "ㆍFrom창고";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(733, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "ㆍTo창고";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate.Location = new System.Drawing.Point(107, 18);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(97, 21);
            this.dtpDueDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(209, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "~";
            // 
            // dtpDueDate2
            // 
            this.dtpDueDate2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDate2.Location = new System.Drawing.Point(232, 19);
            this.dtpDueDate2.Name = "dtpDueDate2";
            this.dtpDueDate2.Size = new System.Drawing.Size(97, 21);
            this.dtpDueDate2.TabIndex = 1;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(107, 64);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(222, 21);
            this.txtProduct.TabIndex = 3;
            // 
            // cboFromStore
            // 
            this.cboFromStore.FormattingEnabled = true;
            this.cboFromStore.Location = new System.Drawing.Point(479, 20);
            this.cboFromStore.Name = "cboFromStore";
            this.cboFromStore.Size = new System.Drawing.Size(173, 20);
            this.cboFromStore.TabIndex = 4;
            // 
            // cboToStore
            // 
            this.cboToStore.FormattingEnabled = true;
            this.cboToStore.Location = new System.Drawing.Point(814, 19);
            this.cboToStore.Name = "cboToStore";
            this.cboToStore.Size = new System.Drawing.Size(173, 20);
            this.cboToStore.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1101, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // CustomerOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "CustomerOrderStatus";
            this.Load += new System.EventHandler(this.CustomerOrderStatus_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboToStore;
        private System.Windows.Forms.ComboBox cboFromStore;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDate2;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        protected System.Windows.Forms.Button btnSearch;
    }
}
