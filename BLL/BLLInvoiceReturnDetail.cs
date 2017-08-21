using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLInvoiceReturnDetail
    {
        public DataTable LoadInvoiceReturnDetailTableForAllDataByInvoiceId(DEInvoiceReturnDetail invRetDetail)
        {
            DALInvoiceReturnDetail obj_InvoiceReturnDetail = new DALInvoiceReturnDetail();

            DataTable dt_InvoiceReturn = obj_InvoiceReturnDetail.LoadInvoiceReturnDetailTableForAllDataByInvoiceId(invRetDetail);

            obj_InvoiceReturnDetail = null;

            return dt_InvoiceReturn;
        }

        public int InsertData(DEInvoiceReturnDetail invRetDetail)
        {
            DALInvoiceReturnDetail obj_DALInvoiceReturnDetail = new DALInvoiceReturnDetail();

            int int_Result = obj_DALInvoiceReturnDetail.InsertData(invRetDetail);

            obj_DALInvoiceReturnDetail = null;

            return int_Result;
        }

        public int DeleteData(DEInvoiceReturnDetail invRetDetail)
        {
            DALInvoiceReturnDetail obj_DALInvoiceReturnDetail = new DALInvoiceReturnDetail();

            int int_Result = obj_DALInvoiceReturnDetail.DeleteData(invRetDetail);

            obj_DALInvoiceReturnDetail = null;

            return int_Result;
        }

        public int CancelReturnInvoice(DEInvoiceReturnDetail invoiceDetail)
        {
            DALInvoiceReturnDetail obj_DALInvoiceReturnDetail = new DALInvoiceReturnDetail();

            int int_Result = obj_DALInvoiceReturnDetail.CancelReturnInvoice(invoiceDetail);

            obj_DALInvoiceReturnDetail = null;

            return int_Result;
        }

        public DataTable LoadInvoiceReturnDetailTableForAllDataByInvoiceDate(DEInvoiceReturnDetail invoiceReturnDetail, DateTime dateTime_From, DateTime dateTime_To)
        {
            DALInvoiceReturnDetail obj_InvoiceReturnDetail = new DALInvoiceReturnDetail();

            DataTable dt_InvoiceReturn = obj_InvoiceReturnDetail.LoadInvoiceReturnDetailTableForAllDataByInvoiceDate(invoiceReturnDetail, dateTime_From, dateTime_To);

            obj_InvoiceReturnDetail = null;

            return dt_InvoiceReturn;
        }


        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDate(DateTime dateTime_From, DateTime dateTime_To, int int_CategoryId)
        {
            DALInvoiceReturnDetail obj_InvoiceReturnDetail = new DALInvoiceReturnDetail();

            DataTable dt_InvoiceReturn = obj_InvoiceReturnDetail.LoadProductReturnSummaryTableForAllDataByInvoiceDate( dateTime_From, dateTime_To, int_CategoryId);

            obj_InvoiceReturnDetail = null;

            return dt_InvoiceReturn;
        }

    }
}
