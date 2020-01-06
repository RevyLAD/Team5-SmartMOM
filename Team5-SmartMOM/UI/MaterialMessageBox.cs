using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Academic_Manager
{
    public static class MaterialMessageBox
    {
        public static DialogResult Show(string message, string caption,MessageBoxButtons button)
        {
            DialogResult result = DialogResult.None;
            if(button == MessageBoxButtons.OK)
            {
                FrmOkBox frm = new FrmOkBox();

                frm.Text = caption;
                frm.Message = message;
                frm.ShowDialog();

                result = frm.DialogResult;
                return result;
            }
            else
            {
                FrmYesOrNoBox frm = new FrmYesOrNoBox();

                frm.Text = caption;
                frm.Message = message;
                frm.ShowDialog();

                result = frm.DialogResult;
                return result;
            }
            

        }
    }
}
