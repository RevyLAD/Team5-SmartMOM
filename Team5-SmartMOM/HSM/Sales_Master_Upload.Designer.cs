namespace Team5_SmartMOM.HSM
{
    partial class Sales_Master_Upload
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
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(1375, 737);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(994, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button3.Size = new System.Drawing.Size(181, 30);
            this.button3.Text = "영업마스터 업로드";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1175, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.button2.Size = new System.Drawing.Size(131, 30);
            this.button2.Text = "양식다운로드";
            // 
            // button1
            // 
            this.button1.Text = "저장";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.panel2.Size = new System.Drawing.Size(1375, 12);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(0, 15);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.panelTop.Size = new System.Drawing.Size(1375, 0);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(116, 125);
            this.splitContainer1.SplitterDistance = 32;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(265, 30);
            this.label1.Text = "영업마스터업로드(PO)";
            // 
            // Sales_Master_Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.ClientSize = new System.Drawing.Size(1397, 761);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Sales_Master_Upload";
            this.Load += new System.EventHandler(this.Sales_Master_Upload_Load);
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
