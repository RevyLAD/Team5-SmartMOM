namespace Team5_SmartMOM.PSM
{
    partial class Purchasing_State
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.cbostate = new System.Windows.Forms.ComboBox();
            this.cbocompany = new System.Windows.Forms.ComboBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.cboplanid = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
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
            this.panelMid.Controls.SetChildIndex(this.lblArrow, 0);
            this.panelMid.Controls.SetChildIndex(this.label1, 0);
            this.panelMid.Controls.SetChildIndex(this.button1, 0);
            this.panelMid.Controls.SetChildIndex(this.button2, 0);
            this.panelMid.Controls.SetChildIndex(this.button3, 0);
            this.panelMid.Controls.SetChildIndex(this.button5, 0);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(969, 0);
            this.button3.Size = new System.Drawing.Size(106, 24);
            this.button3.Text = "납기일자변경";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1075, 0);
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.Text = "발주취소";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1150, 0);
            this.button1.Size = new System.Drawing.Size(48, 24);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(1202, 129);
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.cboplanid);
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.btnSearch);
            this.panelTop.Controls.Add(this.txtProduct);
            this.panelTop.Controls.Add(this.cbocompany);
            this.panelTop.Controls.Add(this.cbostate);
            this.panelTop.Controls.Add(this.dtpDateEnd);
            this.panelTop.Controls.Add(this.dtpDateStart);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Size = new System.Drawing.Size(1202, 109);
            // 
            // splitContainer2
            // 
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.Text = "발주현황";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "* 납기일";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "* 상태";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "* 업체";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(357, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "* 품목";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(536, 21);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(83, 21);
            this.dtpDateEnd.TabIndex = 29;
            this.dtpDateEnd.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.DtpDateEnd_ValueChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(428, 21);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(83, 21);
            this.dtpDateStart.TabIndex = 28;
            this.dtpDateStart.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(506, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = " - ";
            // 
            // cbostate
            // 
            this.cbostate.FormattingEnabled = true;
            this.cbostate.Location = new System.Drawing.Point(109, 67);
            this.cbostate.Name = "cbostate";
            this.cbostate.Size = new System.Drawing.Size(191, 20);
            this.cbostate.TabIndex = 30;
            this.cbostate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoID_KeyPress);
            // 
            // cbocompany
            // 
            this.cbocompany.FormattingEnabled = true;
            this.cbocompany.Location = new System.Drawing.Point(760, 21);
            this.cbocompany.Name = "cbocompany";
            this.cbocompany.Size = new System.Drawing.Size(161, 20);
            this.cbocompany.TabIndex = 31;
            this.cbocompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoID_KeyPress);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(428, 67);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(160, 21);
            this.txtProduct.TabIndex = 34;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1111, 73);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 35;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(871, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(98, 25);
            this.button5.TabIndex = 13;
            this.button5.Text = "발주서 출력";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cboplanid
            // 
            this.cboplanid.FormattingEnabled = true;
            this.cboplanid.Location = new System.Drawing.Point(109, 24);
            this.cboplanid.Name = "cboplanid";
            this.cboplanid.Size = new System.Drawing.Size(191, 20);
            this.cboplanid.TabIndex = 37;
            this.cboplanid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoID_KeyPress);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "* Plan_ID";
            // 
            // Purchasing_State
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 609);
            this.Name = "Purchasing_State";
            this.Text = "Purchasing_State";
            this.Load += new System.EventHandler(this.Purchasing_State_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cbocompany;
        private System.Windows.Forms.ComboBox cbostate;
        protected System.Windows.Forms.Button btnSearch;
        protected System.Windows.Forms.Button button5;
        private System.Windows.Forms.ComboBox cboplanid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}