using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALCustomer
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DECustomer customer)
        {
            SqlCmd.Parameters.AddWithValue("@Customer_Id", customer.Customer_Id);
            SqlCmd.Parameters.AddWithValue("@Customer_Description", customer.Customer_Description);
            SqlCmd.Parameters.AddWithValue("@Address", customer.Address);
            SqlCmd.Parameters.AddWithValue("@Phone", customer.Phone);
            SqlCmd.Parameters.AddWithValue("@Catagory_Id", customer.Catagory_Id);
            SqlCmd.Parameters.AddWithValue("@Active", customer.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", customer.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", customer.ModifiedDate);

            return SqlCmd;
        }

        #endregion

        #region +++  Codes of public access methods  +++

        public DataTable LoadCustomerTableForAllData()
        {
            DataTable dt_Customer;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Cus.Customer_Id,Cus.Customer_Description,Cus.Address,Cus.Phone, Cus.Catagory_Id,Cat.Catagory_Description,Cus.Active,Cus.ModifiedBy,Cus.ModifiedDate FROM tbl_Customer Cus LEFT JOIN tbl_CustomerCatagory Cat on Cus.Catagory_Id = Cat.Catagory_Id where Cus.Active = 'true' order by Cus.Customer_Description";

            dt_Customer = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Customer;
        }


        public Boolean LoadCustomerRow(DECustomer customer)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Cus.Customer_Id,Cus.Customer_Description,Cus.Address,Cus.Phone, Cus.Catagory_Id,Cat.Catagory_Description, Cus.Active,Cus.ModifiedBy,Cus.ModifiedDate FROM tbl_Customer Cus LEFT JOIN tbl_CustomerCatagory Cat on Cus.Catagory_Id = Cat.Catagory_Id Where Customer_Id=@Customer_Id";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, customer);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                customer.Customer_Id = sqlDataReader.GetInt32(0);
                customer.Customer_Description = sqlDataReader.GetString(1);
                customer.Address = sqlDataReader.GetString(2);
                customer.Phone = sqlDataReader.GetString(3);
                customer.Catagory_Id = sqlDataReader.GetInt32(4);
                //customer.Catagory_Description = sqlDataReader.GetString(5);
                customer.Active = sqlDataReader.GetBoolean(6);
                customer.ModifiedBy = sqlDataReader.GetString(7);
                customer.ModifiedDate = sqlDataReader.GetDateTime(8);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public int InsertData(DECustomer customer)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT @Customer_Id = ISNULL(MAX(Customer_Id),0)+1 FROM tbl_Customer INSERT  tbl_Customer  VALUES(@Customer_Id,@Customer_Description,@Address,@Phone,@Active,@ModifiedBy,@ModifiedDate,@Catagory_Id)";

            DeclareSqlCmdParameter(sqlCmd, customer);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }


        public int UpdateData(DECustomer customer)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "UPDATE tbl_Customer SET Customer_Id= @Customer_Id, Customer_Description=@Customer_Description, Address = @Address, Phone = @Phone, Active = @Active ,ModifiedBy = @ModifiedBy ,ModifiedDate = @ModifiedDate, Catagory_Id = @Catagory_Id WHERE Customer_Id = @Customer_Id";

            DeclareSqlCmdParameter(sqlCmd, customer);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int DeleteData(DECustomer customer)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "DELETE FROM tbl_Customer  WHERE Customer_Id = @Customer_Id";

            DeclareSqlCmdParameter(sqlCmd, customer);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int UpdateCustomerOnlyActiveByCustomerId(DECustomer customer)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "UPDATE tbl_Customer SET Active = @Active WHERE Customer_Id = @Customer_Id";

            DeclareSqlCmdParameter(sqlCmd, customer);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadCustomerTableForAllDataByCustomerDescription(DECustomer customer)
        {
            DataTable dt_Customer;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',Cus.Customer_Id,Cus.Customer_Description,Cus.Address,Cus.Phone,Cus.Catagory_Id,Cat.Catagory_Description, Cus.Active,Cus.ModifiedBy,Cus.ModifiedDate FROM tbl_Customer Cus LEFT JOIN tbl_CustomerCatagory Cat on Cus.Catagory_Id = Cat.Catagory_Id where Cus.Active = 'true' And	Cus.Customer_Description  LIKE '%' + @Customer_Description+ '%' order by Cus.Customer_Description";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, customer);

            dt_Customer = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Customer;
        }

        #endregion
    }
}
