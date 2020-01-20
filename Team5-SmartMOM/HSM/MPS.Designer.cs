namespace Team5_SmartMOM.HSM
{
    partial class MPS
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
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.txtModelSuffix = new System.Windows.Forms.TextBox();
            this.dtpDueDateEnd = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDueDateStart = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.panelFull.Size = new System.Drawing.Size(423, 298);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(403, 278);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 230);
            this.panelBottom.Size = new System.Drawing.Size(403, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.cboCustomer);
            this.panelDock.Controls.Add(this.txtModelSuffix);
            this.panelDock.Controls.Add(this.dateTimePicker1);
            this.panelDock.Controls.Add(this.dtpDueDateEnd);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.dtpDueDateStart);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(403, 230);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(403, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(403, 38);
            // 
            // label1
            // 
            this.label1.Text = "생산계획생성";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(202, 10);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 10);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(376, 10);
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(118, 56);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(118, 20);
            this.cboCustomer.TabIndex = 15;
            // 
            // txtModelSuffix
            // 
            this.txtModelSuffix.Location = new System.Drawing.Point(119, 136);
            this.txtModelSuffix.Name = "txtModelSuffix";
            this.txtModelSuffix.Size = new System.Drawing.Size(229, 21);
            this.txtModelSuffix.TabIndex = 14;
            // 
            // dtpDueDateEnd
            // 
            this.dtpDueDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDateEnd.Location = new System.Drawing.Point(245, 96);
            this.dtpDueDateEnd.Name = "dtpDueDateEnd";
            this.dtpDueDateEnd.Size = new System.Drawing.Size(100, 21);
            this.dtpDueDateEnd.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(225, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "~";
            // 
            // dtpDueDateStart
            // 
            this.dtpDueDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDueDateStart.Location = new System.Drawing.Point(118, 21);
            this.dtpDueDateStart.Name = "dtpDueDateStart";
            this.dtpDueDateStart.Size = new System.Drawing.Size(186, 21);
            this.dtpDueDateStart.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "생산계획대상";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "내용";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(27, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "생성일자";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "생성계획기간";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 21);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // MPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(423, 298);
            this.Name = "MPS";
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

        private System.Windows.Forms.ComboBox cboCustomer;
        private System.Windows.Forms.TextBox txtModelSuffix;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpDueDateEnd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDueDateStart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}
