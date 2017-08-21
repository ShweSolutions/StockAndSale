using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StockAndSale
{
    class DEProductInStore
    {
        #region +++ public access method (Constructor) +++

        public DEProductInStore()
        {
            this.Product_Id = 0;            
            this.NoOfUnits = 0;
        }

        #endregion

        #region +++ properties declaration +++
        
        public Int32 Product_Id {get; set;}        

        public Int32 NoOfUnits {get; set;}

        #endregion
    }
}
