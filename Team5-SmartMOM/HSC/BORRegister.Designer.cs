namespace Team5_SmartMOM
{
    partial class BORRegister
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
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboUMU = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTacTime = new System.Windows.Forms.TextBox();
            this.cboFACG_Code = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFacCode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboITEMCode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeild = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPriority = new System.Windows.Forms.TextBox();
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
            this.panelFull.Size = new System.Drawing.Size(641, 390);
            this.panelFull.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFull_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(619, 368);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 320);
            this.panelBottom.Size = new System.Drawing.Size(619, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.txtPriority);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.txtYeild);
            this.panelDock.Controls.Add(this.txtExplain);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.cboUMU);
            this.panelDock.Controls.Add(this.label15);
            this.panelDock.Controls.Add(this.label10);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtTacTime);
            this.panelDock.Controls.Add(this.cboFACG_Code);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.cboFacCode);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.cboITEMCode);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(619, 320);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(619, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(619, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.Text = "Bill Of Resource";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(318, 10);
            // 
            // button1
            // 
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(682, 10);
            this.tileSave.Click += new System.EventHandler(this.tileSave_Click);
            // 
            // txtExplain
            // 
            this.txtExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtExplain.Location = new System.Drawing.Point(128, 143);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(477, 117);
            this.txtExplain.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(8, 146);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 58;
            this.label16.Text = "ㆍ비고";
            // 
            // cboUMU
            // 
            this.cboUMU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUMU.FormattingEnabled = true;
            this.cboUMU.Location = new System.Drawing.Point(433, 111);
            this.cboUMU.Name = "cboUMU";
            this.cboUMU.Size = new System.Drawing.Size(172, 23);
            this.cboUMU.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(325, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 16);
            this.label15.TabIndex = 56;
            this.label15.Text = "ㆍ사용유무";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(9, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 16);
            this.label10.TabIndex = 47;
            this.label10.Text = "ㆍ수율";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(325, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "ㆍTac Time";
            // 
            // txtTacTime
            // 
            this.txtTacTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTacTime.Location = new System.Drawing.Point(433, 47);
            this.txtTacTime.Name = "txtTacTime";
            this.txtTacTime.Size = new System.Drawing.Size(172, 21);
            this.txtTacTime.TabIndex = 39;
            // 
            // cboFACG_Code
            // 
            this.cboFACG_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFACG_Code.FormattingEnabled = true;
            this.cboFACG_Code.Location = new System.Drawing.Point(433, 15);
            this.cboFACG_Code.Name = "cboFACG_Code";
            this.cboFACG_Code.Size = new System.Drawing.Size(172, 23);
            this.cboFACG_Code.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(325, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "ㆍ공정";
            // 
            // cboFacCode
            // 
            this.cboFacCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacCode.FormattingEnabled = true;
            this.cboFacCode.Location = new System.Drawing.Point(128, 45);
            this.cboFacCode.Name = "cboFacCode";
            this.cboFacCode.Size = new System.Drawing.Size(172, 23);
            this.cboFacCode.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(9, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 34;
            this.label4.Text = "ㆍ설비";
            // 
            // cboITEMCode
            // 
            this.cboITEMCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboITEMCode.FormattingEnabled = true;
            this.cboITEMCode.Location = new System.Drawing.Point(128, 13);
            this.cboITEMCode.Name = "cboITEMCode";
            this.cboITEMCode.Size = new System.Drawing.Size(172, 23);
            this.cboITEMCode.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(9, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "ㆍ품목";
            // 
            // txtYeild
            // 
            this.txtYeild.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtYeild.Location = new System.Drawing.Point(128, 81);
            this.txtYeild.Name = "txtYeild";
            this.txtYeild.Size = new System.Drawing.Size(172, 21);
            this.txtYeild.TabIndex = 60;
            this.txtYeild.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Tomato;
            this.label3.Location = new System.Drawing.Point(325, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 61;
            this.label3.Text = "ㆍ우선순위";
            // 
            // txtPriority
            // 
            this.txtPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPriority.Location = new System.Drawing.Point(433, 80);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(172, 21);
            this.txtPriority.TabIndex = 62;
            // 
            // BORRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(641, 390);
            this.Name = "BORRegister";
            this.Load += new System.EventHandler(this.BORRegister_Load);
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

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYeild;
        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboUMU;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTacTime;
        private System.Windows.Forms.ComboBox cboFACG_Code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFacCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboITEMCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPriority;
    }
}
