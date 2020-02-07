using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class Textbox : UserControl
    {
        public Textbox()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Text = dateTimePicker1.Value.ToString("yyyy-MM-dd");

        }

        private void Textbox_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        public string Text
        {
            get
            {
                return (string)maskedTextBox1.Text;
            }
            set
            {
                maskedTextBox1.Text = value;
            }
        }
    }
}
