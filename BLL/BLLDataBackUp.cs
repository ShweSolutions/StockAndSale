using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    public class BLLDataBackUp
    {
        /// Create DataBase Backup File
        /// </summary>
        /// <param name="str_DBBackupName">String  str_DBBackupName for retrieving</param>
        /// <param name="str_DBBackupFilePath">String  str_DBBackupFilePath  for retrieving</param>
        /// <returns></returns>
        public int CreateDBBackupFile(DEDataBackUp DataBackUp)
        {
            // Create an instance of BrowserInfo's data access component
            DALDataBackUp obj_DALDataBackUp= new DALDataBackUp();

            // Read from database            
            int int_Result = obj_DALDataBackUp.CreateDBBackupFile(DataBackUp);

            // Cleanup the resources used
            obj_DALDataBackUp = null;

            // Return from function
            return int_Result;
        }

        }
    }
