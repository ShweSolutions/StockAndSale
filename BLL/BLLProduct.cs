using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLProduct
    {
        public DataTable LoadProductTableForAllData()
        {
            DALProduct obj_DALProduct = new DALProduct();

            DataTable dt_Product = obj_DALProduct.LoadProductTableForAllData();

            obj_DALProduct = null;

            return dt_Product;
        }

        public Boolean LoadProductRow(DEProduct product)
        {
            DALProduct obj_DALProduct = new DALProduct();

            Boolean bool_HasRows = obj_DALProduct.LoadProductRow(product);

            obj_DALProduct = null;

            return bool_HasRows;
        }

        public int InsertData(DEProduct product)
        {
            DALProduct obj_DALProduct = new DALProduct();

            int int_Result;

            if (product.Product_Id == 0)
                int_Result = obj_DALProduct.InsertData(product);
            else
                int_Result = obj_DALProduct.UpdateData(product);

            obj_DALProduct = null;

            return int_Result;
        }

        public int UpdateData(DEProduct product)
        {
            DALProduct obj_DALProduct = new DALProduct();

            int int_Result = obj_DALProduct.UpdateData(product);

            obj_DALProduct = null;

            return int_Result;
        }

        public int DeleteData(DEProduct product)
        {
            DALProduct obj_DALProduct = new DALProduct();

            int int_Result = obj_DALProduct.DeleteData(product);

            obj_DALProduct = null;

            return int_Result;
        }

        public DataTable LoadProductTableForAllDataByProductCode(DEProduct product)
        {
            DALProduct obj_DALProduct = new DALProduct();

            DataTable dt_Product = obj_DALProduct.LoadProductTableForAllDataByProductCode(product);

            obj_DALProduct = null;

            return dt_Product;
        }
    }
}
