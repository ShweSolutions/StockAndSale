using System;
using System.Data;
using System.Data.SqlClient;


namespace StockAndSale
{
    public class DALDataBackUp
    {
        #region +++  Codes of private access methods  +++

        /// <summary>
        /// Create or retrieve parameters' information to execute SQL command.
        /// </summary>
        /// <returns>SqlParameter array containing parameter information</returns>
        private SqlParameter[] DeclareStoreParameter()
        {
            // Create a new parameter list for User object
            SqlParameter[] ParamVariable = new SqlParameter[]   {  
                                                                                                    //new SqlParameter("@ActionID", SqlDbType.TinyInt),
                                                                                                    new SqlParameter("@DBBackUpName", SqlDbType.NVarChar,500),
                                                                                                    new SqlParameter("@DBBackupFilePath", SqlDbType.NVarChar ,500)
                                                                                                };

            return ParamVariable;
        }

        /// <summary>
        /// Assign the parameter values with the data from object.
        /// </summary>
        /// <param name="UserData">Object containing data</param>
        /// <param name="ParameterArray">Parameter array to set the values</param>
        private void AssignStoreParameter(DEDataBackUp DataBackUp, SqlParameter[] ParamVariable)
        {
            ParamVariable[0].Value = DataBackUp.DBBackUpName;
            ParamVariable[1].Value = DataBackUp.DBBackupFilePath;
        }

        #endregion

        /// <summary>
        /// insert one record into tbl_User table
        /// </summary>
        /// <param name="DEUser">DEUser contains data for saving </param>
        /// <returns>return the integer that Prefix a value indicating whether record is executed successfully.</returns>
        public int CreateDBBackupFile(DEDataBackUp DataBackUp)
        {
            // Get a parameter array the values
            SqlParameter[] ParamVariable = DeclareStoreParameter();
            // Set assign the values
            AssignStoreParameter(DataBackUp, ParamVariable);
            // Set the action value to 5 to delete the record
          //  ParamVariable[0].Value =0;

            // Execute the sql command and assign the output value
            int int_Result = SqlHelper.ExecuteNonQuery("sp_DBBackup", CommandType.StoredProcedure, ParamVariable);

            // Cleanup the resources used
            ParamVariable = null;

            // Return from function
            return int_Result;
        }
    }
}
