using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Team5_SmartMOM.PSM
{
    public partial class Stock_RF_State : Team5_SmartMOM.BaseGridForm
    {
        public Stock_RF_State()
        {
            InitializeComponent();
        }

        private void Stock_RF_State_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("입출고일", "입출고일");
            dataGridView1.Columns.Add("구분", "구분");
            dataGridView1.Columns.Add("카테고리", "카테고리");
            dataGridView1.Columns.Add("창고", "창고");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("품목형태", "품목형태");
            dataGridView1.Columns.Add("관리등급", "관리등급");
            dataGridView1.Columns.Add("수불량", "수불량");
            dataGridView1.Columns.Add("단가", "단가");
            dataGridView1.Columns.Add("금액", "금액");            
            
        }
    }
}
