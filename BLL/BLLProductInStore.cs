using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLProductInStore
    {
        public DataTable LoadProductInStoreTableForAllDataByCatagoryIdAndProductCode(int int_Catagory_Id, String product_Code)
        {
            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DataTable dt_ProductInStore = obj_DALProductInStore.LoadProductInStoreTableForAllDataByCatagoryIdAndProductCode(int_Catagory_Id, product_Code);

            obj_DALProductInStore = null;

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableMRPModeForAllDataByCatagoryIdAndProductCode(int int_Catagory_Id, String product_Code)
        {
            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DataTable dt_ProductInStore = obj_DALProductInStore.LoadProductInStoreTableMRPModeForAllDataByCatagoryIdAndProductCode(int_Catagory_Id, product_Code);

            obj_DALProductInStore = null;

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableForAllDataByCatagoryIdAndProductCodeAndNoOfUnits(int int_Catagory_Id, String product_Code, int int_noOfUnits)
        {
            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DataTable dt_ProductInStore = obj_DALProductInStore.LoadProductInStoreTableForAllDataByCatagoryIdAndProductCodeAndNoOfUnits(int_Catagory_Id, product_Code,int_noOfUnits);

            obj_DALProductInStore = null;

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableByProductId(DEProductInStore productInStore)
        {
            DALProductInStore obj_DALProductInStore = new DALProductInStore();

            DataTable dt_ProductInStore = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore);

            obj_DALProductInStore = null;

            return dt_ProductInStore;
        }



    }
}
