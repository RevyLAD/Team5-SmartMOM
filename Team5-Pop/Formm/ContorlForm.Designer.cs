namespace Team5_Pop
{
    partial class ContorlForm
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNowTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNowDate = new System.Windows.Forms.Label();
            this.TimeMangemer = new System.Windows.Forms.Timer(this.components);
            this.SignalIMG = new System.Windows.Forms.ImageList(this.components);
            this.FacilityIMG = new System.Windows.Forms.ImageList(this.components);
            this.facControl4 = new Team5_Pop.FacControl();
            this.facControl5 = new Team5_Pop.FacControl();
            this.facControl3 = new Team5_Pop.FacControl();
            this.facControl2 = new Team5_Pop.FacControl();
            this.facControl1 = new Team5_Pop.FacControl();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.lblNowTime);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblNowDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1164, 43);
            this.panel1.TabIndex = 5;
            // 
            // lblNowTime
            // 
            this.lblNowTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNowTime.AutoSize = true;
            this.lblNowTime.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowTime.ForeColor = System.Drawing.Color.Snow;
            this.lblNowTime.Location = new System.Drawing.Point(1073, 23);
            this.lblNowTime.Name = "lblNowTime";
            this.lblNowTime.Size = new System.Drawing.Size(33, 16);
            this.lblNowTime.TabIndex = 2;
            this.lblNowTime.Text = "time";
            this.lblNowTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(493, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "설비 관리 [POP]";
            // 
            // lblNowDate
            // 
            this.lblNowDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNowDate.AutoSize = true;
            this.lblNowDate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblNowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowDate.ForeColor = System.Drawing.Color.Snow;
            this.lblNowDate.Location = new System.Drawing.Point(1012, 5);
            this.lblNowDate.Name = "lblNowDate";
            this.lblNowDate.Size = new System.Drawing.Size(35, 16);
            this.lblNowDate.TabIndex = 1;
            this.lblNowDate.Text = "date";
            this.lblNowDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimeMangemer
            // 
            this.TimeMangemer.Interval = 1000;
            this.TimeMangemer.Tick += new System.EventHandler(this.TimeMangemer_Tick);
            // 
            // SignalIMG
            // 
            this.SignalIMG.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.SignalIMG.ImageSize = new System.Drawing.Size(16, 16);
            this.SignalIMG.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FacilityIMG
            // 
            this.FacilityIMG.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.FacilityIMG.ImageSize = new System.Drawing.Size(16, 16);
            this.FacilityIMG.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // facControl4
            // 
            this.facControl4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facControl4.Location = new System.Drawing.Point(311, 346);
            this.facControl4.Name = "facControl4";
            this.facControl4.Size = new System.Drawing.Size(232, 291);
            this.facControl4.TabIndex = 4;
            // 
            // facControl5
            // 
            this.facControl5.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facControl5.Location = new System.Drawing.Point(310, 48);
            this.facControl5.Name = "facControl5";
            this.facControl5.Size = new System.Drawing.Size(235, 301);
            this.facControl5.TabIndex = 3;
            // 
            // facControl3
            // 
            this.facControl3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facControl3.Location = new System.Drawing.Point(8, 346);
            this.facControl3.Name = "facControl3";
            this.facControl3.Size = new System.Drawing.Size(233, 301);
            this.facControl3.TabIndex = 2;
            // 
            // facControl2
            // 
            this.facControl2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facControl2.Location = new System.Drawing.Point(621, 48);
            this.facControl2.Name = "facControl2";
            this.facControl2.Size = new System.Drawing.Size(231, 301);
            this.facControl2.TabIndex = 1;
            // 
            // facControl1
            // 
            this.facControl1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.facControl1.Location = new System.Drawing.Point(8, 48);
            this.facControl1.Name = "facControl1";
            this.facControl1.Size = new System.Drawing.Size(232, 301);
            this.facControl1.TabIndex = 0;
            // 
            // ContorlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(1164, 649);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.facControl4);
            this.Controls.Add(this.facControl5);
            this.Controls.Add(this.facControl3);
            this.Controls.Add(this.facControl2);
            this.Controls.Add(this.facControl1);
            this.Name = "ContorlForm";
            this.Text = "ContorlForm";
            this.Load += new System.EventHandler(this.ContorlForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FacControl facControl1;
        private FacControl facControl2;
        private FacControl facControl3;
        private FacControl facControl4;
        private FacControl facControl5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNowTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNowDate;
        private System.Windows.Forms.Timer TimeMangemer;
        private System.Windows.Forms.ImageList SignalIMG;
        private System.Windows.Forms.ImageList FacilityIMG;
    }
}