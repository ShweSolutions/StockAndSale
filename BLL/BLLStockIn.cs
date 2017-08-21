using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLStockIn
    {
        public int InsertData(DEStockIn stockIn)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            int int_Result = obj_DALStockIn.InsertData(stockIn);

            obj_DALStockIn = null;

            return int_Result;
        }

        public DataTable LoadStockTableForAllDataByInDateAndProductCode(DateTime dateTime_From, DateTime dateTime_To, String product_Code)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            DataTable dt_StockIn = obj_DALStockIn.LoadStockTableForAllDataByInDateAndProductCode(dateTime_From, dateTime_To, product_Code);

            obj_DALStockIn = null;

            return dt_StockIn;
        }

        public int UpdateData(DEStockIn stockIn)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            int int_Result = obj_DALStockIn.UpdateData(stockIn);

            obj_DALStockIn = null;

            return int_Result;
        }

        public DataTable LoadStockTableForAllDataByInDateAndProductCode(DEStockIn stockIn)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            DataTable dt_StockIn = obj_DALStockIn.LoadStockTableForAllDataByInDateAndProductCode(stockIn);

            obj_DALStockIn = null;

            return dt_StockIn;
        }

        public DataTable LoadStockTableForAllData(DEStockIn stockIn)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            DataTable dt_StockIn = obj_DALStockIn.LoadStockTableForAllData(stockIn);

            obj_DALStockIn = null;

            return dt_StockIn;
        }

        public Boolean LoadStockInRow(DEStockIn stockIn)
        {
            DALStockIn obj_DALStockIn = new DALStockIn();

            Boolean bool_HasRow = obj_DALStockIn.LoadStockInRow(stockIn);

            obj_DALStockIn = null;

            return bool_HasRow;
        }
    }
}
