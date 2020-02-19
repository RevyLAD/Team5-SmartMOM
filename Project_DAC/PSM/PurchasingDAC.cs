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

        public List<PurchasingStateVO> GetAllPurChasingState(PurchaseSearchVO ps)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"SELECT VO_ID, c.COM_Name, COM_Type, c.COM_Code, ITEM_Name, MATERIAL_ORDER_STATE, VO_Quantity, ITEM_Unit, ITEM_Size, a.ITEM_Code, VO_EndDate, VO_StartDate, VO_InDate, Plan_ID
                                        FROM VendorOrder a inner join ITEM b on a.ITEM_Code = b.ITEM_Code inner join Company c on a.COM_Code = c.COM_Code
                                        WHERE Plan_ID = @Plan_ID ";

                if (ps.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (ps.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                        if (ps.State != "")
                        {
                            sql = sql + " and MATERIAL_ORDER_STATE = @MATERIAL_ORDER_STATE";
                        }
                    }
                    else if (ps.State != "")
                    {
                        sql = sql + " and MATERIAL_ORDER_STATE = @MATERIAL_ORDER_STATE";
                    }
                }
                else if (ps.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                    if (ps.State != "")
                    {
                        sql = sql + " and MATERIAL_ORDER_STATE = @MATERIAL_ORDER_STATE";
                    }
                }
                else if (ps.State != "")
                {
                    sql = sql + " and MATERIAL_ORDER_STATE = @MATERIAL_ORDER_STATE";
                }

                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Plan_ID", ps.Plan_ID);
                cmd.Parameters.AddWithValue("@ITEM_Name", ps.Item);
                cmd.Parameters.AddWithValue("@COM_Name", ps.Company);
                cmd.Parameters.AddWithValue("@MATERIAL_ORDER_STATE", ps.State);
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

        public bool VendorOrder(List<VendorOrderVO> codelist)
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
                        cmd.CommandText = @"UPDATE SalesMaster SET Order_State = '발주완료' WHERE Plan_ID = @Plan_ID";
                        cmd.Parameters.AddWithValue("@Plan_ID", item.Plan_ID);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }
                    foreach (var item in codelist)
                    {
                        cmd.CommandText = @"INSERT INTO VendorOrder (COM_Name, COM_Code, MATERIAL_ORDER_STATE, ITEM_Code, VO_EndDate, VO_Quantity, 
VO_StartDate,  VO_InDate, Plan_ID) VALUES (@COM_Name, @COM_Code, @MATERIAL_ORDER_STATE, @ITEM_Code, @VO_EndDate, @VO_Quantity, @VO_StartDate, @VO_InDate, @Plan_ID)";

                        cmd.Parameters.AddWithValue("@COM_Name", item.COM_Name);
                        cmd.Parameters.AddWithValue("@COM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@MATERIAL_ORDER_STATE", "발주대기");
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@VO_EndDate", item.VO_EndDate);
                        cmd.Parameters.AddWithValue("@VO_Quantity", item.VO_Quantity);
                        cmd.Parameters.AddWithValue("@VO_StartDate", DateTime.Now.ToShortDateString());
                        cmd.Parameters.AddWithValue("@VO_InDate", "");
                        cmd.Parameters.AddWithValue("@Plan_ID", item.Plan_ID);

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

        //입고처리
        public bool MaterialsPut(List<DeleteOrder> lists)
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
                        cmd.CommandText = @"UPDATE VendorOrder SET MATERIAL_ORDER_STATE = '입고처리대기' WHERE VO_ID = @VO_ID";

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
        //입고처리대기 취소
        public bool MaterialsPutCancel(List<DeleteOrder> lists)
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

        public List<SupplierVO> Supplier(SupplierSearchVO sp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"SELECT DISTINCT VO_ID, VO_StartDate, ITEM_OrderComp, v.COM_Code, c.COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, 
                    ITEM_ImportIns, VO_Quantity, VO_EndDate, MATERIAL_ORDER_STATE, ITEM_OrderMethod FROM VendorOrder v 
                    inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join Company c on v.COM_Code = c.COM_Code
                    WHERE MATERIAL_ORDER_STATE = '발주대기' and Plan_ID = @Plan_ID ";

                if (sp.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (sp.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                    }
                }
                else if (sp.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                }


                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@startDate", sp.startDate);
                cmd.Parameters.AddWithValue("@endDate", sp.endDate);
                cmd.Parameters.AddWithValue("@ITEM_Name", sp.Item);
                cmd.Parameters.AddWithValue("@COM_Name", sp.Company);
                cmd.Parameters.AddWithValue("@Plan_ID", sp.Plan_ID);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SupplierVO> list = Helper.DataReaderMapToList<SupplierVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<ImportCheckVO> ImportCheck(ImportCheckSearchVO ics)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"select v.VO_ID, COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, VOD_Result, VOD_GoodEA, VOD_BadEA, VOD_ResultDay
  from VendorOrder v inner join VendorOrderDetail d on v.VO_ID = d.VO_ID inner join ITEM i on v.ITEM_Code = i.ITEM_Code 
WHERE Plan_ID = @Plan_ID ";

                if (ics.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (ics.Company != "")
                    {
                        sql = sql + " and COM_Name = @COM_Name";
                        if (ics.Result != "")
                        {
                            sql = sql + " and VOD_Result = @VOD_Result";
                        }
                    }
                    else if (ics.Result != "")
                    {
                        sql = sql + " and VOD_Result = @VOD_Result";
                    }
                }
                else if (ics.Company != "")
                {
                    sql = sql + " and COM_Name = @COM_Name";
                    if (ics.Result != "")
                    {
                        sql = sql + " and VOD_Result = @VOD_Result";
                    }
                }
                else if (ics.Result != "")
                {
                    sql = sql + " and VOD_Result = @VOD_Result";
                }

                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@startDate", ics.startDate);
                cmd.Parameters.AddWithValue("@endDate", ics.endDate);
                cmd.Parameters.AddWithValue("@ITEM_Name", ics.Item);
                cmd.Parameters.AddWithValue("@COM_Name", ics.Company);
                cmd.Parameters.AddWithValue("@VOD_Result", ics.Result);
                cmd.Parameters.AddWithValue("@Plan_ID", ics.Plan_ID);
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ImportCheckVO> list = Helper.DataReaderMapToList<ImportCheckVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public List<Material_LedgerVO> Material_Ledger(Material_LedgerSearchVO mls)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"select DISTINCT v.VO_ID, COM_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, VOD_GoodEA, FACD_Qty, VO_EndDate, VOD_Result, MATERIAL_ORDER_STATE, VOD_ResultDay
  from VendorOrder v inner join VendorOrderDetail d on v.VO_ID = d.VO_ID inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join FactoryDetail f on v.ITEM_Code = f.ITEM_Code
  WHERE VOD_Result = '합격' and MATERIAL_ORDER_STATE = '입고대기' and v.Plan_ID = @Plan_ID and FACT_Name = '자재창고_01' ";

                if (mls.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (mls.Company != "")
                    {
                        sql = sql + " and COM_Name = @COM_Name";
                    }

                }
                else if (mls.Company != "")
                {
                    sql = sql + " and COM_Name = @COM_Name";
                }


                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@startDate", mls.startDate);
                cmd.Parameters.AddWithValue("@endDate", mls.endDate);
                cmd.Parameters.AddWithValue("@ITEM_Name", mls.Item);
                cmd.Parameters.AddWithValue("@COM_Name", mls.Company);
                cmd.Parameters.AddWithValue("@Plan_ID", mls.Plan_ID);

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

        public List<Receiving_processingVO> Receiving_processing()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select v.VO_ID, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type, ITEM_Unit, FACT_Name, VO_InDate, VOD_GoodEA, ITEM_Price
from VendorOrder v inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join VendorOrderDetail d on v.VO_ID = d.VO_ID left outer join FactoryDetail f on v.ITEM_Code = f.ITEM_Code
where MATERIAL_ORDER_STATE = '입고처리대기' and FACT_Name = '자재창고_01'
order by VO_ID";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Receiving_processingVO> list = Helper.DataReaderMapToList<Receiving_processingVO>(reader);
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

        public List<MaterialsStateVO> MaterialsState(SupplierSearchVO sp)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"select v.VO_ID, VO_InDate, FACT_Name, v.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Unit, VOD_GoodEA, FACD_Qty, COM_Name
from VendorOrder v inner join ITEM i on v.ITEM_Code = i.ITEM_Code inner join VendorOrderDetail d on v.VO_ID = d.VO_ID left outer join FactoryDetail f on v.ITEM_Code = f.ITEM_Code
where MATERIAL_ORDER_STATE = '입고완료' and FACT_Name = '자재창고_01' and v.Plan_ID = @Plan_ID ";
                #region 검색조건
                if (sp.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (sp.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                    }
                }
                else if (sp.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                }

                #endregion
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Plan_ID", sp.Plan_ID);
                cmd.Parameters.AddWithValue("@ITEM_Name", sp.Item);
                cmd.Parameters.AddWithValue("@COM_Name", sp.Company);


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MaterialsStateVO> list = Helper.DataReaderMapToList<MaterialsStateVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool MaterialProcess(List<MaterialInDateVO> lists, List<MaterialsPlusVO> lists2, List<InOutListVO> lists3)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();

                try
                {

                    cmd.CommandType = CommandType.Text;
                    foreach (var item in lists)
                    {
                        cmd.CommandText = @"UPDATE VendorOrder SET MATERIAL_ORDER_STATE = '입고완료', VO_InDate = @VO_InDate WHERE VO_ID = @VO_ID";

                        cmd.Parameters.AddWithValue("@VO_ID", item.VO_ID);
                        cmd.Parameters.AddWithValue("@VO_InDate", DateTime.Now.ToString("yyyy-MM-dd"));

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    foreach (var item in lists2)
                    {
                        cmd.CommandText = @"UPDATE FactoryDetail  SET FACD_Qty = FACD_Qty + @VOD_GoodEA
                                            FROM ITEM i join FactoryDetail f on i.ITEM_Code = f.ITEM_Code
                                            WHERE FACT_Name = '자재창고_01' and f.ITEM_Code = @ITEM_Code";

                        cmd.Parameters.AddWithValue("@VOD_GoodEA", item.VOD_GoodEA);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);



                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }


                    foreach (var item in lists3)
                    {
                        cmd.CommandText = @"INSERT INTO InOutList (InOut_Date ,InOut_Gubun ,InOut_Category ,From_WareHouse ,In_WareHouse, ITEM_Code ,InOut_Qty) 
                                            VALUES (@InOut_Date, @InOut_Gubun, @InOut_Category, @From_WareHouse, @In_WareHouse, @ITEM_Code, @InOut_Qty)";

                        cmd.Parameters.AddWithValue("@InOut_Date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@InOut_Gubun", "입고");
                        cmd.Parameters.AddWithValue("@InOut_Category", "생산실적");
                        cmd.Parameters.AddWithValue("@From_WareHouse", "");
                        cmd.Parameters.AddWithValue("@In_WareHouse", item.In_WareHouse);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.Parameters.AddWithValue("@InOut_Qty", item.InOut_Qty);



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

        //입고취소
        public bool MaterialCancel(List<DeleteOrder> lists, List<MaterialsPlusVO> lists2)
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
                        cmd.CommandText = @"UPDATE FactoryDetail  SET FACD_Qty = FACD_Qty - @VOD_GoodEA
FROM ITEM i join FactoryDetail f on i.ITEM_Code = f.ITEM_Code
WHERE FACT_Name = '자재창고_01' and f.ITEM_Code = @ITEM_Code";

                        cmd.Parameters.AddWithValue("@VOD_GoodEA", item.VOD_GoodEA);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);



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

        public List<Stock_StateVO> Stock_State(MaterialStateVO ms)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"select FACT_Code, FACT_Name, f.ITEM_Code, ITEM_Name, ITEM_Type, ITEM_Size, FACD_Qty, ITEM_Unit
                                from FactoryDetail f inner join ITEM i on f.ITEM_Code = i.ITEM_Code
                                where ITEM_Type = '원자재' ";

                if (ms.FACT_Name != "")
                {
                    sql = sql + " and FACT_Name = @FACT_Name";
                    if (ms.ITEM_Name != "")
                    {
                        sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    }
                    else if (ms.ITEM_Name != "")
                    {
                        sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    }
                }

                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@FACT_Name", ms.FACT_Name);
                cmd.Parameters.AddWithValue("@ITEM_Name", ms.ITEM_Name);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Stock_StateVO> list = Helper.DataReaderMapToList<Stock_StateVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }

        public List<ShipmentOrderVO> ShipmentOrder(ShipmentOrderSearchVO so)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"SELECT SO_WorkOrderID, SALES_Duedate, s.COM_Code, COM_Name, s.ITEM_Code, ITEM_Name, SALES_OrderQty, SALES_CancelQty, (SALES_OrderQty - SALES_CancelQty)SALES_ShipQty
                            FROM SalesMaster s inner join ITEM i on s.ITEM_Code = i.ITEM_Code inner join Company c on s.COM_Code = c.COM_Code
                            WHERE SALES_ORDER_STATE = '작업완료' and Plan_ID = @Plan_ID and Shipment_State is null";
                if (so.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (so.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                    }
                }
                else if (so.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                }
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Plan_ID", so.Plan_ID);
                cmd.Parameters.AddWithValue("@COM_Name", so.Company);
                cmd.Parameters.AddWithValue("@ITEM_Name", so.Item);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShipmentOrderVO> list = Helper.DataReaderMapToList<ShipmentOrderVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }

        public List<ShipmentOrderVO> ShipmentState(ShipmentOrderSearchVO so)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                string sql = @"SELECT SO_WorkOrderID, SALES_Duedate, s.COM_Code, COM_Name, s.ITEM_Code, ITEM_Name, SALES_OrderQty, SALES_ShipQty, SALES_CancelQty
                            FROM SalesMaster s inner join ITEM i on s.ITEM_Code = i.ITEM_Code inner join Company c on s.COM_Code = c.COM_Code
                            WHERE Shipment_State = '출하완료'";
                if (so.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (so.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                    }
                }
                else if (so.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                }
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Plan_ID", so.Plan_ID);
                cmd.Parameters.AddWithValue("@COM_Name", so.Company);
                cmd.Parameters.AddWithValue("@ITEM_Name", so.Item);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ShipmentOrderVO> list = Helper.DataReaderMapToList<ShipmentOrderVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }
        public bool Shipment(List<ShipmentVO> lists)
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
                        cmd.CommandText = "Shipment";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@SALES_ShipQty", item.SALES_ShipQty);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.Parameters.AddWithValue("@SALES_OrderQty", item.SALES_OrderQty);
                        cmd.Parameters.AddWithValue("@SALES_CancelQty", item.SALES_CancelQty);
                        cmd.Parameters.AddWithValue("@SO_WorkOrderID", item.SO_WorkOrderID);
                        cmd.Parameters.AddWithValue("@InOut_Date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@InOut_Qty", item.InOut_Qty);

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

        public List<DeadLineVO> DeadLine()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);                
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT SO_WorkOrderID, s.COM_Code, COM_Name, s.ITEM_Code, ITEM_Name, SALES_OrderQty, SALES_ShipQty, (SALES_OrderQty * ITEM_Price)Price, DeadLine_Date, SALES_CancelQty                        FROM SalesMaster s inner join ITEM i on s.ITEM_Code = i.ITEM_Code inner join Company c on s.COM_Code = c.COM_Code
                        WHERE Shipment_State = '출하완료' and DeadLine_State is null ";
                
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<DeadLineVO> list = Helper.DataReaderMapToList<DeadLineVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }
        public List<DeadLineVO> DeadLineState(ShipmentOrderSearchVO so)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandType = CommandType.Text;

                string sql = @"SELECT SO_WorkOrderID, s.COM_Code, COM_Name, s.ITEM_Code, ITEM_Name, SALES_OrderQty, SALES_ShipQty, Price, DeadLine_Date, SALES_CancelQty                       
FROM SalesMaster s inner join ITEM i on s.ITEM_Code = i.ITEM_Code inner join Company c on s.COM_Code = c.COM_Code
                        WHERE DeadLine_State = '마감완료' and Plan_ID = @Plan_ID ";

                if (so.Item != "")
                {
                    sql = sql + " and ITEM_Name LIKE  '%' + @ITEM_Name +'%'";
                    if (so.Company != "")
                    {
                        sql = sql + " and c.COM_Name = @COM_Name";
                    }
                }
                else if (so.Company != "")
                {
                    sql = sql + " and c.COM_Name = @COM_Name";
                }
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@Plan_ID", so.Plan_ID);
                cmd.Parameters.AddWithValue("@COM_Name", so.Company);
                cmd.Parameters.AddWithValue("@ITEM_Name", so.Item);

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<DeadLineVO> list = Helper.DataReaderMapToList<DeadLineVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }

        
        public bool DeaLinePut(List<DeadLinePutVO> lists)
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
                        cmd.CommandText = @"UPDATE SalesMaster set DeadLine_State = '마감완료', DeadLine_Date = @DeadLine_Date, Price = @Price WHERE SO_WorkOrderID = @SO_WorkOrderID";

                        cmd.Parameters.AddWithValue("@SO_WorkOrderID", item.SO_WorkOrderID);
                        cmd.Parameters.AddWithValue("@DeadLine_Date", DateTime.Now.ToString("yyyy-MM-dd"));
                        cmd.Parameters.AddWithValue("@Price", item.Price);

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

        public List<Process_operationVO> Process_operation()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"select WO_StartDate, FAC_Code, f.FAC_Name, w.ITEM_Code, ITEM_Name, WO_State, FAC_OutWareHouse, planQty, WO_GoodQty, WO_BadQty, restQty, w.WO_ID
  from Facility f inner join WorkOrder w on f.FAC_Name = w.FAC_Name inner join ITEM i on w.ITEM_Code = i.ITEM_Code
  where WO_State = '작업완료' and f.FAC_Name = '최종조립반' and OP_State is null ";     

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Process_operationVO> list = Helper.DataReaderMapToList<Process_operationVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }
        public bool OP_StateChange(List<WO_IDVO> lists)
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
                        cmd.CommandText = @"UPDATE WorkOrder SET OP_State = '공정이동대기' WHERE WO_ID = @WO_ID";

                        cmd.Parameters.AddWithValue("@WO_ID", item.WO_ID);

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
        public List<Process_operation_finishVO> Process_operation_finish()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"select w.ITEM_Code, ITEM_Name, ITEM_Size, FACD_Qty, FACT_Name, WO_GoodQty, WO_ID
  from WorkOrder w inner join item i on w.ITEM_Code = i.ITEM_Code inner join FactoryDetail f on f.ITEM_Code = w.ITEM_Code
  where OP_State = '공정이동대기' and  FACT_Name = 'Halb 창고_01' ";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Process_operation_finishVO> list = Helper.DataReaderMapToList<Process_operation_finishVO>(reader);
                cmd.Connection.Close();

                return list;

            }
        }
        public bool OP_StateChange2(List<WO_IDVO> lists)
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
                        cmd.CommandText = @"UPDATE WorkOrder SET OP_State = '공정이동완료' WHERE WO_ID = @WO_ID";

                        cmd.Parameters.AddWithValue("@WO_ID", item.WO_ID);

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
