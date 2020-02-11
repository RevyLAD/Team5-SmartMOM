using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.LBJ
{
    public class MateriaDAC : ConnectionAccess
    {
        public List<MateriaVO> MateriaRequest()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select A.WO_StartDate, WO_ID, PlanQty, WO_State, B.ITEM_Name, A.ITEM_Code, ITEM_Unit, C.FAC_OutWareHouse, A.FAC_Name
                                    from WorkOrder A inner
                                    join ITEM B on A.ITEM_Code = B.ITEM_Code inner
                                    join Facility C on A.FAC_Name = C.FAC_Name
                                    where WO_StartDate between '2020-02-01' and '2020-02-07'";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MateriaVO> list = Helper.DataReaderMapToList<MateriaVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<MateriaenVO> Materiaen()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select A.ITEM_Code, ITEM_Name, ITEM_Size, B.WO_StartDate, planQty,C.FAC_OutWareHouse
                                    from ITEM A inner join WorkOrder B on A.ITEM_Code = B.ITEM_Code inner join Facility C on b.FAC_Name = c.FAC_Name";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MateriaenVO> list = Helper.DataReaderMapToList<MateriaenVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<MateriaExportVO> MateriaExportVO()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"SELECT WO_ID,WO_StartDate,b.ITEM_Code,FAC_Name,C.ITEM_Size,ITEM_Type,D.FACT_Name, " +
                    "CASE WHEN ITEM_Type = '원자재' THEN '자재창고_01' ELSE  '자재창고_01' END AS 'FACT_Name1' ,planQty,directQty FROM WorkOrder a, BOM b ,ITEM c,  FactoryDetail d where B.BOM_Code = A.ITEM_Code and C.ITEM_Code = b.ITEM_Code and a.ITEM_Code = d.ITEM_Code and a.FAC_Name != '최종조립반' and   C.ITEM_Type = '원자재' and D.FACT_Name != '자재창고_01' and a.Plan_ID = '20200129_P' Order by WO_ID";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MateriaExportVO> list = Helper.DataReaderMapToList<MateriaExportVO>(reader);
                cmd.Connection.Close();

                return list;                    
            }
        }
    }
}
 