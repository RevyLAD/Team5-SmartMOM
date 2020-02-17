namespace Team5_SmartMOM.HSM
{
    partial class WorkOrder
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.cboPlanID = new System.Windows.Forms.ComboBox();
            this.cboWorkState = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.button3.Location = new System.Drawing.Point(910, 0);
            this.button3.Size = new System.Drawing.Size(115, 24);
            this.button3.Text = "작업지시생성";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1025, 0);
            this.button2.Size = new System.Drawing.Size(116, 24);
            this.button2.Text = "작업지시확정";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 72);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dtpDateEnd);
            this.panelTop.Controls.Add(this.dtpDateStart);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.cboWorkState);
            this.panelTop.Controls.Add(this.cboPlanID);
            this.panelTop.Size = new System.Drawing.Size(1202, 52);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.Text = "작업지시생성";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1084, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 39);
            this.btnSearch.TabIndex = 87;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 19);
            this.label10.TabIndex = 80;
            this.label10.Text = "ㆍPlanID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(472, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 12);
            this.label5.TabIndex = 86;
            this.label5.Text = "~";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 79;
            this.label2.Text = "ㆍDate";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(492, 14);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(99, 21);
            this.dtpDateEnd.TabIndex = 84;
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(366, 14);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(99, 21);
            this.dtpDateStart.TabIndex = 85;
            // 
            // cboPlanID
            // 
            this.cboPlanID.FormattingEnabled = true;
            this.cboPlanID.Location = new System.Drawing.Point(109, 14);
            this.cboPlanID.Name = "cboPlanID";
            this.cboPlanID.Size = new System.Drawing.Size(133, 20);
            this.cboPlanID.TabIndex = 83;
            this.cboPlanID.SelectedIndexChanged += new System.EventHandler(this.cboPlanID_SelectedIndexChanged);
            // 
            // cboWorkState
            // 
            this.cboWorkState.FormattingEnabled = true;
            this.cboWorkState.Location = new System.Drawing.Point(708, 14);
            this.cboWorkState.Name = "cboWorkState";
            this.cboWorkState.Size = new System.Drawing.Size(100, 20);
            this.cboWorkState.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(646, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 78;
            this.label3.Text = "ㆍ상태";
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "WorkOrder";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
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
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.ComboBox cboPlanID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboWorkState;
    }
}
