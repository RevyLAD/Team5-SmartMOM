namespace Team5_SmartMOM
{
    partial class FacilitiesDetail
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
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Size = new System.Drawing.Size(840, 649);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(820, 629);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(820, 629);
            // 
            // panelTop
            // 
            this.panelTop.Size = new System.Drawing.Size(820, 26);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(820, 599);
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.button6);
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Controls.Add(this.button4);
            this.panelMid.Size = new System.Drawing.Size(820, 40);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button4, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            this.panelMid.Controls.SetChildIndex(this.button6, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1530, 9);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1578, 9);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1625, 9);
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(40, 22);
            this.label1.Text = "설비";
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Location = new System.Drawing.Point(772, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 23);
            this.button6.TabIndex = 15;
            this.button6.Text = "삭제";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Location = new System.Drawing.Point(725, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(45, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "복사";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Font = new System.Drawing.Font("나눔스퀘어OTF", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Location = new System.Drawing.Point(677, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "등록";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FacilitiesDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(840, 649);
            this.Name = "FacilitiesDetail";
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
    }
}
