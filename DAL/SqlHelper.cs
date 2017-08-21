#region ===============Source Code Information===================
/*
=======================================================
    Solution Name    :   BDC
	Project Name     :   DAL (Data Access Layer)
    Code Platform    :   Microsoft Visual C#.NET 2008
	File Name        :   SqlHelper.cs
=======================================================
    Author			 :   Min Thein Than
	Created Date	 :   16-Mar-2011	   
=======================================================
    Maintained Method(or)Event  Description Remark ModifiedBy ModifiedDate
=======================================================

*/

#endregion
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StockAndSale
{
    public abstract class SqlHelper
    {
        //public static string str_ConString = System.Configuration.ConfigurationManager.AppSettings.Get("ServerName");
        //public static string str_ConString = "";
        public static string str_ConString = ConfigurationManager.AppSettings.Get("SQLConnection");
        private static void AssignSQLCommand(SqlConnection SqlCon, SqlCommand SqlCmd, CommandType SqlCmdType, String SqlText, SqlParameter[] ParamGroup)
        {
            if (SqlCon.State == ConnectionState.Closed)
            SqlCon.Open();
            SqlCmd.CommandText = SqlText;
            SqlCmd.CommandType = SqlCmdType;
            SqlCmd.Connection = SqlCon;
            if (ParamGroup != null)
                foreach (SqlParameter ParamItem in ParamGroup)
                    SqlCmd.Parameters.Add(ParamItem);

        }

        private static void AssignSQLCommand(SqlConnection SqlCon, SqlCommand SqlCmd, CommandType SqlCmdType, String SqlText, SqlParameter[] ParamGroup, SqlTransaction SqlTran)
        {

            if (SqlCon.State == ConnectionState.Closed)
            SqlCon.Open();
            SqlCmd.CommandText = SqlText;
            SqlCmd.CommandType = SqlCmdType;
            SqlCmd.Connection = SqlCon;
            if (SqlTran.Connection != null)
                SqlCmd.Transaction = SqlTran;
            if (ParamGroup != null)
                foreach (SqlParameter ParamItem in ParamGroup)
                    SqlCmd.Parameters.Add(ParamItem);
        }

        public static int ExecuteNonQuery(String SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup)
        {

            int int_Affect;

            using (SqlConnection SqlCon = new SqlConnection(str_ConString))
            {
                SqlCommand SqlCmd = new SqlCommand();
                try
                {
                    AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);

                    int_Affect = SqlCmd.ExecuteNonQuery();
                }
                catch (Exception EX)
                {
                    if (SqlCon.State == ConnectionState.Open)
                        SqlCon.Close();
                    throw EX;
                }
                finally
                {
                    SqlCmd.Parameters.Clear();
                    SqlCmd.Dispose();
                    SqlCon.Dispose();
                }
            }

            return int_Affect;
        }

        public static SqlDataReader ExecuteReader(string SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup)
        {

            SqlDataReader SqlReader;

            SqlConnection SqlCon = new SqlConnection(str_ConString);

            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);

                SqlReader = SqlCmd.ExecuteReader(CommandBehavior.CloseConnection);

            }
            catch (Exception EX)
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
                throw EX;
            }
            finally
            {
                SqlCmd.Parameters.Clear();
                SqlCmd.Dispose();
            }
            return SqlReader;

        }
        public static object ExecuteScalar(string SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup)
        {

            object obj_Prefix;

            SqlConnection SqlCon = new SqlConnection(str_ConString);

            SqlCommand SqlCmd = new SqlCommand();

            try
            {

                AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);

                obj_Prefix = SqlCmd.ExecuteScalar();

            }
            catch (Exception EX)
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
                throw EX;
            }
            finally
            {
                SqlCmd.Parameters.Clear();
                SqlCmd.Dispose();
                SqlCon.Dispose();
            }

            return obj_Prefix;

        }

        public static DataTable ExecuteDataTable(string SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup)
        {

            DataTable dt_Table = new DataTable();

            SqlConnection SqlCon = new SqlConnection(str_ConString);

            SqlCommand SqlCmd = new SqlCommand();

            SqlDataAdapter da_DataAdapter = new SqlDataAdapter();

            try
            {
                AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);
                da_DataAdapter.SelectCommand = SqlCmd;
                da_DataAdapter.Fill(dt_Table);
            }
            catch (Exception EX)
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
                    throw EX;
            }
            finally
            {
                SqlCmd.Parameters.Clear();
                SqlCmd.Dispose();
                SqlCon.Dispose();
                da_DataAdapter.Dispose();
            }

            return dt_Table;
        }


        public static DataSet ExecuteDataSet(string SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup)
        {

            SqlConnection SqlCon = new SqlConnection(str_ConString);

            SqlCommand SqlCmd = new SqlCommand();

            SqlDataAdapter da_DataAdapter = new SqlDataAdapter();

            DataSet ds_DataSet = new DataSet();

            try
            {
                AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);
                da_DataAdapter.SelectCommand = SqlCmd;
                da_DataAdapter.Fill(ds_DataSet);
            }
            catch (Exception EX)
            {
                if (SqlCon.State == ConnectionState.Open)
                    SqlCon.Close();
                throw EX;
            }
            finally
            {
                SqlCmd.Parameters.Clear();
                SqlCmd.Dispose();
                SqlCon.Dispose();
                da_DataAdapter.Dispose();
            }

            return ds_DataSet;

        }

        public static int ExecuteNonQuery(String SqlText, CommandType SqlCmdType, SqlParameter[] Paramgroup, SqlTransaction SqlTrans)
        {

            int int_Affect;

            SqlConnection SqlCon = new SqlConnection(str_ConString);
            SqlCommand SqlCmd = new SqlCommand();

            try
            {
                if (SqlTrans == null)
                    AssignSQLCommand(SqlCon, SqlCmd, SqlCmdType, SqlText, Paramgroup);
                else
                    AssignSQLCommand(SqlTrans.Connection, SqlCmd, SqlCmdType, SqlText, Paramgroup, SqlTrans);

                int_Affect = SqlCmd.ExecuteNonQuery();
            }
            catch (Exception EX)
            {
                throw EX;
            }
            finally
            {
                SqlCmd.Parameters.Clear();
                SqlCmd.Dispose();
                SqlCon.Dispose();
            }

            return int_Affect;
        }
    }
}
