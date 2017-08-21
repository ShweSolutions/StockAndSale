using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALCatagory
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DECatagory catagory)
        {
            SqlCmd.Parameters.AddWithValue("@Catagory_Id", catagory.Catagory_Id);
            SqlCmd.Parameters.AddWithValue("@Catagory_Description", catagory.Catagory_Description);
            SqlCmd.Parameters.AddWithValue("@Active", catagory.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", catagory.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", catagory.ModifiedDate);

            return SqlCmd;
        }

        #endregion

        #region +++  Codes of public access methods  +++
        
        public DataTable LoadCatagoryTableForAllData()
        {
            DataTable dt_Catagory;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Cat.Catagory_Id,Cat.Catagory_Description,Cat.Active,Cat.ModifiedBy,Cat.ModifiedDate FROM tbl_Catagory Cat where Cat.Active = 'true' order by Cat.Catagory_Description";

            dt_Catagory = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Catagory;
        }        
        

        public Boolean LoadCatagoryRow(DECatagory catagory)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Catagory_Id,Catagory_Description,Active,ModifiedBy,ModifiedDate FROM tbl_Catagory Where Catagory_Id=@Catagory_Id";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, catagory);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                catagory.Catagory_Id = sqlDataReader.GetInt32(0);
                catagory.Catagory_Description = sqlDataReader.GetString(1);
                catagory.Active = sqlDataReader.GetBoolean(2);
                catagory.ModifiedBy = sqlDataReader.GetString(3);
                catagory.ModifiedDate = sqlDataReader.GetDateTime(4);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public int InsertData(DECatagory catagory)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT @Catagory_Id = ISNULL(MAX(Catagory_Id),0)+1 FROM tbl_Catagory INSERT  tbl_Catagory  VALUES(@Catagory_Id,@Catagory_Description,@Active,@ModifiedBy,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, catagory);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }


        public int UpdateData(DECatagory catagory)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "UPDATE tbl_Catagory SET Catagory_Id= @Catagory_Id, Catagory_Description=@Catagory_Description, Active = @Active ,ModifiedBy = @ModifiedBy ,ModifiedDate = @ModifiedDate WHERE Catagory_Id = @Catagory_Id";

            DeclareSqlCmdParameter(sqlCmd, catagory);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int DeleteData(DECatagory catagory)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "DELETE FROM tbl_Catagory  WHERE Catagory_ID = @Catagory_Id";

            DeclareSqlCmdParameter(sqlCmd, catagory);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadCatagoryTableForAllDataByCatagoryDescription(DECatagory catagory)
        {
            DataTable dt_Catagory;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Cat.Catagory_Id,Cat.Catagory_Description,Cat.Active,Cat.ModifiedBy,Cat.ModifiedDate FROM tbl_Catagory Cat where Cat.Active = 'true' And	Cat.Catagory_Description  LIKE '%' + @Catagory_Description+ '%' order by Cat.Catagory_Description";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, catagory);

            dt_Catagory = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Catagory;
        }

        #endregion
    }
}
