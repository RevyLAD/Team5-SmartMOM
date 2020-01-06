namespace Academic_Manager
{
    partial class FrmOkBox
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
            this.btnYes = new MaterialSkin.Controls.MaterialRaisedButton();
            this.text1 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Depth = 0;
            this.btnYes.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnYes.Location = new System.Drawing.Point(110, 118);
            this.btnYes.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnYes.Name = "btnYes";
            this.btnYes.Primary = true;
            this.btnYes.Size = new System.Drawing.Size(75, 21);
            this.btnYes.TabIndex = 4;
            this.btnYes.Text = "확인";
            this.btnYes.UseVisualStyleBackColor = true;
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.White;
            this.text1.Depth = 0;
            this.text1.Font = new System.Drawing.Font("Roboto", 11F);
            this.text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.text1.Location = new System.Drawing.Point(8, 78);
            this.text1.MouseState = MaterialSkin.MouseState.HOVER;
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(288, 26);
            this.text1.TabIndex = 3;
            this.text1.Text = "materialLabel1";
            // 
            // FrmOkBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 151);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.text1);
            this.Name = "FrmOkBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmOkBox";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnYes;
        private MaterialSkin.Controls.MaterialLabel text1;
    }
}