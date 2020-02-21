using Project_VO;
using Project_VO.LBJ;
using System;
using System.Collections.Generic;
using System.Data;
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
                cmd.CommandText = @"select A.WO_StartDate, A.WO_ID, PlanQty, WO_State, B.ITEM_Name, A.ITEM_Code, ITEM_Unit, C.FAC_OutWareHouse, A.FAC_Name
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
                cmd.CommandText = @"select WO_ID,WO_StartDate,b.ITEM_Code,FAC_Name,ITEM_Size,ITEM_Type,FACT_Name,FACT_Name1,FACD_Qty ,planQty,directQty, WO_OutState from
                                    (
                                    SELECT WO_ID,WO_StartDate,b.ITEM_Code,FAC_Name,C.ITEM_Size,ITEM_Type,D.FACT_Name,
                                    CASE WHEN ITEM_Type = '원자재' THEN '자재창고_01' ELSE  '자재창고_01' END AS 'FACT_Name1' ,
                                     planQty,BOM_Require, b.BOM_Require *(product_qty) as directQty, WO_OutState
                                    FROM WorkOrder a, BOM b ,ITEM c,  FactoryDetail d
                                    where B.BOM_Code = A.ITEM_Code
                                    and  C.ITEM_Code = b.ITEM_Code
                                    and c.ITEM_Code = d.ITEM_Code
                                    and a.FAC_Name != '최종조립반' 
                                    and   C.ITEM_Type = '원자재' 
                                    and D.FACT_Name != '자재창고_01' ) A LEFT OUTER JOIN

                                    (
                                    select ITEM_Code, FACD_Qty from FactoryDetail where FACT_Code = 'R_01') B ON A.ITEM_Code = B.ITEM_Code

									order by 1";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MateriaExportVO> list = Helper.DataReaderMapToList<MateriaExportVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public bool MateriaTran(List<MateriaExportOkVO> mevo)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                try
                {
                    foreach(var item in mevo)
                    {
                        cmd.CommandText = "MaterialExport";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@directQty", item.directQty);
                        cmd.Parameters.AddWithValue("@WO_ID", item.WO_ID);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.Parameters.AddWithValue("@InOut_Date", item.InOut_Date);
                        cmd.Parameters.AddWithValue("@InOut_Gubun", "출고");
                        cmd.Parameters.AddWithValue("@InOut_Category", "자재차감");
                        cmd.Parameters.AddWithValue("@From_WareHouse", item.In_WareHouse);
                        cmd.Parameters.AddWithValue("@In_WareHouse", item.From_WareHouse);
                        cmd.Parameters.AddWithValue("@InOut_Qty", item.InOut_Qty);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    return true;
                }
                catch (Exception err)
                {
                    System.Diagnostics.Debug.WriteLine(err.Message);
                    cmd.Connection.Close();
                    return false;
                }
            }
        }     
    }
}



