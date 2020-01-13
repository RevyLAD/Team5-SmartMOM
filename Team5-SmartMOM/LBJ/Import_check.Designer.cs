namespace Team5_SmartMOM.LBJ
{
    partial class Import_check
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
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.txtStartNum = new System.Windows.Forms.TextBox();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.cboResult = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            //this.label2 = new System.Windows.Forms.Label();
            this.dtpCheckday2 = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckday = new System.Windows.Forms.DateTimePicker();
            this.cboCheckDay = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.None;
            this.panel1.Controls.SetChildIndex(this.splitContainer1, 0);
            this.panel1.Controls.SetChildIndex(this.dataGridView2, 0);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 120;
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 465);
            // 
            // panelMid
            // 
            this.panelMid.Size = new System.Drawing.Size(1202, 52);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1038, 3);
            this.button3.Size = new System.Drawing.Size(65, 24);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1106, 3);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1153, 3);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 4);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 465);
            this.splitContainer2.SplitterDistance = 52;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.txtProduct);
            this.panelTop.Controls.Add(this.txtStartNum);
            this.panelTop.Controls.Add(this.cboCompany);
            this.panelTop.Controls.Add(this.cboResult);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            //this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpCheckday2);
            this.panelTop.Controls.Add(this.dtpCheckday);
            this.panelTop.Controls.Add(this.cboCheckDay);
            this.panelTop.Size = new System.Drawing.Size(1202, 120);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(794, 11);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(138, 21);
            this.txtProduct.TabIndex = 16;
            // 
            // txtStartNum
            // 
            this.txtStartNum.Location = new System.Drawing.Point(489, 45);
            this.txtStartNum.Name = "txtStartNum";
            this.txtStartNum.Size = new System.Drawing.Size(138, 21);
            this.txtStartNum.TabIndex = 17;
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(489, 11);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(138, 20);
            this.cboCompany.TabIndex = 15;
            // 
            // cboResult
            // 
            this.cboResult.FormattingEnabled = true;
            this.cboResult.Location = new System.Drawing.Point(110, 45);
            this.cboResult.Name = "cboResult";
            this.cboResult.Size = new System.Drawing.Size(190, 20);
            this.cboResult.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(383, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "ㆍ출발번호";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(733, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "ㆍ품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(383, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "ㆍ업체";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "ㆍ판정";
            // 
            // label2
            // 
            //this.label2.AutoSize = true;
            //this.label2.Location = new System.Drawing.Point(199, 17);
            //this.label2.Name = "label2";
            //this.label2.Size = new System.Drawing.Size(14, 12);
            //this.label2.TabIndex = 13;
            //this.label2.Text = "~";
            // 
            // dtpCheckday2
            // 
            this.dtpCheckday2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckday2.Location = new System.Drawing.Point(217, 12);
            this.dtpCheckday2.Name = "dtpCheckday2";
            this.dtpCheckday2.Size = new System.Drawing.Size(83, 21);
            this.dtpCheckday2.TabIndex = 7;
            // 
            // dtpCheckday
            // 
            this.dtpCheckday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckday.Location = new System.Drawing.Point(110, 12);
            this.dtpCheckday.Name = "dtpCheckday";
            this.dtpCheckday.Size = new System.Drawing.Size(83, 21);
            this.dtpCheckday.TabIndex = 8;
            // 
            // cboCheckDay
            // 
            this.cboCheckDay.FormattingEnabled = true;
            this.cboCheckDay.Location = new System.Drawing.Point(24, 12);
            this.cboCheckDay.Name = "cboCheckDay";
            this.cboCheckDay.Size = new System.Drawing.Size(75, 20);
            this.cboCheckDay.TabIndex = 6;
            this.cboCheckDay.Text = "검사일자";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 417);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1202, 172);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1202, 28);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "ㆍ이력조회";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1117, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // Import_check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Import_check";
            this.Text = "수입검사현황";
            this.Load += new System.EventHandler(this.Import_check_Load);
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.TextBox txtStartNum;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.ComboBox cboResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        //private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCheckday2;
        private System.Windows.Forms.DateTimePicker dtpCheckday;
        private System.Windows.Forms.ComboBox cboCheckDay;
        protected System.Windows.Forms.Button btnSearch;
    }
}
