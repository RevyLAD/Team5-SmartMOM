using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academic_Manager
{
    public partial class FrmOkBox : MaterialSkin.Controls.MaterialForm
    {
        public FrmOkBox()
        {
            InitializeComponent();
        }
        public string Message
        {
            get { return text1.Text; }
            set { text1.Text = value; }
        }
    }
}
