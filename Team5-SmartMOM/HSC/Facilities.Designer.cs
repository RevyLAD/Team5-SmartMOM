namespace Team5_SmartMOM
{
    partial class Facilities
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
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Size = new System.Drawing.Size(299, 649);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(279, 629);
            // 
            // panelMid
            // 
            this.panelMid.Size = new System.Drawing.Size(279, 35);
            this.panelMid.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMid_Paint);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Location = new System.Drawing.Point(104, 0);
            this.button3.Size = new System.Drawing.Size(57, 31);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(161, 0);
            this.button2.Size = new System.Drawing.Size(57, 31);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.Location = new System.Drawing.Point(218, 0);
            this.button1.Size = new System.Drawing.Size(57, 31);
            this.button1.Text = "삭제";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Size = new System.Drawing.Size(279, 135);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(279, 116);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(279, 509);
            this.splitContainer2.SplitterDistance = 35;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Panel1MinSize = 5;
            this.splitContainer1.Size = new System.Drawing.Size(240, 509);
            this.splitContainer1.SplitterDistance = 167;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.Text = "설비군";
            // 
            // label2
            // 
            this.label2.Size = new System.Drawing.Size(16, 31);
            // 
            // Facilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(299, 649);
            this.Name = "Facilities";
            this.Text = "설비 관리";
            this.Load += new System.EventHandler(this.Facilities_Load);
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
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
