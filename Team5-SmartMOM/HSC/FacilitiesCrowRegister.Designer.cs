﻿namespace Team5_SmartMOM
{
    partial class FacilitiesCrowRegister
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
            this.cboUMU = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCode = new System.Windows.Forms.TextBox();
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
            this.panelFull.Size = new System.Drawing.Size(424, 504);
            this.panelFull.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFull_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(402, 482);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 434);
            this.panelBottom.Size = new System.Drawing.Size(402, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.dateTimePicker1);
            this.panelDock.Controls.Add(this.txtCode);
            this.panelDock.Controls.Add(this.txtNo);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.txtExplain);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.txtModi);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Controls.Add(this.cboUMU);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtFacName);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Size = new System.Drawing.Size(402, 434);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(402, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(402, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.Text = "설비군";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(196, 9);
            this.button2.Size = new System.Drawing.Size(71, 30);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 9);
            this.button1.Size = new System.Drawing.Size(71, 30);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(-1916, 9);
            this.tileSave.Click += new System.EventHandler(this.tileSave_Click);
            // 
            // cboUMU
            // 
            this.cboUMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUMU.FormattingEnabled = true;
            this.cboUMU.Location = new System.Drawing.Point(155, 107);
            this.cboUMU.Name = "cboUMU";
            this.cboUMU.Size = new System.Drawing.Size(225, 24);
            this.cboUMU.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(18, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "ㆍ설비군 명";
            // 
            // txtFacName
            // 
            this.txtFacName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFacName.Location = new System.Drawing.Point(155, 74);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(225, 22);
            this.txtFacName.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(18, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "ㆍ설비군 코드";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "ㆍ사용유무";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "ㆍ수정자";
            // 
            // txtModi
            // 
            this.txtModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModi.Location = new System.Drawing.Point(155, 142);
            this.txtModi.Name = "txtModi";
            this.txtModi.Size = new System.Drawing.Size(225, 22);
            this.txtModi.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "ㆍ수정시간";
            // 
            // txtExplain
            // 
            this.txtExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtExplain.Location = new System.Drawing.Point(35, 232);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(345, 146);
            this.txtExplain.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(18, 203);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "ㆍ시설설명";
            // 
            // txtNo
            // 
            this.txtNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNo.Location = new System.Drawing.Point(155, 13);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(225, 22);
            this.txtNo.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(18, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 32;
            this.label5.Text = "ㆍ설비군 번호";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(155, 173);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(161, 21);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCode.Location = new System.Drawing.Point(155, 43);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(225, 22);
            this.txtCode.TabIndex = 33;
            // 
            // FacilitiesCrowRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(424, 504);
            this.Name = "FacilitiesCrowRegister";
            this.Load += new System.EventHandler(this.FacilitiesCrowRegister_Load);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtModi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboUMU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCode;
    }
}
