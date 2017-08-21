using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLCustomer
    {
        public DataTable LoadCustomerTableForAllData()
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            DataTable dt_Customer = obj_DALCustomer.LoadCustomerTableForAllData();

            obj_DALCustomer = null;

            return dt_Customer;
        }

        public Boolean LoadCustomerRow(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            Boolean bool_HasRows = obj_DALCustomer.LoadCustomerRow(customer);

            obj_DALCustomer = null;

            return bool_HasRows;
        }

        public int InsertData(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            int int_Result;

            if (customer.Customer_Id == 0)
                int_Result = obj_DALCustomer.InsertData(customer);
            else
                int_Result = obj_DALCustomer.UpdateData(customer);

            obj_DALCustomer = null;

            return int_Result;
        }

        public int UpdateData(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            int int_Result = obj_DALCustomer.UpdateData(customer);

            obj_DALCustomer = null;

            return int_Result;
        }

        public int DeleteData(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            int int_Result = obj_DALCustomer.DeleteData(customer);

            obj_DALCustomer = null;

            return int_Result;
        }

        public DataTable LoadCustomerTableForAllDataByCustomerDescription(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            DataTable dt_Customer = obj_DALCustomer.LoadCustomerTableForAllDataByCustomerDescription(customer);

            obj_DALCustomer = null;

            return dt_Customer;
        }

        public int UpdateCustomerOnlyActiveByCustomerId(DECustomer customer)
        {
            DALCustomer obj_DALCustomer = new DALCustomer();

            int int_Result = obj_DALCustomer.UpdateCustomerOnlyActiveByCustomerId(customer);

            obj_DALCustomer = null;

            return int_Result;
        }
    }
}
