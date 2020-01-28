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
    public partial class Materia_Request : Form
    {
        public Materia_Request()
        {
            InitializeComponent();
        }

        private void Materia_Request_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("계획시작일자", "계획시작일자");
            dataGridView1.Columns.Add("작업지시ID", "작업지시ID");
            dataGridView1.Columns.Add("설비명", "설비명");
            dataGridView1.Columns.Add("소진창고", "소진창고");
            dataGridView1.Columns.Add("품목", "품목");
            dataGridView1.Columns.Add("품명", "품명");
            dataGridView1.Columns.Add("지시수량", "지시수량");
            dataGridView1.Columns.Add("단위", "단위");
            dataGridView1.Columns.Add("상태명", "상태명");

            dataGridView2.Columns.Add("품목", "품목");
            dataGridView2.Columns.Add("품명", "품명");
            dataGridView2.Columns.Add("규격", "규격");
            dataGridView2.Columns.Add("요청창고", "요청창고");
            dataGridView2.Columns.Add("요청일", "요청일");
            dataGridView2.Columns.Add("재고량", "재고량");
            dataGridView2.Columns.Add("표준불출수량", "표준불출수량");
            dataGridView2.Columns.Add("계획요청수량", "계획요청수량");
            dataGridView2.Columns.Add("요청수량", "요청수량");
            dataGridView2.Columns.Add("출고수량", "출고수량");
            dataGridView2.Columns.Add("잔량", "잔량");
            dataGridView2.Columns.Add("사유", "사유");

            dataGridView2.Columns.Add("품목", "계획시작일자");

        }
    }
}
