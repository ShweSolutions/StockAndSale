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
    public partial class Frm_CustomerReturn : Form
    {

        DateTime dt_DateAndTime;

        DECustomerReturn invoiceReturnDetail = new DECustomerReturn();

        DataTable dt_ProductList = new DataTable();

        CtrlStockIn stockIn = null;

        public Frm_CustomerReturn()
        {
            InitializeComponent();

            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            bindCustomerCombo();
            bindProductCombo();
        }

        public Frm_CustomerReturn(CtrlStockIn stockIn_Temp)
        {
            InitializeComponent();

            this.stockIn = stockIn_Temp;

            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            bindCustomerCombo();
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

        private void cbx_Customer_Leave(object sender, EventArgs e)
        {
            if (cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
            {
                MessageBox.Show("Invalid Customer");
                cbx_Customer.Text = string.Empty;
                txt_Address.Text = string.Empty;
                txt_PhoneNo.Text = string.Empty;
            }
            else
            {
                txt_Address.Text = cbx_Customer.SelectedItem.Col2;
                txt_PhoneNo.Text = cbx_Customer.SelectedItem.Col3;

                BindDataGridView();
            }
        }

        private void cbx_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
                {
                    MessageBox.Show("Invalid Customer");
                    cbx_Customer.Text = string.Empty;
                    txt_Address.Text = string.Empty;
                    txt_PhoneNo.Text = string.Empty;
                    cbx_Customer.Focus();
                }
                else
                {
                    txt_Address.Text = cbx_Customer.SelectedItem.Col2;
                    txt_PhoneNo.Text = cbx_Customer.SelectedItem.Col3;

                    BindDataGridView();
                    //cbx_Product.Focus();
                }
            }
        }

        private void cbx_Product_Leave(object sender, EventArgs e)
        {
            if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
            {
                cbx_Product.Text = string.Empty;
                txt_ProductDescription.Text = string.Empty;
                txt_Rate.Text = string.Empty;
                //cbx_Product.Focus();
            }
            else
            {
                txt_ProductDescription.Text = cbx_Product.SelectedItem.Col2;

                DEProduct product = new DEProduct();
                product.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

                BLLProduct obj_BLLProduct = new BLLProduct();

                bool bool_Result = obj_BLLProduct.LoadProductRow(product);

                if (bool_Result == true)
                {
                    if (rdo_Price1.Checked == true)
                    {

                        if (rdo_isCarton.Checked == true)
                        {
                            txt_Rate.Text = product.Carton_Price.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            txt_Rate.Text = product.Unit_Price.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                        }
                    }
                    else
                    {
                        if (rdo_isCarton.Checked == true)
                        {
                            txt_Rate.Text = product.Carton_Price2.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            txt_Rate.Text = product.Unit_Price2.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                        }
                    }
                }
                else
                {
                    cbx_Product.Text = string.Empty;
                    txt_ProductDescription.Text = string.Empty;
                }

                obj_BLLProduct = null;
            }
        }

        private void cbx_Product_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
                {
                    cbx_Product.Text = string.Empty;
                    txt_ProductDescription.Text = string.Empty;
                    txt_Rate.Text = string.Empty;
                    cbx_Product.Focus();
                }
                else
                {
                    txt_ProductDescription.Text = cbx_Product.SelectedItem.Col2;

                    DEProduct product = new DEProduct();
                    product.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

                    BLLProduct obj_BLLProduct = new BLLProduct();

                    bool bool_Result = obj_BLLProduct.LoadProductRow(product);

                    if (bool_Result == true)
                    {
                        if (rdo_Price1.Checked == true)
                        {

                            if (rdo_isCarton.Checked == true)
                            {
                                txt_Rate.Text = product.Carton_Price.ToString();
                            }
                            else if (rdo_isUnit.Checked == true)
                            {
                                txt_Rate.Text = product.Unit_Price.ToString();
                            }
                            else if (rdo_CartonPricePerUnits.Checked == true)
                            {
                                txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                        else
                        {
                            if (rdo_isCarton.Checked == true)
                            {
                                txt_Rate.Text = product.Carton_Price2.ToString();
                            }
                            else if (rdo_isUnit.Checked == true)
                            {
                                txt_Rate.Text = product.Unit_Price2.ToString();
                            }
                            else if (rdo_CartonPricePerUnits.Checked == true)
                            {
                                txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                    }
                    else
                    {
                        cbx_Product.Text = string.Empty;
                        txt_ProductDescription.Text = string.Empty;
                        cbx_Product.Focus();
                    }

                    obj_BLLProduct = null;
                }
            }
        }

        private void rdo_isCarton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
            {
                //MessageBox.Show("Invalid Product Code");
                cbx_Product.Text = string.Empty;
                txt_ProductDescription.Text = string.Empty;
                txt_Rate.Text = string.Empty;
                cbx_Product.Focus();
            }
            else
            {
                //txt_ProductDescription.Text = cbx_Product.SelectedItem.Col2;

                DEProduct product = new DEProduct();
                product.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

                BLLProduct obj_BLLProduct = new BLLProduct();

                bool bool_Result = obj_BLLProduct.LoadProductRow(product);

                if (bool_Result == true)
                {
                    if (rdo_Price1.Checked == true)
                    {

                        if (rdo_isCarton.Checked == true)
                        {
                            txt_Rate.Text = product.Carton_Price.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            txt_Rate.Text = product.Unit_Price.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            if (product.Carton_Price == 0)
                                txt_Rate.Text = "0.00";
                            else
                                txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                        }
                    }
                    else
                    {
                        if (rdo_isCarton.Checked == true)
                        {
                            txt_Rate.Text = product.Carton_Price2.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            txt_Rate.Text = product.Unit_Price2.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            if (product.Carton_Price2 == 0)
                                txt_Rate.Text = "0.00";
                            else
                                txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                        }
                    }

                    txt_Quantity.Focus();
                }
                else
                {
                    //MessageBox.Show("Invalid Product Code");
                    //cbx_Product.Text = string.Empty;
                    //txt_ProductDescription.Text = string.Empty;
                }

                obj_BLLProduct = null;
            }
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal dec_Rate = Convert.ToDecimal(txt_Rate.Text);
                Decimal dec_Quantity = Convert.ToDecimal(txt_Quantity.Text);
                Decimal dec_Total = dec_Rate * dec_Quantity;

                txt_Amount.Text = dec_Total.ToString();

            }
            catch (Exception ex)
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.dt_DateAndTime = dt_DateAndTime.AddSeconds(1);
            lbl_Date.Text = dt_DateAndTime.ToLongDateString();
            lbl_Time.Text = dt_DateAndTime.ToLongTimeString();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text == "Add")
            {
                if (ValidateUserInput())
                {
                    this.save();                   

                }
            }
            else
            {
                if (ValidateUserInput())
                {
                    this.update();

                    
                }
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
            else if (txt_Quantity.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Quantity, "Enter Quantity");
                string str_error = ErrorProvider.GetError(txt_Quantity);
                MessageBox.Show(str_error);
            }
            

            ErrorProvider.Clear();
            return bool_Test;
        }

        private void update()
        {

        }

        private void save()
        {
            invoiceReturnDetail.CustomerReturn_Id = Guid.NewGuid();
            invoiceReturnDetail.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            invoiceReturnDetail.ReturnDate = Convert.ToDateTime(dtp_ReturnDate.Value);
            invoiceReturnDetail.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

            if (rdo_isCarton.Checked == true)
            {
                invoiceReturnDetail.isCarton = true;
            }
            else
            {
                invoiceReturnDetail.isCarton = false;
            }

            invoiceReturnDetail.Qty = Convert.ToInt32(txt_Quantity.Text);
            invoiceReturnDetail.Price = Convert.ToDecimal(txt_Rate.Text);
            invoiceReturnDetail.Amount = Convert.ToDecimal(txt_Amount.Text);
            invoiceReturnDetail.ModifiedDate = Convert.ToDateTime(lbl_Date.Text + " " + lbl_Time.Text);

            BLLCustomerReturn obj_BLLInvoiceReturnDetail = new BLLCustomerReturn();

            try
            {
                int int_Result = obj_BLLInvoiceReturnDetail.InsertData(invoiceReturnDetail);

                if (int_Result > 0)
                {
                    BindDataGridView();
                    clearProductDetail();

                    if (stockIn != null) stockIn.RSearch();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                invoiceReturnDetail = new DECustomerReturn();
                obj_BLLInvoiceReturnDetail = null;
                cbx_Product.Focus();
            }
        }

        private void Frm_CustomerReturn_Load(object sender, EventArgs e)
        {
            dt_DateAndTime = Convert.ToDateTime(dtp_InvoiceDetailDate.Value);
            lbl_Date.Text = dt_DateAndTime.ToLongDateString();
            lbl_Time.Text = dt_DateAndTime.ToLongTimeString();
            Timer.Start();

            FormatDataGridViewStyle();

            BindDataGridView();
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_ProductList);
        }

        private void BindDataGridView()
        {
            DECustomerReturn customerReturnDetail = new DECustomerReturn();
            //customerReturnDetail.ReturnDate = Convert.ToDateTime(dtp_ReturnDate.Text);

            DateTime dateTime_From = Convert.ToDateTime(dtp_ReturnDate.Text);
            DateTime dateTime_To = Convert.ToDateTime(dtp_ReturnDate.Text).AddHours(23.9);

            try
            {
                customerReturnDetail.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            }
            catch (Exception ex)
            {
                return;
            }

            BLLCustomerReturn obj_BLLCustomerReturnDetail = new BLLCustomerReturn();

            DataTable dt_CustomerReturnDetail;

            dt_CustomerReturnDetail = obj_BLLCustomerReturnDetail.LoadCustomerReturnDetailTableForAllDataByReturn(dateTime_From, dateTime_To, customerReturnDetail);

            dgv_ProductList.DataSource = dt_CustomerReturnDetail;

            NumberingTableForDataGridView(dt_CustomerReturnDetail);

            this.dt_ProductList = dt_CustomerReturnDetail;

            FormatDataGridView();

            calculateTotal(dt_CustomerReturnDetail);
        }

        private void FormatDataGridView()
        {
            dgv_ProductList.Columns[0].HeaderText = "No";
            dgv_ProductList.Columns[0].Width = 40;
            dgv_ProductList.Columns[0].ReadOnly = true;

            dgv_ProductList.Columns[1].Visible = false; // 

            dgv_ProductList.Columns[2].Visible = false; // 

            dgv_ProductList.Columns[3].Visible = false; //

            dgv_ProductList.Columns[4].Visible = false; //

            dgv_ProductList.Columns[5].HeaderText = "Code"; // 
            dgv_ProductList.Columns[5].Width = 130;
            dgv_ProductList.Columns[5].ReadOnly = true;

            dgv_ProductList.Columns[6].HeaderText = "Description"; // Product Desc
            dgv_ProductList.Columns[6].Width = 300;
            dgv_ProductList.Columns[6].ReadOnly = true;

            dgv_ProductList.Columns[7].HeaderText = "Quantity"; // Qty
            dgv_ProductList.Columns[7].Width = 100;
            dgv_ProductList.Columns[7].ReadOnly = true;

            dgv_ProductList.Columns[8].HeaderText = "Measurement"; // No Of Cartons
            dgv_ProductList.Columns[8].Width = 100;
            dgv_ProductList.Columns[8].ReadOnly = true;

            dgv_ProductList.Columns[9].HeaderText = "Rate"; // Product Description
            dgv_ProductList.Columns[9].Width = 100;
            dgv_ProductList.Columns[9].ReadOnly = true;

            dgv_ProductList.Columns[10].HeaderText = "Amount"; // No Of Cartons
            dgv_ProductList.Columns[10].Width = 100;
            dgv_ProductList.Columns[10].ReadOnly = true;
            dgv_ProductList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_ProductList.Columns[11].Visible = false;
        }

        private void calculateTotal(DataTable dt_Temp)
        {
            Decimal dec_Total = 0;
            Decimal dec_Discount = 0;
            Decimal dec_GrandTotal = 0;

            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dec_Total += Convert.ToDecimal(dt_Temp.Rows[i]["RAmount"].ToString());
            }

            txt_Total.Text = dec_Total.ToString();

        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void clearProductDetail()
        {
            rdo_isCarton.Checked = true;
            cbx_Product.Text = string.Empty;
            txt_ProductDescription.Text = string.Empty;
            txt_Rate.Text = string.Empty;
            txt_Amount.Text = string.Empty;
            txt_Quantity.Text = string.Empty;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearProductDetail();
            btn_Add.Text = "Add";
        }

        private void dtp_ReturnDate_ValueChanged(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void btn_DeleteRow_Click(object sender, EventArgs e)
        {
            if (dgv_ProductList.Rows.Count > 0)
            {
                DialogResult Colse_Result;
                Colse_Result = MessageBox.Show(" Are you sure you want to Delete?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Colse_Result == DialogResult.Yes)
                {
                    this.delete();

                }
            }
        }

        private void delete()
        {
            invoiceReturnDetail.CustomerReturn_Id = new Guid(dgv_ProductList.CurrentRow.Cells[1].Value.ToString());            
            invoiceReturnDetail.Product_Id = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[4].Value.ToString());

            if (dgv_ProductList.CurrentRow.Cells[8].Value.ToString().Equals("Cartons"))
            {
                invoiceReturnDetail.isCarton = true;
            }
            else
            {
                invoiceReturnDetail.isCarton = false;
            }

            invoiceReturnDetail.Qty = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[7].Value.ToString());
            invoiceReturnDetail.Price = Convert.ToDecimal(dgv_ProductList.CurrentRow.Cells[9].Value.ToString());
            invoiceReturnDetail.Amount = Convert.ToDecimal(dgv_ProductList.CurrentRow.Cells[10].Value.ToString());

            BLLCustomerReturn obj_BLLCustomerReturn = new BLLCustomerReturn();

            try
            {
                int int_Result = obj_BLLCustomerReturn.DeleteData(invoiceReturnDetail);

                if (int_Result > 0)
                {
                    BindDataGridView();
                    clearProductDetail();

                    if (stockIn != null) stockIn.RSearch();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                invoiceReturnDetail = new DECustomerReturn();
                obj_BLLCustomerReturn = null;
                cbx_Product.Focus();
            }
        }

        private void txt_Rate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal dec_Rate = Convert.ToDecimal(txt_Rate.Text);
                Decimal dec_Quantity = Convert.ToDecimal(txt_Quantity.Text);
                Decimal dec_Total = dec_Rate * dec_Quantity;

                txt_Amount.Text = dec_Total.ToString();

            }
            catch (Exception ex)
            {

            }
        }


    }
}
