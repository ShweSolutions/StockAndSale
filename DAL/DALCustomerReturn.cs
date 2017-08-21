using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALCustomerReturn
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DECustomerReturn customerReturn)
        {
            SqlCmd.Parameters.AddWithValue("@CustomerReturn_Id", customerReturn.CustomerReturn_Id);
            SqlCmd.Parameters.AddWithValue("@Customer_Id", customerReturn.Customer_Id);
            SqlCmd.Parameters.AddWithValue("@ReturnDate", customerReturn.ReturnDate);
            SqlCmd.Parameters.AddWithValue("@Product_Id", customerReturn.Product_Id);
            SqlCmd.Parameters.AddWithValue("@isCarton", customerReturn.isCarton);
            SqlCmd.Parameters.AddWithValue("@Qty", customerReturn.Qty);
            SqlCmd.Parameters.AddWithValue("@Price", customerReturn.Price);
            SqlCmd.Parameters.AddWithValue("@Amount", customerReturn.Amount);
            SqlCmd.Parameters.AddWithValue("@Remark", customerReturn.Remark);
            SqlCmd.Parameters.AddWithValue("@Active", customerReturn.Active);
            SqlCmd.Parameters.AddWithValue("@ModifiedBy", customerReturn.ModifiedBy);
            SqlCmd.Parameters.AddWithValue("@ModifiedDate", customerReturn.ModifiedDate);

            return SqlCmd;
        }

        public int InsertData(DECustomerReturn customerReturn, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_CustomerReturn  VALUES(@CustomerReturn_Id,@Customer_Id,@ReturnDate,@Product_Id,@isCarton,@Qty,@Price,@Amount,@Remark,@Active,@ModifiedBy,@ModifiedDate)";

            DeclareSqlCmdParameter(sqlCmd, customerReturn);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int InsertData(DECustomerReturn customerReturn)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = customerReturn.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = customerReturn.Product_Id;
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
                    this.InsertData(customerReturn, SqlCon, tn);

                    int int_NoOfUnitsSale = 0;

                    if (customerReturn.isCarton == true)
                    {
                        int_NoOfUnitsSale = (customerReturn.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = customerReturn.Qty;
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

        public int DeleteData(DECustomerReturn cusReturn)
        {
            int int_Result = 0;

            DALProductInStore obj_DALProductInStore = new DALProductInStore();
            DALProduct obj_DALProduct = new DALProduct();

            DEProductInStore productInStore = new DEProductInStore();
            productInStore.Product_Id = cusReturn.Product_Id;

            DEProduct product = new DEProduct();
            product.Product_Id = cusReturn.Product_Id;
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

                    if (cusReturn.isCarton == true)
                    {
                        int_NoOfUnitsSale = (cusReturn.Qty * product.NoOfUnitsPerCarton);
                    }
                    else
                    {
                        int_NoOfUnitsSale = cusReturn.Qty;
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

                    this.DeleteData(cusReturn, SqlCon, tn);

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

        private int DeleteData(DECustomerReturn cusReturn, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Delete From tbl_CustomerReturn where CustomerReturn_Id = @CustomerReturn_Id";

            DeclareSqlCmdParameter(sqlCmd, cusReturn);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }


        public DataTable LoadCustomerReturnDetailTableForAllDataByReturnDateAndCustomerID(DateTime dateTime_From, DateTime dateTime_To, DECustomerReturn cusRetDetail)
        {
            DataTable dt_CustomerReturn;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'RNo',cusR.CustomerReturn_Id as 'cusR_Id',cusR.Customer_Id, cusR.ReturnDate,cusR.Product_Id as 'RProduct_Id',P.Product_Code as 'RProduct_Code',P.Product_Description as 'RProduct_Description',cusR.Qty as 'RQty',CASE WHEN cusR.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'RUnits',cusR.Price as 'RRate',cusR.Amount as 'RAmount',cusR.Active FROM tbl_CustomerReturn cusR LEFT JOIN tbl_Product P ON cusR.Product_Id = P.Product_Id where cusR.ReturnDate <='" + dateTime_To + "' And cusR.ReturnDate >= '" + dateTime_From + "' and cusR.Customer_Id = @Customer_Id order by cusR.ModifiedDate";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, cusRetDetail);

            dt_CustomerReturn = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_CustomerReturn;
        }

        public DataTable LoadCustomerReturnForAllDataByReturnDateAndCustomerIDAndProductCode(DateTime dateTime_From, DateTime dateTime_To, String product_Code, Int32 Customer_Id)
        {
            DataTable dt_CustomerReturn;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'RNo',cusR.CustomerReturn_Id as 'cusR_Id',cusR.Customer_Id,cus.Customer_Description, cusR.ReturnDate,cusR.Product_Id as 'RProduct_Id',P.Product_Code as 'RProduct_Code',P.Product_Description as 'RProduct_Description',cusR.Qty as 'RQty',CASE WHEN cusR.isCarton = 'True' then 'Cartons' ELSE 'Pcs' END as 'RUnits',cusR.Price as 'RRate',cusR.Amount as 'RAmount',cusR.Active FROM tbl_CustomerReturn cusR LEFT JOIN tbl_Customer cus on cusR.Customer_Id = cus.Customer_Id LEFT JOIN tbl_Product P ON cusR.Product_Id = P.Product_Id where cusR.ReturnDate <='" + dateTime_To + "' And cusR.ReturnDate >= '" + dateTime_From + "'	And (P.Product_Code  LIKE '%" + product_Code + "%' OR  '" + product_Code + "'='') And (cusR.Customer_Id  = '" + Customer_Id + "' OR  '" + Customer_Id + "'='0') order by cusR.ModifiedDate";

            //sqlCmd = DeclareSqlCmdParameter(sqlCmd, cusRetDetail);

            dt_CustomerReturn = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_CustomerReturn;
        }

        #endregion
    }


}
