namespace Team5_SmartMOM
{
    partial class BasePopUpDialog
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDock = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileUpdate = new MetroFramework.Controls.MetroTile();
            this.tileSave = new MetroFramework.Controls.MetroTile();
            this.label1 = new System.Windows.Forms.Label();
            this.panelFull.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFull
            // 
            this.panelFull.Controls.Add(this.panelMain);
            this.panelFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFull.Location = new System.Drawing.Point(0, 0);
            this.panelFull.Name = "panelFull";
            this.panelFull.Padding = new System.Windows.Forms.Padding(10);
            this.panelFull.Size = new System.Drawing.Size(633, 445);
            this.panelFull.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panelBottom);
            this.panelMain.Controls.Add(this.panelDock);
            this.panelMain.Controls.Add(this.panelTop);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(10, 10);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(613, 425);
            this.panelMain.TabIndex = 0;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.button2);
            this.panelBottom.Controls.Add(this.button1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 377);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(613, 48);
            this.panelBottom.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(142)))), ((int)(((byte)(150)))));
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(310, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(234, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "저장";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelDock
            // 
            this.panelDock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDock.Location = new System.Drawing.Point(0, 48);
            this.panelDock.Name = "panelDock";
            this.panelDock.Size = new System.Drawing.Size(613, 377);
            this.panelDock.TabIndex = 1;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelTop.Size = new System.Drawing.Size(613, 48);
            this.panelTop.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(147)))), ((int)(((byte)(211)))));
            this.panel1.Controls.Add(this.tileUpdate);
            this.panel1.Controls.Add(this.tileSave);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 38);
            this.panel1.TabIndex = 0;
            // 
            // tileUpdate
            // 
            this.tileUpdate.CustomBackground = true;
            this.tileUpdate.Location = new System.Drawing.Point(3, 13);
            this.tileUpdate.Name = "tileUpdate";
            this.tileUpdate.Size = new System.Drawing.Size(16, 16);
            this.tileUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.tileUpdate.TabIndex = 6;
            this.tileUpdate.TileImage = global::Team5_SmartMOM.Properties.Resources.edit1;
            this.tileUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUpdate.UseTileImage = true;
            // 
            // tileSave
            // 
            this.tileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSave.CustomBackground = true;
            this.tileSave.Location = new System.Drawing.Point(586, 10);
            this.tileSave.Name = "tileSave";
            this.tileSave.Size = new System.Drawing.Size(20, 20);
            this.tileSave.TabIndex = 5;
            this.tileSave.TileImage = global::Team5_SmartMOM.Properties.Resources.x_button2;
            this.tileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSave.UseTileImage = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "여기다가제목";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BasePopUpDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 445);
            this.Controls.Add(this.panelFull);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasePopUpDialog";
            this.Text = "BasePopUpDialog";
            this.panelFull.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panelFull;
        protected System.Windows.Forms.Panel panelMain;
        protected System.Windows.Forms.Panel panelDock;
        protected System.Windows.Forms.Panel panelTop;
        protected System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label1;
        protected MetroFramework.Controls.MetroTile tileSave;
        private MetroFramework.Controls.MetroTile tileUpdate;
        protected System.Windows.Forms.Panel panelBottom;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
    }
}