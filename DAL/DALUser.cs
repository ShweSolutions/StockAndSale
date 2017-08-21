using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALUser
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEUser user)
        {
            SqlCmd.Parameters.AddWithValue("@UserId", user.UserId);
            SqlCmd.Parameters.AddWithValue("@Name", user.Name);
            SqlCmd.Parameters.AddWithValue("@LoginName", user.LoginName);
            SqlCmd.Parameters.AddWithValue("@Password", user.Password);
            SqlCmd.Parameters.AddWithValue("@Active", user.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", user.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", user.ModifiedDate);

            return SqlCmd;
        }

        #endregion

        public DataTable LoadUserTableForAllData()
        {
            DataTable dt_User;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',U.UserId,U.Name,U.LoginName,U.Password,U.Active,U.ModifiedBy,U.ModifiedDate FROM tbl_User U where U.Active = 'true' order by U.Name";

            dt_User = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_User;
        }

        public DataTable LoadUserPermissionTableForAllDataByUserId(DEUser user)
        {
            DataTable dt_UserPermission;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT P.PermissionId as 'No',P.Description as 'Permission' FROM tbl_Permission P LEFT JOIN tbl_UserPermission UP on P.PermissionId = UP.PermissionId where UP.UserId = @UserId";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, user);

            dt_UserPermission = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_UserPermission;
        }

        public Boolean LoadUserRow(DEUser user)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT UserId,Name,LoginName,Password,Active,ModifiedBy,ModifiedDate FROM tbl_User Where UserId=@UserId";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, user);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                user.UserId = sqlDataReader.GetGuid(0);
                user.Name = sqlDataReader.GetString(1);
                user.LoginName = sqlDataReader.GetString(2);
                user.Password = sqlDataReader.GetString(3);
                user.Active = sqlDataReader.GetBoolean(4);
                user.ModifiedBy = sqlDataReader.GetString(5);
                user.ModifiedDate = sqlDataReader.GetDateTime(6);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public Boolean LoadUserRowByLoginName(DEUser user)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT UserId,Name,LoginName,Password,Active,ModifiedBy,ModifiedDate FROM tbl_User Where LoginName=@LoginName";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, user);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                user.UserId = sqlDataReader.GetGuid(0);
                user.Name = sqlDataReader.GetString(1);
                user.LoginName = sqlDataReader.GetString(2);
                user.Password = sqlDataReader.GetString(3);
                user.Active = sqlDataReader.GetBoolean(4);
                user.ModifiedBy = sqlDataReader.GetString(5);
                user.ModifiedDate = sqlDataReader.GetDateTime(6);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }

        public int InsertData(DEUser user, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_User  VALUES(@UserId,@Name,@LoginName,@Password,@Active,@ModifiedBy,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, user);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int UpdateData(DEUser user, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "UPDATE  tbl_User SET UserId = @UserId, Name = @Name, LoginName = @LoginName, Password = @Password, Active = @Active , ModifiedBy = @ModifiedBy, ModifiedDate = @ModifiedDate where UserId = @UserId";

            DeclareSqlCmdParameter(sqlCmd, user);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int InsertData(DEUser user,DataTable dt_Permission)
        {
            int int_Result = 0;

            DALUserPermission obj_DALUserPermission = new DALUserPermission();

            DEUserPermission userPermission = new DEUserPermission();
            userPermission.UserId = user.UserId;

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
                    this.InsertData(user, SqlCon, tn);

                    for (int i = 0; i < dt_Permission.Rows.Count; i++)
                    {
                       userPermission.PermissionId = Convert.ToInt32(dt_Permission.Rows[i][0].ToString());
                       obj_DALUserPermission.InsertData(userPermission, SqlCon, tn);
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
                    obj_DALUserPermission = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        public Boolean LoadUserByLoginNameAndPassword(DEUser user)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT UserId,Name,LoginName,Password,Active,ModifiedBy,ModifiedDate FROM tbl_User Where LoginName=@LoginName And Password = @Password";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, user);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                user.UserId = sqlDataReader.GetGuid(0);
                user.Name = sqlDataReader.GetString(1);
                user.LoginName = sqlDataReader.GetString(2);
                user.Password = sqlDataReader.GetString(3);
                user.Active = sqlDataReader.GetBoolean(4);
                user.ModifiedBy = sqlDataReader.GetString(5);
                user.ModifiedDate = sqlDataReader.GetDateTime(6);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;

        }

        public int UpdateData(DEUser user, DataTable dt_Permission)
        {
            int int_Result = 0;

            DALUserPermission obj_DALUserPermission = new DALUserPermission();

            DEUserPermission userPermission = new DEUserPermission();
            userPermission.UserId = user.UserId;

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
                    this.UpdateData(user, SqlCon, tn);

                    obj_DALUserPermission.DeleteData(userPermission, SqlCon, tn);

                    for (int i = 0; i < dt_Permission.Rows.Count; i++)
                    {
                        userPermission.PermissionId = Convert.ToInt32(dt_Permission.Rows[i][0].ToString());
                        obj_DALUserPermission.InsertData(userPermission, SqlCon, tn);
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
                    obj_DALUserPermission = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

    }
}
