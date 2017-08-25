using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLInvoice
    {
        public int InsertData(DEInvoice inv, DEInvoiceNo invNo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            int int_Result = obj_DALInvoice.InsertData(inv, invNo);

            obj_DALInvoice = null;

            return int_Result;
        }

        public int UpdateData(DEInvoice inv)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            int int_Result = obj_DALInvoice.UpdateData(inv);

            obj_DALInvoice = null;

            return int_Result;
        }

        public DataTable LoadInvoiceTableForAllDataByInvoice_Id(DEInvoice inv)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByInvoice_Id(inv);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByInvoice_No(DEInvoice inv)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByInvoice_No(inv);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public Boolean LoadInvoiceRow(DEInvoice inv)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            Boolean bool_HasRow = obj_DALInvoice.LoadInvoiceRow(inv);

            obj_DALInvoice = null;

            return bool_HasRow;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id,String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To,dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id,user,str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(dateTime_From, dateTime_To, dateTime_Current, int_CustomerGroupId, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user,str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionOnly(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotion(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSampleOnly(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSample(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterCancelInvoice(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterCancelInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilter(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date,String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date,user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadPaidInvoiceTableForAllDataByFilter(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadPaidInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroupId, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadPaidInvoiceTableForAllDataByFilterByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroupId, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterSampleInvoice(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterSampleInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterForPromotionOnly(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterForPromotion(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterForPromotionAndSampleOnly(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date, String user, String str_PONo)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterForPromotionAndSample(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        //public DataTable LoadInvoiceTableForAllDataByFilter(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_Due_Date,String user)
        //{
        //    DALInvoice obj_DALInvoice = new DALInvoice();

        //    DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date,user);

        //    obj_DALInvoice = null;

        //    return dt_Invoice;
        //}

        public DataTable LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, Boolean bool_isPaid)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_DueDate , user,bool_isPaid);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, Boolean bool_isPaid)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroupId, str_InvoiceNo, int_InvoiceType_Id, dateTime_DueDate, user, bool_isPaid);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        


        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerId(Int32 CustomerId, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerId(CustomerId,dateTime_From, dateTime_To,Category_Id);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerGroupId(Int32 CustomerGroupId, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerGroupId(CustomerGroupId, dateTime_From, dateTime_To, Category_Id);

            obj_DALInvoice = null;

            return dt_Invoice;
        }


        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerId(Int32 Customer_Id, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerId(Customer_Id, dateTime_From, dateTime_To,Category_Id);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerGroupId(Int32 CustomerGroup_Id, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)
        {
            DALInvoice obj_DALInvoice = new DALInvoice();

            DataTable dt_Invoice = obj_DALInvoice.LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerGroupId(CustomerGroup_Id, dateTime_From, dateTime_To, Category_Id);

            obj_DALInvoice = null;

            return dt_Invoice;
        }

    }
}
