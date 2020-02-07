namespace Team5_SmartMOM.PSM
{
    partial class Supplier
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnWait = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelZ1 = new PanelZ.PanelZ();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtOrderNum = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.cbocompany = new System.Windows.Forms.ComboBox();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpDateStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMid = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.lblArrow = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelZ1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 857);
            this.panel1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.panel7.Controls.Add(this.dataGridView2);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.dataGridView1);
            this.panel7.Controls.Add(this.panel4);
            this.panel7.Controls.Add(this.panel3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 32);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1222, 825);
            this.panel7.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 478);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(1222, 344);
            this.dataGridView2.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnWait);
            this.panel5.Controls.Add(this.btnCancel);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 450);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1222, 28);
            this.panel5.TabIndex = 4;
            // 
            // btnWait
            // 
            this.btnWait.BackColor = System.Drawing.Color.Snow;
            this.btnWait.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnWait.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWait.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.btnWait.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWait.Location = new System.Drawing.Point(1049, 0);
            this.btnWait.Name = "btnWait";
            this.btnWait.Size = new System.Drawing.Size(116, 28);
            this.btnWait.TabIndex = 9;
            this.btnWait.Text = "입고대기처리";
            this.btnWait.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWait.UseVisualStyleBackColor = false;
            this.btnWait.Click += new System.EventHandler(this.btnWait_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Snow;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Image = global::Team5_SmartMOM.Properties.Resources.note;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(1165, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "취소";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "자재입고관리";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1222, 333);
            this.dataGridView1.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.button9);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1222, 30);
            this.panel4.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Snow;
            this.button3.Dock = System.Windows.Forms.DockStyle.Right;
            this.button3.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(1108, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "선택";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Snow;
            this.button9.Dock = System.Windows.Forms.DockStyle.Right;
            this.button9.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button9.Image = global::Team5_SmartMOM.Properties.Resources.microsoft_excel;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(1165, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(57, 30);
            this.button9.TabIndex = 11;
            this.button9.Text = "엑셀";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "입고대기리스트";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.panel3.Controls.Add(this.panelZ1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1222, 87);
            this.panel3.TabIndex = 0;
            // 
            // panelZ1
            // 
            this.panelZ1.BackColor = System.Drawing.Color.White;
            this.panelZ1.Controls.Add(this.btnSearch);
            this.panelZ1.Controls.Add(this.txtOrderNum);
            this.panelZ1.Controls.Add(this.txtProduct);
            this.panelZ1.Controls.Add(this.cbocompany);
            this.panelZ1.Controls.Add(this.dtpDateEnd);
            this.panelZ1.Controls.Add(this.dtpDateStart);
            this.panelZ1.Controls.Add(this.label10);
            this.panelZ1.Controls.Add(this.label7);
            this.panelZ1.Controls.Add(this.label4);
            this.panelZ1.Controls.Add(this.label3);
            this.panelZ1.Controls.Add(this.label8);
            this.panelZ1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelZ1.EndColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.panelZ1.GradientAngle = 90;
            this.panelZ1.Location = new System.Drawing.Point(0, 0);
            this.panelZ1.Name = "panelZ1";
            this.panelZ1.Size = new System.Drawing.Size(1222, 87);
            this.panelZ1.StartColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(210)))), ((int)(((byte)(220)))));
            this.panelZ1.TabIndex = 1;
            this.panelZ1.Transparent1 = 150;
            this.panelZ1.Transparent2 = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnSearch.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(1130, 47);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(81, 30);
            this.btnSearch.TabIndex = 77;
            this.btnSearch.Text = "조회";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtOrderNum
            // 
            this.txtOrderNum.Location = new System.Drawing.Point(106, 47);
            this.txtOrderNum.Name = "txtOrderNum";
            this.txtOrderNum.Size = new System.Drawing.Size(216, 21);
            this.txtOrderNum.TabIndex = 76;
            this.txtOrderNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNum_KeyPress);
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(813, 14);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(160, 21);
            this.txtProduct.TabIndex = 75;
            this.txtProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduct_KeyPress);
            // 
            // cbocompany
            // 
            this.cbocompany.FormattingEnabled = true;
            this.cbocompany.Location = new System.Drawing.Point(502, 11);
            this.cbocompany.Name = "cbocompany";
            this.cbocompany.Size = new System.Drawing.Size(161, 20);
            this.cbocompany.TabIndex = 73;
            this.cbocompany.SelectedIndexChanged += new System.EventHandler(this.cbocompany_SelectedIndexChanged);
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateEnd.Location = new System.Drawing.Point(240, 13);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(92, 21);
            this.dtpDateEnd.TabIndex = 72;
            this.dtpDateEnd.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            this.dtpDateEnd.ValueChanged += new System.EventHandler(this.dtpDateEnd_ValueChanged);
            // 
            // dtpDateStart
            // 
            this.dtpDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateStart.Location = new System.Drawing.Point(106, 11);
            this.dtpDateStart.Name = "dtpDateStart";
            this.dtpDateStart.Size = new System.Drawing.Size(93, 21);
            this.dtpDateStart.TabIndex = 71;
            this.dtpDateStart.Value = new System.DateTime(2020, 1, 6, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(205, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 12);
            this.label10.TabIndex = 70;
            this.label10.Text = " - ";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(737, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 19);
            this.label7.TabIndex = 69;
            this.label7.Text = "* 품명";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(404, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 19);
            this.label4.TabIndex = 67;
            this.label4.Text = "* 업체";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(10, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 66;
            this.label3.Text = "* 발주번호";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 65;
            this.label8.Text = "* 납기일자";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panelMid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1222, 32);
            this.panel2.TabIndex = 0;
            // 
            // panelMid
            // 
            this.panelMid.BackColor = System.Drawing.Color.White;
            this.panelMid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMid.Controls.Add(this.label9);
            this.panelMid.Controls.Add(this.lblArrow);
            this.panelMid.Controls.Add(this.button5);
            this.panelMid.Controls.Add(this.button6);
            this.panelMid.Controls.Add(this.button7);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMid.Location = new System.Drawing.Point(0, 0);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1222, 31);
            this.panelMid.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(16, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 27);
            this.label9.TabIndex = 12;
            this.label9.Text = "입고대기";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblArrow
            // 
            this.lblArrow.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblArrow.Image = global::Team5_SmartMOM.Properties.Resources.arrow;
            this.lblArrow.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblArrow.Location = new System.Drawing.Point(0, 0);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.lblArrow.Size = new System.Drawing.Size(16, 27);
            this.lblArrow.TabIndex = 11;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Snow;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button5.Image = global::Team5_SmartMOM.Properties.Resources.pencil;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(1047, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(57, 27);
            this.button5.TabIndex = 6;
            this.button5.Text = "등록";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Snow;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button6.Image = global::Team5_SmartMOM.Properties.Resources.note;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(1104, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(57, 27);
            this.button6.TabIndex = 7;
            this.button6.Text = "복사";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Snow;
            this.button7.Dock = System.Windows.Forms.DockStyle.Right;
            this.button7.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button7.Image = global::Team5_SmartMOM.Properties.Resources.microsoft_excel;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(1161, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(57, 27);
            this.button7.TabIndex = 8;
            this.button7.Text = "엑셀";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // Supplier
            // 
            this.ClientSize = new System.Drawing.Size(1222, 857);
            this.Controls.Add(this.panel1);
            this.Name = "Supplier";
            this.Load += new System.EventHandler(this.Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panelZ1.ResumeLayout(false);
            this.panelZ1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel5;
        protected System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button btnWait;
        protected System.Windows.Forms.Button btnCancel;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button9;
        protected System.Windows.Forms.Panel panelMid;
        protected System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Label lblArrow;
        protected System.Windows.Forms.Button button5;
        protected System.Windows.Forms.Button button6;
        protected System.Windows.Forms.Button button7;
        private PanelZ.PanelZ panelZ1;
        protected System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtOrderNum;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.ComboBox cbocompany;
        private System.Windows.Forms.DateTimePicker dtpDateEnd;
        private System.Windows.Forms.DateTimePicker dtpDateStart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
    }
}