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

        private void Panel_Gradient(object sender, PaintEventArgs e)
        {
            Color startColor = Color.FromArgb(213, 227, 247);
            Color middleColor = Color.FromArgb(225, 236, 249);
            Color endColor = Color.FromArgb(219, 231, 248);



            LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle,
                                                                Color.Black,
                                                                Color.Black,
                                                                0,
                                                                false);

            ColorBlend cb = new ColorBlend();
            cb.Positions = new[] { 0, 1 / 2f, 1 };
            cb.Colors = new[] { startColor, middleColor, endColor };

            br.InterpolationColors = cb;
            br.RotateTransform(45);
            e.Graphics.FillRectangle(br, this.ClientRectangle);
        }
    }
}
