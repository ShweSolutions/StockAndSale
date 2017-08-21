using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALStockIn
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEStockIn stockIn)
        {
            SqlCmd.Parameters.AddWithValue("@StockInId", stockIn.StockInId);
            SqlCmd.Parameters.AddWithValue("@StockInDate", stockIn.StockInDate);
            SqlCmd.Parameters.AddWithValue("@Product_Id", stockIn.Product_Id);
            SqlCmd.Parameters.AddWithValue("@Product_Code", stockIn.Product_Code);
            SqlCmd.Parameters.AddWithValue("@NoOfCartons", stockIn.NoOfCartons);
            SqlCmd.Parameters.AddWithValue("@NoOfUnits", stockIn.NoOfUnits);
            SqlCmd.Parameters.AddWithValue("@Carton_Price_Buying", stockIn.Carton_Price_Buying);
            SqlCmd.Parameters.AddWithValue("@TotalAmount", stockIn.TotalAmount);
            SqlCmd.Parameters.AddWithValue("@Active", stockIn.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", stockIn.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", stockIn.ModifiedDate);

            return SqlCmd;
        }
        
        #endregion

        public int InsertData(DEStockIn stockIn, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_StockIn  VALUES(@StockInId,@StockInDate,@Product_Id,@NoOfCartons,@NoOfUnits,@Carton_Price_Buying,@TotalAmount,@Active,@ModifiedBy,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, stockIn);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int UpdateData(DEStockIn stockIn, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Update tbl_StockIn  SET StockInId = @StockInId, StockInDate = @StockInDate, Product_Id = @Product_Id, NoOfCartons = @NoOfCartons,NoOfUnits = @NoOfUnits , Carton_Price_Buying = @Carton_Price_Buying, TotalAmount = @TotalAmount,Active = @Active, ModifiedBy = @ModifiedBy,ModifiedDate = @ModifiedDate where StockInId = @StockInId";

            DeclareSqlCmdParameter(sqlCmd, stockIn);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadNoOfUnitsOfProductStockIn(DEStockIn stockIn, SqlConnection con, SqlTransaction tn)
        {
            DataTable dt_StockIn;

            SqlCommand sqlCmd = new SqlCommand(" ", con, tn);

            sqlCmd.CommandText = "SELECT ((st.NoOfCartons * p.NoOfUnitsPerCarton)+st.NoOfUnits),p.NoOfUnitsPerCarton From tbl_StockIn st LEFT JOIN tbl_Product p ON st.Product_Id = p.Product_Id where st.StockInId = @StockInId";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, stockIn);

            dt_StockIn = SqlConjunction.GetSQLTransDataTable(sqlCmd);

            return dt_StockIn;
        }

        public int InsertData(DEStockIn stockIn)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = stockIn.Product_Id;            

            SqlConnection SqlCon = new SqlConnection(SqlConjunction.DataConn);
            try
            {
                if (SqlCon.State != ConnectionState.Open)
                { SqlCon.Open(); }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            SqlTransaction tn = SqlCon.BeginTransaction();

            {
                try
                {
                    this.InsertData(stockIn, SqlCon, tn);

                    DataTable dt_TempNoOfUnitProductStockIn = this.LoadNoOfUnitsOfProductStockIn(stockIn, SqlCon, tn);

                    if (dt_TempNoOfUnitProductStockIn.Rows.Count > 0)  ///  no of units of product stock in ရလာမယ္
                    {
                        int int_NoOfUnits = Convert.ToInt32(dt_TempNoOfUnitProductStockIn.Rows[0][0].ToString());

                        DataTable dt_ProductInStoreTemp = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore, SqlCon, tn);

                        if (dt_ProductInStoreTemp.Rows.Count > 0) 
                        {
                            int int_NoOfUnitsInStore = Convert.ToInt32(dt_ProductInStoreTemp.Rows[0][0].ToString());

                            productInStore.NoOfUnits = (int_NoOfUnits + int_NoOfUnitsInStore);

                            obj_DALProductInStore.UpdateData(productInStore, SqlCon, tn);
                        }
                        else
                        {
                            productInStore.NoOfUnits = int_NoOfUnits;

                            obj_DALProductInStore.InsertData(productInStore, SqlCon, tn);
                            
                        }
                    }
                    

                    tn.Commit();
                    int_Result = 1;
                }
                catch (Exception ex)
                {
                    tn.Rollback();
                    int_Result = 0;
                    throw (ex);
                }
                finally
                {
                    obj_DALProductInStore = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        public Boolean LoadStockInRow(DEStockIn stockIn)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT StIn.StockInId,StIn.StockInDate,StIn.Product_Id,P.Product_Code,P.Product_Description,StIn.NoOfCartons,StIn.NoOfUnits FROM tbl_StockIn StIn LEFT JOIN tbl_Product P ON StIn.Product_Id = P.Product_Id where StIn.StockInId = @StockInId ";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, stockIn);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                stockIn.StockInId = sqlDataReader.GetGuid(0);
                stockIn.StockInDate = sqlDataReader.GetDateTime(1);
                stockIn.Product_Id = sqlDataReader.GetInt32(2);
                stockIn.Product_Code = sqlDataReader.GetString(3);
                stockIn.Product_Description = sqlDataReader.GetString(4);
                stockIn.NoOfCartons = sqlDataReader.GetInt32(5);
                stockIn.NoOfUnits = sqlDataReader.GetInt32(6);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;

            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public int UpdateData(DEStockIn stockIn)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = stockIn.Product_Id;

            SqlConnection SqlCon = new SqlConnection(SqlConjunction.DataConn);
            try
            {
                if (SqlCon.State != ConnectionState.Open)
                { SqlCon.Open(); }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            SqlTransaction tn = SqlCon.BeginTransaction();

            {
                try
                {
                    DataTable dt_OriginalNoOfUnitsInStore = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore, SqlCon, tn);

                    if (dt_OriginalNoOfUnitsInStore.Rows.Count > 0)
                    {
                        int int_OriginalNoOfUnitsInStore = Convert.ToInt32(dt_OriginalNoOfUnitsInStore.Rows[0][0].ToString());

                        DataTable dt_StockInOriginalNoOfUnits = this.LoadNoOfUnitsOfProductStockIn(stockIn, SqlCon, tn);

                        int int_StockInOriginalNoOfUnist = Convert.ToInt32(dt_StockInOriginalNoOfUnits.Rows[0][0].ToString());
                        int int_NoOfUnitsPerCarton = Convert.ToInt32(dt_StockInOriginalNoOfUnits.Rows[0][1].ToString());

                        this.UpdateData(stockIn, SqlCon, tn);

                        productInStore.NoOfUnits = (int_OriginalNoOfUnitsInStore - int_StockInOriginalNoOfUnist) + ((stockIn.NoOfCartons * int_NoOfUnitsPerCarton)+stockIn.NoOfUnits);

                        obj_DALProductInStore.UpdateData(productInStore, SqlCon, tn);

                    }


                    tn.Commit();
                    int_Result = 1;
                }
                catch (Exception ex)
                {
                    tn.Rollback();
                    int_Result = 0;
                    throw (ex);
                }
                finally
                {
                    obj_DALProductInStore = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        public DataTable LoadStockTableForAllDataByInDateAndProductCode(DEStockIn stockIn)
        {
            DataTable dt_StockIn;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',StIn.StockInId,StIn.StockInDate,StIn.Product_Id,P.Product_Code,P.Product_Description,StIn.NoOfCartons,StIn.NoOfUnits FROM tbl_StockIn StIn LEFT JOIN tbl_Product P ON StIn.Product_Id = P.Product_Id where StIn.StockInDate = @StockInDate And	P.Product_Code  LIKE '%' + @Product_Code+ '%' ";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, stockIn);

            dt_StockIn = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_StockIn;
        }

        public DataTable LoadStockTableForAllDataByInDateAndProductCode(DateTime dateTime_From,DateTime dateTime_To,String product_Code)
        {
            DataTable dt_StockIn;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',StIn.StockInId,StIn.StockInDate,StIn.Product_Id,P.Product_Code,P.Product_Description,StIn.NoOfCartons,StIn.NoOfUnits FROM tbl_StockIn StIn LEFT JOIN tbl_Product P ON StIn.Product_Id = P.Product_Id where StIn.StockInDate <='"+ dateTime_To +"' And StIn.StockInDate >= '"+ dateTime_From +"'	And (P.Product_Code  LIKE '%"+product_Code+"%' OR  '"+product_Code+"'='')";
            
            dt_StockIn = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_StockIn;
        }

        public DataTable LoadStockTableForAllData(DEStockIn stockIn)
        {
            DataTable dt_StockIn;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',StIn.StockInId,StIn.StockInDate,StIn.Product_Id,P.Product_Code,P.Product_Description,StIn.NoOfCartons,StIn.NoOfUnits FROM tbl_StockIn StIn LEFT JOIN tbl_Product P ON StIn.Product_Id = P.Product_Id where StIn.StockInDate = @StockInDate ";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, stockIn);

            dt_StockIn = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_StockIn;
        }
    }
}
