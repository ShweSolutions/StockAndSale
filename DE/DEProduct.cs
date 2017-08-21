using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEProduct
    {
        #region +++ public access method (Constructor) +++

        public DEProduct()
        {
            this.Product_Id = 0;
            this.Product_Code = string.Empty;
            this.Product_Description = string.Empty;
            this.Unit_Weight = 0;
            this.NoOfUnitsPerCarton = 0;
            this.Unit_Price = 0;
            this.Carton_Price = 0;
            this.CartonPrice_Buying = 0;
            this.Catagory_Id = 0;            
            this.Active = true;
            this.ModifiedBy = DEGlobal.str_UserName;
            this.ModifiedDate = DEGlobal.dateTime_ToDayDate;
            this.Unit_Price2 = 0;
            this.Carton_Price2 = 0;
            this.MinLVL = 0;
            this.ReorderCtn = 0;
            this.SrNo = 0;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 Product_Id {get; set;}

        public String Product_Code {get; set;}

        public String Product_Description {get; set;}
        
        public Decimal Unit_Weight {get; set;}

        public Int32 NoOfUnitsPerCarton {get; set;}

        public Decimal Unit_Price {get; set;}

        public Decimal Carton_Price {get; set;}

        public Decimal CartonPrice_Buying {get; set;}

        public Int32 Catagory_Id {get; set;}

        public String Catagory_Description { get; set; }

        public Boolean Active { get; set; }

        public String ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        public Decimal Unit_Price2 { get; set; }

        public Decimal Carton_Price2 { get; set; }

        public Int32 MinLVL { get; set; }

        public Int32 ReorderCtn { get; set; }

        public Int32 SrNo { get; set; }


        #endregion
    }
}
