using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Stock_State : Team5_SmartMOM.BaseGridForm
    {
        public Stock_State()
        {
            InitializeComponent();
        }

        private void Stock_State_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("창고코드", "창고코드");
            dataGridView1.Columns.Add("창고", "창고");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("품목타입", "품목타입");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("재고량", "재고량");
            dataGridView1.Columns.Add("단위", "단위");
            dataGridView1.Columns.Add("관리등급", "관리등급");
            dataGridView1.Columns.Add("비고", "비고");
        }
    }
}
