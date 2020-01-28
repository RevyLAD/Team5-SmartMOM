namespace Team5_SmartMOM
{
    partial class FacilitiesRegister
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
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboBadWareHouse = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFac_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboOutWareHouse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FACG_Code = new System.Windows.Forms.TextBox();
            this.FAC_Code = new System.Windows.Forms.TextBox();
            this.cboInWareHouse = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtModifiyDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOthers = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panelFull.Size = new System.Drawing.Size(720, 414);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(698, 392);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 344);
            this.panelBottom.Size = new System.Drawing.Size(698, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.txtOthers);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.txtModifiyDate);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.cboInWareHouse);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.FAC_Code);
            this.panelDock.Controls.Add(this.FACG_Code);
            this.panelDock.Controls.Add(this.txtRemark);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.cboUse);
            this.panelDock.Controls.Add(this.label15);
            this.panelDock.Controls.Add(this.txtModifier);
            this.panelDock.Controls.Add(this.label14);
            this.panelDock.Controls.Add(this.cboBadWareHouse);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtFac_Name);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.cboOutWareHouse);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(698, 344);
            this.panelDock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDock_Paint);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(698, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(698, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.Text = "설비";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(391, 10);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(315, 10);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(1282, 10);
            this.tileSave.Click += new System.EventHandler(this.tileSave_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtRemark.Location = new System.Drawing.Point(106, 112);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(564, 85);
            this.txtRemark.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(18, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 58;
            this.label16.Text = "ㆍ특이사항";
            // 
            // cboUse
            // 
            this.cboUse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(106, 76);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(124, 21);
            this.cboUse.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(18, 78);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "ㆍ사용유무";
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModifier.Location = new System.Drawing.Point(331, 76);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.Size = new System.Drawing.Size(124, 21);
            this.txtModifier.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(243, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 54;
            this.label14.Text = "ㆍ수정자";
            // 
            // cboBadWareHouse
            // 
            this.cboBadWareHouse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboBadWareHouse.FormattingEnabled = true;
            this.cboBadWareHouse.Location = new System.Drawing.Point(546, 44);
            this.cboBadWareHouse.Name = "cboBadWareHouse";
            this.cboBadWareHouse.Size = new System.Drawing.Size(124, 21);
            this.cboBadWareHouse.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(463, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 44;
            this.label9.Text = "ㆍ불량창고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(475, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 40;
            this.label7.Text = "ㆍ설비명";
            // 
            // txtFac_Name
            // 
            this.txtFac_Name.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFac_Name.Location = new System.Drawing.Point(546, 12);
            this.txtFac_Name.Name = "txtFac_Name";
            this.txtFac_Name.Size = new System.Drawing.Size(124, 21);
            this.txtFac_Name.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(243, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "ㆍ설비코드";
            // 
            // cboOutWareHouse
            // 
            this.cboOutWareHouse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboOutWareHouse.FormattingEnabled = true;
            this.cboOutWareHouse.Location = new System.Drawing.Point(106, 42);
            this.cboOutWareHouse.Name = "cboOutWareHouse";
            this.cboOutWareHouse.Size = new System.Drawing.Size(124, 21);
            this.cboOutWareHouse.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 35;
            this.label5.Text = "ㆍ소진창고";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(18, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 14);
            this.label2.TabIndex = 30;
            this.label2.Text = "ㆍ설비군코드";
            // 
            // FACG_Code
            // 
            this.FACG_Code.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FACG_Code.Location = new System.Drawing.Point(106, 12);
            this.FACG_Code.Name = "FACG_Code";
            this.FACG_Code.Size = new System.Drawing.Size(124, 21);
            this.FACG_Code.TabIndex = 60;
            // 
            // FAC_Code
            // 
            this.FAC_Code.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FAC_Code.Location = new System.Drawing.Point(331, 12);
            this.FAC_Code.Name = "FAC_Code";
            this.FAC_Code.Size = new System.Drawing.Size(124, 21);
            this.FAC_Code.TabIndex = 61;
            // 
            // cboInWareHouse
            // 
            this.cboInWareHouse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboInWareHouse.FormattingEnabled = true;
            this.cboInWareHouse.Location = new System.Drawing.Point(331, 44);
            this.cboInWareHouse.Name = "cboInWareHouse";
            this.cboInWareHouse.Size = new System.Drawing.Size(124, 21);
            this.cboInWareHouse.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(243, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 62;
            this.label4.Text = "ㆍ양품창고";
            // 
            // txtModifiyDate
            // 
            this.txtModifiyDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModifiyDate.Location = new System.Drawing.Point(546, 76);
            this.txtModifiyDate.Name = "txtModifiyDate";
            this.txtModifiyDate.Size = new System.Drawing.Size(124, 21);
            this.txtModifiyDate.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(461, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "ㆍ수정시간";
            // 
            // txtOthers
            // 
            this.txtOthers.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtOthers.Location = new System.Drawing.Point(106, 203);
            this.txtOthers.Multiline = true;
            this.txtOthers.Name = "txtOthers";
            this.txtOthers.Size = new System.Drawing.Size(564, 85);
            this.txtOthers.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(18, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 66;
            this.label8.Text = "ㆍ비고";
            // 
            // FacilitiesRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(720, 414);
            this.Name = "FacilitiesRegister";
            this.Load += new System.EventHandler(this.FacilitiesRegister_Load);
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

        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboUse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cboBadWareHouse;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFac_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboOutWareHouse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOthers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModifiyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInWareHouse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FAC_Code;
        private System.Windows.Forms.TextBox FACG_Code;
    }
}
