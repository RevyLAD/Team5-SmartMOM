using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using Project_VO.HSM;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master_Upload : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master_Upload()
        {
            InitializeComponent();
        }
        private void Sales_Master_Upload_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = true;
        }

        private void button3_Click(object sender, EventArgs e) //영업마스터 업로드
        {
            MasterCreate frm = new MasterCreate();
            frm.StartPosition = FormStartPosition.CenterScreen;
            

            if(frm.ShowDialog() == DialogResult.OK)
            {
                DataTable dt = frm.ExcelData;
                dataGridView1.DataSource = dt;
            }
        }

        private void button1_Click(object sender, EventArgs e)//저장
        {
            List<SalesMasterVO> sales = new List<SalesMasterVO>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                SalesMasterVO sale = new SalesMasterVO();
                sale.SALES_OrderDate= dataGridView1.Rows[i].Cells["planDate"].Value.ToString();
                sale.SO_WorkOrderID = dataGridView1.Rows[i].Cells["WORK_ORDER_ID"].Value.ToString();
                sale.COM_Code = dataGridView1.Rows[i].Cells["업체CODE"].Value.ToString();
                sale.PO_Type = dataGridView1.Rows[i].Cells["발주구분"].Value.ToString();
                sale.ITEM_Code = dataGridView1.Rows[i].Cells["ITEM CODE"].Value.ToString();
                sale.SALES_OrderQty = Convert.ToInt32(dataGridView1.Rows[i].Cells["계획수량합계"].Value);
                sale.SALES_Duedate = dataGridView1.Rows[i].Cells["납기일"].Value.ToString();

                sales.Add(sale);
            }

            HSM_Service service = new HSM_Service();
            if(service.UploadSalesMaster(sales))
            {
                MessageBox.Show("영업마스터가 저장되었습니다.");
            }
            else
            {
                MessageBox.Show("저장실패");
            }

        }
    }
}
