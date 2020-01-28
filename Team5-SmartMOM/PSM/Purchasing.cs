using Project_VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;

namespace Team5_SmartMOM.PSM
{
    public partial class Purchasing : BaseGridForm
    {
        public Purchasing()
        {
            InitializeComponent();
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

            DataLoad();
        }


        public void DataLoad()
        {
            CommonCodeService service = new CommonCodeService();
            List<CommonCodeVO> common = service.GetAllCommonCode();            
            CommonUtil.ComboBinding(cboProduct, common, "Common_Key", "Common_Value", "전체");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Purchasing_Order frm = new Purchasing_Order();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.ShowDialog();
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
