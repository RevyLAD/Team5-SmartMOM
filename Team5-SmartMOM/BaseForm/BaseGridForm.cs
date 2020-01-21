using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public partial class BaseGridForm : Form
    {
        public BaseGridForm()
        {
            InitializeComponent();
        }

        private void BaseGridForm_Load(object sender, EventArgs e)
        {
            //AddHeaderCheckBox();


        }
        private void AddHeaderCheckBox()
        {
            CheckBox m_headerCheckBox;
            m_headerCheckBox = new CheckBox();

            m_headerCheckBox.Size = new Size(15, 15);

            m_headerCheckBox.Visible = true;
            m_headerCheckBox.TabIndex = 1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
