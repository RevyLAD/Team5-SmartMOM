namespace Team5_SmartMOM.HSM
{
    partial class MasterCreate
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtVersion = new System.Windows.Forms.TextBox();
            this.dtpPlanDate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
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
            this.panelFull.Size = new System.Drawing.Size(373, 274);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(353, 254);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 206);
            this.panelBottom.Size = new System.Drawing.Size(353, 48);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.dtpPlanDate);
            this.panelDock.Controls.Add(this.dateTimePicker1);
            this.panelDock.Controls.Add(this.txtVersion);
            this.panelDock.Controls.Add(this.txtFileName);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Size = new System.Drawing.Size(353, 206);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(353, 48);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroTile1);
            this.panel1.Size = new System.Drawing.Size(353, 38);
            this.panel1.Controls.SetChildIndex(this.label1, 0);
            this.panel1.Controls.SetChildIndex(this.tileSave, 0);
            this.panel1.Controls.SetChildIndex(this.metroTile1, 0);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(140, 22);
            this.label1.Text = "영업마스터 업로드";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(210, 6);
            this.button2.Size = new System.Drawing.Size(70, 34);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 6);
            this.button1.Size = new System.Drawing.Size(151, 35);
            this.button1.Text = "영업마스터 Upload";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tileSave
            // 
            this.tileSave.Location = new System.Drawing.Point(-1444, 10);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ파일선택";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkOrange;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "ㆍ계획파일";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "ㆍ계획일자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ㆍ계획기준버전";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(141, 51);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(189, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(141, 82);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 21);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // txtVersion
            // 
            this.txtVersion.Location = new System.Drawing.Point(141, 117);
            this.txtVersion.Name = "txtVersion";
            this.txtVersion.Size = new System.Drawing.Size(98, 21);
            this.txtVersion.TabIndex = 1;
            // 
            // dtpPlanDate
            // 
            this.dtpPlanDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.dtpPlanDate.ForeColor = System.Drawing.Color.White;
            this.dtpPlanDate.Location = new System.Drawing.Point(140, 17);
            this.dtpPlanDate.Name = "dtpPlanDate";
            this.dtpPlanDate.Size = new System.Drawing.Size(75, 27);
            this.dtpPlanDate.TabIndex = 3;
            this.dtpPlanDate.Text = "파일 선택";
            this.dtpPlanDate.UseVisualStyleBackColor = false;
            this.dtpPlanDate.Click += new System.EventHandler(this.btnFindFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // metroTile1
            // 
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.CustomBackground = true;
            this.metroTile1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.metroTile1.Location = new System.Drawing.Point(328, 10);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(20, 20);
            this.metroTile1.TabIndex = 7;
            this.metroTile1.TileImage = global::Team5_SmartMOM.Properties.Resources.x_button2;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseTileImage = true;
            // 
            // MasterCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(373, 274);
            this.Name = "MasterCreate";
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dtpPlanDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtVersion;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        protected MetroFramework.Controls.MetroTile metroTile1;
    }
}
