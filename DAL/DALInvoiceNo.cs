using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StockAndSale
{
    class DALInvoiceNo
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEInvoiceNo invoiceNo)
        {
            SqlCmd.Parameters.AddWithValue("@Type", invoiceNo.Type);
            SqlCmd.Parameters.AddWithValue("@Year", invoiceNo.Year);
            SqlCmd.Parameters.AddWithValue("@PreFix", invoiceNo.PreFix);
            SqlCmd.Parameters.AddWithValue("@Current_Id", invoiceNo.Current_Id);
            
            return SqlCmd;
        }

        #endregion

        public int UpdateData(DEInvoiceNo invNo, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);
            
            sqlCmd.CommandText = "Update  tbl_InvoiceNo  SET Type = @Type , Year = @Year,  PreFix = @PreFix , Current_Id = @Current_ID where Type = @Type";

            DeclareSqlCmdParameter(sqlCmd, invNo);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public Boolean LoadInvoiceNoRow(DEInvoiceNo invoiceNo)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Type,Year,PreFix,Current_Id FROM tbl_InvoiceNo Where Type=@Type";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, invoiceNo);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                invoiceNo.Type = sqlDataReader.GetInt32(0);
                invoiceNo.Year = sqlDataReader.GetInt32(1);
                invoiceNo.PreFix = sqlDataReader.GetString(2);
                invoiceNo.Current_Id = sqlDataReader.GetInt32(3);               
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }
    }
}
