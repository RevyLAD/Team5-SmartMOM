namespace Team5_SmartMOM.HSM
{
    partial class MasterUpload_PO_
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer2
            // 
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(754, 19);
            this.button3.Size = new System.Drawing.Size(101, 24);
            this.button3.Text = "영업마스터생성";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(861, 19);
            this.button2.Size = new System.Drawing.Size(94, 24);
            this.button2.Text = "양식다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(961, 19);
            this.button1.Size = new System.Drawing.Size(82, 24);
            this.button1.Text = "Excel등록";
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(170, 22);
            this.label1.Text = "영업마스터업로드(PO)";
            // 
            // MasterUpload_PO_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1066, 591);
            this.Name = "MasterUpload_PO_";
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
