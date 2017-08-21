using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
   public class DEStockIn
    {
        #region +++ public access method (Constructor) +++

        public DEStockIn()
        {
            this.StockInId = Guid.Empty;
            this.StockInDate = DEGlobal.dateTime_ToDayDate;
            this.Product_Id = 0;
            this.Product_Code = string.Empty;
            this.Product_Description = string.Empty;
            this.NoOfCartons = 0;
            this.NoOfUnits = 0;
            this.Carton_Price_Buying = 0;
            this.TotalAmount = 0;
            this.Active = false;
            this.ModifiedBy = DEGlobal.str_UserName; ;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Guid StockInId {get; set;}

        public DateTime StockInDate {get; set;}

        public Int32 Product_Id {get; set;}

        public String Product_Code { get; set; }

        public String Product_Description { get; set; }

        public Int32 NoOfCartons {get; set;}

        public Int32 NoOfUnits { get; set; }

        public Decimal Carton_Price_Buying {get; set;}

        public Decimal TotalAmount {get; set;}        

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }


        #endregion
    }
}
