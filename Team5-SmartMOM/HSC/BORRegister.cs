﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class BORRegister : Team5_SmartMOM.BasePopUpDialog
    {
        public BORRegister()
        {
            InitializeComponent();
        }

        private void tileSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}