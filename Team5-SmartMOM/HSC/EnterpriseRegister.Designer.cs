namespace Team5_SmartMOM
{
    partial class EnterpriseRegister
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
            this.txtModifiyDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCOM_Type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCOM_Name = new System.Windows.Forms.TextBox();
            this.txtCOM_Code = new System.Windows.Forms.TextBox();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtModifier = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCOM_Manager = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCOM_Owner = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCOM_Sector = new System.Windows.Forms.TextBox();
            this.txtCOM_Email = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtCOM_Phone = new System.Windows.Forms.TextBox();
            this.cbo_UseOrNot = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtComNo = new System.Windows.Forms.TextBox();
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
            this.panelFull.Size = new System.Drawing.Size(767, 391);
            this.panelFull.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFull_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(745, 369);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 321);
            this.panelBottom.Size = new System.Drawing.Size(745, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.txtComNo);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.cbo_UseOrNot);
            this.panelDock.Controls.Add(this.label21);
            this.panelDock.Controls.Add(this.label17);
            this.panelDock.Controls.Add(this.txtCOM_Phone);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.txtCOM_Email);
            this.panelDock.Controls.Add(this.txtCOM_Sector);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtCOM_Owner);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.txtModifiyDate);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.cboCOM_Type);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.txtCOM_Name);
            this.panelDock.Controls.Add(this.txtCOM_Code);
            this.panelDock.Controls.Add(this.txtInformation);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.txtModifier);
            this.panelDock.Controls.Add(this.label14);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.txtCOM_Manager);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(745, 321);
            this.panelDock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDock_Paint);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(745, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(745, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.Text = "업체정보";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(368, 10);
            this.button2.Size = new System.Drawing.Size(93, 30);
            this.button2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 10);
            this.button1.Size = new System.Drawing.Size(86, 30);
            this.button1.TabIndex = 14;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(2179, 10);
            // 
            // txtModifiyDate
            // 
            this.txtModifiyDate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModifiyDate.Location = new System.Drawing.Point(104, 124);
            this.txtModifiyDate.Name = "txtModifiyDate";
            this.txtModifiyDate.ReadOnly = true;
            this.txtModifiyDate.Size = new System.Drawing.Size(124, 21);
            this.txtModifiyDate.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 90;
            this.label3.Text = "ㆍ수정시간";
            // 
            // cboCOM_Type
            // 
            this.cboCOM_Type.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboCOM_Type.FormattingEnabled = true;
            this.cboCOM_Type.Location = new System.Drawing.Point(585, 35);
            this.cboCOM_Type.Name = "cboCOM_Type";
            this.cboCOM_Type.Size = new System.Drawing.Size(124, 21);
            this.cboCOM_Type.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(488, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 88;
            this.label4.Text = "ㆍ업체타입";
            // 
            // txtCOM_Name
            // 
            this.txtCOM_Name.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Name.Location = new System.Drawing.Point(356, 35);
            this.txtCOM_Name.Name = "txtCOM_Name";
            this.txtCOM_Name.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Name.TabIndex = 3;
            // 
            // txtCOM_Code
            // 
            this.txtCOM_Code.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Code.Location = new System.Drawing.Point(104, 35);
            this.txtCOM_Code.Name = "txtCOM_Code";
            this.txtCOM_Code.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Code.TabIndex = 2;
            // 
            // txtInformation
            // 
            this.txtInformation.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtInformation.Location = new System.Drawing.Point(104, 162);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.Size = new System.Drawing.Size(605, 105);
            this.txtInformation.TabIndex = 13;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(18, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 84;
            this.label16.Text = "ㆍ업체정보";
            // 
            // txtModifier
            // 
            this.txtModifier.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtModifier.Location = new System.Drawing.Point(356, 126);
            this.txtModifier.Name = "txtModifier";
            this.txtModifier.ReadOnly = true;
            this.txtModifier.Size = new System.Drawing.Size(124, 21);
            this.txtModifier.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(241, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 80;
            this.label14.Text = "ㆍ수정자";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(488, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 14);
            this.label12.TabIndex = 78;
            this.label12.Text = "ㆍ이메일";
            // 
            // txtCOM_Manager
            // 
            this.txtCOM_Manager.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Manager.Location = new System.Drawing.Point(356, 65);
            this.txtCOM_Manager.Name = "txtCOM_Manager";
            this.txtCOM_Manager.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Manager.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(241, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 14);
            this.label6.TabIndex = 71;
            this.label6.Text = "ㆍ업체명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(18, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 68;
            this.label2.Text = "ㆍ업체코드";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(241, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 94;
            this.label5.Text = "ㆍ담당자명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(18, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 14);
            this.label7.TabIndex = 96;
            this.label7.Text = "ㆍ대표자명";
            // 
            // txtCOM_Owner
            // 
            this.txtCOM_Owner.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Owner.Location = new System.Drawing.Point(104, 65);
            this.txtCOM_Owner.Name = "txtCOM_Owner";
            this.txtCOM_Owner.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Owner.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(488, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 100;
            this.label9.Text = "ㆍ업종";
            // 
            // txtCOM_Sector
            // 
            this.txtCOM_Sector.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Sector.Location = new System.Drawing.Point(585, 65);
            this.txtCOM_Sector.Name = "txtCOM_Sector";
            this.txtCOM_Sector.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Sector.TabIndex = 7;
            // 
            // txtCOM_Email
            // 
            this.txtCOM_Email.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Email.Location = new System.Drawing.Point(585, 95);
            this.txtCOM_Email.Name = "txtCOM_Email";
            this.txtCOM_Email.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Email.TabIndex = 10;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label17.Location = new System.Drawing.Point(18, 97);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 14);
            this.label17.TabIndex = 110;
            this.label17.Text = "ㆍ전화번호";
            // 
            // txtCOM_Phone
            // 
            this.txtCOM_Phone.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtCOM_Phone.Location = new System.Drawing.Point(104, 95);
            this.txtCOM_Phone.Name = "txtCOM_Phone";
            this.txtCOM_Phone.Size = new System.Drawing.Size(124, 21);
            this.txtCOM_Phone.TabIndex = 8;
            // 
            // cbo_UseOrNot
            // 
            this.cbo_UseOrNot.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_UseOrNot.FormattingEnabled = true;
            this.cbo_UseOrNot.Location = new System.Drawing.Point(356, 95);
            this.cbo_UseOrNot.Name = "cbo_UseOrNot";
            this.cbo_UseOrNot.Size = new System.Drawing.Size(124, 21);
            this.cbo_UseOrNot.TabIndex = 9;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label21.ForeColor = System.Drawing.Color.Tomato;
            this.label21.Location = new System.Drawing.Point(241, 97);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(67, 14);
            this.label21.TabIndex = 117;
            this.label21.Text = "ㆍ사용유무";
            // 
            // txtComNo
            // 
            this.txtComNo.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtComNo.Location = new System.Drawing.Point(104, 6);
            this.txtComNo.Name = "txtComNo";
            this.txtComNo.Size = new System.Drawing.Size(204, 21);
            this.txtComNo.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(18, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 14);
            this.label8.TabIndex = 119;
            this.label8.Text = "ㆍ업체번호";
            // 
            // EnterpriseRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(767, 391);
            this.Name = "EnterpriseRegister";
            this.Load += new System.EventHandler(this.EnterpriseRegister_Load);
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
        private System.Windows.Forms.TextBox txtModifiyDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCOM_Type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCOM_Name;
        private System.Windows.Forms.TextBox txtCOM_Code;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtModifier;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCOM_Manager;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_UseOrNot;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtCOM_Phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCOM_Email;
        private System.Windows.Forms.TextBox txtCOM_Sector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCOM_Owner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComNo;
        private System.Windows.Forms.Label label8;
    }
}
