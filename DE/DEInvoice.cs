using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    public class DEInvoice
    {
        #region +++ public access method (Constructor) +++

        public DEInvoice()
        {
            this.Invoice_Id = Guid.Empty;
            this.Invoice_No = string.Empty;
            this.Invoice_Date = DEGlobal.dateTime_ToDayDate;
            this.Customer_Name = string.Empty;
            this.Customer_Id = 0;
            this.Customer_Description = string.Empty;
            this.Address = string.Empty;
            this.Phone = string.Empty;
            this.Total = 0;
            this.Advance = 0;
            this.DiscountPercent = 0;
            this.Discount = 0;
            this.GrandTotal = 0;
            this.InvoiceType_Id = 0;
            this.InvoiceType_Description = string.Empty;
            this.Invoice_Due_Date = DEGlobal.dateTime_ToDayDate;
            this.isPaid = false;
            this.PayDate = DEGlobal.dateTime_DefaultDate;
            this.isReturn = false;
            this.Remark = string.Empty;
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
            this.IsPromotion = false;
            this.PromDesc = string.Empty;
            this.PONumber = string.Empty;
            this.CommercialTax = 0;
            this.DeliveryDiscount = 0;
            this.DDPercent = 0;
            this.IsInclusiveTax = false;
            this.IsSample = false;

        }

        #endregion

        #region +++ properties declaration +++
        
        public Guid Invoice_Id {get; set;}

        public String Invoice_No {get; set;}

        public DateTime Invoice_Date {get; set;}

        public String Customer_Name {get; set;}

        public Int32 Customer_Id {get; set;}

        public String Customer_Description { get; set; }

        public String Address { get; set; }

        public String Phone { get; set; }

        public Decimal Total {get; set;}
        
        public Decimal Advance {get; set;}

        public Decimal DiscountPercent { get; set; }
        
        public Decimal Discount {get; set;}

        public Decimal GrandTotal {get; set;}

        public Int32 InvoiceType_Id {get; set;}

        public String InvoiceType_Description { get; set; }

        public DateTime Invoice_Due_Date {get; set;}

        public Boolean isPaid {get; set;}

        public DateTime PayDate {get; set;}

        public Boolean isReturn { get; set; }

        public String Remark { get; set; }

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Boolean IsPromotion { get; set; }

        public String PromDesc { get; set; }

        public String PONumber { get; set; }

        public Decimal CommercialTax { get; set; }

        public Decimal DeliveryDiscount { get; set; }

        public Decimal DDPercent { get; set; }

        public Boolean IsInclusiveTax { get; set; }

        public Boolean IsSample { get; set; }

        #endregion
    }
}
