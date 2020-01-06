using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
namespace Academic_Manager
{
    public partial class CustomMessageBox : MaterialSkin.Controls.MaterialForm
    {
        MaterialSkin.MaterialSkinManager skinManager;
        public CustomMessageBox()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.DARK;
            skinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Grey600, Primary.Grey900, Accent.LightBlue200, TextShade.WHITE);
        }
    }
}
