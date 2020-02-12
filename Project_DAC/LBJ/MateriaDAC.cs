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
                cmd.CommandText = @"SELECT WO_ID,WO_StartDate,b.ITEM_Code,FAC_Name,C.ITEM_Size,ITEM_Type,D.FACT_Name, FACD_Qty, CASE WHEN ITEM_Type = '원자재' THEN '자재창고_01' ELSE  '자재창고_01' END AS 'FACT_Name1' ,planQty,directQty
FROM WorkOrder a, BOM b ,ITEM c,  FactoryDetail d where B.BOM_Code = A.ITEM_Code and C.ITEM_Code = b.ITEM_Code and a.ITEM_Code = d.ITEM_Code and a.FAC_Name != '최종조립반' and   C.ITEM_Type = '원자재' and D.FACT_Name != '자재창고_01' and a.Plan_ID = '20200129_P' Order by WO_ID";
                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<MateriaExportVO> list = Helper.DataReaderMapToList<MateriaExportVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }
        public bool MateriaTran(List<MateriaExportVO> mevo, List<InoutList> iol)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.Connection.Open();
                cmd.CommandType = CommandType.Text;
                try
                {
                    foreach(var item in mevo)
                    {
                        cmd.CommandText = "Update FactoryDetail set FACD_Qty = FACD_Qty - @directQty where ITEM_Code = @ITEM_Code and FACT_Name = '자재창고_01'";
                        cmd.Parameters.AddWithValue("@directQty", item.directQty);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    foreach (var item in mevo)
                    {
                        cmd.CommandText = "Update FactoryDetail set FACD_Qty = FACD_Qty + @planQty where ITEM_Code = @ITEM_Code";

                        cmd.Parameters.AddWithValue("@planQty", item.planQty);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    foreach (var item in iol)
                    {
                        cmd.CommandText = @"INSERT INTO InOutList(InOut_Date, InOut_Gubun, InOut_Category, In_WareHouse, ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type, InOut_Qty) select A.InOut_Date, InOUT_Gubun, InOut_Category, In_WareHouse, B.ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type, A.InOut_Qty from InOutList A, ITEM B where ITEM_No = @ITEM_No and A.ITEM_Code = B.ITEM_Code";
                        cmd.Parameters.AddWithValue("@InOut_Date", item.InOut_Date);
                        cmd.Parameters.AddWithValue("@InOut_Gubun", item.InOut_Gubun);
                        cmd.Parameters.AddWithValue("@InOut_Category", item.InOut_Category);
                        cmd.Parameters.AddWithValue("@In_WareHouse", item.In_WareHouse);
                        cmd.Parameters.AddWithValue("@ITEM_Code", item.ITEM_Code);
                        cmd.Parameters.AddWithValue("@ITEM_Name", item.ITEM_Name);
                        cmd.Parameters.AddWithValue("@ITEM_Size", item.ITEM_Size);
                        cmd.Parameters.AddWithValue("@ITEM_Type", item.ITEM_Type);
                        cmd.Parameters.AddWithValue("@InOut_Qty", item.InOut_Qty);
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
        //public bool MateriaTran(MateriaExportVO mevo, //List<MateriaExportVO> MateriaTran()
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = new SqlConnection(this.ConnectionString);
        //        cmd.CommandText = "select A.InOut_Date, InOut_Gubun, InOut_Category, In_WareHouse, A.ITEM_Code, B.ITEM_Name, ITEM_Size, ITEM_Type, A.InOut_Qty from InOutList A inner join ITEM B on A.ITEM_Code = B.ITEM_Code";
        //        cmd.Connection.Open();
        //        SqlTransaction tran = cmd.Connection.BeginTransaction();
        //        try
        //        {
        //            cmd.Transaction = tran;
        //            cmd.CommandType = CommandType.Text;
        //            cmd.CommandText = "INSERT INTO InOutList(InOut_Date, InOut_Gubun, InOut_Category, In_WareHouse, ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type, InOut_Qty) value(@InOut_Date, @InOut_Gubun, @InOut_Category, @In_WareHouse, @ITEM_Code, @Fac_Name, @ITEM_Size, @ITEM_Type, @InOut_Qty)";
        //            cmd.Parameters.AddWithValue("@InOut_Date", mevo.WO_StartDate);
        //            cmd.Parameters.AddWithValue("@In_WareHouse", mevo.FACT_Name1);
        //            cmd.Parameters.AddWithValue("@ITEM_Code", mevo.ITEM_Code);
        //            cmd.Parameters.AddWithValue("@Fac_Name", mevo.FACT_Name);
        //            cmd.Parameters.AddWithValue("@ITEM_Size", mevo.ITEM_Size);
        //            cmd.Parameters.AddWithValue("@ITEM_Type", mevo.ITEM_Type);
        //            cmd.Parameters.AddWithValue("@InOut_Qty", mevo.planQty);

        //            int mevoID = cmd.ExecuteNonQuery();

        //            foreach ()
        //        }
        //    }
        //}
        //public string MateriaTran(MateriaExportVO mvo)
        //{
        //    using (SqlConnection conn = new SqlConnection())
        //    {
        //        conn.Open();
        //        SqlTransaction tran = conn.BeginTransaction();

        //        try
        //        {
        //            string sql = "INSERT INTO InOutList(InOut_Date, InOut_Gubun, InOut_Category, In_WareHouse, ITEM_Code, ITEM_Name, ITEM_Size, ITEM_Type, InOut_Qty) value(@InOut_Date, @InOut_Gubun, @InOut_Category, @In_WareHouse, @ITEM_Code, @ITEM_Name, @ITEM_Size, @ITEM_Type, @InOut_Qty)";
        //            using (SqlCommand scm = new SqlCommand(sql, conn))
        //            {
        //                scm.Transaction = tran;

        //                scm.Parameters.AddWithValue("@InOut_Date", mvo.WO_StartDate);
        //                scm.Parameters.AddWithValue("@InOut_Gubun", mvo.)
        //            }
        //        }
        //    }
        //}


        //public string InsertNop_History(NopHistoryVO nop)
        //{

        //    using (SqlConnection conn = new SqlConnection(Connstr))
        //    {
        //        conn.Open();
        //        SqlTransaction tran = conn.BeginTransaction();

        //        try
        //        {
        //            string chksql = "INSERT INTO Nop_History(Wc_Code, Nop_Mi_Code, Nop_Type, Nop_Time, Remark, Ins_Emp) values(@Wc_Code, @Nop_Mi_Code, @Nop_Type, @Nop_Time, @Remark, @Ins_Emp)";
        //            using (SqlCommand cmdchk = new SqlCommand(chksql, conn))
        //            {
        //                cmdchk.Transaction = tran;

        //                cmdchk.Parameters.AddWithValue("@Wc_Code", nop.Wc_Code);
        //                cmdchk.Parameters.AddWithValue("@Nop_Mi_Code", nop.Nop_Mi_Code);
        //                cmdchk.Parameters.AddWithValue("@Nop_Type", nop.Nop_Type);
        //                cmdchk.Parameters.AddWithValue("@Nop_Time", nop.Nop_Time);
        //                cmdchk.Parameters.AddWithValue("@Remark", nop.Remark);
        //                cmdchk.Parameters.AddWithValue("@Ins_Emp", nop.Ins_Emp);
        //                int iResult = Convert.ToInt32(cmdchk.ExecuteScalar());
        //                if (iResult > 0)
        //                    throw new Exception("비가동 등록 중 오류가 발생했습니다.");

        //                cmdchk.Parameters.Clear();

        //            }
        //            //------------------------------------------------------------- 
        //            string Stsql = @"UPDATE WorkCenter_Master SET Use_YN = 'N' Where Wc_Code=@Wc_Code";
        //            using (SqlCommand cmd = new SqlCommand(Stsql, conn))
        //            {
        //                cmd.Transaction = tran;

        //                cmd.Parameters.AddWithValue("@Wc_Code", nop.Wc_Code);

        //                int iResult = cmd.ExecuteNonQuery();
        //                if (iResult < 1)
        //                    throw new Exception("비가동 등록 중 오류가 발생했습니다.");

        //                cmd.Parameters.Clear();


        //                tran.Commit();
        //                return "OK";
        //            }
        //        }
        //        catch (Exception err)
        //        {
        //            tran.Rollback();
        //            return err.Message;
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}
    }
}



