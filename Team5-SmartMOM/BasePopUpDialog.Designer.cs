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
            this.SuspendLayout();
            // 
            // BasePopUpDialog
            // 
            this.ClientSize = new System.Drawing.Size(897, 559);
            this.Name = "BasePopUpDialog";
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
        protected MetroFramework.Controls.MetroTile tileUpdate;
        protected System.Windows.Forms.Panel panelBottom;
        protected System.Windows.Forms.Button button2;
        protected System.Windows.Forms.Button button1;
    }
}