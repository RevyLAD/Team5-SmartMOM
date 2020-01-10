namespace Team5_SmartMOM
{
    partial class Enterprise
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
            this.btnInquiry = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cboFacCrow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panelMid.Controls.Add(this.metroButton2);
            this.panelMid.Controls.Add(this.metroButton1);
            this.panelMid.Size = new System.Drawing.Size(1202, 40);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.metroButton1, 0);
            this.panelMid.Controls.SetChildIndex(this.metroButton2, 0);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Dock = System.Windows.Forms.DockStyle.None;
            this.button3.Location = new System.Drawing.Point(898, 9);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Dock = System.Windows.Forms.DockStyle.None;
            this.button2.Location = new System.Drawing.Point(949, 9);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Dock = System.Windows.Forms.DockStyle.None;
            this.button1.Location = new System.Drawing.Point(1000, 9);
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 181);
            this.panel3.Size = new System.Drawing.Size(1202, 408);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Size = new System.Drawing.Size(1202, 106);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.textBox3);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.btnInquiry);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.cboFacCrow);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Size = new System.Drawing.Size(1202, 86);
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.Controls.SetChildIndex(this.label2, 0);
            this.panelTop.Controls.SetChildIndex(this.label3, 0);
            this.panelTop.Controls.SetChildIndex(this.cboFacCrow, 0);
            this.panelTop.Controls.SetChildIndex(this.textBox1, 0);
            this.panelTop.Controls.SetChildIndex(this.btnInquiry, 0);
            this.panelTop.Controls.SetChildIndex(this.label4, 0);
            this.panelTop.Controls.SetChildIndex(this.label6, 0);
            this.panelTop.Controls.SetChildIndex(this.textBox2, 0);
            this.panelTop.Controls.SetChildIndex(this.label5, 0);
            this.panelTop.Controls.SetChildIndex(this.textBox3, 0);
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(696, 62);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Location = new System.Drawing.Point(976, 14);
            this.splitContainer2.Size = new System.Drawing.Size(1202, 497);
            this.splitContainer2.SplitterDistance = 40;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1158, 497);
            this.splitContainer1.SplitterDistance = 808;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.Text = "업체코드정의";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 10);
            this.label2.Size = new System.Drawing.Size(16, 72);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnInquiry.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInquiry.Location = new System.Drawing.Point(1051, 30);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(92, 32);
            this.btnInquiry.TabIndex = 6;
            this.btnInquiry.Text = "조회";
            this.btnInquiry.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(140, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 22);
            this.textBox1.TabIndex = 8;
            // 
            // cboFacCrow
            // 
            this.cboFacCrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacCrow.FormattingEnabled = true;
            this.cboFacCrow.Location = new System.Drawing.Point(788, 7);
            this.cboFacCrow.Name = "cboFacCrow";
            this.cboFacCrow.Size = new System.Drawing.Size(168, 24);
            this.cboFacCrow.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(693, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ㆍ 업체타입";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(454, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 22);
            this.textBox2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(373, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "ㆍ 업체명";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(140, 51);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 22);
            this.textBox3.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(4, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "ㆍ 사업자등록번호";
            // 
            // metroButton1
            // 
            this.metroButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton1.Location = new System.Drawing.Point(1051, 10);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(74, 23);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "양식다운로드";
            // 
            // metroButton2
            // 
            this.metroButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.metroButton2.Location = new System.Drawing.Point(1131, 10);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(62, 23);
            this.metroButton2.TabIndex = 3;
            this.metroButton2.Text = "Excel 등록";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(56, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "ㆍ 업체명";
            // 
            // Enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Enterprise";
            this.Load += new System.EventHandler(this.Enterprise_Load);
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

        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboFacCrow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.Label label6;
    }
}
