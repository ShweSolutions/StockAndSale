using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLCustomerReturn
    {
        public int InsertData(DECustomerReturn cusReturn)
        {
            DALCustomerReturn obj_DALCustomerReturn = new DALCustomerReturn();

            int int_Result = obj_DALCustomerReturn.InsertData(cusReturn);

            obj_DALCustomerReturn = null;

            return int_Result;
        }

        public int DeleteData(DECustomerReturn cusReturn)
        {
            DALCustomerReturn obj_DALCustomerReturn = new DALCustomerReturn();

            int int_Result = obj_DALCustomerReturn.DeleteData(cusReturn);

            obj_DALCustomerReturn = null;

            return int_Result;
        }

        public DataTable LoadCustomerReturnForAllDataByReturnDateAndCustomerIDAndProductCode(DateTime dateTime_From, DateTime dateTime_To, String product_Code, Int32 Customer_Id)
        {
            DALCustomerReturn obj_DALCustomerReturn = new DALCustomerReturn();

            DataTable dt_CustomerReturn = obj_DALCustomerReturn.LoadCustomerReturnForAllDataByReturnDateAndCustomerIDAndProductCode(dateTime_From, dateTime_To, product_Code, Customer_Id);

            obj_DALCustomerReturn = null;

            return dt_CustomerReturn;
        }

        public DataTable LoadCustomerReturnDetailTableForAllDataByReturn(DateTime dateTime_From, DateTime dateTime_To, DECustomerReturn cusRetDetail)
        {
            DALCustomerReturn obj_DALCustomerReturn = new DALCustomerReturn();

            DataTable dt_CustomerReturn = obj_DALCustomerReturn.LoadCustomerReturnDetailTableForAllDataByReturnDateAndCustomerID(dateTime_From, dateTime_To, cusRetDetail);

            obj_DALCustomerReturn = null;

            return dt_CustomerReturn;
        }

    }
}
