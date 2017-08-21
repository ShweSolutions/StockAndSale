using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEInvoiceReturnDetail
    {
        #region +++ public access method (Constructor) +++

        public DEInvoiceReturnDetail()
        {
            this.InvoiceReturnDetail_Id = Guid.Empty;
            this.Invoice_Id = Guid.Empty;
            this.Product_Id = 0;
            this.isCarton = false;
            this.Qty = 0;
            this.Price = 0;
            this.Amount = 0;
            this.Active = true;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++

        public Guid InvoiceReturnDetail_Id { get; set; }

        public Guid Invoice_Id {get; set;}

        public Int32 Product_Id {get; set;}

        public Boolean isCarton {get; set;}

        public Int32 Qty {get; set;}

        public Decimal Price {get; set;}

        public Decimal Amount {get; set;}

        public Boolean Active { get; set; }

        public DateTime ModifiedDate { get; set; }

        #endregion
    }
}
