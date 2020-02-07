using Project_VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Project_DAC
{
    public class PurchasingDAC : ConnectionAccess
    {
        public List<ComPanyListVO> GetAllPurChasing()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct Com_No,COM_Name from Company where COM_Type = '협력업체' ";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ComPanyListVO> list = Helper.DataReaderMapToList<ComPanyListVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PurchasingVO> GetAllPurChasingDetail(string query)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "Select COM_No, a.COM_Code, COM_Name, b.ITEM_Code, Vo_Quantity, Vo_EndDate, ITEM_Size, ITEM_ImportIns, " +
                    "ITEM_OrderComp, ITEM_MinOrderQuantity From Company a inner join VendorOrder b on a.COM_Code = b.COM_Code " +
                    "inner join ITEM c on b.ITEM_Code = c.ITEM_Code WHERE COM_No = @COM_No";

                cmd.Connection.Open();
                cmd.Parameters.AddWithValue("@COM_No", query);
                SqlDataReader reader = cmd.ExecuteReader();
                List<PurchasingVO> list = Helper.DataReaderMapToList<PurchasingVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<PurchasingStateVO> GetAllPurChasingState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"SELECT VO_ID, c.COM_Name, COM_Type, c.COM_Code, ITEM_Name, MATERIAL_ORDER_STATE, VO_Quantity, ITEM_Unit, ITEM_Size, a.ITEM_Code, VO_EndDate, VO_StartDate, VO_InDate
FROM VendorOrder a inner join ITEM b on a.ITEM_Code = b.ITEM_Code inner join Company c on a.COM_Code = c.COM_Code Order by VO_ID";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<PurchasingStateVO> list = Helper.DataReaderMapToList<PurchasingStateVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<MATERIAL_ORDER_STATEVO> GetAllOrderState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select distinct MATERIAL_ORDER_STATE FROM VendorOrder ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MATERIAL_ORDER_STATEVO> list = Helper.DataReaderMapToList<MATERIAL_ORDER_STATEVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool VendorOrder(List<VendorOrderVO> codelist, string Plan_ID)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.CommandText = @"UPDATE SalesMaster SET Order_State = '발주완료' WHERE Plan_ID = @Plan_ID";                    
                    cmd.Parameters.AddWithValue("@Plan_ID", Plan_ID);

                    cmd.ExecuteNonQuery();

                    foreach (var item in codelist)
                    {
                        cmd.CommandText = @"INSERT INTO VendorOrder (COM_Code, MATERIAL_ORDER_STATE, ITEM_Code, VO_EndDate, VO_Quantity, 
VO_StartDate,  VO_InDate) VALUES (@COM_Code, @MATERIAL_ORDER_STATE, @ITEM_Code, @VO_EndDate, @VO_Quantity, @VO_StartDate, @VO_InDate)";
                        
                        cmd.Parameters.AddWithValue("@COM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@MATERIAL_ORDER_STATE", "발주대기");
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@VO_EndDate", item.VO_EndDate);
                        cmd.Parameters.AddWithValue("@VO_Quantity", item.VO_Quantity);
                        cmd.Parameters.AddWithValue("@VO_StartDate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@VO_InDate", DateTime.Now.ToShortDateString());

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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
        //납기일자변경
        public bool EndDateChange(List<EndDateChange> datelist)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in datelist)
                    {
                        cmd.CommandText = @"UPDATE VendorOrder SET VO_EndDate = @VO_EndDate WHERE VO_ID = @VO_ID";

                        cmd.Parameters.AddWithValue("@VO_EndDate", item.VO_EndDate);
                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);                       

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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
        //발주취소
        public bool OrderDelete(List<DeleteOrder> deletelist)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in deletelist)
                    {
                        cmd.CommandText = @"DELETE FROM VendorOrder WHERE VO_ID = @VO_ID";
                        
                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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

        public bool OrderChange(List<DeleteOrder> lists)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in lists)
                    {
                        cmd.CommandText = @"UPDATE VendorOrder SET MATERIAL_ORDER_STATE = '발주처리' WHERE VO_ID = @VO_ID";
                        
                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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

        public bool OrderCancel(List<DeleteOrder> lists)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in lists)
                    {
                        cmd.CommandText = @"UPDATE VendorOrder SET MATERIAL_ORDER_STATE = '발주대기' WHERE VO_ID = @VO_ID";

                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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
        //입고대기
        public bool WarehousingWait(List<DeleteOrder> lists, List<VenderorderDetailVO> lists2)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in lists)
                    {
                        cmd.CommandText = @"UPDATE VendorOrder SET MATERIAL_ORDER_STATE = '입고대기' WHERE VO_ID = @VO_ID";

                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    foreach (var item in lists2)
                    {
                        cmd.CommandText = @"INSERT INTO VendorOrderDetail(VO_ID, VOD_GoodEA, VOD_BadEA, VOD_ResultDay, VOD_Result) VALUES(@VO_ID, @VOD_GoodEA, @VOD_BadEA, @VOD_ResultDay, @VOD_Result)";
                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);
                        cmd.Parameters.AddWithValue("@VOD_GoodEA", item.VOD_GoodEA);
                        cmd.Parameters.AddWithValue("@VOD_BadEA", 0);
                        cmd.Parameters.AddWithValue("@VOD_ResultDay", item.VO_StartDate);
                        cmd.Parameters.AddWithValue("@VOD_Result", "불합격");

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }


                    cmd.Connection.Close();
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

        public List<SupplierVO> Supplier()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"SELECT DISTINCT VO_ID, VO_StartDate, ITEM_OrderComp, v.COM_Code, c.COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, 
                    ITEM_ImportIns, VO_Quantity, VO_EndDate, MATERIAL_ORDER_STATE, ITEM_OrderMethod FROM VendorOrder v 
                    inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join Company c on v.COM_Code = c.COM_Code
                    WHERE MATERIAL_ORDER_STATE = '발주대기' Order by VO_ID";
                
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SupplierVO> list = Helper.DataReaderMapToList<SupplierVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<ImportCheckVO> ImportCheck()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select v.VO_ID, COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, VOD_Result, VOD_GoodEA, VOD_BadEA, VOD_ResultDay
  from VendorOrder v inner join VendorOrderDetail d on v.VO_ID = d.VO_ID inner join ITEM i on v.ITEM_Code = i.ITEM_Code
  order by VO_ID";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ImportCheckVO> list = Helper.DataReaderMapToList<ImportCheckVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<Material_LedgerVO> Material_Ledger()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select DISTINCT v.VO_ID, COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, VOD_GoodEA, FACD_Qty, VO_EndDate, VOD_Result, MATERIAL_ORDER_STATE, VOD_ResultDay
  from VendorOrder v inner join VendorOrderDetail d on v.VO_ID = d.VO_ID inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join FactoryDetail f on v.ITEM_Code = f.ITEM_Code
  WHERE VOD_Result = '합격'
  order by VO_ID";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Material_LedgerVO> list = Helper.DataReaderMapToList<Material_LedgerVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<SupplierStateVO> SupplierState()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"SELECT distinct VO_ID, c.COM_Name, COM_Type, c.COM_Code, ITEM_Name, MATERIAL_ORDER_STATE, VO_Quantity, FACD_Qty, FACT_Name, ITEM_Unit, ITEM_Size, a.ITEM_Code, VO_EndDate, VO_StartDate, VO_InDate
FROM VendorOrder a inner join ITEM b on a.ITEM_Code = b.ITEM_Code inner join Company c on a.COM_Code = c.COM_Code inner join FactoryDetail f on a.ITEM_Code = f.ITEM_Code
WHERE FACT_Code = 'R_01' and MATERIAL_ORDER_STATE = '발주처리'
Order by VO_ID";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SupplierStateVO> list = Helper.DataReaderMapToList<SupplierStateVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool Result(List<DeleteOrder> lists)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach (var item in lists)
                    {
                        cmd.CommandText = @"UPDATE VendorOrderDetail SET VOD_Result = '합격' WHERE VO_ID = @VO_ID";

                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    cmd.Connection.Close();
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
