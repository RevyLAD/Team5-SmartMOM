namespace Team5_Pop
{
    partial class BarcodeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtWorkOrderID = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileUpdate = new MetroFramework.Controls.MetroTile();
            this.tileSave = new MetroFramework.Controls.MetroTile();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "작업지시 바코드를 스캔(입력) 하세요!";
            // 
            // txtWorkOrderID
            // 
            this.txtWorkOrderID.BackColor = System.Drawing.Color.Black;
            this.txtWorkOrderID.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtWorkOrderID.ForeColor = System.Drawing.Color.Yellow;
            this.txtWorkOrderID.Location = new System.Drawing.Point(16, 73);
            this.txtWorkOrderID.Multiline = true;
            this.txtWorkOrderID.Name = "txtWorkOrderID";
            this.txtWorkOrderID.Size = new System.Drawing.Size(330, 50);
            this.txtWorkOrderID.TabIndex = 1;
            this.txtWorkOrderID.Text = "ㅎㅇㅎㅇ";
            this.txtWorkOrderID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkOrderID_KeyDown);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Snow;
            this.btnCheck.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCheck.Location = new System.Drawing.Point(361, 73);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 50);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "확인";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.tileUpdate);
            this.panel1.Controls.Add(this.tileSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 31);
            this.panel1.TabIndex = 3;
            // 
            // tileUpdate
            // 
            this.tileUpdate.ActiveControl = null;
            this.tileUpdate.BackColor = System.Drawing.Color.Transparent;
            this.tileUpdate.Location = new System.Drawing.Point(3, 9);
            this.tileUpdate.Name = "tileUpdate";
            this.tileUpdate.Size = new System.Drawing.Size(16, 16);
            this.tileUpdate.Style = MetroFramework.MetroColorStyle.White;
            this.tileUpdate.TabIndex = 6;
            this.tileUpdate.TileImage = global::Team5_Pop.Properties.Resources.graph;
            this.tileUpdate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUpdate.UseCustomBackColor = true;
            this.tileUpdate.UseSelectable = true;
            this.tileUpdate.UseTileImage = true;
            // 
            // tileSave
            // 
            this.tileSave.ActiveControl = null;
            this.tileSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tileSave.BackColor = System.Drawing.Color.Transparent;
            this.tileSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tileSave.Location = new System.Drawing.Point(433, 7);
            this.tileSave.Name = "tileSave";
            this.tileSave.Size = new System.Drawing.Size(16, 16);
            this.tileSave.TabIndex = 5;
            this.tileSave.TileImage = global::Team5_Pop.Properties.Resources.x_button;
            this.tileSave.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileSave.UseCustomBackColor = true;
            this.tileSave.UseSelectable = true;
            this.tileSave.UseStyleColors = true;
            this.tileSave.UseTileImage = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(17, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "작업지시 바코드 확인";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(454, 136);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtWorkOrderID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarcodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "작업지시 바코드 확인";
            this.Activated += new System.EventHandler(this.BarcodeForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BarcodeForm_FormClosed);
            this.Load += new System.EventHandler(this.BarcodeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWorkOrderID;
        private System.Windows.Forms.Button btnCheck;
        protected System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTile tileUpdate;
        protected System.Windows.Forms.Label label2;
        public MetroFramework.Controls.MetroTile tileSave;
    }
}