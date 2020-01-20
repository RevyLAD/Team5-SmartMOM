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
    public partial class Purchasing : BaseGridForm
    {
        public Purchasing()
        {
            InitializeComponent();
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Purchasing_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("품목명", "품목명");
            dataGridView1.Columns.Add("품목유형", "품목유형");
            dataGridView1.Columns.Add("표준발주", "표준발주");
            dataGridView1.Columns.Add("현재고", "현재고");
            dataGridView1.Columns.Add("업체", "업체");
            dataGridView1.Columns.Add("담당자", "담당자");
            dataGridView1.Columns.Add("창고", "창고");
            dataGridView1.Columns.Add("안전재고", "안전재고");
            dataGridView1.Columns.Add("발주방식", "발주방식");
            dataGridView1.Columns.Add("규격", "규격");
            dataGridView1.Columns.Add("불량율", "불량율");
            dataGridView1.Columns.Add("항목", "항목");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");

            dataGridView1.Columns.Add("날짜", "날짜");
            dataGridView1.Columns.Add("날짜", "날짜");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Purchasing_Order frm = new Purchasing_Order();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
        }
    }
}
