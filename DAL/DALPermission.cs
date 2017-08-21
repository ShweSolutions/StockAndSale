using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALPermission
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEPermission permission)
        {
            SqlCmd.Parameters.AddWithValue("@PermissionId", permission.PermissionId);
            SqlCmd.Parameters.AddWithValue("@Description", permission.Description);            

            return SqlCmd;
        }

        #endregion

        #region  +++ Codes of public access methods +++

        public DataTable LoadPermissionTableForAllData()
        {
            DataTable dt_Permission;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT PermissionId,Description FROM tbl_Permission";

            dt_Permission = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Permission;
        }  

        #endregion



    }
}
