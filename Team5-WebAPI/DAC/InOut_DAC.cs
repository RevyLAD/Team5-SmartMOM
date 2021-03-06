﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using Team5_WebAPI.Models;

namespace Team5_WebAPI.DAC
{
    public class InOut_DAC
    {
        string StrConn = string.Empty;
        public InOut_DAC()
        {
            StrConn = WebConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        }

        public List<InOut_VO> SearchInItem()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText = "  select DatePart(Month,Inout_date)as InOut_Date ,InOut_Gubun ,sum(InOut_Qty)as Total from InOutList where year(inOut_Date)=Year(GETDATE()) group by  DatePart(Month,Inout_date),InOut_Gubun ";

          
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<InOut_VO> list = Helper.DataReaderMapToList<InOut_VO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public List<Item_VO2> InoutCount()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(StrConn);
                cmd.CommandText = "select count(case when InOut_Gubun ='입고' then 1 end) as Initem,count(case when InOut_Gubun ='출고' then 1 end) as OutItem from InOutList ";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<Item_VO2> list = Helper.DataReaderMapToList<Item_VO2>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}