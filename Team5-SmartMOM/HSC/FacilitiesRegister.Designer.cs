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
            this.txtExplain = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cboUse = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtReceiveTime = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cboMaterials = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTurn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboProcess = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFacName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboFacCate = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelFull.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDock.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Size = new System.Drawing.Size(720, 445);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(700, 425);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.textBox4);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.textBox3);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.comboBox1);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.textBox2);
            this.panelDock.Controls.Add(this.textBox1);
            this.panelDock.Controls.Add(this.txtExplain);
            this.panelDock.Controls.Add(this.label16);
            this.panelDock.Controls.Add(this.cboUse);
            this.panelDock.Controls.Add(this.label15);
            this.panelDock.Controls.Add(this.txtReceiveTime);
            this.panelDock.Controls.Add(this.label14);
            this.panelDock.Controls.Add(this.cboMaterials);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.txtTurn);
            this.panelDock.Controls.Add(this.label11);
            this.panelDock.Controls.Add(this.cboProcess);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txtFacName);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.cboFacCate);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(700, 377);
            this.panelDock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDock_Paint);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(700, 48);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(700, 38);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.Text = "설비";
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(934, 10);
            this.tileSave.Click += new System.EventHandler(this.tileSave_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.Size = new System.Drawing.Size(700, 48);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(331, 10);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(255, 10);
            // 
            // txtExplain
            // 
            this.txtExplain.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtExplain.Location = new System.Drawing.Point(106, 146);
            this.txtExplain.Multiline = true;
            this.txtExplain.Name = "txtExplain";
            this.txtExplain.Size = new System.Drawing.Size(564, 85);
            this.txtExplain.TabIndex = 59;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label16.Location = new System.Drawing.Point(18, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 14);
            this.label16.TabIndex = 58;
            this.label16.Text = "ㆍ특이사항";
            // 
            // cboUse
            // 
            this.cboUse.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboUse.FormattingEnabled = true;
            this.cboUse.Location = new System.Drawing.Point(106, 72);
            this.cboUse.Name = "cboUse";
            this.cboUse.Size = new System.Drawing.Size(124, 21);
            this.cboUse.TabIndex = 57;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label15.ForeColor = System.Drawing.Color.Tomato;
            this.label15.Location = new System.Drawing.Point(18, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 14);
            this.label15.TabIndex = 56;
            this.label15.Text = "ㆍ사용유무";
            // 
            // txtReceiveTime
            // 
            this.txtReceiveTime.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtReceiveTime.Location = new System.Drawing.Point(106, 103);
            this.txtReceiveTime.Name = "txtReceiveTime";
            this.txtReceiveTime.ReadOnly = true;
            this.txtReceiveTime.Size = new System.Drawing.Size(124, 21);
            this.txtReceiveTime.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(18, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 14);
            this.label14.TabIndex = 54;
            this.label14.Text = "ㆍ수정자";
            // 
            // cboMaterials
            // 
            this.cboMaterials.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboMaterials.FormattingEnabled = true;
            this.cboMaterials.Location = new System.Drawing.Point(546, 77);
            this.cboMaterials.Name = "cboMaterials";
            this.cboMaterials.Size = new System.Drawing.Size(124, 21);
            this.cboMaterials.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(463, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 14);
            this.label12.TabIndex = 50;
            this.label12.Text = "ㆍ외주여부";
            // 
            // txtTurn
            // 
            this.txtTurn.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTurn.Location = new System.Drawing.Point(331, 74);
            this.txtTurn.Name = "txtTurn";
            this.txtTurn.Size = new System.Drawing.Size(124, 21);
            this.txtTurn.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(243, 77);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 14);
            this.label11.TabIndex = 46;
            this.label11.Text = "ㆍMES 설비";
            // 
            // cboProcess
            // 
            this.cboProcess.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboProcess.FormattingEnabled = true;
            this.cboProcess.Location = new System.Drawing.Point(546, 44);
            this.cboProcess.Name = "cboProcess";
            this.cboProcess.Size = new System.Drawing.Size(124, 21);
            this.cboProcess.TabIndex = 45;
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
            // txtFacName
            // 
            this.txtFacName.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtFacName.Location = new System.Drawing.Point(546, 12);
            this.txtFacName.Name = "txtFacName";
            this.txtFacName.Size = new System.Drawing.Size(124, 21);
            this.txtFacName.TabIndex = 39;
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
            // cboFacCate
            // 
            this.cboFacCate.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cboFacCate.FormattingEnabled = true;
            this.cboFacCate.Location = new System.Drawing.Point(106, 42);
            this.cboFacCate.Name = "cboFacCate";
            this.cboFacCate.Size = new System.Drawing.Size(124, 21);
            this.cboFacCate.TabIndex = 36;
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 21);
            this.textBox1.TabIndex = 60;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(331, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 21);
            this.textBox2.TabIndex = 61;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(331, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 63;
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
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox3.Location = new System.Drawing.Point(331, 106);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(124, 21);
            this.textBox3.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(243, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 14);
            this.label3.TabIndex = 64;
            this.label3.Text = "ㆍ수정시간";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox4.Location = new System.Drawing.Point(106, 237);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(564, 85);
            this.textBox4.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어OTF Bold", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(18, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 66;
            this.label8.Text = "ㆍ비고";
            // 
            // FacilitiesRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(720, 445);
            this.Name = "FacilitiesRegister";
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
        private System.Windows.Forms.ComboBox cboMaterials;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTurn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboProcess;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFacName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboFacCate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}
