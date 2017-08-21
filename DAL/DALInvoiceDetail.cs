using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALInvoiceDetail
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEInvoiceDetail invoiceDetail)
        {
            SqlCmd.Parameters.AddWithValue("@InvoiceDetail_Id", invoiceDetail.InvoiceDetail_Id);
            SqlCmd.Parameters.AddWithValue("@Invoice_Id", invoiceDetail.Invoice_Id);
            SqlCmd.Parameters.AddWithValue("@Product_Id", invoiceDetail.Product_Id);
            SqlCmd.Parameters.AddWithValue("@isCarton", invoiceDetail.isCarton);
            SqlCmd.Parameters.AddWithValue("@Qty", invoiceDetail.Qty);
            SqlCmd.Parameters.AddWithValue("@Price", invoiceDetail.Price);
            SqlCmd.Parameters.AddWithValue("@Amount", invoiceDetail.Amount);
            SqlCmd.Parameters.AddWithValue("@FOC", invoiceDetail.FOC);
            SqlCmd.Parameters.AddWithValue("@Active", invoiceDetail.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", invoiceDetail.ModifiedDate);

            return SqlCmd;
        }

        #endregion

        public int InsertData(DEInvoiceDetail invoiceDetail)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = invoiceDetail.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = invoiceDetail.Product_Id;
            obj_DALProduct.LoadProductRow(product);

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
                    this.InsertData(invoiceDetail, SqlCon, tn);

                    int int_NoOfUnitsSale = 0;

                    if(invoiceDetail.isCarton == true)
                    {
                        int_NoOfUnitsSale = (invoiceDetail.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = invoiceDetail.Qty;
                    }

                    DataTable dt_ProductInStoreTemp = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore, SqlCon, tn);

                    if (dt_ProductInStoreTemp.Rows.Count > 0)
                    {
                        int int_NoOfUnitsInStore = Convert.ToInt32(dt_ProductInStoreTemp.Rows[0][0].ToString());

                        productInStore.NoOfUnits = (int_NoOfUnitsInStore - int_NoOfUnitsSale);

                        obj_DALProductInStore.UpdateData(productInStore, SqlCon, tn);
                    }
                    else
                    {
                        productInStore.NoOfUnits = (int_NoOfUnitsSale * (-1));

                        obj_DALProductInStore.InsertData(productInStore, SqlCon, tn);
                    }


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
                    obj_DALProductInStore = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        public int DeleteData(DEInvoiceDetail invoiceDetail)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = invoiceDetail.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = invoiceDetail.Product_Id;
            obj_DALProduct.LoadProductRow(product);

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

                    int int_NoOfUnitsSale = 0;

                    if (invoiceDetail.isCarton == true)
                    {
                        int_NoOfUnitsSale = (invoiceDetail.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = invoiceDetail.Qty;
                    }

                    DataTable dt_ProductInStoreTemp = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore, SqlCon, tn);

                    if (dt_ProductInStoreTemp.Rows.Count > 0)
                    {
                        int int_NoOfUnitsInStore = Convert.ToInt32(dt_ProductInStoreTemp.Rows[0][0].ToString());

                        productInStore.NoOfUnits = (int_NoOfUnitsInStore + int_NoOfUnitsSale);

                        obj_DALProductInStore.UpdateData(productInStore, SqlCon, tn);
                    }
                    else
                    {
                       
                    }

                    this.DeleteData(invoiceDetail, SqlCon, tn);

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
                    obj_DALProductInStore = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }   

        private int InsertData(DEInvoiceDetail invoiceDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_InvoiceDetail  VALUES(@InvoiceDetail_Id,@Invoice_Id,@Product_Id,@isCarton,@Qty,@Price,@Amount,@FOC,@Active,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, invoiceDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        private int DeleteData(DEInvoiceDetail invoiceDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Delete From tbl_InvoiceDetail where InvoiceDetail_Id = @InvoiceDetail_Id";

            DeclareSqlCmdParameter(sqlCmd, invoiceDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceId(DEInvoiceDetail invoiceDetail)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',invD.InvoiceDetail_Id,invD.Invoice_Id,invD.Product_Id,P.Product_Code,P.Product_Description,invD.Qty,CASE WHEN invD.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'Units',invD.Price as 'Rate',invD.Amount,invD.Active,invD.FOC as 'Remark' FROM tbl_InvoiceDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id where invD.Invoice_Id = @Invoice_Id order by invD.ModifiedDate";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, invoiceDetail);

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public int CancelDetailInvoice(DEInvoiceDetail invoiceDetail)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = invoiceDetail.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = invoiceDetail.Product_Id;
            obj_DALProduct.LoadProductRow(product);

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
                    int int_NoOfUnitsSale = 0;

                    if (invoiceDetail.isCarton)
                    {
                        int_NoOfUnitsSale = invoiceDetail.Qty * product.NoOfUnitsPerCarton;
                    }
                    else
                    {
                        int_NoOfUnitsSale = invoiceDetail.Qty;
                    }

                    DataTable dt_ProductInStoreTemp = obj_DALProductInStore.LoadProductInStoreTableByProductId(productInStore, SqlCon, tn);

                    if (dt_ProductInStoreTemp.Rows.Count > 0)
                    {
                        int int_NoOfUnitsInStore = Convert.ToInt32(dt_ProductInStoreTemp.Rows[0][0].ToString());

                        productInStore.NoOfUnits = (int_NoOfUnitsInStore + int_NoOfUnitsSale);

                        obj_DALProductInStore.UpdateData(productInStore, SqlCon, tn);
                    }
                    else
                    {

                    }

                    this.updateActiveData(invoiceDetail, SqlCon, tn);

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
                    obj_DALProductInStore = null;

                    SqlCon.Close();
                    tn.Dispose();
                }

                return int_Result;

            }
        }

        private int updateActiveData(DEInvoiceDetail invoiceDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Update tbl_InvoiceDetail Set Active = @Active where InvoiceDetail_Id = @InvoiceDetail_Id";

            DeclareSqlCmdParameter(sqlCmd, invoiceDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadInvoiceDetailTableForAllDataByInvoiceDate(DEInvoiceDetail invoiceDetail, DateTime dateTime_From, DateTime dateTime_To)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',invD.InvoiceDetail_Id,invD.Invoice_Id,invD.Product_Id,P.Product_Code,P.Product_Description,invD.Qty,CASE WHEN invD.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'Units',invD.Price as 'Rate',invD.Amount,invD.Active,invT.InvoiceType_Id,invT.InvoiceType_Description,Cus.Customer_Id,Cus.Customer_Description,inv.Invoice_No,inv.Invoice_Date FROM tbl_InvoiceDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id LEFT JOIN tbl_Invoice inv ON invD.Invoice_Id = inv.Invoice_Id LEFT JOIN tbl_Customer Cus ON inv.Customer_Id = Cus.Customer_Id LEFT JOIN tbl_InvoiceType invT ON inv.InvoiceType_Id = invT.InvoiceType_Id  where (invD.Product_Id = @Product_Id) And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invD.Active = 'true')  order by inv.Invoice_Date";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, invoiceDetail);
            
            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }


        public DataTable LoadInvoiceDetailTableForFOCReport(DateTime dateTime_From, DateTime dateTime_To,int customerId,int productId)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',invD.InvoiceDetail_Id,invD.Invoice_Id,invD.Product_Id,P.Product_Code,P.Product_Description,CASE WHEN invD.isCarton = 'true' THEN invD.Qty ELSE 0 END AS 'Cartons', CASE WHEN invD.isCarton = 'false' THEN invD.Qty ELSE 0 END AS 'Units', invD.Price, (invD.Qty * invD.Price) AS 'Amount', invD.FOC, invD.Active,invT.InvoiceType_Id,invT.InvoiceType_Description,Cus.Customer_Id,Cus.Customer_Description,inv.Invoice_No,inv.Invoice_Date FROM tbl_InvoiceDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id LEFT JOIN tbl_Invoice inv ON invD.Invoice_Id = inv.Invoice_Id LEFT JOIN tbl_Customer Cus ON inv.Customer_Id = Cus.Customer_Id LEFT JOIN tbl_InvoiceType invT ON inv.InvoiceType_Id = invT.InvoiceType_Id  where  (invD.Product_Id ='" + productId + "' OR '" + productId + "'='0' ) And (cus.Customer_Id ='" + customerId + "' OR '" + customerId + "'='0' ) And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invD.Active = 'true') And (invD.FOC ='FOC')  order by inv.Invoice_Date";
                        
            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadInvoiceDetailTableForPromotionReport(DateTime dateTime_From, DateTime dateTime_To, int customerId, int categoryId)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',invD.InvoiceDetail_Id,invD.Invoice_Id,invD.Product_Id,P.Product_Code,P.Product_Description,CASE WHEN invD.isCarton = 'true' THEN invD.Qty ELSE 0 END AS 'Cartons', CASE WHEN invD.isCarton = 'false' THEN invD.Qty ELSE 0 END AS 'Units', invD.Price, (invD.Qty * invD.Price) AS 'Amount', inv.PromDesc, invD.Active,invT.InvoiceType_Id,invT.InvoiceType_Description,Cus.Customer_Id,Cus.Customer_Description,inv.Invoice_No,inv.Invoice_Date FROM tbl_InvoiceDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id LEFT JOIN tbl_Invoice inv ON invD.Invoice_Id = inv.Invoice_Id LEFT JOIN tbl_Customer Cus ON inv.Customer_Id = Cus.Customer_Id LEFT JOIN tbl_InvoiceType invT ON inv.InvoiceType_Id = invT.InvoiceType_Id  where  (P.Catagory_Id ='" + categoryId + "' OR '" + categoryId + "'='0' ) And (cus.Customer_Id ='" + customerId + "' OR '" + customerId + "'='0' ) And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invD.Active = 'true') And (inv.IsPromotion ='true')  order by inv.Invoice_Date";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadProductSaleSummaryTableForAllDataByInvoiceDate(DateTime dateTime_From, DateTime dateTime_To, int Category_Id)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Sale_Amount'  from [dbo].[fn_GetProductSaleByReport]('" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton order by Product_Code;";
            
            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }



        

    }
}
