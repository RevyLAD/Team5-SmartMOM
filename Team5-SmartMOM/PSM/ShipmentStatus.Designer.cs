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
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.btnexcel = new System.Windows.Forms.Button();
            this.cboplanid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbocompany = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Size = new System.Drawing.Size(1222, 660);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Size = new System.Drawing.Size(1202, 640);
            this.panel1.Controls.SetChildIndex(this.panelMid, 0);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.splitContainer2, 0);
            this.panel1.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.Controls.SetChildIndex(this.panel4, 0);
            this.panel1.Controls.SetChildIndex(this.panel5, 0);
            this.panel1.Controls.SetChildIndex(this.dataGridView2, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(973, 0);
            this.button3.Size = new System.Drawing.Size(86, 24);
            this.button3.Text = "출하취소";
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1059, 0);
            this.button2.Size = new System.Drawing.Size(82, 24);
            this.button2.Text = "출하취소";
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 117);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtitem);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.cbocompany);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.cboplanid);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelTop.Size = new System.Drawing.Size(1202, 97);
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
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.Text = "출하현황";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1114, 59);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 38;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1202, 462);
            this.dataGridView2.TabIndex = 43;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.btnexcel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1202, 28);
            this.panel5.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 15;
            this.label7.Text = "고객목록";
            // 
            // btnexcel
            // 
            this.btnexcel.BackColor = System.Drawing.Color.Snow;
            this.btnexcel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnexcel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnexcel.Image = global::Team5_SmartMOM.Properties.Resources.microsoft_excel;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(1141, 0);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(57, 24);
            this.btnexcel.TabIndex = 14;
            this.btnexcel.Text = "엑셀";
            this.btnexcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // cboplanid
            // 
            this.cboplanid.FormattingEnabled = true;
            this.cboplanid.Location = new System.Drawing.Point(123, 21);
            this.cboplanid.Name = "cboplanid";
            this.cboplanid.Size = new System.Drawing.Size(191, 20);
            this.cboplanid.TabIndex = 92;
            this.cboplanid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboplanid_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 91;
            this.label5.Text = "* Plan_ID";
            // 
            // cbocompany
            // 
            this.cbocompany.FormattingEnabled = true;
            this.cbocompany.Location = new System.Drawing.Point(423, 21);
            this.cbocompany.Name = "cbocompany";
            this.cbocompany.Size = new System.Drawing.Size(191, 20);
            this.cbocompany.TabIndex = 94;
            this.cbocompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboplanid_KeyPress);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(342, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 93;
            this.label3.Text = "* 고객사";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(123, 53);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(191, 21);
            this.txtitem.TabIndex = 98;
            this.txtitem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtitem_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 97;
            this.label4.Text = "* 품목";
            // 
            // ShipmentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 660);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        protected System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbocompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboplanid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
