using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEUserPermission
    {
        #region +++ public access method (Constructor) +++

        public DEUserPermission()
        {
            this.UserId = Guid.Empty;
            this.PermissionId = 0;            
        }

        #endregion

        #region +++ properties declaration +++
        
        public Guid UserId {get; set;}

        public Int32 PermissionId {get; set;}

        #endregion
    }
}
