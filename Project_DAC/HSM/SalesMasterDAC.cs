using Project_VO.HSM;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DAC.HSM
{
    public class SalesMasterDAC : ConnectionAccess
    {
        public List<SalesMasterAllVO> GetAllSalesMaster()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select SO_WorkOrderID,sm.COM_Code,c.COM_Name,sm.ITEM_Code,i.ITEM_Name, " +
                    "PO_Type,SALES_OrderQty,ISNULL(SALES_ShipQty, 0) SALES_ShipQty,ISNULL(SALES_CancelQty, 0) SALES_CancelQty,  " +
                    "Convert(nvarchar(10), SALES_Duedate, 23) SALES_Duedate,Convert(nvarchar(10), SALES_OrderDate, 23) SALES_OrderDate,SALES_ORDER_STATE,sm.SALES_ORDER_STATE, SALES_Remark " +
                    "FROM SalesMaster sm, Company c, ITEM i " +
                    "WHERE sm.COM_Code = c.COM_Code " +
                    "AND sm.ITEM_Code = i.ITEM_Code";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesMasterAllVO> list = Helper.DataReaderMapToList<SalesMasterAllVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        /// <summary>
        /// 상태가 '작업대기'인 항목조회
        /// </summary>
        /// <returns></returns>
        public List<SalesMasterWorkOrder> GetSalesMasterByPlanID(string planId)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = @"select s.ITEM_Code, i.ITEM_Name, s.SALES_OrderQty,Convert(nvarchar(10),SALES_Duedate,23) SALES_Duedate
                                    from SalesMaster s , ITEM i
                                    where Plan_ID = @Plan_ID
                                    and SALES_ORDER_STATE = '작업대기'
                                    and s.ITEM_Code = i.ITEM_Code";

                cmd.Parameters.AddWithValue("@Plan_ID", planId);

                cmd.Connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesMasterWorkOrder> list = Helper.DataReaderMapToList<SalesMasterWorkOrder>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        /// <summary>
        /// 엑셀파일 업로드
        /// </summary>
        /// <param name="sales"></param>
        /// <returns></returns>
        public bool UploadSalesMaster(List<SalesMasterVO> sales)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.Connection.Open();
                    foreach (var item in sales)
                    {
                        cmd.CommandText = "INSERT INTO SalesMaster(SO_WorkOrderID ,COM_Code ,ITEM_Code, PO_Type ,SALES_OrderQty ,SALES_Duedate,SALES_OrderDate, SALES_ORDER_STATE ) " +
                                          "VALUES (@SO_WorkOrderID ,@COM_Code ,@ITEM_Code, @PO_Type ,@SALES_OrderQty ,@SALES_Duedate , @SALES_OrderDate, @SALES_ORDER_STATE)";

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@SO_WorkOrderID", item.SO_WorkOrderID);
                        cmd.Parameters.AddWithValue("@COM_Code", item.COM_Code);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.Parameters.AddWithValue("@PO_Type", item.PO_Type);
                        cmd.Parameters.AddWithValue("@SALES_OrderQty", item.SALES_OrderQty);
                        cmd.Parameters.AddWithValue("@SALES_Duedate", Convert.ToDateTime(item.SALES_Duedate));
                        cmd.Parameters.AddWithValue("@SALES_OrderDate", Convert.ToDateTime(item.SALES_OrderDate));
                        cmd.Parameters.AddWithValue("@SALES_ORDER_STATE", "주문대기");


                        cmd.ExecuteNonQuery();
                    }

                    cmd.Connection.Close();


                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }

        }


        /// <summary>
        /// 수동생성
        /// </summary>
        /// <param name="sales"></param>
        /// <returns></returns>
        public bool UploadPassiveSalesMaster(SalesMasterAllVO sales)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.Connection.Open();

                    cmd.CommandText = "INSERT INTO SalesMaster(SO_WorkOrderID ,COM_Code ,ITEM_Code, PO_Type ,SALES_OrderQty,SALES_ShipQty,SALES_CancelQty ,SALES_Duedate,SALES_OrderDate, SALES_ORDER_STATE,SALES_Remark ) " +
                                      "VALUES (@SO_WorkOrderID ,@COM_Code ,@ITEM_Code, @PO_Type ,@SALES_OrderQty,@SALES_ShipQty,@SALES_CancelQty ,@SALES_Duedate , @SALES_OrderDate, @SALES_ORDER_STATE,@SALES_Remark)";

                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@SO_WorkOrderID", sales.SO_WorkOrderID);
                    cmd.Parameters.AddWithValue("@COM_Code", sales.COM_Code);
                    cmd.Parameters.AddWithValue("@ITEM_Code", sales.ITEM_Code);
                    cmd.Parameters.AddWithValue("@PO_Type", sales.PO_Type);
                    cmd.Parameters.AddWithValue("@SALES_OrderQty", sales.SALES_OrderQty);
                    cmd.Parameters.AddWithValue("@SALES_ShipQty", sales.SALES_ShipQty);
                    cmd.Parameters.AddWithValue("@SALES_CancelQty", sales.SALES_CancelQty);
                    cmd.Parameters.AddWithValue("@SALES_Duedate", Convert.ToDateTime(sales.SALES_Duedate));
                    cmd.Parameters.AddWithValue("@SALES_OrderDate", DateTime.Now.ToShortDateString());
                    cmd.Parameters.AddWithValue("@SALES_ORDER_STATE", "주문대기");
                    cmd.Parameters.AddWithValue("@SALES_Remark", sales.SALES_Remark);



                    cmd.ExecuteNonQuery();


                    cmd.Connection.Close();


                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }

        }

        public bool UpdatePlanID(List<UpdatePlanIDVO> plan)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    foreach (var item in plan)
                    {
                        cmd.Connection = new SqlConnection(this.ConnectionString);
                        cmd.Connection.Open();

                        cmd.CommandText = "UPDATE SalesMaster SET Plan_ID = @Plan_ID, Sales_Order_State = '생산대기' WHERE SO_WorkOrderID = @SO_WorkOrderID";

                        cmd.Parameters.Clear();

                        cmd.Parameters.AddWithValue("@SO_WorkOrderID", item.SO_WorkOrderID);
                        cmd.Parameters.AddWithValue("@Plan_ID", item.Plan_ID);



                        cmd.ExecuteNonQuery();
                    }

                    cmd.Connection.Close();


                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }

        }

        public bool UpdatePlanID(string workID)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {

                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.Connection.Open();
                    cmd.CommandText = "UPDATE SalesMaster SET Sales_Order_State = '작업대기', Order_State = '발주대기' WHERE SO_WorkOrderID = @SO_WorkOrderID";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@SO_WorkOrderID", workID);


                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();


                }

                return true;


            }
            catch (Exception err)
            {

                return false;
            }

        }
    }
}
