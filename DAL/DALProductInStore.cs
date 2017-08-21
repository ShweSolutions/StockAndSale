using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace StockAndSale
{
    class DALProductInStore
    {
        #region +++  Codes of private access methods  +++

        private SqlCommand DeclareSqlCmdParameter(SqlCommand SqlCmd, DEProductInStore productInStore)
        {
            SqlCmd.Parameters.AddWithValue("@Product_Id", productInStore.Product_Id);
            SqlCmd.Parameters.AddWithValue("@NoOfUnits", productInStore.NoOfUnits);            

            return SqlCmd;
        }

        #endregion

        public int InsertData(DEProductInStore productInStore, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "INSERT  tbl_ProductInStore  VALUES(@Product_Id,@NoOfUnits)";

            DeclareSqlCmdParameter(sqlCmd, productInStore);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public int UpdateData(DEProductInStore productInStore, SqlConnection SqlCon, SqlTransaction tn)
        {
            int int_Result;

            SqlCommand sqlCmd = new SqlCommand(" ", SqlCon, tn);

            sqlCmd.CommandText = "Update tbl_ProductInStore SET NoOfUnits = @NoOfUnits where Product_Id = @Product_Id";

            DeclareSqlCmdParameter(sqlCmd, productInStore);

            int_Result = SqlConjunction.GetSQLTransVoid(sqlCmd);

            sqlCmd = null;

            return int_Result;
        }

        public DataTable LoadProductInStoreTableByProductId(DEProductInStore productInStore, SqlConnection con, SqlTransaction tn)
        {
            DataTable dt_ProductInStore;

            SqlCommand sqlCmd = new SqlCommand(" ", con, tn);

            sqlCmd.CommandText = "SELECT NoOfUnits  From tbl_ProductInStore where Product_Id = @Product_Id";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, productInStore);

            dt_ProductInStore = SqlConjunction.GetSQLTransDataTable(sqlCmd);

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableByProductId(DEProductInStore productInStore)
        {
            DataTable dt_ProductInStore;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT NoOfUnits  From tbl_ProductInStore where Product_Id = @Product_Id";

            sqlCmd = DeclareSqlCmdParameter(sqlCmd, productInStore);

            dt_ProductInStore = SqlConjunction.GetSQLDataTable(sqlCmd);

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableForAllDataByCatagoryIdAndProductCode(int int_Catagory_Id, String product_Code)
        {
            DataTable dt_ProductInStore;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',inS.Product_Id,p.Product_Code,p.Product_Description,inS.NoOfUnits as 'Total No Of Units In Store',(inS.NoOfUnits/p.NoOfUnitsPerCarton) as 'No Of Cartons in Store' , (inS.NoOfUnits%p.NoOfUnitsPerCarton) as 'No Of Units in Store',p.NoOfUnitsPerCarton, p.MinLVL, p.ReorderCtn from tbl_ProductInStore inS left join tbl_Product p on inS.Product_Id = p.Product_Id where (p.Catagory_Id ='" + int_Catagory_Id + "' OR '" + int_Catagory_Id + "'='0' ) And (p.Product_Code  LIKE '%" + product_Code + "%' OR  '" + product_Code + "'='')  order by p.SrNo";

            dt_ProductInStore = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableMRPModeForAllDataByCatagoryIdAndProductCode(int int_Catagory_Id, String product_Code)
        {
            DataTable dt_ProductInStore;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',inS.Product_Id,p.Product_Code,p.Product_Description,inS.NoOfUnits as 'Total No Of Units In Store',(inS.NoOfUnits/p.NoOfUnitsPerCarton) as 'No Of Cartons in Store' , (inS.NoOfUnits%p.NoOfUnitsPerCarton) as 'No Of Units in Store',p.NoOfUnitsPerCarton, p.MinLVL, p.ReorderCtn from tbl_ProductInStore inS left join tbl_Product p on inS.Product_Id = p.Product_Id where inS.NoOfUnits <= p.MinLVL And (p.Catagory_Id ='" + int_Catagory_Id + "' OR '" + int_Catagory_Id + "'='0' ) And (p.Product_Code  LIKE '%" + product_Code + "%' OR  '" + product_Code + "'='')  order by p.SrNo";

            dt_ProductInStore = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_ProductInStore;
        }

        public DataTable LoadProductInStoreTableForAllDataByCatagoryIdAndProductCodeAndNoOfUnits(int int_Catagory_Id, String product_Code, int int_noOfUnits)
        {
            DataTable dt_ProductInStore;

            SqlCommand sqlCmd = new SqlCommand();

            sqlCmd.CommandText = "SELECT 0 As 'No',inS.Product_Id,p.Product_Code,p.Product_Description,inS.NoOfUnits as 'Total No Of Units In Store',(inS.NoOfUnits/p.NoOfUnitsPerCarton) as 'No Of Cartons in Store' , (inS.NoOfUnits%p.NoOfUnitsPerCarton) as 'No Of Units in Store',p.NoOfUnitsPerCarton, p.MinLVL, p.ReorderCtn from tbl_ProductInStore inS left join tbl_Product p on inS.Product_Id = p.Product_Id where (p.Catagory_Id ='" + int_Catagory_Id + "' OR '" + int_Catagory_Id + "'='0' ) And inS.NoOfUnits <'"+int_noOfUnits+"' And (p.Product_Code  LIKE '%" + product_Code + "%' OR  '" + product_Code + "'='') order by p.SrNo";

            dt_ProductInStore = SqlConjunction.GetSQLDataTable(sqlCmd);

            sqlCmd = null;

            return dt_ProductInStore;
        }

    }
}
