using Project_VO;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Team5_SmartMOM.Service;

namespace Team5_SmartMOM.PSM
{
    public partial class Materia_Request : Form
    {
        List<MateriaVO> mvo;
        List<MateriaRequestVO> list;
        public Materia_Request()
        {
            InitializeComponent();
        }

        DateTimePicker dtp;
        private void Materia_Request_Load(object sender, EventArgs e)
        {
            dtp = new DateTimePicker();
            dateTimePicker1.Value = dtp.Value = DateTime.Now.AddDays(-7);

            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "계획시작일자", "WO_StartDate", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시ID", "WO_ID", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "설비명", "FAC_Name", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "소진창고", "FAC_OutWareHouse", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품목", "ITEM_Code", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "품명", "ITEM_Name", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "지시수량", "PlanQty", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "단위", "ITEM_Unit", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView1, "작업지시", "WO_State", true, 160);

            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품목", "ITEM_Code", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "품명", "ITEM_Name", true, 200);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "규격", "ITEM_Size", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "요청창고", "FAC_OutWareHouse", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "요청일", "WO_StartDate", true, 160);
            UtilityClass.AddNewColumnToDataGridView(dataGridView2, "계획요청수량", "planQty", true, 160);

            LBJ_Service service = new LBJ_Service();
            dataGridView1.DataSource = mvo = service.MateriaRequest();
            dataGridView2.DataSource = service.Materiaen();

            DataLoad();
        }
        public void DataLoad()
        {
            LBJ_Service lbjservice = new LBJ_Service();
            HSC_Service hscservice = new HSC_Service();
            List<MateriaVO> Materialist = lbjservice.MateriaRequest();
            dataGridView1.DataSource = Materialist;

            List<MateriaenVO> Materiaenlist = lbjservice.Materiaen();
            dataGridView2.DataSource = Materiaenlist;

            dataGridView1.DataSource = lbjservice.MateriaRequest();

            List<FacilitieDetailVO> facvo = hscservice.GetAllFacilitiesDetail();
            CommonUtil.ComboBinding(cboFacilities, facvo, "FAC_No", "FAC_Name", "전체");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<MateriaVO> mvo = new List<MateriaVO>();

            if (cboFacilities.Text.Trim() != "" && txtITEM_Code.Text != "" && txtWO_ID.Text != "")
            {
                //string a = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                //string b = dateTimePicker2.Value.ToString("yyyy-MM-dd");
                dataGridView1.DataSource = MateriaSearch();
            }
            else
            {

            }
               
        }
        private List<MateriaVO> MateriaSearch()
        {
            List<MateriaVO> mvo2 = new List<MateriaVO>();

            foreach (var item in mvo)
            {                
                if (item.FAC_Name.Trim().Contains(cboFacilities.Text.Trim()) &&
                    item.ITEM_Code.Trim().Contains(txtITEM_Code.Text.Trim()) &&
                    item.WO_State.Trim().Contains(txtWO_ID.Text.Trim()))
                    mvo2.Add(item);
                    
            }
            return mvo2;
        }

        private void btnAllSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = mvo;
        }
    }
}
