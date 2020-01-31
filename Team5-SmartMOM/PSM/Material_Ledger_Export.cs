using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Material_Ledger_Export : Team5_SmartMOM.BaseGridForm
    {
        public Material_Ledger_Export()
        {
            InitializeComponent();
        }

        private void Material_Ledger_Export_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("작업지시서", "작업지시서");
            dataGridView1.Columns.Add("요청일", "요청일");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("품목유형", "품목유형");
            dataGridView1.Columns.Add("요청창고", "요청창고");
            dataGridView1.Columns.Add("불출일자", "불출일자");
            dataGridView1.Columns.Add("불출창고", "불출창고");
            dataGridView1.Columns.Add("현재고", "현재고");
            dataGridView1.Columns.Add("표준불출수량", "표준불출수량");
            dataGridView1.Columns.Add("계획수량", "계획수량");
            dataGridView1.Columns.Add("소요량", "소요량");
            dataGridView1.Columns.Add("요청수량", "요청수량");
            dataGridView1.Columns.Add("출고수량", "출고수량");
        }
    }
}
