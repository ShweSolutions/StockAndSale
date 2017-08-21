using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLInvoiceDetail
    {
        public int InsertData(DEInvoiceDetail invoiceDetail)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            int int_Result = obj_DALInvoiceDetail.InsertData(invoiceDetail);

            obj_DALInvoiceDetail = null;

            return int_Result;
        }

        public int DeleteData(DEInvoiceDetail invoiceDetail)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            int int_Result = obj_DALInvoiceDetail.DeleteData(invoiceDetail);

            obj_DALInvoiceDetail = null;

            return int_Result;
        }

        public int CancelDetailInvoice(DEInvoiceDetail invoiceDetail)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            int int_Result = obj_DALInvoiceDetail.CancelDetailInvoice(invoiceDetail);

            obj_DALInvoiceDetail = null;

            return int_Result;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceId(DEInvoiceDetail invoiceDetail)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            DataTable dt_InvoiceDetail = obj_DALInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);

            obj_DALInvoiceDetail = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDate(DEInvoiceDetail invoiceDetail, DateTime dateTime_From, DateTime dateTime_To)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            DataTable dt_InvoiceDetail = obj_DALInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceDate(invoiceDetail,dateTime_From,dateTime_To);

            obj_DALInvoiceDetail = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadInvoiceDetailTableForFOCReport(DateTime dateTime_From, DateTime dateTime_To, int customerId, int productId)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            DataTable dt_InvoiceDetail = obj_DALInvoiceDetail.LoadInvoiceDetailTableForFOCReport(dateTime_From, dateTime_To, customerId, productId);

            obj_DALInvoiceDetail = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadInvoiceDetailTableForPromotionReport(DateTime dateTime_From, DateTime dateTime_To, int customerId, int categoryId)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            DataTable dt_InvoiceDetail = obj_DALInvoiceDetail.LoadInvoiceDetailTableForPromotionReport(dateTime_From, dateTime_To, customerId, categoryId);

            obj_DALInvoiceDetail = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadProductSaleSummaryTableForAllDataByInvoiceDate(DateTime dateTime_From, DateTime dateTime_To, int int_CategoryId)
        {
            DALInvoiceDetail obj_DALInvoiceDetail = new DALInvoiceDetail();

            DataTable dt_InvoiceDetail = obj_DALInvoiceDetail.LoadProductSaleSummaryTableForAllDataByInvoiceDate(dateTime_From, dateTime_To,int_CategoryId);

            obj_DALInvoiceDetail = null;

            return dt_InvoiceDetail;
        }



    }
}
