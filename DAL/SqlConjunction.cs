using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace StockAndSale
{
    class SqlConjunction
    {
        public static string DataConn = ConfigurationManager.AppSettings.Get("SQLConnection");

        public static int GetSQLInt(SqlCommand SqlCmd)
        {
            int i = 0;
            SqlConnection cn = new SqlConnection(DataConn);
            SqlCmd.Connection = cn;
            try
            {
                cn.Open();
                SqlDataReader sdr = SqlCmd.ExecuteReader();
                while (sdr.Read())
                {
                    if (!(sdr[0].ToString() == "" || sdr[0].ToString().Equals("") || sdr[0].ToString().Equals(null)))
                    {
                        i = int.Parse(sdr[0].ToString());
                    }
                    else
                    {
                        return i;
                    }
                }
            }
            catch (SqlException sqx)
            {
                throw sqx;

            }
            finally
            {
                cn.Close();
            }
            return i;
        }

        public static long GetSQLLong(SqlCommand SqlCmd)
        {
            long i = 0;
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(DataConn);
            SqlDataAdapter sqlAdt = new SqlDataAdapter(SqlCmd);
            SqlCmd.Connection = cn;
            try
            {

                cn.Open();
                SqlCmd.ExecuteNonQuery();
                sqlAdt.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    i = long.Parse(dt.Rows[0][0].ToString());
                }
                else
                {
                    i = 0;
                }

            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                cn.Close();
            }
            return i;
        }

        public static DataTable GetSQLTransDataTable(SqlCommand sqlCmd)
        {
            DataTable dt = new DataTable();            
            SqlDataAdapter sqlAdt = new SqlDataAdapter(sqlCmd);

            try
            {                
                sqlCmd.ExecuteNonQuery();
                sqlAdt.Fill(dt);
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                
            }

            return dt;
        }

        public static int GetSQLTransVoid(SqlCommand sqlCmd)
        {
            int int_Result = 0;
            try
            {
                int_Result = sqlCmd.ExecuteNonQuery();
            }
            catch (SqlException sqx)
            {
                throw sqx;
                //MessageBox.Show(sqx.Message + sqx.Source);
            }
            finally
            {
                // sqlCon.Close();
            }

            return int_Result;
        }



        public static int GetSQLVoid(SqlCommand sqlCmd)
        {
            int int_Result = 0;
            SqlConnection sqlCon = new SqlConnection(DataConn);
            sqlCmd.Connection = sqlCon;

            try
            {
                sqlCon.Open();
                int_Result = sqlCmd.ExecuteNonQuery();

            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                sqlCon.Close();
            }

            return int_Result;
        }

        public static string GetSQLString(SqlCommand SqlCmd)
        {
            string str = "";
            SqlConnection con = new SqlConnection(DataConn);
            SqlCmd.Connection = con;
            try
            {
                con.Open();
                SqlDataReader sdr = SqlCmd.ExecuteReader();
                while (sdr.Read())
                {
                    str = sdr[0].ToString();
                }
            }
            catch (SqlException sqx)
            {
                throw sqx;

            }
            finally
            {
                con.Close();
            }
            return str;
        }

        public static DataTable GetSQLDataTable(SqlCommand sqlCmd)
        {
            DataTable dt = new DataTable();
            SqlConnection sqlCon = new SqlConnection(DataConn);
            sqlCmd.Connection = sqlCon;
            SqlDataAdapter sqlAdt = new SqlDataAdapter(sqlCmd);

            try
            {
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                sqlAdt.Fill(dt);
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                sqlCon.Close();
            }

            return dt;
        }

        public static SqlDataReader GetSQLExecuteReader(SqlCommand sqlCmd, SqlConnection sqlCon)
        {
            SqlDataReader sqlDataReader = null;
            sqlCmd.Connection = sqlCon;

            try
            {
                sqlCon.Open();
                sqlDataReader = sqlCmd.ExecuteReader();
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                //sqlCon.Close();
            }

            return sqlDataReader;
        }

        public static int GetSQLDecimal(SqlCommand SqlCmd)
        {
            int i = 0;
            SqlConnection cn = new SqlConnection(DataConn);
            SqlCmd.Connection = cn;
            try
            {
                cn.Open();
                SqlDataReader sdr = SqlCmd.ExecuteReader();
                while (sdr.Read())
                {
                    i = int.Parse(sdr[0].ToString());
                }
            }
            catch (SqlException sqx)
            {
                throw sqx;
            }
            finally
            {
                cn.Close();
            }
            return i;
        }

        public static SqlConnection GetSqlConnection()
        {

            SqlConnection SqlCon = new SqlConnection(DataConn);

            return SqlCon;

        }

    }
}
