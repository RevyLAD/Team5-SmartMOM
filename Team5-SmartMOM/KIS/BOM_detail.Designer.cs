namespace Team5_SmartMOM
{
    partial class BOM_detail
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_differenceItem = new System.Windows.Forms.ComboBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.dtp_Enddate = new System.Windows.Forms.DateTimePicker();
            this.txt_Reviser = new System.Windows.Forms.TextBox();
            this.cbo_AutoDeduction = new System.Windows.Forms.ComboBox();
            this.txt_Remarks = new System.Windows.Forms.TextBox();
            this.cbo_Item = new System.Windows.Forms.ComboBox();
            this.txt_Revise_day = new System.Windows.Forms.TextBox();
            this.cbo_UseorNot = new System.Windows.Forms.ComboBox();
            this.cbo_Required_plan = new System.Windows.Forms.ComboBox();
            this.dtp_Startdate = new System.Windows.Forms.DateTimePicker();
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
            this.panelFull.Size = new System.Drawing.Size(633, 462);
            // 
            // panelMain
            // 
            this.panelMain.Size = new System.Drawing.Size(613, 442);
            // 
            // panelBottom
            // 
            this.panelBottom.Location = new System.Drawing.Point(0, 394);
            // 
            // panelDock
            // 
            this.panelDock.Controls.Add(this.dtp_Startdate);
            this.panelDock.Controls.Add(this.cbo_Required_plan);
            this.panelDock.Controls.Add(this.cbo_UseorNot);
            this.panelDock.Controls.Add(this.txt_Revise_day);
            this.panelDock.Controls.Add(this.cbo_Item);
            this.panelDock.Controls.Add(this.txt_Remarks);
            this.panelDock.Controls.Add(this.cbo_AutoDeduction);
            this.panelDock.Controls.Add(this.txt_Reviser);
            this.panelDock.Controls.Add(this.dtp_Enddate);
            this.panelDock.Controls.Add(this.txt_Quantity);
            this.panelDock.Controls.Add(this.txt_differenceItem);
            this.panelDock.Controls.Add(this.label8);
            this.panelDock.Controls.Add(this.label9);
            this.panelDock.Controls.Add(this.label10);
            this.panelDock.Controls.Add(this.label11);
            this.panelDock.Controls.Add(this.label12);
            this.panelDock.Controls.Add(this.label6);
            this.panelDock.Controls.Add(this.label7);
            this.panelDock.Controls.Add(this.label4);
            this.panelDock.Controls.Add(this.label5);
            this.panelDock.Controls.Add(this.label3);
            this.panelDock.Controls.Add(this.label2);
            this.panelDock.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.panelDock.Size = new System.Drawing.Size(613, 394);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "ㆍ상위품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "ㆍ소요량";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "ㆍ수정자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(21, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "ㆍ종료일";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(21, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "ㆍ비고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(21, 197);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "ㆍ자동차감";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(327, 198);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "ㆍ소요계획";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(327, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "ㆍ수정일";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(327, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "ㆍ사용유무";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(327, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 12);
            this.label11.TabIndex = 7;
            this.label11.Text = "ㆍ시작일";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(327, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 12);
            this.label12.TabIndex = 6;
            this.label12.Text = "ㆍ품목";
            // 
            // txt_differenceItem
            // 
            this.txt_differenceItem.FormattingEnabled = true;
            this.txt_differenceItem.Location = new System.Drawing.Point(118, 17);
            this.txt_differenceItem.Name = "txt_differenceItem";
            this.txt_differenceItem.Size = new System.Drawing.Size(175, 20);
            this.txt_differenceItem.TabIndex = 11;
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(118, 60);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(175, 21);
            this.txt_Quantity.TabIndex = 12;
            // 
            // dtp_Enddate
            // 
            this.dtp_Enddate.Location = new System.Drawing.Point(118, 104);
            this.dtp_Enddate.Name = "dtp_Enddate";
            this.dtp_Enddate.Size = new System.Drawing.Size(175, 21);
            this.dtp_Enddate.TabIndex = 13;
            // 
            // txt_Reviser
            // 
            this.txt_Reviser.Location = new System.Drawing.Point(118, 145);
            this.txt_Reviser.Name = "txt_Reviser";
            this.txt_Reviser.Size = new System.Drawing.Size(175, 21);
            this.txt_Reviser.TabIndex = 14;
            // 
            // cbo_AutoDeduction
            // 
            this.cbo_AutoDeduction.FormattingEnabled = true;
            this.cbo_AutoDeduction.Location = new System.Drawing.Point(118, 194);
            this.cbo_AutoDeduction.Name = "cbo_AutoDeduction";
            this.cbo_AutoDeduction.Size = new System.Drawing.Size(175, 20);
            this.cbo_AutoDeduction.TabIndex = 15;
            // 
            // txt_Remarks
            // 
            this.txt_Remarks.Location = new System.Drawing.Point(118, 237);
            this.txt_Remarks.Multiline = true;
            this.txt_Remarks.Name = "txt_Remarks";
            this.txt_Remarks.Size = new System.Drawing.Size(473, 85);
            this.txt_Remarks.TabIndex = 60;
            // 
            // cbo_Item
            // 
            this.cbo_Item.FormattingEnabled = true;
            this.cbo_Item.Location = new System.Drawing.Point(414, 17);
            this.cbo_Item.Name = "cbo_Item";
            this.cbo_Item.Size = new System.Drawing.Size(177, 20);
            this.cbo_Item.TabIndex = 61;
            // 
            // txt_Revise_day
            // 
            this.txt_Revise_day.Location = new System.Drawing.Point(414, 145);
            this.txt_Revise_day.Name = "txt_Revise_day";
            this.txt_Revise_day.Size = new System.Drawing.Size(177, 21);
            this.txt_Revise_day.TabIndex = 62;
            // 
            // cbo_UseorNot
            // 
            this.cbo_UseorNot.FormattingEnabled = true;
            this.cbo_UseorNot.Location = new System.Drawing.Point(414, 105);
            this.cbo_UseorNot.Name = "cbo_UseorNot";
            this.cbo_UseorNot.Size = new System.Drawing.Size(177, 20);
            this.cbo_UseorNot.TabIndex = 63;
            // 
            // cbo_Required_plan
            // 
            this.cbo_Required_plan.FormattingEnabled = true;
            this.cbo_Required_plan.Location = new System.Drawing.Point(414, 194);
            this.cbo_Required_plan.Name = "cbo_Required_plan";
            this.cbo_Required_plan.Size = new System.Drawing.Size(177, 20);
            this.cbo_Required_plan.TabIndex = 64;
            // 
            // dtp_Startdate
            // 
            this.dtp_Startdate.Location = new System.Drawing.Point(414, 57);
            this.dtp_Startdate.Name = "dtp_Startdate";
            this.dtp_Startdate.Size = new System.Drawing.Size(177, 21);
            this.dtp_Startdate.TabIndex = 65;
            // 
            // BOM_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(633, 462);
            this.Name = "BOM_detail";
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

        private System.Windows.Forms.ComboBox cbo_AutoDeduction;
        private System.Windows.Forms.TextBox txt_Reviser;
        private System.Windows.Forms.DateTimePicker dtp_Enddate;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.ComboBox txt_differenceItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Startdate;
        private System.Windows.Forms.ComboBox cbo_Required_plan;
        private System.Windows.Forms.ComboBox cbo_UseorNot;
        private System.Windows.Forms.TextBox txt_Revise_day;
        private System.Windows.Forms.ComboBox cbo_Item;
        private System.Windows.Forms.TextBox txt_Remarks;
    }
}
