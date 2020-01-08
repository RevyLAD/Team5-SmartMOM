namespace Team5_SmartMOM
{
    partial class FactoryRegister
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
            this.label2 = new System.Windows.Forms.Label();
            this.cboFacCrow = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFacCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFacCate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHighFac = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.cboUMU = new System.Windows.Forms.ComboBox();
            this.cboAgency = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProcess = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cboDemand = new System.Windows.Forms.ComboBox();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.cboMaterials = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtReceiver = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtReceiveTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelFull.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDock.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.txtExplain);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.cboUse);
            this.panelDock.Controls.Add(this.label15);
            this.panelDock.Controls.Add(this.txtReceiveTime);
            this.panelDock.Controls.Add(this.label14);
            this.panelDock.Controls.Add(this.txtReceiver);
            this.panelDock.Controls.Add(this.label13);
            this.panelDock.Controls.Add(this.cboMaterials);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.txtTurn);
            this.panelDock.Controls.Add(this.cboDemand);
            this.panelDock.Controls.Add(this.label10);
            this.panelDock.Controls.Add(this.label11);
            this.panelDock.Controls.Add(this.cboProcess);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.cboAgency);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.cboUMU);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtFacName);
            this.panelDock.Controls.Add(this.cboHighFac);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.cboFacCate);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.txtFacCode);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.cboFacCrow);
            this.panelDock.Controls.Add(this.label2);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.Text = "공장 정보";
            // 
            // tileSave
            // 
            this.tileSave.Click += new System.EventHandler(this.tileSave_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(19, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ시설군";
            // 
            // cboFacCrow
            // 
            this.cboFacCrow.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacCrow.FormattingEnabled = true;
            this.cboFacCrow.Location = new System.Drawing.Point(107, 15);
            this.cboFacCrow.Name = "cboFacCrow";
            this.cboFacCrow.Size = new System.Drawing.Size(172, 21);
            this.cboFacCrow.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(326, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "ㆍ유무상구분";
            // 
            // txtFacCode
            // 
            this.txtFacCode.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFacCode.Location = new System.Drawing.Point(107, 42);
            this.txtFacCode.Name = "txtFacCode";
            this.txtFacCode.Size = new System.Drawing.Size(172, 21);
            this.txtFacCode.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(19, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "ㆍ시설코드";
            // 
            // cboFacCate
            // 
            this.cboFacCate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacCate.FormattingEnabled = true;
            this.cboFacCate.Location = new System.Drawing.Point(107, 69);
            this.cboFacCate.Name = "cboFacCate";
            this.cboFacCate.Size = new System.Drawing.Size(172, 21);
            this.cboFacCate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Tomato;
            this.label5.Location = new System.Drawing.Point(19, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "ㆍ시설구분";
            // 
            // cboHighFac
            // 
            this.cboHighFac.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboHighFac.FormattingEnabled = true;
            this.cboHighFac.Location = new System.Drawing.Point(414, 17);
            this.cboHighFac.Name = "cboHighFac";
            this.cboHighFac.Size = new System.Drawing.Size(172, 21);
            this.cboHighFac.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(326, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 14);
            this.label6.TabIndex = 7;
            this.label6.Text = "ㆍ상위시설";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Tomato;
            this.label7.Location = new System.Drawing.Point(326, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "ㆍ시설명";
            // 
            // txtFacName
            // 
            this.txtFacName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFacName.Location = new System.Drawing.Point(414, 44);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(172, 21);
            this.txtFacName.TabIndex = 9;
            // 
            // cboUMU
            // 
            this.cboUMU.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUMU.FormattingEnabled = true;
            this.cboUMU.Location = new System.Drawing.Point(414, 71);
            this.cboUMU.Name = "cboUMU";
            this.cboUMU.Size = new System.Drawing.Size(172, 21);
            this.cboUMU.TabIndex = 11;
            // 
            // cboAgency
            // 
            this.cboAgency.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboAgency.FormattingEnabled = true;
            this.cboAgency.Location = new System.Drawing.Point(414, 98);
            this.cboAgency.Name = "cboAgency";
            this.cboAgency.Size = new System.Drawing.Size(172, 21);
            this.cboAgency.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(326, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 12;
            this.label8.Text = "ㆍ업체";
            // 
            // cboProcess
            // 
            this.cboProcess.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Location = new System.Drawing.Point(414, 125);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(172, 21);
            this.cboProcess.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(326, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 14;
            this.label9.Text = "ㆍ공정차감";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(19, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 14);
            this.label10.TabIndex = 17;
            this.label10.Text = "ㆍ수요차감";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(19, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "ㆍ순서";
            // 
            // cboDemand
            // 
            this.cboDemand.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboDemand.FormattingEnabled = true;
            this.cboDemand.Location = new System.Drawing.Point(107, 123);
            this.cboDemand.Name = "cboDemand";
            this.cboDemand.Size = new System.Drawing.Size(172, 21);
            this.cboDemand.TabIndex = 18;
            // 
            // txtTurn
            // 
            this.txtTurn.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTurn.Location = new System.Drawing.Point(107, 96);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.Size = new System.Drawing.Size(172, 21);
            this.txtTurn.TabIndex = 19;
            // 
            // cboMaterials
            // 
            this.cboMaterials.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboMaterials.FormattingEnabled = true;
            this.cboMaterials.Location = new System.Drawing.Point(107, 150);
            this.cboMaterials.Name = "cboMaterials";
            this.cboMaterials.Size = new System.Drawing.Size(172, 21);
            this.cboMaterials.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(19, 152);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 20;
            this.label12.Text = "ㆍ자재차감";
            // 
            // txtReceiver
            // 
            this.txtReceiver.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReceiver.Location = new System.Drawing.Point(414, 152);
            this.txtReceiver.Name = "txtReceiver";
            this.txtReceiver.ReadOnly = true;
            this.txtReceiver.Size = new System.Drawing.Size(172, 21);
            this.txtReceiver.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(326, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 14);
            this.label13.TabIndex = 22;
            this.label13.Text = "ㆍ수령자";
            // 
            // txtReceiveTime
            // 
            this.txtReceiveTime.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReceiveTime.Location = new System.Drawing.Point(107, 177);
            this.txtReceiveTime.Name = "txtReceiveTime";
            this.txtReceiveTime.ReadOnly = true;
            this.txtReceiveTime.Size = new System.Drawing.Size(172, 21);
            this.txtReceiveTime.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(19, 180);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 14);
            this.label14.TabIndex = 24;
            this.label14.Text = "ㆍ수령시간";
            // 
            // cboUse
            // 
            this.cboUse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(414, 179);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(172, 21);
            this.cboUse.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(326, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 26;
            this.label15.Text = "ㆍ사용유무";
            // 
            // txtExplain
            // 
            this.txtExplain.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtExplain.Location = new System.Drawing.Point(107, 206);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(479, 117);
            this.txtExplain.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(19, 209);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 28;
            this.label16.Text = "ㆍ시설설명";
            // 
            // FactoryRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Name = "FactoryRegister";
            this.panelFull.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelDock.ResumeLayout(false);
            this.panelDock.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtExplain;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cboUse;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtReceiveTime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtReceiver;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboMaterials;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.ComboBox cboDemand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboAgency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboUMU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.ComboBox cboHighFac;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFacCate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFacCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFacCrow;
        private System.Windows.Forms.Label label2;
    }
}
