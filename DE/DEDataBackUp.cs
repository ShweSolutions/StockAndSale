using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
  public class DEDataBackUp
    {
        #region +++ Codes of public access methods +++
        /// <summary>
        /// Initialize a object with the default values.
        /// </summary>
      public DEDataBackUp()
        {
            this.DBBackUpName= string.Empty;
            this.DBBackupFilePath = string.Empty;
        }

        #endregion

      #region +++ Properties assigning and retrieving codes +++

      /// <summary>
      /// Codes for assigning and retrieving property "DBBackUpName"
      /// </summary>
      public String  DBBackUpName{ get; set; }

      /// <summary>
      /// Codes for assigning and retrieving property "DBBackupFilePath"
      /// </summary>
      public String DBBackupFilePath { get; set; }
      #endregion
    }
}