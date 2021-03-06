﻿using Project_VO;
using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.HSM
{
    public partial class Sales_Master : Team5_SmartMOM.BaseGridForm
    {
        public Sales_Master()
        {
            InitializeComponent();
        }


        private void Sales_Master_Load(object sender, EventArgs e)
        {
            dtpDueDateStart.Value = DateTime.Now.AddMonths(-1);
            dtpDueDateEnd.Value = DateTime.Now.AddMonths(2);

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객WO", "SO_WorkOrderID", true, 180);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사", "COM_Code", true, 80);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "고객사명", "COM_Name", true, 140);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문유형", "PO_Type", true, 90, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문수량", "SALES_OrderQty", true, 90, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "출고수량", "SALES_ShipQty", true, 90, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "취소수량", "SALES_CancelQty", true, 90, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납기일", "SALES_Duedate", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "주문일", "SALES_OrderDate", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "상태", "SALES_ORDER_STATE", true, 100, DataGridViewContentAlignment.MiddleCenter);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "비고", "SALES_Remark", true, 260);

            button2.PerformClick();
            InitCombo();

        }

        #region Settings
        private void InitCombo()
        {
            CommonCodeService service = new CommonCodeService();

            List<CommonCodeVO> listGubunCode = service.GetAllCommonCode();
            List<CompanyCodeVO> listCompanyCode = service.GetCustomerCompanyCode();


            //공통코드링큐
            List<CommonCodeVO> OrderGubunList = (from item in listGubunCode
                                                 where item.Common_Type == "SALES_ORDER_STATE"
                                                 select item).ToList();


            CommonUtil.ComboBinding(cboState, OrderGubunList, "Common_Key", "Common_Value", "전체");
            CommonUtil.ComboBinding(cboCustomer, listCompanyCode, "COM_Code", "COM_Name");

        }
        #endregion

        #region btnClick Methods
        private void button2_Click(object sender, EventArgs e) //영업마스터 생성
        {
            dataGridView1.DataSource = null;
            HSM_Service service = new HSM_Service();

            List<SalesMasterAllVO> list = new List<SalesMasterAllVO>();
            list = service.GetAllSalesMaster();

            if (list.Count != 0)
            {
                dataGridView1.DataSource = list;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if(dataGridView1[11, i].Value.ToString() == "주문대기")
                        dataGridView1[11, i].Style.BackColor = Color.LightYellow;
                }
            }
            else
                MessageBox.Show("생성할 영업마스터 정보가 없습니다.\n영업마스터를 업로드 해주시길 바랍니다.", "확인");
        }

        private void button3_Click(object sender, EventArgs e) //영업마스터 수동생성
        {
            SO_Insert frm = new SO_Insert();
            frm.StartPosition = FormStartPosition.CenterScreen;
            if(frm.ShowDialog() == DialogResult.OK)
            {
                button2.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e) //수요계획 생성 버튼
        {
            List<UpdatePlanIDVO> plans = new List<UpdatePlanIDVO>();

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value==null)
                    break;

                if(dataGridView1.Rows[i].Cells[11].Value.ToString() == "주문대기")
                {

                    UpdatePlanIDVO plan = new UpdatePlanIDVO();
                    plan.SO_WorkOrderID = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    //Plan_ID : 20200101_P 형식
                    plan.Plan_ID = dataGridView1.Rows[i].Cells[10].Value.ToString().Replace("-", "") + "_" +
                        dataGridView1.Rows[i].Cells[5].Value.ToString().Substring(0, 1);

                    plans.Add(plan);
                }
            }

            HSM_Service service = new HSM_Service();

            if(plans.Count==0)
            {
                MessageBox.Show("생성할 수요계획 대상이 없습니다.");
                return;
            }

            if (service.UpdatePlanID(plans))
            {
                MessageBox.Show("수요계획이 생성되었습니다.");
                button2.PerformClick();
            }
            else
            {
                MessageBox.Show("수요계획생성실패");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) //조회
        {
            dataGridView1.DataSource = null;
            HSM_Service service = new HSM_Service();

            SalesMasterAllVO saleVo = new SalesMasterAllVO();
            saleVo.SALES_ORDER_STATE = cboState.Text;
            saleVo.COM_Name = cboCustomer.Text;
            saleVo.SALES_OrderDate = dtpDueDateStart.Value.ToShortDateString();
            saleVo.SALES_Duedate = dtpDueDateEnd.Value.ToShortDateString();
            saleVo.SO_WorkOrderID = txtOrderNum.Text;

            List<SalesMasterAllVO> list = new List<SalesMasterAllVO>();
            list = service.GetSalesMasterByVO(saleVo);

            if (list.Count != 0)
            {
                dataGridView1.DataSource = list;

                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[11, i].Value.ToString() == "주문대기")
                        dataGridView1[11, i].Style.BackColor = Color.LightYellow;
                }
            }
            else
                MessageBox.Show("조회결과가 없습니다.", "확인");

        }

        #endregion
    }
}
