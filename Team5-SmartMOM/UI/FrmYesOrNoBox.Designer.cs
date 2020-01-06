namespace Academic_Manager
{
    partial class FrmYesOrNoBox
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
            this.text1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnNo = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.Depth = 0;
            this.text1.Font = new System.Drawing.Font("Roboto", 11F);
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text1.Location = new System.Drawing.Point(12, 79);
            this.text1.MouseState = MaterialSkin.MouseState.HOVER;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(312, 27);
            this.text1.TabIndex = 0;
            this.text1.Text = "materialLabel1";
            // 
            // btnYes
            // 
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnYes.Location = new System.Drawing.Point(55, 116);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(75, 21);
            this.btnYes.TabIndex = 2;
            this.btnYes.Text = "YES";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Depth = 0;
            this.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnNo.Location = new System.Drawing.Point(158, 116);
            this.btnNo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNo.Name = "btnNo";
            this.btnNo.Primary = true;
            this.btnNo.Size = new System.Drawing.Size(75, 21);
            this.btnNo.TabIndex = 2;
            this.btnNo.Text = "No";
            this.btnNo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // FrmYesOrNoBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 149);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.text1);
            this.Font = new System.Drawing.Font("굴림", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmYesOrNoBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmYesOrNoBox";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel text1;
        private MaterialSkin.Controls.MaterialRaisedButton btnYes;
        private MaterialSkin.Controls.MaterialRaisedButton btnNo;
    }
}