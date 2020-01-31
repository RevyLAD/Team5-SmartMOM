using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger : Form
    {
        public Material_Ledger()
        {
            InitializeComponent();
        }

        private void Material_Ledger_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("업체", "업체");
            dataGridView1.Columns.Add("납품업체", "납품업체");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("품목종류", "품목종류");
            dataGridView1.Columns.Add("단위", "단위");
            dataGridView1.Columns.Add("검사여부", "검사여부");
            dataGridView1.Columns.Add("발주수량", "발주수량");
            dataGridView1.Columns.Add("출고수량", "출고수량");
            dataGridView1.Columns.Add("잔량", "잔량");
            dataGridView1.Columns.Add("납기일", "납기일");
            dataGridView1.Columns.Add("출발일", "출발일");
            dataGridView1.Columns.Add("출발상태", "출발상태");
            dataGridView1.Columns.Add("주문상태", "주문상태");
            dataGridView1.Columns.Add("생성일", "생성일");

            dataGridView2.Columns.Add("품목", "품목");
            dataGridView2.Columns.Add("품명", "품명");
            dataGridView2.Columns.Add("규격", "규격");
            dataGridView2.Columns.Add("단위", "단위");
            dataGridView2.Columns.Add("입고창고", "입고창고");
            dataGridView2.Columns.Add("입고일자", "입고일자");
            dataGridView2.Columns.Add("입고량", "입고량");
            dataGridView2.Columns.Add("단가", "단가");                        
            dataGridView2.Columns.Add("수정자", "수정자");
            dataGridView2.Columns.Add("비고", "비고");
        }
    }
}
