﻿using Project_VO.HSM;
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
                    "Convert(nvarchar(10), SALES_Duedate, 23) SALES_Duedate,Convert(nvarchar(10), SALES_OrderDate, 23) SALES_OrderDate,SALES_ORDER_STATE " +
                    "FROM SalesMaster sm, Company c, ITEM i " +
                    "WHERE sm.SALES_ORDER_STATE = '주문대기' " +
                    "AND sm.COM_Code = c.COM_Code " +
                    "AND sm.ITEM_Code = i.ITEM_Code";

                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<SalesMasterAllVO> list = Helper.DataReaderMapToList<SalesMasterAllVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
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
            catch(Exception err)
            {
                
                return false;
            }
           
        }
    }
}