using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEUser
    {
        #region +++ public access method (Constructor) +++

        public DEUser()
        {
            this.UserId = Guid.Empty;
            this.Name = string.Empty;
            this.LoginName = string.Empty;
            this.Password = string.Empty;
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Guid UserId {get; set;}

        public String Name {get; set;}

        public String LoginName {get; set;}

        public String Password {get; set;}

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        #endregion
    }
}
