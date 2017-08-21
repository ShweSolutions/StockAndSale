using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALInvoiceReturnDetail
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEInvoiceReturnDetail invRetDetail)
        {
            SqlCmd.Parameters.AddWithValue("@InvoiceReturnDetail_Id", invRetDetail.InvoiceReturnDetail_Id);
            SqlCmd.Parameters.AddWithValue("@Invoice_Id", invRetDetail.Invoice_Id);
            SqlCmd.Parameters.AddWithValue("@Product_Id", invRetDetail.Product_Id);
            SqlCmd.Parameters.AddWithValue("@isCarton", invRetDetail.isCarton);
            SqlCmd.Parameters.AddWithValue("@Qty", invRetDetail.Qty);
            SqlCmd.Parameters.AddWithValue("@Price", invRetDetail.Price);
            SqlCmd.Parameters.AddWithValue("@Amount", invRetDetail.Amount);
            SqlCmd.Parameters.AddWithValue("@Active", invRetDetail.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", invRetDetail.ModifiedDate);

            return SqlCmd;
        }

        #endregion

        public DataTable LoadInvoiceReturnDetailTableForAllDataByInvoiceId(DEInvoiceReturnDetail invRetDetail)
        {
            DataTable dt_InvoiceReturnDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'RNo',invRD.InvoiceReturnDetail_Id as 'RInvoiceDetail_Id',invRD.Invoice_Id as 'RInvoice_Id',invRD.Product_Id as 'RProduct_Id',P.Product_Code as 'RProduct_Code',P.Product_Description as 'RProduct_Description',invRD.Qty as 'RQty',CASE WHEN invRD.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'RUnits',invRD.Price as 'RRate',invRD.Amount as 'RAmount',invRD.Active FROM tbl_InvoiceReturnDetail invRD LEFT JOIN tbl_Product P ON invRD.Product_Id = P.Product_Id where invRD.Invoice_Id = @Invoice_Id order by invRD.ModifiedDate";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, invRetDetail);

            dt_InvoiceReturnDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceReturnDetail;
        }

        private int InsertData(DEInvoiceReturnDetail invRetDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_InvoiceReturnDetail  VALUES(@InvoiceReturnDetail_Id,@Invoice_Id,@Product_Id,@isCarton,@Qty,@Price,@Amount,@Active,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, invRetDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int InsertData(DEInvoiceReturnDetail invRetDetail)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = invRetDetail.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = invRetDetail.Product_Id;
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
                    this.InsertData(invRetDetail, SqlCon, tn);

                    int int_NoOfUnitsSale = 0;

                    if (invRetDetail.isCarton == true)
                    {
                        int_NoOfUnitsSale = (invRetDetail.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = invRetDetail.Qty;
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

        public int DeleteData(DEInvoiceReturnDetail invRetDetail)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = invRetDetail.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = invRetDetail.Product_Id;
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

                    if (invRetDetail.isCarton == true)
                    {
                        int_NoOfUnitsSale = (invRetDetail.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = invRetDetail.Qty;
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

                    }

                    this.DeleteData(invRetDetail, SqlCon, tn);

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

        private int DeleteData(DEInvoiceReturnDetail invRetDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Delete From tbl_InvoiceReturnDetail where InvoiceReturnDetail_Id = @InvoiceReturnDetail_Id";

            DeclareSqlCmdParameter(sqlCmd, invRetDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }


        public int CancelReturnInvoice(DEInvoiceReturnDetail invoiceDetail)
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

                        productInStore.NoOfUnits = (int_NoOfUnitsInStore - int_NoOfUnitsSale);

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

        private int updateActiveData(DEInvoiceReturnDetail invoiceDetail, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Update tbl_InvoiceReturnDetail Set Active = @Active where InvoiceReturnDetail_Id = @InvoiceReturnDetail_Id";

            DeclareSqlCmdParameter(sqlCmd, invoiceDetail);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadInvoiceReturnDetailTableForAllDataByInvoiceDate(DEInvoiceReturnDetail invoiceReturnDetail, DateTime dateTime_From, DateTime dateTime_To)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'RNo',invD.InvoiceReturnDetail_Id as 'RInvoiceDetail_Id',invD.Invoice_Id as 'RInvoice_Id',invD.Product_Id as 'RProduct_Id',P.Product_Code as 'RProduct_Code',P.Product_Description as 'RProduct_Description',invD.Qty as  'RQty',CASE WHEN invD.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'RUnits',invD.Price as 'RRate',invD.Amount as 'RAmount',invD.Active,invT.InvoiceType_Id as 'RInvoiceType_Id',invT.InvoiceType_Description as 'RInvoiceType_Description',Cus.Customer_Id as 'RCustomer_Id',Cus.Customer_Description as 'RCustomer_Description',inv.Invoice_No as 'RInvoice_No',inv.Invoice_Date as 'RInvoice_Date' FROM tbl_InvoiceReturnDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id LEFT JOIN tbl_Invoice inv ON invD.Invoice_Id = inv.Invoice_Id LEFT JOIN tbl_Customer Cus ON inv.Customer_Id = Cus.Customer_Id LEFT JOIN tbl_InvoiceType invT ON inv.InvoiceType_Id = invT.InvoiceType_Id  where (invD.Product_Id = @Product_Id) And (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invD.Active = 'true') order by inv.Invoice_Date";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, invoiceReturnDetail);

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

        public DataTable LoadProductReturnSummaryTableForAllDataByInvoiceDate(DateTime dateTime_From, DateTime dateTime_To, int Category_Id)
        {
            DataTable dt_InvoiceDetail;

            SqlCommand sqlCmd = new SqlCommand();

            //sqlCmd.CommandText = "SELECT 0 As 'RNo',invD.InvoiceReturnDetail_Id as 'RInvoiceDetail_Id',invD.Invoice_Id as 'RInvoice_Id',invD.Product_Id as 'RProduct_Id',P.Product_Code as 'RProduct_Code',P.Product_Description as 'RProduct_Description',invD.Qty as  'RQty',CASE WHEN invD.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'RUnits',invD.Price as 'RRate',invD.Amount as 'RAmount',invD.Active,invT.InvoiceType_Id as 'RInvoiceType_Id',invT.InvoiceType_Description as 'RInvoiceType_Description',Cus.Customer_Id as 'RCustomer_Id',Cus.Customer_Description as 'RCustomer_Description',inv.Invoice_No as 'RInvoice_No',inv.Invoice_Date as 'RInvoice_Date' FROM tbl_InvoiceReturnDetail invD LEFT JOIN tbl_Product P ON invD.Product_Id = P.Product_Id LEFT JOIN tbl_Invoice inv ON invD.Invoice_Id = inv.Invoice_Id LEFT JOIN tbl_Customer Cus ON inv.Customer_Id = Cus.Customer_Id LEFT JOIN tbl_InvoiceType invT ON inv.InvoiceType_Id = invT.InvoiceType_Id  where (inv.Invoice_Date <='" + dateTime_To + "' And inv.Invoice_Date >= '" + dateTime_From + "') And (invD.Active = 'true') order by inv.Invoice_Date";

            sqlCmd.CommandText = "SELECT Product_Code, Product_Description ,(Sum(CASE WHEN isCarton = 'True' then (Qty) ELSE (0) END)+  (Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END)/NoOfUnitsPerCarton )) as 'Cartons',(Sum(CASE WHEN isCarton = 'False' then (Qty) ELSE (0) END))%NoOfUnitsPerCarton as 'Units' ,NoOfUnitsPerCarton,Sum(Amount) as 'Ret_Amount'  from [dbo].[fn_GetProductReturnByReport]('" + dateTime_From + "','" + dateTime_To + "','" + Category_Id + "') group by Product_Code,Product_Description,NoOfUnitsPerCarton order by Product_Code;";

            dt_InvoiceDetail = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_InvoiceDetail;
        }

    }
}
