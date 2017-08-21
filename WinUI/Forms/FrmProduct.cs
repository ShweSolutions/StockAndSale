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
    public partial class FrmProduct : Form
    {
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void clearScreen()
        {
            txt_Code.Tag = 0;
            txt_Code.Text = string.Empty;
            txt_Description.Text = string.Empty;
            txt_Weight.Text = string.Empty;
            txt_NoOfUnits.Text = string.Empty;
            txt_UnitPrice.Text = string.Empty;
            txt_CartonPrice.Text = string.Empty;
            cbx_Catagory.Text = string.Empty;
            txt_UnitPrice2.Text = string.Empty;
            txt_CartonPrice2.Text = string.Empty;
            txt_MinLvl.Text = string.Empty;
            txt_ReorderCtn.Text = string.Empty;
            txt_SrNo.Text = string.Empty;

            bindCatagoryCombo();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                this.save();
            }
        }

        private void AssignData(DEProduct product)
        {
            product.Product_Id = Convert.ToInt32(txt_Code.Tag);
            product.Product_Code = txt_Code.Text.Trim();
            product.Product_Description = txt_Description.Text;
            product.Unit_Weight = Convert.ToDecimal(txt_Weight.Text);
            product.NoOfUnitsPerCarton = Convert.ToInt32(txt_NoOfUnits.Text);
            product.Unit_Price = Convert.ToDecimal(txt_UnitPrice.Text);
            product.Carton_Price = Convert.ToDecimal(txt_CartonPrice.Text);
            product.Unit_Price2 = Convert.ToDecimal(txt_UnitPrice2.Text);
            product.Carton_Price2 = Convert.ToDecimal(txt_CartonPrice2.Text);
            product.MinLVL = Convert.ToInt32(txt_MinLvl.Text);
            product.ReorderCtn = Convert.ToInt32(txt_ReorderCtn.Text);

            try
            {
                product.Catagory_Id = Convert.ToInt32(cbx_Catagory.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                product.Catagory_Id = 0;
            }

            try
            {
                product.SrNo = Convert.ToInt32(txt_SrNo.Text);
            }
            catch (Exception ex)
            {
                product.SrNo = 0;
            }
        }

        private void save()
        {
            DEProduct product = new DEProduct();
            AssignData(product);

            BLLProduct obj_BLLProduct = new BLLProduct();

            try
            {
                int int_Result = obj_BLLProduct.InsertData(product);

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
                product = null;
                obj_BLLProduct = null;
            }

        }

        private void BindDataGridView()
        {
            DEProduct product = new DEProduct();

            BLLProduct obj_BLLProduct = new BLLProduct();

            DataTable dt_Product;

            if (txt_FilteredCode.Text.Trim().Length <= 0)
            {
                dt_Product = obj_BLLProduct.LoadProductTableForAllData();
            }
            else
            {
                product.Product_Code = txt_FilteredCode.Text;
                dt_Product = obj_BLLProduct.LoadProductTableForAllDataByProductCode(product);
            }

            dgv_Product.DataSource = dt_Product;

            NumberingTableForDataGridView(dt_Product);

            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgv_Product.Columns[0].HeaderText = "No";
            dgv_Product.Columns[0].Width = 40;
            dgv_Product.Columns[0].ReadOnly = true;

            dgv_Product.Columns[1].Visible = false; // Product_Id

            dgv_Product.Columns[2].HeaderText = "Product Code"; // Product Code
            dgv_Product.Columns[2].Width = 130;
            dgv_Product.Columns[2].ReadOnly = true;

            dgv_Product.Columns[3].HeaderText = "Description"; // Description
            dgv_Product.Columns[3].Width = 200;
            dgv_Product.Columns[3].ReadOnly = true;

            dgv_Product.Columns[4].HeaderText = "Weight"; // Weight
            dgv_Product.Columns[4].Width = 80;
            dgv_Product.Columns[4].ReadOnly = true;

            dgv_Product.Columns[5].HeaderText = "NoOfUnits"; // NoOfUnits
            dgv_Product.Columns[5].Width = 80;
            dgv_Product.Columns[5].ReadOnly = true;

            dgv_Product.Columns[6].HeaderText = "Unit Price"; // Unit Price
            dgv_Product.Columns[6].Width = 80;
            dgv_Product.Columns[6].ReadOnly = true;

            dgv_Product.Columns[7].HeaderText = "Carton Price"; // Carton Price
            dgv_Product.Columns[7].Width = 80;
            dgv_Product.Columns[7].ReadOnly = true;

            dgv_Product.Columns[8].Visible = false; // Buying Price
            dgv_Product.Columns[9].Visible = false; // Cat ID
            dgv_Product.Columns[10].Visible = false; // Cat Desc
            dgv_Product.Columns[11].Visible = false; // Active
            dgv_Product.Columns[12].Visible = false; // ModifiedBy
            dgv_Product.Columns[13].Visible = false; // ModifiedDate

            dgv_Product.Columns[14].HeaderText = "Sr No."; // Carton Price
            dgv_Product.Columns[14].Width = 80;
            dgv_Product.Columns[14].ReadOnly = true;
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            clearScreen();
            BindDataGridView();
            FormatDataGridViewStyle();
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_Product);
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            if (txt_Code.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Code, "Enter Product Code");
                string str_error = ErrorProvider.GetError(txt_Code);
                MessageBox.Show(str_error);
            }
            else if (txt_Description.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Description, "Enter Product Description");
                string str_error = ErrorProvider.GetError(txt_Description);
                MessageBox.Show(str_error);
            }
            else if (txt_Weight.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Weight, "Enter Net Weight");
                string str_error = ErrorProvider.GetError(txt_Weight);
                MessageBox.Show(str_error);
            }
            else if (txt_NoOfUnits.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_NoOfUnits, "Enter No: Of Units Per Carton");
                string str_error = ErrorProvider.GetError(txt_NoOfUnits);
                MessageBox.Show(str_error);
            }
            else if (txt_UnitPrice.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_UnitPrice, "Enter Unit Price 1");
                string str_error = ErrorProvider.GetError(txt_UnitPrice);
                MessageBox.Show(str_error);
            }
            else if (txt_CartonPrice.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_CartonPrice, "Enter Carton Price 1");
                string str_error = ErrorProvider.GetError(txt_CartonPrice);
                MessageBox.Show(str_error);
            }
            else if (cbx_Catagory.Text.Trim().Length == 0 || cbx_Catagory.SelectedValue == null)
            {
                bool_Test = false;
                ErrorProvider.SetError(cbx_Catagory, "Please Select Product Catagory");
                string str_error = ErrorProvider.GetError(cbx_Catagory);
                MessageBox.Show(str_error);
            }
            else if (txt_UnitPrice2.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_UnitPrice2, "Enter Unit Price 2");
                string str_error = ErrorProvider.GetError(txt_UnitPrice2);
                MessageBox.Show(str_error);
            }
            else if (txt_CartonPrice2.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_CartonPrice2, "Enter Carton Price 2");
                string str_error = ErrorProvider.GetError(txt_CartonPrice2);
                MessageBox.Show(str_error);
            }
            else if (txt_MinLvl.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_MinLvl, "Enter Minimum Stock Level");
                string str_error = ErrorProvider.GetError(txt_MinLvl);
                MessageBox.Show(str_error);
            }
            else if (txt_ReorderCtn.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_ReorderCtn, "Enter Reorder cartons");
                string str_error = ErrorProvider.GetError(txt_ReorderCtn);
                MessageBox.Show(str_error);
            }

            ErrorProvider.Clear();
            return bool_Test;
        }


        private void bindCatagoryCombo()
        {
            BLLCatagory obj_BLLCatagory = new BLLCatagory();
            DataTable dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllData();

            cbx_Catagory.Items.Clear();
            cbx_Catagory.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Catagory.SourceDataString = new string[] { "Catagory_Description", "Catagory_Id", "Catagory_Id", "Catagory_Id" };
            cbx_Catagory.ColumnNum = 3;
            cbx_Catagory.ColumnWidth = "150;0;0,0";
            cbx_Catagory.SourceDataTable = dt_Catagory;

            cbx_Catagory.Text = string.Empty;

        }

        private void txt_Weight_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_NoOfUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        private void txt_UnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_CartonPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_FilteredCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataGridView();
            }
        }

        private void dgv_Product_DoubleClick(object sender, EventArgs e)
        {
            DEProduct product = new DEProduct();
            product.Product_Id = Convert.ToInt32(dgv_Product.CurrentRow.Cells[1].Value);

            BLLProduct obj_BLLProduct = new BLLProduct();
            bool bool_Result = obj_BLLProduct.LoadProductRow(product);

            if (bool_Result == true)
            {
                DisplayData(product);
            }
            else
            {
                MessageBox.Show("Record is not found.");
            }

            product = null;
            obj_BLLProduct = null;
        }

        private void DisplayData(DEProduct product)
        {
            txt_Code.Tag = product.Product_Id;
            txt_Code.Text = product.Product_Code;
            txt_Description.Text = product.Product_Description;
            txt_Weight.Text = Convert.ToString(product.Unit_Weight);
            txt_NoOfUnits.Text = Convert.ToString(product.NoOfUnitsPerCarton);
            txt_UnitPrice.Text = Convert.ToString(product.Unit_Price);
            txt_CartonPrice.Text = Convert.ToString(product.Carton_Price);
            cbx_Catagory.SelectedValue = product.Catagory_Id.ToString();
            txt_UnitPrice2.Text = Convert.ToString(product.Unit_Price2);
            txt_CartonPrice2.Text = Convert.ToString(product.Carton_Price2);
            txt_MinLvl.Text = Convert.ToString(product.MinLVL);
            txt_ReorderCtn.Text = Convert.ToString(product.ReorderCtn);
            txt_SrNo.Text = Convert.ToString(product.SrNo);
        }

        private void txt_UnitPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_CartonPrice2_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_MinLvl_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        private void txt_ReorderCtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        private void txt_SrNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }
    }
}
