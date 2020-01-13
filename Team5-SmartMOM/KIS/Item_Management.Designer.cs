namespace Team5_SmartMOM
{
    partial class Item_Management
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_standard = new System.Windows.Forms.TextBox();
            this.cbo_Supplier = new System.Windows.Forms.ComboBox();
            this.cbo_manager = new System.Windows.Forms.ComboBox();
            this.cbo_Warehouse = new System.Windows.Forms.ComboBox();
            this.cbo_itemtype = new System.Windows.Forms.ComboBox();
            this.cbo_Company = new System.Windows.Forms.ComboBox();
            this.cbo_releasehouse = new System.Windows.Forms.ComboBox();
            this.cbo_UseorNot = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Controls.Add(this.button4);
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button4, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(955, 0);
            this.button3.Text = "엑셀";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1012, 0);
            this.button2.Size = new System.Drawing.Size(107, 24);
            this.button2.Text = "양식 다운로드";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1119, 0);
            this.button1.Size = new System.Drawing.Size(79, 24);
            this.button1.Text = "Excel등록";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cbo_UseorNot);
            this.panelTop.Controls.Add(this.cbo_releasehouse);
            this.panelTop.Controls.Add(this.cbo_Company);
            this.panelTop.Controls.Add(this.cbo_itemtype);
            this.panelTop.Controls.Add(this.cbo_Warehouse);
            this.panelTop.Controls.Add(this.cbo_manager);
            this.panelTop.Controls.Add(this.cbo_Supplier);
            this.panelTop.Controls.Add(this.txt_standard);
            this.panelTop.Controls.Add(this.txt_item);
            this.panelTop.Controls.Add(this.btn_Search);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Text = "품목정보";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "품목";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "납품업체";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(20, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "담당자";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(380, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "규격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(380, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "입고창고";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(380, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "품목유형";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(748, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "업체";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(748, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 12);
            this.label9.TabIndex = 7;
            this.label9.Text = "출고창고";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(748, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 8;
            this.label10.Text = "사용유무";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btn_Search.ForeColor = System.Drawing.Color.White;
            this.btn_Search.Location = new System.Drawing.Point(1083, 76);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(99, 23);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "조회";
            this.btn_Search.UseVisualStyleBackColor = false;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(110, 19);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(217, 21);
            this.txt_item.TabIndex = 10;
            // 
            // txt_standard
            // 
            this.txt_standard.Location = new System.Drawing.Point(454, 19);
            this.txt_standard.Name = "txt_standard";
            this.txt_standard.Size = new System.Drawing.Size(217, 21);
            this.txt_standard.TabIndex = 11;
            // 
            // cbo_Supplier
            // 
            this.cbo_Supplier.FormattingEnabled = true;
            this.cbo_Supplier.Location = new System.Drawing.Point(110, 48);
            this.cbo_Supplier.Name = "cbo_Supplier";
            this.cbo_Supplier.Size = new System.Drawing.Size(217, 20);
            this.cbo_Supplier.TabIndex = 12;
            // 
            // cbo_manager
            // 
            this.cbo_manager.FormattingEnabled = true;
            this.cbo_manager.Location = new System.Drawing.Point(110, 76);
            this.cbo_manager.Name = "cbo_manager";
            this.cbo_manager.Size = new System.Drawing.Size(217, 20);
            this.cbo_manager.TabIndex = 13;
            // 
            // cbo_Warehouse
            // 
            this.cbo_Warehouse.FormattingEnabled = true;
            this.cbo_Warehouse.Location = new System.Drawing.Point(454, 48);
            this.cbo_Warehouse.Name = "cbo_Warehouse";
            this.cbo_Warehouse.Size = new System.Drawing.Size(217, 20);
            this.cbo_Warehouse.TabIndex = 14;
            // 
            // cbo_itemtype
            // 
            this.cbo_itemtype.FormattingEnabled = true;
            this.cbo_itemtype.Location = new System.Drawing.Point(454, 76);
            this.cbo_itemtype.Name = "cbo_itemtype";
            this.cbo_itemtype.Size = new System.Drawing.Size(217, 20);
            this.cbo_itemtype.TabIndex = 15;
            // 
            // cbo_Company
            // 
            this.cbo_Company.FormattingEnabled = true;
            this.cbo_Company.Location = new System.Drawing.Point(819, 19);
            this.cbo_Company.Name = "cbo_Company";
            this.cbo_Company.Size = new System.Drawing.Size(217, 20);
            this.cbo_Company.TabIndex = 16;
            // 
            // cbo_releasehouse
            // 
            this.cbo_releasehouse.FormattingEnabled = true;
            this.cbo_releasehouse.Location = new System.Drawing.Point(819, 47);
            this.cbo_releasehouse.Name = "cbo_releasehouse";
            this.cbo_releasehouse.Size = new System.Drawing.Size(217, 20);
            this.cbo_releasehouse.TabIndex = 17;
            // 
            // cbo_UseorNot
            // 
            this.cbo_UseorNot.FormattingEnabled = true;
            this.cbo_UseorNot.Location = new System.Drawing.Point(819, 73);
            this.cbo_UseorNot.Name = "cbo_UseorNot";
            this.cbo_UseorNot.Size = new System.Drawing.Size(217, 20);
            this.cbo_UseorNot.TabIndex = 18;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button4.Dock = System.Windows.Forms.DockStyle.Right;
            this.button4.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button4.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(898, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 24);
            this.button4.TabIndex = 13;
            this.button4.Text = "복사";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(841, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 24);
            this.button5.TabIndex = 14;
            this.button5.Text = "등록";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Btn_newitem_Click);
            // 
            // Item_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Item_Management";
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

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_standard;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_UseorNot;
        private System.Windows.Forms.ComboBox cbo_releasehouse;
        private System.Windows.Forms.ComboBox cbo_Company;
        private System.Windows.Forms.ComboBox cbo_itemtype;
        private System.Windows.Forms.ComboBox cbo_Warehouse;
        private System.Windows.Forms.ComboBox cbo_manager;
        private System.Windows.Forms.ComboBox cbo_Supplier;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button4;
    }
}
