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
                cmd.CommandText = "SELECT VO_ID, MATERIAL_ORDER_STATE, VO_Quantity, a.ITEM_Code, VO_EndDate, VO_StartDate, " +
                    "VO_InDate, ITEM_Name, ITEM_Size, ITEM_Unit, c.COM_Code, COM_Type, COM_Name, COM_No " +
                    "FROM VendorOrder a inner join ITEM b on a.ITEM_Code = b.ITEM_Code " +
                    "inner join Company c on a.COM_Code = c.COM_Code Order by VO_ID";

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

        public bool VendorOrder(List<CodeVO> codelist)
        {

            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;

                try
                {
                    foreach (var item in codelist)
                    {
                        cmd.CommandText = @"INSERT INTO VendorOrder (COM_Code, MATERIAL_ORDER_STATE, ITEM_Code, VO_EndDate, VO_Quantity, 
VO_StartDate,  VO_InDate) VALUES (@COM_Code, @MATERIAL_ORDER_STATE, @ITEM_Code, @VO_EndDate, @VO_Quantity, @VO_StartDate, @VO_InDate)";

                        cmd.Parameters.AddWithValue("@COM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@MATERIAL_ORDER_STATE", "발주대기");
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@VO_EndDate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@VO_Quantity", 30);
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
        public List<SupplierVO> Supplier()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SELECT VO_ID, VO_StartDate, ITEM_OrderComp, v.COM_Code, COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, " +
                    "ITEM_ImportIns, VO_Quantity, VO_EndDate, ITEM_OrderMethod FROM VendorOrder v " +
                    "inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join Company c on v.COM_Code = c.COM_Code";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SupplierVO> list = Helper.DataReaderMapToList<SupplierVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}
