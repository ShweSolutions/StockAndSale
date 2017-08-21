using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace StockAndSale
{
    class DALUserPermission
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEUserPermission userPermission)
        {
            SqlCmd.Parameters.AddWithValue("@UserId", userPermission.UserId);
            SqlCmd.Parameters.AddWithValue("@PermissionId", userPermission.PermissionId);           

            return SqlCmd;
        }

        #endregion

        public int InsertData(DEUserPermission userPermission, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_UserPermission  VALUES(@UserId,@PermissionId)";

            DeclareSqlCmdParameter(sqlCmd, userPermission);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int DeleteData(DEUserPermission userPermission, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Delete  tbl_UserPermission  where UserId = @UserId";

            DeclareSqlCmdParameter(sqlCmd, userPermission);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }
    }
}
