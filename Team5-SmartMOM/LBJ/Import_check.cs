using Project_VO;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Team5_SmartMOM.BaseForm;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.LBJ
{
    public partial class Import_Check : Team5_SmartMOM.BaseGridForm
    {
        List<ImportVO> list_;
        public Import_Check()
        {
            InitializeComponent();
        }
        private void Import_Check_Load(object sender, EventArgs e)
        {
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "No", "VO_ID", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "검사일", "VOD_ResultDay", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "업체명", "COM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 150);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "규격", "ITEM_Size", true, 135);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "최종 결과", "VOD_Result", true, 100);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "납품 수량", "VOD_GoodEA", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "불량 수량", "VOD_BadEA", true, 200);

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "No", "VO_ID", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "검사항목", "INS_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "불량수량", "VOD_BadEA", true, 200);

            DataLoad();
            DataLoad2();
            DataLoad3();
        }
        public void DataLoad()
        {
            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = list_= service.Imports();

            LBJ_Service services = new LBJ_Service();
            dataGridView2.DataSource = service.ImportSearch();

            List<EnterpriseVO> list = new List<EnterpriseVO>();

            HSC_Service service1 = new HSC_Service();

            list = service1.GetAllEnterprise();
            string ComName = cboCompany.Text.Trim();

            List<EnterpriseVO> temp = (from item in list
                                            where item.COM_Name.Contains(ComName)
                                            select item).Distinct().ToList();
            List<EnterpriseVO> ComList = new List<EnterpriseVO>();
            foreach (EnterpriseVO item1 in temp)
            {
                bool addok = true;
                if (ComList.Count < 1)
                    ComList.Add(item1);
                else
                {
                    for (int i = 0; i < ComList.Count; i++)
                        if (ComList[i].COM_Name.Trim() == item1.COM_Name.Trim())
                            addok = false;

                    if (addok)
                        ComList.Add(item1);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cboCompany, ComList, "COM_No", "COM_Name");
        }
        public void DataLoad2()
        {
            List<ITEM_VO> list = new List<ITEM_VO>();

            KIS_Service service = new KIS_Service();
             
            list = service.ShowITEM();
            string ItemCode = cboProduct.Text.Trim();

            List<ITEM_VO> temp = (from item in list
                                       where item.ITEM_Code.Contains(ItemCode)
                                       select item).Distinct().ToList();
            List<ITEM_VO> ItemList = new List<ITEM_VO>();
            foreach (ITEM_VO item1 in temp)
            {
                bool addok = true;
                if (ItemList.Count < 1)
                    ItemList.Add(item1);
                else
                {
                    for (int i = 0; i < ItemList.Count; i++)
                        if (ItemList[i].ITEM_Code.Trim() == item1.ITEM_Code.Trim())
                            addok = false;

                    if (addok)
                        ItemList.Add(item1);
                    else
                        continue;
                }
            }
            CommonUtil.ComboBinding(cboProduct, ItemList, "ITEM_No", "ITEM_Code");
        }
        public void DataLoad3()
        {
            List<CommonCodeVO> list = new List<CommonCodeVO>();

            CommonCodeService service1 = new CommonCodeService();
            list = service1.GetAllCommonCode();

            //공통코드링큐
            List<CommonCodeVO> OrderShiftList = (from item in list
                                                 where item.Common_Type == "PassOrFail"
                                                 select item).ToList();

            CommonUtil.ComboBinding(cboResult, OrderShiftList, "Common_Key", "Common_Value");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboCompany.Text.Trim() == "" &&
                cboProduct.Text.Trim() == "" &&
                cboResult.Text.Trim() == "" )
            {

            }
            else
                dataGridView1.DataSource = ImportSearch();
        }
        private List<ImportVO> ImportSearch()
        {
            List<ImportVO> Importlist = new List<ImportVO>();

            foreach (var item in list_)
            {
                if (item.COM_Name.Trim().Contains(cboCompany.Text.Trim()) && item.ITEM_Code.Trim().Contains(cboProduct.Text.Trim()) && item.VOD_Result.Trim().Contains(cboResult.Text.Trim()))
                    Importlist.Add(item); 
            }
            return Importlist;
        }

        private void btn_showAll_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list_;
        }
    }
 
}
