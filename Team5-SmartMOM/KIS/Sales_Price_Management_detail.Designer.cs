namespace Team5_SmartMOM
{
    partial class Sales_Price_Management_detail
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
            this.txt_edit_date = new System.Windows.Forms.TextBox();
            this.txt_edit_user = new System.Windows.Forms.TextBox();
            this.txt_Forgotten_price = new System.Windows.Forms.TextBox();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbo_Company = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_end_date = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_item = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbo_UseorNot = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_now_Price = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtp_start_date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.panelFull.Size = new System.Drawing.Size(633, 459);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(611, 437);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 389);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.txt_edit_date);
            this.panelDock.Controls.Add(this.txt_edit_user);
            this.panelDock.Controls.Add(this.txt_Forgotten_price);
            this.panelDock.Controls.Add(this.txt_Remarks);
            this.panelDock.Controls.Add(this.label13);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.cbo_Company);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Controls.Add(this.txt_end_date);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.cbo_item);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.cbo_UseorNot);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.txt_now_Price);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.dtp_start_date);
            this.panelDock.Controls.Add(this.label10);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Size = new System.Drawing.Size(611, 389);
            // 
            // label1
            // 
            this.label1.Text = "영업단가관리";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txt_edit_date
            // 
            this.txt_edit_date.Enabled = false;
            this.txt_edit_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_edit_date.Location = new System.Drawing.Point(413, 174);
            this.txt_edit_date.Name = "txt_edit_date";
            this.txt_edit_date.Size = new System.Drawing.Size(175, 21);
            this.txt_edit_date.TabIndex = 117;
            // 
            // txt_edit_user
            // 
            this.txt_edit_user.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_edit_user.Location = new System.Drawing.Point(113, 174);
            this.txt_edit_user.Name = "txt_edit_user";
            this.txt_edit_user.Size = new System.Drawing.Size(177, 21);
            this.txt_edit_user.TabIndex = 116;
            // 
            // txt_Forgotten_price
            // 
            this.txt_Forgotten_price.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Forgotten_price.Location = new System.Drawing.Point(413, 49);
            this.txt_Forgotten_price.Name = "txt_Forgotten_price";
            this.txt_Forgotten_price.Size = new System.Drawing.Size(177, 21);
            this.txt_Forgotten_price.TabIndex = 115;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_Remarks.Location = new System.Drawing.Point(113, 217);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(477, 104);
            this.txt_Remarks.TabIndex = 113;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(22, 220);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 12);
            this.label13.TabIndex = 112;
            this.label13.Text = "ㆍ비고";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(322, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 111;
            this.label6.Text = "ㆍ수정일";
            // 
            // cbo_Company
            // 
            this.cbo_Company.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_Company.FormattingEnabled = true;
            this.cbo_Company.Location = new System.Drawing.Point(113, 14);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(175, 20);
            this.cbo_Company.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 94;
            this.label2.Text = "ㆍ업체";
            // 
            // txt_end_date
            // 
            this.txt_end_date.Enabled = false;
            this.txt_end_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_end_date.Location = new System.Drawing.Point(413, 91);
            this.txt_end_date.Name = "txt_end_date";
            this.txt_end_date.Size = new System.Drawing.Size(177, 21);
            this.txt_end_date.TabIndex = 109;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(22, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 12);
            this.label5.TabIndex = 96;
            this.label5.Text = "ㆍ현재단가";
            // 
            // cbo_item
            // 
            this.cbo_item.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_item.FormattingEnabled = true;
            this.cbo_item.Location = new System.Drawing.Point(413, 14);
            this.cbo_item.Name = "cbo_item";
            this.cbo_item.Size = new System.Drawing.Size(177, 20);
            this.cbo_item.TabIndex = 108;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(22, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 97;
            this.label4.Text = "ㆍ시작일";
            // 
            // cbo_UseorNot
            // 
            this.cbo_UseorNot.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_UseorNot.FormattingEnabled = true;
            this.cbo_UseorNot.Location = new System.Drawing.Point(113, 130);
            this.cbo_UseorNot.Name = "cbo_UseorNot";
            this.cbo_UseorNot.Size = new System.Drawing.Size(175, 20);
            this.cbo_UseorNot.TabIndex = 107;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(22, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 98;
            this.label7.Text = "ㆍ사용유무";
            // 
            // txt_now_Price
            // 
            this.txt_now_Price.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_now_Price.Location = new System.Drawing.Point(113, 50);
            this.txt_now_Price.Name = "txt_now_Price";
            this.txt_now_Price.Size = new System.Drawing.Size(175, 21);
            this.txt_now_Price.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(322, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 12);
            this.label12.TabIndex = 99;
            this.label12.Text = "ㆍ품목";
            // 
            // dtp_start_date
            // 
            this.dtp_start_date.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dtp_start_date.Location = new System.Drawing.Point(113, 91);
            this.dtp_start_date.Name = "dtp_start_date";
            this.dtp_start_date.Size = new System.Drawing.Size(175, 21);
            this.dtp_start_date.TabIndex = 105;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(322, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 12);
            this.label10.TabIndex = 101;
            this.label10.Text = "ㆍ이전단가";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(322, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 102;
            this.label9.Text = "ㆍ종료일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(22, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 12);
            this.label8.TabIndex = 103;
            this.label8.Text = "ㆍ수정자";
            // 
            // Sales_Price_Management_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(633, 459);
            this.Name = "Sales_Price_Management_detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Sales_Price_Management_detail_Load);
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

        private System.Windows.Forms.TextBox txt_edit_date;
        private System.Windows.Forms.TextBox txt_edit_user;
        private System.Windows.Forms.TextBox txt_Forgotten_price;
        private System.Windows.Forms.TextBox txt_Remarks;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbo_Company;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_end_date;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_item;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbo_UseorNot;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_now_Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtp_start_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
