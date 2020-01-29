namespace Team5_SmartMOM.HSM
{
    partial class Product_Plan
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
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.cboEquipment = new System.Windows.Forms.ComboBox();
            this.cboPlanID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
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
            this.button3.Location = new System.Drawing.Point(1019, 0);
            this.button3.Size = new System.Drawing.Size(65, 24);
            this.button3.Text = "엑셀";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 102);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Transparent;
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpDateEnd);
            this.panelTop.Controls.Add(this.dtpDateStart);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label11);
            this.panelTop.Controls.Add(this.cboProduct);
            this.panelTop.Controls.Add(this.cboEquipment);
            this.panelTop.Controls.Add(this.cboPlanID);
            this.panelTop.Size = new System.Drawing.Size(1202, 82);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Text = "생산계획";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(544, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 28;
            this.label5.Text = "~";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(564, 9);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(99, 21);
            this.dtpDateEnd.TabIndex = 26;
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(438, 9);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(99, 21);
            this.dtpDateStart.TabIndex = 27;
            this.dtpDateStart.ValueChanged += new System.EventHandler(this.dtpDateStart_ValueChanged);
            // 
            // cboEquipment
            // 
            this.cboEquipment.FormattingEnabled = true;
            this.cboEquipment.Location = new System.Drawing.Point(109, 51);
            this.cboEquipment.Name = "cboEquipment";
            this.cboEquipment.Size = new System.Drawing.Size(121, 20);
            this.cboEquipment.TabIndex = 24;
            // 
            // cboPlanID
            // 
            this.cboPlanID.FormattingEnabled = true;
            this.cboPlanID.Location = new System.Drawing.Point(109, 9);
            this.cboPlanID.Name = "cboPlanID";
            this.cboPlanID.Size = new System.Drawing.Size(121, 20);
            this.cboPlanID.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 17;
            this.label11.Text = "ㆍ설비";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 21;
            this.label10.Text = "ㆍPlanID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(375, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "ㆍ품목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(365, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "ㆍDate";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1084, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 39);
            this.btnSearch.TabIndex = 76;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(437, 51);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(226, 20);
            this.cboProduct.TabIndex = 24;
            // 
            // Product_Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Product_Plan";
            this.Load += new System.EventHandler(this.Product_Plan_Load);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.ComboBox cboEquipment;
        private System.Windows.Forms.ComboBox cboPlanID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cboProduct;
    }
}
