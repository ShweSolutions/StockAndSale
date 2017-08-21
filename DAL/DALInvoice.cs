using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALInvoice
    { 
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEInvoice inv)
        {
            SqlCmd.Parameters.AddWithValue("@Invoice_Id", inv.Invoice_Id);
            SqlCmd.Parameters.AddWithValue("@Invoice_No", inv.Invoice_No);
            SqlCmd.Parameters.AddWithValue("@Invoice_Date", inv.Invoice_Date);
            SqlCmd.Parameters.AddWithValue("@Customer_Name", inv.Customer_Name);
            SqlCmd.Parameters.AddWithValue("@Customer_Id", inv.Customer_Id);
            SqlCmd.Parameters.AddWithValue("@Total", inv.Total);
            SqlCmd.Parameters.AddWithValue("@Advance", inv.Advance);
            SqlCmd.Parameters.AddWithValue("@DiscountPercent", inv.DiscountPercent);
            SqlCmd.Parameters.AddWithValue("@Discount", inv.Discount);
            SqlCmd.Parameters.AddWithValue("@GrandTotal", inv.GrandTotal);
            SqlCmd.Parameters.AddWithValue("@InvoiceType_Id", inv.InvoiceType_Id);
            SqlCmd.Parameters.AddWithValue("@Invoice_Due_Date", inv.Invoice_Due_Date);
            SqlCmd.Parameters.AddWithValue("@isPaid", inv.isPaid);
            SqlCmd.Parameters.AddWithValue("@PayDate", inv.PayDate);
            SqlCmd.Parameters.AddWithValue("@isReturn", inv.isReturn);
            SqlCmd.Parameters.AddWithValue("@Remark", inv.Remark);
            SqlCmd.Parameters.AddWithValue("@Active", inv.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", inv.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", inv.ModifiedDate);
            SqlCmd.Parameters.AddWithValue("@IsPromotion", inv.IsPromotion);
            SqlCmd.Parameters.AddWithValue("@PromDesc", inv.PromDesc);
            SqlCmd.Parameters.AddWithValue("@PONumber", inv.PONumber);
            SqlCmd.Parameters.AddWithValue("@CommercialTax", inv.CommercialTax);
            SqlCmd.Parameters.AddWithValue("@DeliveryDiscount", inv.DeliveryDiscount);
            SqlCmd.Parameters.AddWithValue("@DDPercent", inv.DDPercent);
            SqlCmd.Parameters.AddWithValue("@IsInclusiveTax", inv.IsInclusiveTax);
            SqlCmd.Parameters.AddWithValue("@IsSample", inv.IsSample);

            return SqlCmd;
        }
        
        #endregion

        public int InsertData(DEInvoice inv, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_Invoice  VALUES(@Invoice_Id,@Invoice_No,@Invoice_Date,@Customer_Name,@Customer_Id,@Total,@Advance,@DiscountPercent,@Discount,@GrandTotal,@InvoiceType_Id,@Invoice_Due_Date,@isPaid,@PayDate,@isReturn,@Remark,@Active,@ModifiedBy,@ModifiedDate,@IsPromotion,@PromDesc,@PONumber, @CommercialTax, @DeliveryDiscount, @DDPercent, @IsInclusiveTax, @IsSample)";

            DeclareSqlCmdParameter(sqlCmd, inv);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int UpdateData(DEInvoice inv)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "UPDATE tbl_Invoice SET Invoice_Id= @Invoice_Id, Invoice_No=@Invoice_No,Invoice_Date = @Invoice_Date, Customer_Name = @Customer_Name, Customer_Id = @Customer_Id, Total = @Total,Advance = @Advance, DiscountPercent = @DiscountPercent, Discount = @Discount, GrandTotal = @GrandTotal, InvoiceType_Id = @InvoiceType_Id , Invoice_Due_Date = @Invoice_Due_Date, isPaid = @isPaid, isReturn = @isReturn ,PayDate = @PayDate, Remark = @Remark , Active = @Active ,ModifiedBy = @ModifiedBy ,ModifiedDate = @ModifiedDate, IsPromotion = @IsPromotion, PromDesc = @PromDesc, PONumber = @PONumber, CommercialTax = @CommercialTax, DeliveryDiscount = @DeliveryDiscount, DDPercent = @DDPercent, IsInclusiveTax = @IsInclusiveTax, IsSample = @IsSample WHERE Invoice_Id = @Invoice_Id";

            DeclareSqlCmdParameter(sqlCmd, inv);

            int_Result = SqlConjunction.GetSQLVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int InsertData(DEInvoice inv, DEInvoiceNo invNo)
        {
            int int_Result = 0;

            DALInvoiceNo obj_DALInvoiceNo = new DALInvoiceNo();            

            SqlConnection SqlCon = new SqlConnection(SqlConjunction.DataConn);
            try
            {
                if (SqlCon.State != ConnectionState.Open)
                { SqlCon.Open(); }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex);
            }

            SqlTransaction tn = SqlCon.BeginTransaction();

            {
                try
                {
                    this.InsertData(inv, SqlCon, tn);

                    //obj_DALInvoiceNo.UpdateData(invNo, SqlCon, tn);

                    tn.Commit();
                    int_Result = 1;
                }
                catch (Exception ex)
                {
                    tn.Rollback();
                    int_Result = 0;
                    throw (ex);
                }
                finally
                {
                    obj_DALInvoiceNo = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        public DataTable LoadInvoiceTableForAllDataByInvoice_Id(DEInvoice inv)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal, inv.InvoiceType_Id,invType.InvoiceType_Description,inv.Invoice_Due_Date,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,inv.ModifiedBy,inv.ModifiedDate,inv.IsPromotion,inv.PromDesc,inv.PONumber FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id where inv.Invoice_Id = @Invoice_Id And inv.Active = 'true'";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, inv);

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByInvoice_No(DEInvoice inv)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal, inv.InvoiceType_Id,invType.InvoiceType_Description,inv.Invoice_Due_Date,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,inv.ModifiedBy,inv.ModifiedDate FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id where inv.Invoice_No = @Invoice_No And inv.Active = 'true'";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, inv);

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterCancelInvoice(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal, inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,Sum(invRD.Amount) as 'ReturnAmount',inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (inv.Active = 'false') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user,Boolean bool_isPaid)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,Sum(invRD.Amount) as 'ReturnAmount',inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') And (inv.isPaid = '" + bool_isPaid + "') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, Boolean bool_isPaid)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,Sum(invRD.Amount) as 'ReturnAmount',inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Catagory_Id ='" + int_CustomerGroupId + "' OR '" + int_CustomerGroupId + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') And (inv.isPaid = '" + bool_isPaid + "') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilter(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo,int int_InvoiceType_Id,DateTime dateTime_DueDate,String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal,Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal,Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Catagory_Id ='" + int_CustomerGroupId + "' OR '" + int_CustomerGroupId + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterSampleInvoice(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal,Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') And (inv.IsSample = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterForPromotion(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') And (inv.IsPromotion = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterForPromotionAndSample(DateTime dateTime_From, DateTime dateTime_To, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, DateTime dateTime_DueDate, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "') And (inv.Invoice_Due_Date ='" + dateTime_DueDate + "' OR '" + dateTime_DueDate + "'='1/1/1900 12:00:00 AM' ) And (inv.Active = 'true') And (inv.IsPromotion = 'true') And (inv.IsSample = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,inv.Invoice_Date";   //And (inv.Customer_Id <> '0')";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(DateTime dateTime_From, DateTime dateTime_To,DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id,String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "')  And (inv.Invoice_Due_Date <'" + dateTime_Current + "' And inv.isPaid = 'false')  And (inv.Active = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,Invoice_Date"; 

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_CustomerGroupId, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Catagory_Id ='" + int_CustomerGroupId + "' OR '" + int_CustomerGroupId + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "')  And (inv.Invoice_Due_Date <'" + dateTime_Current + "' And inv.isPaid = 'false')  And (inv.Active = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,Invoice_Date";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference' ,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "')  And (inv.Invoice_Due_Date <'" + dateTime_Current + "' And inv.isPaid = 'false')  And (inv.Active = 'true') And (inv.IsSample = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,Invoice_Date";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotion(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference', inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "')  And (inv.Invoice_Due_Date <'" + dateTime_Current + "' And inv.isPaid = 'false')  And (inv.Active = 'true') And (inv.IsPromotion = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,Invoice_Date"; 

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd); 

            sqlCmd = null;

            return dt_Invoice;
        }

        public DataTable LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSample(DateTime dateTime_From, DateTime dateTime_To, DateTime dateTime_Current, int int_Customer_Id, String str_InvoiceNo, int int_InvoiceType_Id, String user, String str_PONo)
        {
            DataTable dt_Invoice;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 as 'No',inv.Invoice_Id,inv.Invoice_No,Convert(nvarchar,inv.Invoice_Date,103) as 'Invoice_Date',Convert(nvarchar,inv.Invoice_Due_Date,103) as 'Invoice_Due_Date',inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.CommercialTax,inv.Discount,inv.DeliveryDiscount,inv.GrandTotal, Sum(invRD.Amount) as 'ReturnAmount',(inv.GrandTotal - Sum(invRD.Amount)) as 'Difference', inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,CASE WHEN inv.isPaid = 'True' then Convert(nvarchar,inv.PayDate,103) ELSE '' END as 'PayDate',inv.isReturn,inv.Remark,inv.Active,U.Name as 'ModifiedBy',inv.ModifiedDate,inv.IsPromotion FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id LEFT JOIN tbl_User U ON inv.ModifiedBy = U.LoginName LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where (inv.ModifiedBy ='" + user + "' OR '" + user + "'='' ) And  (cus.Customer_Id ='" + int_Customer_Id + "' OR '" + int_Customer_Id + "'='0' ) And (inv.Invoice_No  LIKE '%" + str_InvoiceNo + "%' OR  '" + str_InvoiceNo + "'='') And (inv.PONumber  LIKE '%" + str_PONo + "%' OR  '" + str_PONo + "'='')  And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invType.InvoiceType_Id ='" + int_InvoiceType_Id + "')  And (inv.Invoice_Due_Date <'" + dateTime_Current + "' And inv.isPaid = 'false')  And (inv.Active = 'true') And (inv.IsPromotion = 'true') And (inv.IsSample = 'true') group by inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Invoice_Due_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.Discount,inv.GrandTotal,inv.InvoiceType_Id,invType.InvoiceType_Description,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,U.Name,inv.ModifiedDate,inv.IsPromotion,inv.CommercialTax,inv.DeliveryDiscount order by inv.isPaid desc,Invoice_Date";

            dt_Invoice = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_Invoice;
        }

        public Boolean LoadInvoiceRow(DEInvoice inv)
        {
            Boolean bool_HasRows = false;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT inv.Invoice_Id,inv.Invoice_No,inv.Invoice_Date,inv.Customer_Name,inv.Customer_Id,cus.Customer_Description,cus.Address,cus.Phone,inv.Total,inv.Advance,inv.DiscountPercent,inv.Discount,inv.GrandTotal, inv.InvoiceType_Id,invType.InvoiceType_Description,inv.Invoice_Due_Date,inv.isPaid,inv.PayDate,inv.isReturn,inv.Remark,inv.Active,inv.ModifiedBy,inv.ModifiedDate,inv.IsPromotion,inv.PromDesc,inv.PONumber,inv.CommercialTax,inv.DeliveryDiscount,inv.DDPercent,inv.IsInclusiveTax, inv.IsSample FROM tbl_Invoice inv LEFT JOIN tbl_Customer cus ON inv.Customer_Id = cus.Customer_Id LEFT JOIN tbl_InvoiceType invType ON inv.InvoiceType_Id = invType.InvoiceType_Id where inv.Invoice_Id = @Invoice_Id ";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, inv);

            SqlConnection con = new SqlConnection(SqlConjunction.DataConn);

            SqlDataReader sqlDataReader = SqlConjunction.GetSQLExecuteReader(sqlCmd, con);

            while (sqlDataReader.Read())
            {
                inv.Invoice_Id = sqlDataReader.GetGuid(0);
                inv.Invoice_No = sqlDataReader.GetString(1);
                inv.Invoice_Date = sqlDataReader.GetDateTime(2);
                inv.Customer_Name = sqlDataReader.GetString(3);
                inv.Customer_Id = sqlDataReader.GetInt32(4);
                inv.Customer_Description = sqlDataReader.GetString(5);
                inv.Address = sqlDataReader.GetString(6);
                inv.Phone = sqlDataReader.GetString(7);
                inv.Total = sqlDataReader.GetDecimal(8);
                inv.Advance = sqlDataReader.GetDecimal(9);
                inv.DiscountPercent = sqlDataReader.GetDecimal(10);
                inv.Discount = sqlDataReader.GetDecimal(11);
                inv.GrandTotal = sqlDataReader.GetDecimal(12);
                inv.InvoiceType_Id = sqlDataReader.GetInt32(13);
                inv.InvoiceType_Description = sqlDataReader.GetString(14);
                inv.Invoice_Due_Date = sqlDataReader.GetDateTime(15);
                inv.isPaid = sqlDataReader.GetBoolean(16);
                inv.PayDate = sqlDataReader.GetDateTime(17);
                inv.isReturn = sqlDataReader.GetBoolean(18);
                inv.Remark = sqlDataReader.GetString(19);
                inv.Active = sqlDataReader.GetBoolean(20);
                inv.ModifiedBy = sqlDataReader.GetString(21);
                inv.ModifiedDate = sqlDataReader.GetDateTime(22);
                inv.IsPromotion = sqlDataReader.GetBoolean(23);
                inv.PromDesc = sqlDataReader.GetString(24);
                inv.PONumber = sqlDataReader.GetString(25);
                inv.CommercialTax = sqlDataReader.GetDecimal(26);
                inv.DeliveryDiscount = sqlDataReader.GetDecimal(27);
                inv.DDPercent = sqlDataReader.GetDecimal(28);
                inv.IsInclusiveTax = sqlDataReader.GetBoolean(29);
                inv.IsSample = sqlDataReader.GetBoolean(30);
            }

            if (sqlDataReader.HasRows)
                bool_HasRows = true;
            else
                bool_HasRows = false;
            con.Close();

            sqlCmd = null;

            return bool_HasRows;
        }


        public DataTable LoadProductSaleSummaryByDateFilter(DateTime dateTime_From, DateTime dateTime_To)
        {
            DataTable dt_ProductSale;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT * FROM tbl_Invoice inv LEFT JOIN tbl_InvoiceDetail invD ON inv.Invoice_Id = invD.Invoice_Id LEFT JOIN tbl_InvoiceReturnDetail invRD ON inv.Invoice_Id = invRD.Invoice_Id  where   (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (inv.Active = 'true')"; //  And (inv.Customer_Id <> '0')

            dt_ProductSale = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_ProductSale;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerId(Int32 Customer_Id, DateTime dateTime_From, DateTime dateTime_To,Int32 Category_Id)     // to edit
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description, Catagory_Id, Catagory_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Sale_Amount'  from [dbo].[fn_GetProductSaleByCustomer]('" + Customer_Id + "','" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton,Catagory_Id, Catagory_Description order by Catagory_Id,Product_Code;";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerGroupId(Int32 CustomerGroup_Id, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)     // to edit
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description, Catagory_Id, Catagory_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Sale_Amount'  from [dbo].[fn_GetProductSaleByCustomerGroup]('" + CustomerGroup_Id + "','" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton,Catagory_Id, Catagory_Description order by Catagory_Id,Product_Code;";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }


        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerId(Int32 Customer_Id, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)   // to edit
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description, Catagory_Id, Catagory_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Ret_Amount'  from [dbo].[fn_GetProductReturnByCustomer]('" + Customer_Id + "','" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton,Catagory_Id, Catagory_Description order by Catagory_Id,Product_Code;";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerGroupId(Int32 CustomerGroup_Id, DateTime dateTime_From, DateTime dateTime_To, Int32 Category_Id)   // to edit
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description, Catagory_Id, Catagory_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Ret_Amount'  from [dbo].[fn_GetProductReturnByCustomerGroup]('" + CustomerGroup_Id + "','" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton,Catagory_Id, Catagory_Description order by Catagory_Id,Product_Code;";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

    }
}
