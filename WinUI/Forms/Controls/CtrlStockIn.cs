using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockAndSale
{
    public partial class CtrlStockIn : UserControl
    {
        DataTable dt_CustomerReturn = null;

        public CtrlStockIn()
        {
            InitializeComponent();

            DateTime dateTime_From = DateTime.Today;
            DateTime dateTime_RFrom = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);
            dateTime_RFrom = dateTime_RFrom.AddDays(-30);

            dtp_InDateFrom.Value = dateTime_From;
            dtp_ReturnDateFrom.Value = dateTime_RFrom;

            bindCustomerCombo();

            FormatDataGridViewStyle();

            this.Search();
            this.RSearch();
            
        }

        private void bindCustomerCombo()
        {
            BLLCustomer obj_BLLCustomer = new BLLCustomer();
            DataTable dt_Customer = obj_BLLCustomer.LoadCustomerTableForAllData();

            cbx_Customer.Items.Clear();
            cbx_Customer.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Customer.SourceDataString = new string[] { "Customer_Description", "Address", "Phone", "Customer_Id" };
            cbx_Customer.ColumnNum = 4;
            cbx_Customer.ColumnWidth = "150;0;0;0";
            cbx_Customer.SourceDataTable = dt_Customer;

            cbx_Customer.Text = string.Empty;
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_Result);
            UIControl.FormatDataGridView(dgv_RResult);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProductArrival frm_ProductArrival = new FrmProductArrival(this);
            frm_ProductArrival.ShowDialog();
        }        

        public void Search()
        {
            DateTime dateTime_From = Convert.ToDateTime(dtp_InDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InDateTo.Value.Date.AddHours(23.9));
            String product_Code = txt_ProductCode.Text;

            BLLStockIn obj_BLLStockIn = new BLLStockIn();

            DataTable dt_StockIn;

            dt_StockIn = obj_BLLStockIn.LoadStockTableForAllDataByInDateAndProductCode(dateTime_From, dateTime_To, product_Code);
            
            dgv_Result.DataSource = dt_StockIn;

            NumberingTableForDataGridView(dt_StockIn);

            FormatDataGridView();
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void FormatDataGridView()
        {
            dgv_Result.Columns[0].HeaderText = "No";
            dgv_Result.Columns[0].Width = 50;
            dgv_Result.Columns[0].ReadOnly = true;

            dgv_Result.Columns[1].Visible = false; // Stock_Id

            dgv_Result.Columns[2].HeaderText = "Arrival In Date"; // Arrival In Date
            dgv_Result.Columns[2].Width = 150;
            dgv_Result.Columns[2].ReadOnly = true;
            dgv_Result.Columns[2].DefaultCellStyle.Format = "dd-MMM-yyyy";

            dgv_Result.Columns[3].Visible = false; // Product_Id

            dgv_Result.Columns[4].HeaderText = "Product Code"; // Product Code
            dgv_Result.Columns[4].Width = 150;
            dgv_Result.Columns[4].ReadOnly = true;

            dgv_Result.Columns[5].HeaderText = "Product Description"; // Product Description
            dgv_Result.Columns[5].Width = 450;
            dgv_Result.Columns[5].ReadOnly = true;

            dgv_Result.Columns[6].HeaderText = "No of Cartons"; // No Of Cartons
            dgv_Result.Columns[6].Width = 150;
            dgv_Result.Columns[6].ReadOnly = true;

            dgv_Result.Columns[7].HeaderText = "No of Units"; // No Of Cartons
            dgv_Result.Columns[7].Width = 150;
            dgv_Result.Columns[7].ReadOnly = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txt_ProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void dtp_InDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void dtp_InDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgv_Result.CurrentRow != null)
            {
                DEStockIn stockIn = new DEStockIn();
                stockIn.StockInId = new Guid(dgv_Result.CurrentRow.Cells[1].Value.ToString());
                stockIn.StockInDate = Convert.ToDateTime(dgv_Result.CurrentRow.Cells[2].Value.ToString());
                stockIn.Product_Id = Convert.ToInt32(dgv_Result.CurrentRow.Cells[3].Value.ToString());
                stockIn.Product_Code = Convert.ToString(dgv_Result.CurrentRow.Cells[4].Value.ToString());
                stockIn.Product_Description = Convert.ToString(dgv_Result.CurrentRow.Cells[5].Value.ToString());
                stockIn.NoOfCartons = Convert.ToInt32(dgv_Result.CurrentRow.Cells[6].Value.ToString());
                stockIn.NoOfUnits = Convert.ToInt32(dgv_Result.CurrentRow.Cells[7].Value.ToString());

                FrmProductArrival frm_ProductArrival = new FrmProductArrival(stockIn,this);
                frm_ProductArrival.ShowDialog();

                // frm_ProductArrival.DisplayData(stockIn);
            }
            else
            {
                MessageBox.Show("Please Select Row");
            }
            
        }

        private void CtrlStockIn_Load(object sender, EventArgs e)
        {
            ControlPermission();
        }

        private void ControlPermission()
        {
            if (DEGlobal.bool_NewArrival)
            {
                this.btn_NewArrival.Enabled = true;
                this.btn_CustomerReturn.Enabled = true;
            }
            else
            {
                this.btn_NewArrival.Enabled = false;
                this.btn_CustomerReturn.Enabled = false;
            }

            if (DEGlobal.bool_EditArrival)
            {
                this.btn_EditArrival.Enabled = true;
                this.btn_CustomerReturn.Enabled = true;
            }
            else
            {
                this.btn_EditArrival.Enabled = false;
                this.btn_CustomerReturn.Enabled = false;
            }
        }

        private void btn_CustomerReturn_Click(object sender, EventArgs e)
        {
            Frm_CustomerReturn frm_CustomerReturn = new Frm_CustomerReturn(this);
            frm_CustomerReturn.ShowDialog();
        }

        private void btn_RSearch_Click(object sender, EventArgs e)
        {
            RSearch();
        }

        public void RSearch()
        {
            DateTime dateTime_From = Convert.ToDateTime(dtp_ReturnDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_ReturnDateTo.Value.Date.AddHours(23.9));
            String product_Code = txt_RProductCode.Text;
            Int32 Customer_Id = 0;

            try
            {
                Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4); 
            }
            catch (Exception ex)
            {
                Customer_Id = 0;
            }

            BLLCustomerReturn obj_BLLCustomerReturn = new BLLCustomerReturn();

            DataTable dt_CustomerReturn;

            dt_CustomerReturn = obj_BLLCustomerReturn.LoadCustomerReturnForAllDataByReturnDateAndCustomerIDAndProductCode(dateTime_From, dateTime_To, product_Code, Customer_Id);

            dgv_RResult.DataSource = dt_CustomerReturn;

            NumberingTableForDataGridView(dt_CustomerReturn);

            this.dt_CustomerReturn = dt_CustomerReturn;

            RFormatDataGridView();
        }

        private void RFormatDataGridView()
        {
            dgv_RResult.Columns[0].HeaderText = "No";
            dgv_RResult.Columns[0].Width = 50;
            dgv_RResult.Columns[0].ReadOnly = true;

            dgv_RResult.Columns[1].Visible = false; // Return Id

            dgv_RResult.Columns[2].Visible = false; // Customer_Id

            dgv_RResult.Columns[3].HeaderText = "Customer Description";
            dgv_RResult.Columns[3].Width = 200;
            dgv_RResult.Columns[3].ReadOnly = true;

            dgv_RResult.Columns[4].HeaderText = "Return Date"; // Return Date
            dgv_RResult.Columns[4].Width = 100;
            dgv_RResult.Columns[4].ReadOnly = true;
            dgv_RResult.Columns[4].DefaultCellStyle.Format = "dd-MMM-yyyy";

            dgv_RResult.Columns[5].Visible = false; // Product_Id

            dgv_RResult.Columns[6].HeaderText = "Product Code"; // Product Code
            dgv_RResult.Columns[6].Width = 100;
            dgv_RResult.Columns[6].ReadOnly = true;

            dgv_RResult.Columns[7].HeaderText = "Product Description"; // Product Description
            dgv_RResult.Columns[7].Width = 400;
            dgv_RResult.Columns[7].ReadOnly = true;

            dgv_RResult.Columns[8].HeaderText = "Qty"; // Qty
            dgv_RResult.Columns[8].Width = 100;
            dgv_RResult.Columns[8].ReadOnly = true;

            dgv_RResult.Columns[9].HeaderText = "Unit"; // Unit
            dgv_RResult.Columns[9].Width = 100;
            dgv_RResult.Columns[9].ReadOnly = true;

            dgv_RResult.Columns[10].HeaderText = "Rate"; // Rate
            dgv_RResult.Columns[10].Width = 100;
            dgv_RResult.Columns[10].ReadOnly = true;

            dgv_RResult.Columns[11].HeaderText = "Amount"; // Amount
            dgv_RResult.Columns[11].Width = 100;
            dgv_RResult.Columns[11].ReadOnly = true;

            dgv_RResult.Columns[12].Visible = false; // Active
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Frm_CustomerReturnReport frm_CustomerReturn = new Frm_CustomerReturnReport(this.dt_CustomerReturn);
            frm_CustomerReturn.ShowDialog();
        }
        
    }
}
