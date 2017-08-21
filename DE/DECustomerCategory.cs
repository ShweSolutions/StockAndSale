using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DECustomerCategory
    {
        #region +++ public access method (Constructor) +++

        public DECustomerCategory()
        {
            this.Catagory_Id = 0;
            this.Catagory_Description = string.Empty;
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 Catagory_Id {get; set;}

        public String Catagory_Description {get; set;}

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        #endregion
    }
}
