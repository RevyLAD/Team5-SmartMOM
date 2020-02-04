namespace Team5_SmartMOM
{
    partial class CircleProgressBar
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
            this.radWaitingBar1 = new Telerik.WinControls.UI.RadWaitingBar();
            this.segmentedRingWaitingBarIndicatorElement1 = new Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement();
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // radWaitingBar1
            // 
            this.radWaitingBar1.Location = new System.Drawing.Point(3, 1);
            this.radWaitingBar1.Name = "radWaitingBar1";
            // 
            // 
            // 
            this.radWaitingBar1.RootElement.AutoSize = false;
            this.radWaitingBar1.RootElement.ControlBounds = new System.Drawing.Rectangle(3, 1, 50, 53);
            this.radWaitingBar1.Size = new System.Drawing.Size(50, 53);
            this.radWaitingBar1.TabIndex = 1;
            this.radWaitingBar1.Text = "radWaitingBar1";
            this.radWaitingBar1.WaitingIndicators.Add(this.segmentedRingWaitingBarIndicatorElement1);
            this.radWaitingBar1.WaitingSpeed = 20;
            this.radWaitingBar1.WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.RadWaitingBarElement)(this.radWaitingBar1.GetChildAt(0))).WaitingSpeed = 20;
            ((Telerik.WinControls.UI.WaitingBarContentElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0))).WaitingStyle = Telerik.WinControls.Enumerations.WaitingBarStyles.SegmentedRing;
            ((Telerik.WinControls.UI.WaitingBarSeparatorElement)(this.radWaitingBar1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).Dash = false;
            // 
            // segmentedRingWaitingBarIndicatorElement1
            // 
            this.segmentedRingWaitingBarIndicatorElement1.Name = "segmentedRingWaitingBarIndicatorElement1";
            // 
            // CircleProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(55, 55);
            this.Controls.Add(this.radWaitingBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CircleProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CircleProgressBar";
            this.Load += new System.EventHandler(this.frmWaitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radWaitingBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadWaitingBar radWaitingBar1;
        private Telerik.WinControls.UI.SegmentedRingWaitingBarIndicatorElement segmentedRingWaitingBarIndicatorElement1;
    }
}