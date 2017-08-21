using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DECustomerReturn
    {
        #region +++ public access method (Constructor) +++

        public DECustomerReturn()
        {
            this.CustomerReturn_Id = Guid.Empty;
            this.Customer_Id = 0;
            this.ReturnDate = DEGlobal.dateTime_ToDayDate;
            this.Product_Id = 0;
            this.isCarton = false;
            this.Qty = 0;
            this.Price = 0;
            this.Amount = 0;
            this.Remark = string.Empty;
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++

        public Guid CustomerReturn_Id { get; set; }
        
        public Int32 Customer_Id {get; set;}

        public DateTime ReturnDate {get; set;}

        public Int32 Product_Id {get; set;}

        public Boolean isCarton {get; set;}

        public Int32 Qty {get; set;}

        public Decimal Price {get; set;}

        public Decimal Amount {get; set;}

        public String Remark {get; set;}

        public Boolean Active { get; set; }

        public String ModifiedBy {get; set; }

        public DateTime ModifiedDate { get; set; }

        #endregion
    }
    
}
