using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEInvoiceDetail
    {
        #region +++ public access method (Constructor) +++

        public DEInvoiceDetail()
        {
            this.InvoiceDetail_Id = Guid.Empty;
            this.Invoice_Id = Guid.Empty;
            this.Product_Id = 0;
            this.isCarton = false;
            this.Qty = 0;
            this.Price = 0;
            this.Amount = 0;
            this.FOC = string.Empty;
            this.Active = true;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++

        public Guid InvoiceDetail_Id { get; set; }
        
        public Guid Invoice_Id {get; set;}

        public Int32 Product_Id {get; set;}

        public Boolean isCarton {get; set;}

        public Int32 Qty {get; set;}

        public Decimal Price {get; set;}

        public Decimal Amount {get; set;}

        public String FOC { get; set; }

        public Boolean Active { get; set; }

        public DateTime ModifiedDate { get; set; }

        #endregion
    }
}
