﻿namespace Team5_SmartMOM
{
    partial class Sales_Price_Management
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
            this.button4 = new System.Windows.Forms.Button();
            this.cbo_Company = new System.Windows.Forms.ComboBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.dtp_ExistingDate = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
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
            // panelMid
            // 
            this.panelMid.Controls.Add(this.button7);
            this.panelMid.Controls.Add(this.button6);
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Size = new System.Drawing.Size(1202, 31);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            this.panelMid.Controls.SetChildIndex(this.button6, 0);
            this.panelMid.Controls.SetChildIndex(this.button7, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(933, 0);
            this.button3.Size = new System.Drawing.Size(57, 27);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(990, 0);
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.Text = "양식다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1094, 0);
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.Text = "Excel등록";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 31);
            this.panel2.Size = new System.Drawing.Size(1202, 74);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbo_Company);
            this.panelTop.Controls.Add(this.button4);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.dtp_ExistingDate);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 54);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Size = new System.Drawing.Size(1202, 538);
            this.splitContainer2.SplitterDistance = 53;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Size = new System.Drawing.Size(1145, 538);
            this.splitContainer1.SplitterDistance = 560;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(100, 27);
            this.label1.Text = "영업단가관리";
            // 
            // lblArrow
            // 
            this.lblArrow.Size = new System.Drawing.Size(16, 27);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(18, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ기준일자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(367, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ품목";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(714, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "ㆍ업체";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(1059, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "조회";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // cbo_Company
            // 
            this.cbo_Company.FormattingEnabled = true;
            this.cbo_Company.Location = new System.Drawing.Point(783, 13);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(207, 20);
            this.cbo_Company.TabIndex = 12;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(430, 13);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(208, 21);
            this.txt_item.TabIndex = 11;
            // 
            // dtp_ExistingDate
            // 
            this.dtp_ExistingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ExistingDate.Location = new System.Drawing.Point(109, 13);
            this.dtp_ExistingDate.Name = "dtp_ExistingDate";
            this.dtp_ExistingDate.Size = new System.Drawing.Size(177, 21);
            this.dtp_ExistingDate.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(876, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 27);
            this.button5.TabIndex = 19;
            this.button5.Text = "복사";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(819, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 27);
            this.button6.TabIndex = 20;
            this.button6.Text = "삭제";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(762, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 27);
            this.button7.TabIndex = 21;
            this.button7.Text = "등록";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Btn_newitem_Click);
            // 
            // Sales_Price_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Sales_Price_Management";
            this.Load += new System.EventHandler(this.Sales_Price_Management_Load);
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_Company;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.DateTimePicker dtp_ExistingDate;
        protected System.Windows.Forms.Button button7;
        protected System.Windows.Forms.Button button6;
        protected System.Windows.Forms.Button button5;
    }
}
