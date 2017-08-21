using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLCatagory
    {
        public DataTable LoadCatagoryTableForAllData()
        {
            DALCatagory obj_DALCatagory = new DALCatagory();

            DataTable dt_Catagory = obj_DALCatagory.LoadCatagoryTableForAllData();

            obj_DALCatagory = null;

            return dt_Catagory;
        }

        public Boolean LoadCatagoryRow(DECatagory catagory)
        {            
            DALCatagory obj_DALCatagory = new DALCatagory();

            Boolean bool_HasRows = obj_DALCatagory.LoadCatagoryRow(catagory);

            obj_DALCatagory = null;
                        
            return bool_HasRows;
        }

        public int InsertData(DECatagory catagory)
        {
            DALCatagory obj_DALCatagory = new DALCatagory();

            int int_Result;

            if (catagory.Catagory_Id == 0)
                int_Result = obj_DALCatagory.InsertData(catagory);
            else
                int_Result = obj_DALCatagory.UpdateData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public int UpdateData(DECatagory catagory)
        {
            DALCatagory obj_DALCatagory = new DALCatagory();

            int int_Result = obj_DALCatagory.UpdateData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public int DeleteData(DECatagory catagory)
        {
            DALCatagory obj_DALCatagory = new DALCatagory();

            int int_Result = obj_DALCatagory.DeleteData(catagory);

            obj_DALCatagory = null;

            return int_Result;
        }

        public DataTable LoadCatagoryTableForAllDataByCatagoryDescription(DECatagory catagory)
        {
            DALCatagory obj_DALCatagory = new DALCatagory();

            DataTable dt_Catagory = obj_DALCatagory.LoadCatagoryTableForAllDataByCatagoryDescription(catagory);

            obj_DALCatagory = null;

            return dt_Catagory;
        }

    }
}
