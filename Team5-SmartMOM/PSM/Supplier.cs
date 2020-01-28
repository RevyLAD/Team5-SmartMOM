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
    public partial class Supplier : Form
    {
        public Supplier()
        {
            InitializeComponent();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("발주일자", "발주일자");
            dataGridView1.Columns.Add("발주업체", "발주업체");
            dataGridView1.Columns.Add("납품업체", "납품업체");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("단위", "단위");
            dataGridView1.Columns.Add("검사여부", "검사여부");
            dataGridView1.Columns.Add("발주량", "발주량");
            dataGridView1.Columns.Add("입고수량", "입고수량");
            dataGridView1.Columns.Add("잔량", "잔량");
            dataGridView1.Columns.Add("납기일자", "납기일자");
            dataGridView1.Columns.Add("발주유형", "발주유형");
            dataGridView1.Columns.Add("비고", "비고");

            dataGridView2.Columns.Add("발주시리얼", "발주시리얼");            
            dataGridView2.Columns.Add("품목", "품목");
            dataGridView2.Columns.Add("품명", "품명");
            dataGridView2.Columns.Add("규격", "규격");
            dataGridView2.Columns.Add("단위", "단위");
            dataGridView2.Columns.Add("발주수량", "발주수량");
            dataGridView2.Columns.Add("잔여수량", "잔여수량");
            dataGridView2.Columns.Add("입고수량", "입고수량");
            dataGridView2.Columns.Add("발주유형", "발주유형");
            dataGridView2.Columns.Add("입고일자", "입고일자");
            dataGridView2.Columns.Add("발주일자", "발주일자");
            dataGridView2.Columns.Add("검사유무", "검사유무");
            dataGridView2.Columns.Add("비고", "비고");
        }

        private void dtpDateEnd_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateStart.Value > dtpDateEnd.Value.AddDays(1))
            {
                MessageBox.Show("시작일보다 빠를 수 없습니다.");
                dtpDateEnd.Value = dtpDateStart.Value.AddMonths(1);
                return;
            }
        }
    }
    
}
