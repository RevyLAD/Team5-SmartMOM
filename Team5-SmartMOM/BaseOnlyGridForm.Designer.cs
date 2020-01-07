namespace Team5_SmartMOM
{
    partial class BaseOnlyGridForm
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
            this.panelFull = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelMid = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panelFull.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(220)))), ((int)(((byte)(227)))));
            this.panelFull.Controls.Add(this.panel1);
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(0, 0);
            this.panelFull.Name = "panelFull";
            this.panelFull.Padding = new System.Windows.Forms.Padding(10);
            this.panelFull.Size = new System.Drawing.Size(1066, 591);
            this.panelFull.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 571);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelMid);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvMain);
            this.splitContainer2.Size = new System.Drawing.Size(1046, 571);
            this.splitContainer2.SplitterDistance = 55;
            this.splitContainer2.TabIndex = 1;
            // 
            // panelMid
            // 
            this.panelMid.Controls.Add(this.button3);
            this.panelMid.Controls.Add(this.button2);
            this.panelMid.Controls.Add(this.button1);
            this.panelMid.Controls.Add(this.label1);
            this.panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid.Location = new System.Drawing.Point(0, 0);
            this.panelMid.Name = "panelMid";
            this.panelMid.Size = new System.Drawing.Size(1046, 55);
            this.panelMid.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(903, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 24);
            this.button3.TabIndex = 1;
            this.button3.Text = "button1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(951, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 24);
            this.button2.TabIndex = 1;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(998, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "항목이름";
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.Size = new System.Drawing.Size(1046, 512);
            this.dgvMain.TabIndex = 9;
            // 
            // BaseOnlyGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 591);
            this.Controls.Add(this.panelFull);
            this.Name = "BaseOnlyGridForm";
            this.Text = "BaseOnlyGridForm";
            this.panelFull.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelMid.ResumeLayout(false);
            this.panelMid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.Panel panelFull;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.SplitContainer splitContainer2;
        protected System.Windows.Forms.Panel panelMid;
        protected System.Windows.Forms.Button button3;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DataGridView dgvMain;
    }
}