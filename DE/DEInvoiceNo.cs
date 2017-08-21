using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEInvoiceNo
    {

        #region +++ public access method (Constructor) +++

        public DEInvoiceNo()
        {
            this.Type = 0;
            this.Year = DateTime.Today.Year;
            this.PreFix = string.Empty;
            this.Current_Id = 0;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 Type {get; set;}

        public Int32 Year {get; set;}

        public String PreFix { get; set; }

        public Int32 Current_Id { get; set; }

        #endregion
    }
}
