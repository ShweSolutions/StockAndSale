using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLCustomerCategory
    {
        public DataTable LoadCatagoryTableForAllData()
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            DataTable dt_Catagory = obj_DALCatagory.LoadCatagoryTableForAllData();

            obj_DALCatagory = null;

            return dt_Catagory;
        }

        public Boolean LoadCatagoryRow(DECustomerCategory catagory)
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            Boolean bool_HasRows = obj_DALCatagory.LoadCatagoryRow(catagory);

            obj_DALCatagory = null;

            return bool_HasRows;
        }

        public int InsertData(DECustomerCategory catagory)
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            int int_Result;

            if (catagory.Catagory_Id == 0)
                int_Result = obj_DALCatagory.InsertData(catagory);
            else
                int_Result = obj_DALCatagory.UpdateData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public int UpdateData(DECustomerCategory catagory)
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            int int_Result = obj_DALCatagory.UpdateData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public int DeleteData(DECustomerCategory catagory)
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            int int_Result = obj_DALCatagory.DeleteData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public DataTable LoadCatagoryTableForAllDataByCatagoryDescription(DECustomerCategory catagory)
        {
            DALCustomerCategory obj_DALCatagory = new DALCustomerCategory();

            DataTable dt_Catagory = obj_DALCatagory.LoadCatagoryTableForAllDataByCatagoryDescription(catagory);

            obj_DALCatagory = null;

            return dt_Catagory;
        }
    }
}
