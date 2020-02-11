namespace Team5_SmartMOM.PSM
{
    partial class Material_Ledger_Export
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
            this.cbosystem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboFacCode = new System.Windows.Forms.ComboBox();
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
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.Text = "출고";
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 93);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboFacCode);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.cbosystem);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Controls.Add(this.dateTimePicker2);
            this.panelTop.Controls.Add(this.dateTimePicker1);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Size = new System.Drawing.Size(1202, 73);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(121, 24);
            this.label1.Text = "원자재불출";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1114, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 99;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbosystem
            // 
            this.cbosystem.FormattingEnabled = true;
            this.cbosystem.Location = new System.Drawing.Point(453, 15);
            this.cbosystem.Name = "cbosystem";
            this.cbosystem.Size = new System.Drawing.Size(161, 20);
            this.cbosystem.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 19);
            this.label2.TabIndex = 94;
            this.label2.Text = "* 설비";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(229, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(83, 21);
            this.dateTimePicker2.TabIndex = 88;
            this.dateTimePicker2.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(83, 21);
            this.dateTimePicker1.TabIndex = 87;
            this.dateTimePicker1.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(207, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 86;
            this.label10.Text = " - ";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 85;
            this.label3.Text = "* 품목";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 19);
            this.label9.TabIndex = 80;
            this.label9.Text = "* 요청일";
            // 
            // cboFacCode
            // 
            this.cboFacCode.FormattingEnabled = true;
            this.cboFacCode.Location = new System.Drawing.Point(733, 18);
            this.cboFacCode.Name = "cboFacCode";
            this.cboFacCode.Size = new System.Drawing.Size(163, 20);
            this.cboFacCode.TabIndex = 100;
            // 
            // Material_Ledger_Export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Material_Ledger_Export";
            this.Load += new System.EventHandler(this.Material_Ledger_Export_Load);
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
        private System.Windows.Forms.ComboBox cbosystem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboFacCode;
    }
}
