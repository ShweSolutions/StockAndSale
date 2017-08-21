using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALProduct
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEProduct product)
        {
            SqlCmd.Parameters.AddWithValue("@Product_Id", product.Product_Id);
            SqlCmd.Parameters.AddWithValue("@Product_Code", product.Product_Code);
            SqlCmd.Parameters.AddWithValue("@Product_Description", product.Product_Description);
            SqlCmd.Parameters.AddWithValue("@Unit_Weight", product.Unit_Weight);
            SqlCmd.Parameters.AddWithValue("@NoOfUnitsPerCarton", product.NoOfUnitsPerCarton);
            SqlCmd.Parameters.AddWithValue("@Unit_Price", product.Unit_Price);
            SqlCmd.Parameters.AddWithValue("@Carton_Price", product.Carton_Price);
            SqlCmd.Parameters.AddWithValue("@CartonPrice_Buying", product.CartonPrice_Buying);
            SqlCmd.Parameters.AddWithValue("@Catagory_Id", product.Catagory_Id);
            SqlCmd.Parameters.AddWithValue("@Active", product.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", product.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", product.ModifiedDate);
            SqlCmd.Parameters.AddWithValue("@Unit_Price2", product.Unit_Price2);
            SqlCmd.Parameters.AddWithValue("@Carton_Price2", product.Carton_Price2);
            SqlCmd.Parameters.AddWithValue("@MinLVL", product.MinLVL);
            SqlCmd.Parameters.AddWithValue("@ReorderCtn", product.ReorderCtn);
            SqlCmd.Parameters.AddWithValue("@SrNo", product.SrNo);

            return SqlCmd;
        }

        #endregion

       #region +++  Codes of public access methods  +++

        public DataTable LoadProductTableForAllData()
        {
            DataTable dt_Product;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Pro.Product_Id,Pro.Product_Code,Pro.Product_Description,Pro.Unit_Weight,Pro.NoOfUnitsPerCarton,Pro.Unit_Price,Pro.Carton_Price,Pro.CartonPrice_Buying,Pro.Catagory_Id,Cat.Catagory_Description,Pro.Active,Pro.ModifiedBy,Pro.ModifiedDate, Pro.Unit_Price2, Pro.Carton_Price2, Pro.MinLVL, Pro.ReorderCtn, Pro.SrNo FROM tbl_Product Pro LEFT JOIN tbl_Catagory Cat on Pro.Catagory_Id = Cat.Catagory_Id where Pro.Active = 'true' order by Pro.Product_Code";

            dt_Product = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Product;
        }


        public Boolean LoadProductRow(DEProduct product)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Pro.Product_Id,Pro.Product_Code,Pro.Product_Description,Pro.Unit_Weight,Pro.NoOfUnitsPerCarton,Pro.Unit_Price,Pro.Carton_Price,Pro.CartonPrice_Buying,Pro.Catagory_Id,Cat.Catagory_Description,Pro.Active,Pro.ModifiedBy,Pro.ModifiedDate, Pro.Unit_Price2, Pro.Carton_Price2, Pro.MinLVL, Pro.ReorderCtn, Pro.SrNo FROM tbl_Product Pro LEFT JOIN tbl_Catagory Cat on Pro.Catagory_Id = Cat.Catagory_Id where Pro.Active = 'true' And Pro.Product_Id = @Product_Id";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, product);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                product.Product_Id = sqlDataReader.GetInt32(0);
                product.Product_Code = sqlDataReader.GetString(1);
                product.Product_Description = sqlDataReader.GetString(2);
                product.Unit_Weight = sqlDataReader.GetDecimal(3);
                product.NoOfUnitsPerCarton = sqlDataReader.GetInt32(4);
                product.Unit_Price = sqlDataReader.GetDecimal(5);
                product.Carton_Price = sqlDataReader.GetDecimal(6);
                product.CartonPrice_Buying = sqlDataReader.GetDecimal(7);
                product.Catagory_Id = sqlDataReader.GetInt32(8);
                product.Catagory_Description = sqlDataReader.GetString(9);
                product.Active = sqlDataReader.GetBoolean(10);
                product.ModifiedBy = sqlDataReader.GetString(11);
                product.ModifiedDate = sqlDataReader.GetDateTime(12);
                product.Unit_Price2 = sqlDataReader.GetDecimal(13);
                product.Carton_Price2 = sqlDataReader.GetDecimal(14);
                product.MinLVL = sqlDataReader.GetInt32(15);
                product.ReorderCtn = sqlDataReader.GetInt32(16);
                product.SrNo = sqlDataReader.GetInt32(17);
                
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public int InsertData(DEProduct product)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT @Product_Id = ISNULL(MAX(Product_Id),0)+1 FROM tbl_Product INSERT  tbl_Product  VALUES(@Product_Id,@Product_Code,@Product_Description,@Unit_Weight,@NoOfUnitsPerCarton,@Unit_Price,@Carton_Price,@CartonPrice_Buying,@Catagory_Id,@Active,@ModifiedBy,@ModifiedDate,@Unit_Price2,@Carton_Price2,@MinLVL,@ReorderCtn, @SrNo)";

            DeclareSqlCmdParameter(sqlCmd, product);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }


        public int UpdateData(DEProduct product)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "UPDATE tbl_Product SET Product_Id= @Product_Id, Product_Code=@Product_Code, Product_Description = @Product_Description, Unit_Weight = @Unit_Weight, NoOfUnitsPerCarton = @NoOfUnitsPerCarton,Unit_Price = @Unit_Price, Carton_Price = @Carton_Price, CartonPrice_Buying = @CartonPrice_Buying, Catagory_Id = @Catagory_Id , Active = @Active ,ModifiedBy = @ModifiedBy ,ModifiedDate = @ModifiedDate, Unit_Price2 = @Unit_Price2, Carton_Price2 = @Carton_Price2, MinLVL = @MinLVL, ReorderCtn = @ReorderCtn, SrNo = @SrNo WHERE Product_Id = @Product_Id";

            DeclareSqlCmdParameter(sqlCmd, product);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int DeleteData(DEProduct product)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "DELETE FROM tbl_Product  WHERE Product_Id = @Product_Id";

            DeclareSqlCmdParameter(sqlCmd, product);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadProductTableForAllDataByProductCode(DEProduct product)
        {
            DataTable dt_Product;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Pro.Product_Id,Pro.Product_Code,Pro.Product_Description,Pro.Unit_Weight,Pro.NoOfUnitsPerCarton,Pro.Unit_Price,Pro.Carton_Price,Pro.CartonPrice_Buying,Pro.Catagory_Id,Cat.Catagory_Description,Pro.Active,Pro.ModifiedBy,Pro.ModifiedDate, Pro.Unit_Price2, Pro.Carton_Price2, Pro.MinLVL, Pro.ReorderCtn, Pro.SrNo FROM tbl_Product Pro LEFT JOIN tbl_Catagory Cat on Pro.Catagory_Id = Cat.Catagory_Id where Pro.Active = 'true' And Pro.Product_Code  LIKE '%' + @Product_Code+ '%' order by Pro.SrNo";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, product);

            dt_Product = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Product;
        }

        #endregion
    }
}
