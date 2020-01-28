using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger_State : Team5_SmartMOM.BaseGridForm
    {
        public Material_Ledger_State()
        {
            InitializeComponent();
        }

        private void Material_Ledger_State_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("입고번호", "입고번호");
            dataGridView1.Columns.Add("입고일", "입고일");
            dataGridView1.Columns.Add("입고유형", "입고유형");
            dataGridView1.Columns.Add("입고창고", "입고창고");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("단위", "단위");
            dataGridView1.Columns.Add("입고량", "입고량");
            dataGridView1.Columns.Add("취소량", "취소량");
            dataGridView1.Columns.Add("잔량", "잔량");
            dataGridView1.Columns.Add("업체", "업체");
            dataGridView1.Columns.Add("납품업체", "납품업체");
           
        }
    }
}
