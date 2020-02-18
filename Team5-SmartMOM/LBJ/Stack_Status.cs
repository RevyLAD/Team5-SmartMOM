using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.LBJ
{
    public partial class Stack_Status : Team5_SmartMOM.BaseGridForm
    {
        List<StackStatusVO> statusList;
        public Stack_Status()
        {
            InitializeComponent();
        }

        private void Stack_Status_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "FACD_ID", true, 50, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고코드", "FACT_Code", true, 130, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "창고", "FACT_Name", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목타입", "ITEM_Type", true, 150, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 130, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "재고량", "FACD_Qty", true, 100, DataGridViewContentAlignment.MiddleRight);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 80, DataGridViewContentAlignment.MiddleRight);
            
            LBJ_Service service = new LBJ_Service();
            List<StackStatusVO> StackList = service.StackStatus();
            dataGridView1.DataSource = statusList = StackList;

            string ItemType = cboProductType.Text.Trim();

            List<StackStatusVO> temp = (from item in StackList
                                        where item.ITEM_Type.Contains(ItemType)
                                        select item).Distinct().ToList();
            List<StackStatusVO> StackStatus = new List<StackStatusVO>();

            foreach (StackStatusVO item in temp)
            {
                bool addok = true;
                if (StackStatus.Count < 1)
                    StackStatus.Add(item);
                else
                {
                    for (int i = 0; i < StackStatus.Count; i++)
                        if (StackStatus[i].ITEM_Type.Trim() == item.ITEM_Type.Trim())
                            addok = false;

                    if (addok)
                        StackStatus.Add(item);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cboProductType, StackStatus, "FACD_ID", "ITEM_Type");
            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            List<StackStatusVO> StackList = service.StackStatus();
            dataGridView1.DataSource = statusList = StackList;

            string FactName = cboFactory.Text.Trim();

            List<StackStatusVO> temp = (from item in StackList
                                        where item.FACT_Name.Contains(FactName)
                                            select item).Distinct().ToList();
            List<StackStatusVO> StackStatus = new List<StackStatusVO>();

            foreach(StackStatusVO item in temp)
            {
                bool addok = true;
                if (StackStatus.Count < 1)
                    StackStatus.Add(item);
                else
                {
                    for (int i = 0; i < StackStatus.Count; i++)
                        if (StackStatus[i].FACT_Name.Trim() == item.FACT_Name.Trim())
                            addok = false;

                    if (addok)
                        StackStatus.Add(item);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cboFactory, StackStatus, "FACD_ID", "FACT_Name");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<StackStatusVO> StackStatuslist = (from item in statusList
                                                   where item.FACT_Name == cboFactory.Text &&
                                                               item.ITEM_Type == cboProductType.Text
                                                select item).ToList();
            dataGridView1.DataSource = StackStatuslist;      
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = statusList;
        }
    }
}
