using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEInvoiceType
    {
        #region +++ public access method (Constructor) +++

        public DEInvoiceType()
        {
            this.InvoiceType_Id = 0;
            this.InvoiceType_Description = string.Empty;
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 InvoiceType_Id {get; set;}

        public String InvoiceType_Description {get; set;}

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        #endregion
    }
}
