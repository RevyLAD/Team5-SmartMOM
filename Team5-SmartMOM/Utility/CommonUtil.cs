
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM
{
    public class CommonUtil
    {
        #region comboBox 바인딩 관련
        public static void ComboBinding(ComboBox combo, List<ComboItemVO> list)
        {
            combo.DataSource = list;
            combo.ValueMember = "Code";
            combo.DisplayMember = "CodeNm";
        }

        public static void ComboBinding(ComboBox combo, List<ComboItemVO> list, string blankText)
        {
            if (list == null)
                list = new List<ComboItemVO>();

            list.Insert(0, new ComboItemVO(blankText));
            combo.DataSource = list;
            combo.DisplayMember = "CodeNm";
            combo.ValueMember = "Code";
        }

        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm)
        {
            if (list == null)
                list = new List<T>();

            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }

        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm, string blankText) where T : class, new()
        {
            if (list == null)
                list = new List<T>();

            T blankItem = new T();
            blankItem.GetType().GetProperty(CodeNm).SetValue(blankItem, blankText);
            list.Insert(0, blankItem);

            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }
        #endregion

    }
}
