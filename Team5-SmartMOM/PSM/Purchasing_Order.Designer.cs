namespace Team5_SmartMOM.PSM
{
    partial class Purchasing_Order
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
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblPlanID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tileUpdate = new MetroFramework.Controls.MetroTile();
            this.Mainpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.Color.White;
            this.Mainpanel.Controls.Add(this.panel1);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Padding = new System.Windows.Forms.Padding(10);
            this.Mainpanel.Size = new System.Drawing.Size(1052, 533);
            this.Mainpanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnOrder);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1032, 513);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(532, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 31;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.btnOrder.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(385, 455);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(110, 46);
            this.btnOrder.TabIndex = 32;
            this.btnOrder.Text = "발주";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblPlanID);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.dataGridView2);
            this.panel5.Location = new System.Drawing.Point(269, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(744, 353);
            this.panel5.TabIndex = 30;
            // 
            // lblPlanID
            // 
            this.lblPlanID.AutoSize = true;
            this.lblPlanID.Location = new System.Drawing.Point(85, 12);
            this.lblPlanID.Name = "lblPlanID";
            this.lblPlanID.Size = new System.Drawing.Size(38, 12);
            this.lblPlanID.TabIndex = 28;
            this.lblPlanID.Text = "label6";
            this.lblPlanID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(6, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "발주";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 30);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(738, 320);
            this.dataGridView2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(8, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 353);
            this.panel4.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "발주업체";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(228, 319);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tileUpdate);
            this.panel2.Location = new System.Drawing.Point(8, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 49);
            this.panel2.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "정규발주";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tileUpdate
            // 
            this.tileUpdate.CustomBackground = true;
            this.tileUpdate.Location = new System.Drawing.Point(3, 15);
            this.tileUpdate.Name = "tileUpdate";
            this.tileUpdate.Size = new System.Drawing.Size(16, 16);
            this.tileUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.tileUpdate.TabIndex = 7;
            this.tileUpdate.TileImage = global::Team5_SmartMOM.Properties.Resources.edit1;
            this.tileUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUpdate.UseTileImage = true;
            // 
            // Purchasing_Order
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1052, 533);
            this.Controls.Add(this.Mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Purchasing_Order";
            this.Load += new System.EventHandler(this.Purchasing_Order_Load);
            this.Mainpanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPlanID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTile tileUpdate;
    }
}