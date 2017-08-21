using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockAndSale
{
    public partial class FrmProductArrival : Form
    {
        public FrmProductArrival()
        {
            InitializeComponent();
        }

        CtrlStockIn stockIn;

        public FrmProductArrival(CtrlStockIn temp_StockIn)
        {
            InitializeComponent();
            stockIn = temp_StockIn;
        }

        public FrmProductArrival(DEStockIn stockIn)
        {
            InitializeComponent();
            arrival = stockIn;
            dtp_FilteredInDate.Value = arrival.StockInDate;
            this.bindProductCombo();
            this.DisplayData(arrival);
        }

        public FrmProductArrival(DEStockIn stockIn,CtrlStockIn temp_StockIn)
        {
            InitializeComponent();
            arrival = stockIn;
            dtp_FilteredInDate.Value = arrival.StockInDate;
            this.bindProductCombo();
            this.DisplayData(arrival);
            this.stockIn = temp_StockIn;
        }

        DEStockIn arrival = new DEStockIn();

        private void FrmProductArrival_Load(object sender, EventArgs e)
        {
            if (arrival.StockInId == Guid.Empty)
            {
                clearScreen();
            }
            FormatDataGridViewStyle();
            BindDataGridView();
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_ArrivalProduct);
        }

        private void clearScreen()
        {
            arrival.StockInId = Guid.Empty;
            arrival.StockInDate = DEGlobal.dateTime_ToDayDate;
            arrival.Product_Id = 0;
            arrival.NoOfCartons = 0;
            arrival.NoOfUnits = 0;

            txt_Description.Text = string.Empty;
            txt_NoOfCartons.Text = string.Empty;
            txt_NoOfUnits.Text = string.Empty;

            cbx_Product.Enabled = true;

            bindProductCombo();
        }

        private void bindProductCombo()
        {
            BLLProduct obj_BLLProduct = new BLLProduct();
            DataTable dt_Product = obj_BLLProduct.LoadProductTableForAllData();

            cbx_Product.Items.Clear();
            cbx_Product.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Product.SourceDataString = new string[] { "Product_Code", "Product_Description", "Product_Id", "Product_Id" };
            cbx_Product.ColumnNum = 3;
            cbx_Product.ColumnWidth = "150;150;0,0";
            cbx_Product.SourceDataTable = dt_Product;

            cbx_Product.Text = string.Empty;
        }

        private void txt_NoOfCartons_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        private void cbx_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
                {
                    MessageBox.Show("Invalid Product Code");
                    cbx_Product.Text = string.Empty;
                    txt_Description.Text = string.Empty;
                }
                else
                {
                    txt_Description.Text = cbx_Product.SelectedItem.Col2;
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                this.save();

                if (stockIn != null)
                {
                    stockIn.Search();
                }

            }
        }

        private void save()
        {
            arrival.StockInDate = Convert.ToDateTime(dtp_InDate.Text);
            arrival.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);
            arrival.NoOfCartons = Convert.ToInt32(txt_NoOfCartons.Text);
            try
            {
                arrival.NoOfUnits = Convert.ToInt32(txt_NoOfUnits.Text);
            }
            catch (Exception ex)
            {
                arrival.NoOfUnits = 0;
            }


            if (arrival.StockInId == Guid.Empty)
            {
                saveNewArrival();
            }
            else
            {
                updateNewArrival();
            }
        }

        private void saveNewArrival()
        {
            arrival.StockInId = Guid.NewGuid();

            BLLStockIn obj_BLLStockIn = new BLLStockIn();

            try
            {
                int int_Result = obj_BLLStockIn.InsertData(arrival);

                if (int_Result > 0)
                {
                    MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                    BindDataGridView();
                    clearScreen();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                arrival = new DEStockIn();
                obj_BLLStockIn = null;
            }


        }

        private void BindDataGridView()
        {
            DEStockIn stockIn = new DEStockIn();
            stockIn.StockInDate = Convert.ToDateTime(dtp_FilteredInDate.Value.Date.ToString());

            BLLStockIn obj_BLLStockIn= new BLLStockIn();

            DataTable dt_StockIn;

            if (txt_FilteredCode.Text.Trim().Length <= 0)
            {
                dt_StockIn = obj_BLLStockIn.LoadStockTableForAllData(stockIn);
            }
            else
            {
                stockIn.Product_Code = txt_FilteredCode.Text;
                dt_StockIn = obj_BLLStockIn.LoadStockTableForAllDataByInDateAndProductCode(stockIn);
            }

            dgv_ArrivalProduct.DataSource = dt_StockIn;

            NumberingTableForDataGridView(dt_StockIn);

            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgv_ArrivalProduct.Columns[0].HeaderText = "No";
            dgv_ArrivalProduct.Columns[0].Width = 40;
            dgv_ArrivalProduct.Columns[0].ReadOnly = true;

            dgv_ArrivalProduct.Columns[1].Visible = false; // Stock_Id

            dgv_ArrivalProduct.Columns[2].HeaderText = "Arrival In Date"; // Arrival In Date
            dgv_ArrivalProduct.Columns[2].Width = 110;
            dgv_ArrivalProduct.Columns[2].ReadOnly = true;
            dgv_ArrivalProduct.Columns[2].DefaultCellStyle.Format = "dd-MMM-yyyy";    

            dgv_ArrivalProduct.Columns[3].Visible = false; // Product_Id

            dgv_ArrivalProduct.Columns[4].HeaderText = "Product Code"; // Product Code
            dgv_ArrivalProduct.Columns[4].Width = 110;
            dgv_ArrivalProduct.Columns[4].ReadOnly = true;

            dgv_ArrivalProduct.Columns[5].HeaderText = "Product Description"; // Product Description
            dgv_ArrivalProduct.Columns[5].Width = 210;
            dgv_ArrivalProduct.Columns[5].ReadOnly = true;

            dgv_ArrivalProduct.Columns[6].HeaderText = "No of Cartons"; // No Of Cartons
            dgv_ArrivalProduct.Columns[6].Width = 90;
            dgv_ArrivalProduct.Columns[6].ReadOnly = true;

            dgv_ArrivalProduct.Columns[7].HeaderText = "No of Units"; // No Of Units
            dgv_ArrivalProduct.Columns[7].Width = 90;
            dgv_ArrivalProduct.Columns[7].ReadOnly = true;

            
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }
                
        private void updateNewArrival()
        {
            BLLStockIn obj_BLLStockIn = new BLLStockIn();

            try
            {
                int int_Result = obj_BLLStockIn.UpdateData(arrival);

                if (int_Result > 0)
                {
                    MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                    BindDataGridView();
                    clearScreen();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                arrival = new DEStockIn();
                obj_BLLStockIn = null;
            }
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            if (cbx_Product.Text.Length == 0 || cbx_Product.SelectedValue == null)
            {
                bool_Test = false;
                ErrorProvider.SetError(cbx_Product, "Please Select Product");
                string str_error = ErrorProvider.GetError(cbx_Product);
                MessageBox.Show(str_error);
            }
            else if (txt_NoOfCartons.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_NoOfCartons, "Enter No Of Cartons");
                string str_error = ErrorProvider.GetError(txt_NoOfCartons);
                MessageBox.Show(str_error);
            }
            
            
            ErrorProvider.Clear();
            return bool_Test;
        }

        private void cbx_Product_Leave(object sender, EventArgs e)
        {
            if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
            {
                MessageBox.Show("Invalid Product Code");
                cbx_Product.Text = string.Empty;
                txt_Description.Text = string.Empty;
            }
            else
            {
                txt_Description.Text = cbx_Product.SelectedItem.Col2;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            arrival = new DEStockIn();
            clearScreen();
        }

        private void dtp_FilteredInDate_ValueChanged(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void txt_FilteredCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataGridView();
            }
        }

        private void dgv_ArrivalProduct_DoubleClick(object sender, EventArgs e)
        {
            arrival.StockInId = new Guid(Convert.ToString(dgv_ArrivalProduct.CurrentRow.Cells[1].Value));

            BLLStockIn obj_BLLStockIn = new BLLStockIn();
            bool bool_Result = obj_BLLStockIn.LoadStockInRow(arrival);

            if (bool_Result == true)
            {
                DisplayData(arrival);
            }
            else
            {
                MessageBox.Show("Record is not found.");
            }
            
            obj_BLLStockIn = null;
        }

        public void DisplayData(DEStockIn arrival)
        {
            dtp_InDate.Value = arrival.StockInDate;
            cbx_Product.SelectedValue = arrival.Product_Id.ToString();
            cbx_Product.Enabled = false;
            txt_Description.Text = arrival.Product_Description;
            txt_NoOfCartons.Text = arrival.NoOfCartons.ToString();
            txt_NoOfUnits.Text = arrival.NoOfUnits.ToString();

        }

        private void txt_NoOfUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        
    }
}
