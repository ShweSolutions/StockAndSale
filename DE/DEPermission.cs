using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEPermission
    {
         #region +++ public access method (Constructor) +++

        public DEPermission()
        {
            this.PermissionId = 0;
            this.Description = string.Empty;            
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 PermissionId {get; set;}

        public String Description {get; set;}

        #endregion
    }
}
