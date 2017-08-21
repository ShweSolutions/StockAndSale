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
    public partial class FrmConsignmentInvoice : Form
    {
        CtrlSale ctrlSale;

        public FrmConsignmentInvoice()
        {
            InitializeComponent();
            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            lbl_ReturnStatus.Text = "No";
        }

        DateTime dt_DateAndTime;

        public FrmConsignmentInvoice(DEInvoice inv)
        {
            InitializeComponent();
            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            this.invoice = inv;
            
        }

        public FrmConsignmentInvoice(CtrlSale saleTemp)
        {
            InitializeComponent();
            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            lbl_ReturnStatus.Text = "No";
            ctrlSale = saleTemp;
        }

        public FrmConsignmentInvoice(DEInvoice inv, CtrlSale saleTemp)
        {
            InitializeComponent();
            rdo_isCarton.Checked = true;
            rdo_Price1.Checked = true;
            this.invoice = inv;

            ctrlSale = saleTemp;

        }      

        DEInvoice invoice = new DEInvoice();

        DEInvoiceDetail invoiceDetail = new DEInvoiceDetail();

        DataTable dt_ProductList = new DataTable();

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

        private void generateNewInvoice(out String str_InvoiceNo, out DEInvoiceNo inv)
        {
            str_InvoiceNo = string.Empty;

            DEInvoiceNo invoiceNo = new DEInvoiceNo();
            invoiceNo.Type = 3;

            BLLInvoiceNo obj_BLLInvoiceNo = new BLLInvoiceNo();

            Boolean hasRow = obj_BLLInvoiceNo.LoadInvoiceNoRow(invoiceNo);

            if (hasRow)
            {
                String str_Temp = string.Empty;

                if ((invoiceNo.Current_Id + 1).ToString().Length == 4)
                {
                    str_Temp = "0";
                }
                else if ((invoiceNo.Current_Id + 1).ToString().Length == 3)
                {
                    str_Temp = "00";
                }
                else if ((invoiceNo.Current_Id + 1).ToString().Length == 2)
                {
                    str_Temp = "000";
                }
                else if ((invoiceNo.Current_Id + 1).ToString().Length == 1)
                {
                    str_Temp = "0000";
                }                

                invoiceNo.Year = DateTime.Today.Year;
                invoiceNo.Current_Id = (invoiceNo.Current_Id + 1);

                str_InvoiceNo = invoiceNo.PreFix.ToString() + "-" + str_Temp + (invoiceNo.Current_Id).ToString();

                txt_Invoice_No.Text = str_InvoiceNo;
            }

            inv = invoiceNo;
        }

        private void saveInvoice()
        {
            if (cbx_Customer.Text.Length == 0 || cbx_Customer.SelectedValue == null)
            {
                ErrorProvider.SetError(cbx_Customer, "Please Select Customer First");
                string str_error = ErrorProvider.GetError(cbx_Customer);
                MessageBox.Show(str_error);
                ErrorProvider.Clear();
            }
            else
            {

                invoice.Invoice_Id = Guid.NewGuid();
                invoice.Invoice_No = txt_Invoice_No.Text.Trim();
                invoice.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
                invoice.InvoiceType_Id = 3;
                invoice.isPaid = false;
                invoice.IsPromotion = chb_IsPromotion.Checked;
                invoice.IsInclusiveTax = chb_InclusiveTax.Checked;
                invoice.IsSample = chb_IsSample.Checked;
                invoice.PromDesc = txt_PromDesc.Text;
                invoice.PONumber = txt_PONumber.Text;

                BLLInvoice obj_BLLInvoice = new BLLInvoice();

                DataTable dt_InvoiceNo = obj_BLLInvoice.LoadInvoiceTableForAllDataByInvoice_No(invoice);

                if (dt_InvoiceNo.Rows.Count > 0)
                {
                    ErrorProvider.SetError(txt_Invoice_No, "Invoice No is already Existed");
                    string str_error = ErrorProvider.GetError(txt_Invoice_No);
                    MessageBox.Show(str_error);
                    ErrorProvider.Clear();
                    invoice = new DEInvoice();
                }

                else
                {

                    try
                    {
                        int int_Result = obj_BLLInvoice.InsertData(invoice, new DEInvoiceNo());

                        if (int_Result > 0)
                        {
                            this.save();
                            this.assignInvoiceData();
                            this.upDateInvoice();
                            //MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        obj_BLLInvoice = null;
                    }
                }
            }
            
        }

        private void btn_NewInvoiceNo_Click(object sender, EventArgs e)
        {
            //if (txt_Invoice_No.Text.Length > 0)
            //{

            //}
            //else
            //{
            //    if (cbx_Customer.Text.Length == 0 || cbx_Customer.SelectedValue == null)
            //    {
            //        ErrorProvider.SetError(cbx_Customer, "Please Select Customer First");
            //        string str_error = ErrorProvider.GetError(cbx_Customer);
            //        MessageBox.Show(str_error);
            //        ErrorProvider.Clear();
            //    }
            //    else
            //    {
            //        String InvoiceNo = null;
            //        DEInvoiceNo invNo = new DEInvoiceNo();

            //        generateNewInvoice(out InvoiceNo, out invNo);

            //        invoice.Invoice_Id = Guid.NewGuid();
            //        invoice.Invoice_No = InvoiceNo;
            //        invoice.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            //        invoice.InvoiceType_Id = 3;
            //        invoice.isPaid = false;

            //        BLLInvoice obj_BLLInvoice = new BLLInvoice();

            //        try
            //        {
            //            int int_Result = obj_BLLInvoice.InsertData(invoice, invNo);

            //            if (int_Result > 0)
            //            {

            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            throw ex;
            //        }
            //        finally
            //        {
            //            obj_BLLInvoice = null;
            //        }
            //    }
            //}
        }

            private void FormatDataGridViewStyle()
            {
            UIControl.FormatDataGridView(dgv_ProductList);
            }

        private void FrmConsignmentInvoice_Load(object sender, EventArgs e)
        {
            dt_DateAndTime = Convert.ToDateTime(dtp_InvoiceDetailDate.Value);
            lbl_Date.Text = dt_DateAndTime.ToLongDateString();
            lbl_Time.Text = dt_DateAndTime.ToLongTimeString();
            Timer.Start();

            bindCustomerCombo();
            bindProductCombo();
            FormatDataGridViewStyle();

            if (invoice.Invoice_Id == Guid.Empty)
            {
                
            }
            else
            {
                BindDataGridView();

                BLLInvoice obj_BLLInvoice = new BLLInvoice();

                Boolean has_Row = obj_BLLInvoice.LoadInvoiceRow(invoice);

                if (has_Row)
                {
                    displayInvoiceData();
                }                
            }
        }

        private void displayInvoiceData()
        {
            txt_Invoice_No.Text = invoice.Invoice_No;
            dtp_InvoiceDate.Value = invoice.Invoice_Date;
            dtp_InvoiceDueDate.Value = invoice.Invoice_Due_Date;
            txt_Name.Text = invoice.Customer_Name;
            cbx_Customer.SelectedValue = invoice.Customer_Id.ToString();
            txt_Address.Text = invoice.Address;
            txt_PhoneNo.Text = invoice.Phone;
            chb_IsPromotion.Checked = invoice.IsPromotion;
            chb_IsSample.Checked = invoice.IsSample;
            chb_InclusiveTax.Checked = invoice.IsInclusiveTax;
            txt_PromDesc.Text = invoice.PromDesc;
            txt_PONumber.Text = invoice.PONumber;

            txt_Advance.Text = Convert.ToString(invoice.Advance);
            txt_CommercialTax.Text = invoice.CommercialTax.ToString("##.##");
            txt_DiscountPercent.Text = Convert.ToString(invoice.DiscountPercent);
            txt_Discount.Text = Convert.ToString(invoice.Discount);
            txt_DDPercent.Text = Convert.ToString(invoice.DDPercent);
            txt_DeliveryDiscount.Text = Convert.ToString(invoice.DeliveryDiscount);
            txt_Remark.Text = Convert.ToString(invoice.Remark);

            if (invoice.isPaid == true)
            {
                btn_Save.Enabled = false;
                btn_Add.Enabled = false;
                btn_Receive.Text = "UnPaid";
                btn_DeleteRow.Enabled = false;

                lbl_PaymentDate.Text = invoice.PayDate.ToShortDateString();
                lbl_PaymentStatus.Visible = true;
                lbl_PaymentDate.Visible = true;
            }
            else
            {
                btn_Save.Enabled = true;
                btn_Add.Enabled = true;
                btn_Receive.Text = "Paid";
                btn_DeleteRow.Enabled = true;

                lbl_PaymentDate.Text = "Date";
                lbl_PaymentStatus.Visible = false;
                lbl_PaymentDate.Visible = false;
            }

            if (invoice.isReturn == true)
            {
                lbl_ReturnStatus.Text = "Yes";
                showReturnAmount();
            }
            else
            {
                lbl_ReturnStatus.Text = "No";
                txt_Return.Text = "0";
            }
        }

        public void showReturnAmount()
        {
            DEInvoiceReturnDetail invoiceReturnDetail = new DEInvoiceReturnDetail();
            invoiceReturnDetail.Invoice_Id = invoice.Invoice_Id;

            BLLInvoiceReturnDetail obj_BLLInvoiceReturnDetail = new BLLInvoiceReturnDetail();

            DataTable dt_InvoiceReturnDetail;

            dt_InvoiceReturnDetail = obj_BLLInvoiceReturnDetail.LoadInvoiceReturnDetailTableForAllDataByInvoiceId(invoiceReturnDetail);

            calculateReturnTotal(dt_InvoiceReturnDetail);
        }

        public void calculateReturnTotal(DataTable dt_Temp)
        {
            Decimal dec_Total = 0;

            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dec_Total += Convert.ToDecimal(dt_Temp.Rows[i]["RAmount"].ToString());
            }

            txt_Return.Text = dec_Total.ToString();

        }

        private void txt_Quantity_Enter(object sender, EventArgs e)
        {
            if (cbx_Product.Text.Trim().Length == 0 || cbx_Product.SelectedValue == null)
            {
                cbx_Product.Focus();
            }
        }

        private void txt_Quantity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    Decimal dec_Rate = Convert.ToDecimal(txt_Rate.Text);
                    Decimal dec_Quantity = Convert.ToDecimal(txt_Quantity.Text);
                    Decimal dec_Total = dec_Rate * dec_Quantity;

                    if (chb_FOC.Checked)
                    {
                        txt_Amount.Text = string.Empty;
                    }
                    else
                    {
                        txt_Amount.Text = dec_Total.ToString();
                    }

                    btn_Add.Focus();

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void txt_Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);    
        }

        private void txt_Quantity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Decimal dec_Rate = Convert.ToDecimal(txt_Rate.Text);
                Decimal dec_Quantity = Convert.ToDecimal(txt_Quantity.Text);
                Decimal dec_Total = dec_Rate * dec_Quantity;

                if (chb_FOC.Checked)
                {
                    txt_Amount.Text = string.Empty;
                }
                else
                {
                    txt_Amount.Text = dec_Total.ToString();
                }

            }
            catch (Exception ex)
            {

            }
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
                    Decimal dec_tax = 0;

                    if (rdo_Price1.Checked == true)
                    {

                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price, 5);
                                txt_Rate.Text = (product.Carton_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price, 5);
                                txt_Rate.Text = (product.Unit_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                    }
                    else
                    {
                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price2, 5);
                                txt_Rate.Text = (product.Carton_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price2.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price2, 5);
                                txt_Rate.Text = (product.Unit_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price2.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price2 == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price2 / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                    }

                    txt_Quantity.Focus();
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
                        Decimal dec_tax = 0;

                        if (rdo_Price1.Checked == true)
                        {

                            if (rdo_isCarton.Checked == true)
                            {
                                ///
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    dec_tax = calculateTax(product.Carton_Price, 5);
                                    txt_Rate.Text = (product.Carton_Price - dec_tax).ToString();
                                }
                                else
                                    txt_Rate.Text = product.Carton_Price.ToString();
                            }
                            else if (rdo_isUnit.Checked == true)
                            {
                                ///
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    dec_tax = calculateTax(product.Unit_Price, 5);
                                    txt_Rate.Text = (product.Unit_Price - dec_tax).ToString();
                                }
                                else
                                    txt_Rate.Text = product.Unit_Price.ToString();
                            }
                            else if (rdo_CartonPricePerUnits.Checked == true)
                            {
                                ///
                                if (product.Carton_Price == 0)
                                    txt_Rate.Text = "0.00";
                                else
                                {
                                    if (chb_InclusiveTaxItem.Checked == true)
                                    {
                                        decimal amount = product.Carton_Price / product.NoOfUnitsPerCarton;
                                        dec_tax = calculateTax(amount, 5);
                                        txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                    }
                                    else
                                        txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                                }
                            }
                        }
                        else
                        {
                            if (rdo_isCarton.Checked == true)
                            {
                                ///
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    dec_tax = calculateTax(product.Carton_Price2, 5);
                                    txt_Rate.Text = (product.Carton_Price2 - dec_tax).ToString();
                                }
                                else
                                    txt_Rate.Text = product.Carton_Price2.ToString();
                            }
                            else if (rdo_isUnit.Checked == true)
                            {
                                ///
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    dec_tax = calculateTax(product.Unit_Price2, 5);
                                    txt_Rate.Text = (product.Unit_Price2 - dec_tax).ToString();
                                }
                                else
                                    txt_Rate.Text = product.Unit_Price2.ToString();
                            }
                            else if (rdo_CartonPricePerUnits.Checked == true)
                            {
                                ///
                                if (product.Carton_Price2 == 0)
                                    txt_Rate.Text = "0.00";
                                else
                                {
                                    if (chb_InclusiveTaxItem.Checked == true)
                                    {
                                        decimal amount = product.Carton_Price2 / product.NoOfUnitsPerCarton;
                                        dec_tax = calculateTax(amount, 5);
                                        txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                    }
                                    else
                                        txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                                }
                            }
                        }

                        txt_Quantity.Focus();
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
                    Decimal dec_tax = 0;

                    if (rdo_Price1.Checked == true)
                    {

                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price, 5);
                                txt_Rate.Text = (product.Carton_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price, 5);
                                txt_Rate.Text = (product.Unit_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                    }
                    else
                    {
                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price2, 5);
                                txt_Rate.Text = (product.Carton_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price2.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price2, 5);
                                txt_Rate.Text = (product.Unit_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price2.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price2 == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price2 / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
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

        private decimal calculateTax(decimal amount, decimal rate)
        {
            decimal tax = 0;

            //tax = (amount / 100) * rate;
            tax = Convert.ToDecimal((amount / 21).ToString("##.##"));

            return tax;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearProductDetail();
            btn_Add.Text = "Add";  
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (btn_Add.Text == "Add")
            {
                if (ValidateUserInput())
                {
                    if (invoice.Invoice_Id == Guid.Empty)
                    {
                        this.saveInvoice();
                    }
                    else
                    {
                        this.save();
                        this.assignInvoiceData();
                        this.upDateInvoice();
                    }
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

        private void btn_Add_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (btn_Add.Text == "Add")
                {
                    if (ValidateUserInput())
                    {
                        this.save();
                        this.assignInvoiceData();
                        this.upDateInvoice();
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
                    this.assignInvoiceData();
                    this.upDateInvoice();
                }
            }
        }

        private void txt_Total_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e); 
        }

        private void txt_Advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);
        }

        private void txt_Discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForDecimal(sender, e);   
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

        private void update()
        {

        }

        private void save()
        {
            invoiceDetail.InvoiceDetail_Id = Guid.NewGuid();
            invoiceDetail.Invoice_Id = invoice.Invoice_Id;
            invoiceDetail.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

            if (rdo_isCarton.Checked == true)
            {
                invoiceDetail.isCarton = true;
            }
            else
            {
                invoiceDetail.isCarton = false;
            }

            invoiceDetail.Qty = Convert.ToInt32(txt_Quantity.Text);
            invoiceDetail.Price = Convert.ToDecimal(txt_Rate.Text);

             try
            {
                invoiceDetail.Amount = Convert.ToDecimal(txt_Amount.Text);
            }
            catch (Exception ex)
            {
                invoiceDetail.Amount = 0;
            }

            if (chb_FOC.Checked)
            {
                invoiceDetail.FOC = "FOC";
            }

            invoiceDetail.ModifiedDate = Convert.ToDateTime(lbl_Date.Text + " " + lbl_Time.Text);

            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            try
            {
                int int_Result = obj_BLLInvoiceDetail.InsertData(invoiceDetail);

                if (int_Result > 0)
                {
                    this.upDateInvoice();
                    BindDataGridView();
                    clearProductDetail();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                invoiceDetail = new DEInvoiceDetail();
                obj_BLLInvoiceDetail = null;
                cbx_Product.Focus();
            }
        }

        private void delete()
        {
            invoiceDetail.InvoiceDetail_Id = new Guid(dgv_ProductList.CurrentRow.Cells[1].Value.ToString());
            invoiceDetail.Invoice_Id = new Guid(dgv_ProductList.CurrentRow.Cells[2].Value.ToString());
            invoiceDetail.Product_Id = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[3].Value.ToString());

            if (dgv_ProductList.CurrentRow.Cells[7].Value.ToString().Equals("Cartons"))
            {
                invoiceDetail.isCarton = true;
            }
            else
            {
                invoiceDetail.isCarton = false;
            }

            invoiceDetail.Qty = Convert.ToInt32(dgv_ProductList.CurrentRow.Cells[6].Value.ToString());
            invoiceDetail.Price = Convert.ToDecimal(dgv_ProductList.CurrentRow.Cells[8].Value.ToString());
            invoiceDetail.Amount = Convert.ToDecimal(dgv_ProductList.CurrentRow.Cells[9].Value.ToString());

            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            try
            {
                int int_Result = obj_BLLInvoiceDetail.DeleteData(invoiceDetail);

                if (int_Result > 0)
                {
                    BindDataGridView();
                    clearProductDetail();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                invoiceDetail = new DEInvoiceDetail();
                obj_BLLInvoiceDetail = null;
                cbx_Product.Focus();
            }
        }

        private void BindDataGridView()
        {
            DEInvoiceDetail invoiceDetail = new DEInvoiceDetail();
            invoiceDetail.Invoice_Id = invoice.Invoice_Id;

            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            DataTable dt_InvoiceDetail;

            dt_InvoiceDetail = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);

            dgv_ProductList.DataSource = dt_InvoiceDetail;

            NumberingTableForDataGridView(dt_InvoiceDetail);

            this.dt_ProductList = dt_InvoiceDetail;

            FormatDataGridView();

            calculateTotal(dt_InvoiceDetail);
            //calculateDiscount();
            //calculateDeliverDiscount();

        }

        private void calculateDeliverDiscount()
        {
            Decimal dec_DDiscount = 0;
            Decimal dec_Amount = 0;
            Decimal dec_DDPercent = 0;

            try
            {
                dec_Amount = Convert.ToDecimal(txt_Total.Text);
            }
            catch (Exception ex)
            {
                dec_Amount = 0;
            }

            try
            {
                dec_DDPercent = Convert.ToDecimal(txt_DDPercent.Text);
            }
            catch (Exception ex)
            {
                dec_DDPercent = 0;
            }

            dec_DDiscount = (dec_Amount / 100) * dec_DDPercent;

            txt_DeliveryDiscount.Text = dec_DDiscount.ToString("##.##");


        }

        private void calculateTotal(DataTable dt_Temp)
        {
            Decimal dec_Total = 0;
            Decimal dec_Advance = 0;
            Decimal dec_CommecialTax = 0;
            Decimal dec_Discount = 0;
            Decimal dec_ReturnAmount = 0;
            Decimal dec_DeliveryDiscount = 0;
            Decimal dec_GrandTotal = 0;

            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dec_Total += Convert.ToDecimal(dt_Temp.Rows[i]["Amount"].ToString());
            }

            txt_Total.Text = dec_Total.ToString();

            try
            {
                dec_Discount = Convert.ToDecimal(txt_Discount.Text);
            }
            catch (Exception ex)
            {
                dec_Discount = 0;
            }

            if (chb_InclusiveTax.Checked == true)
            {
                dec_CommecialTax = ((dec_Total - dec_Discount) / 100) * 5;
                //dec_CommecialTax = (dec_Total - dec_Discount) / 21;
                //dec_CommecialTax = (((dec_Total - dec_Discount) / 20) * 21) - dec_Total;
            }
            else
            {
                dec_CommecialTax = 0;
            }

            txt_CommercialTax.Text = dec_CommecialTax.ToString("##.##");           

            try
            {
                dec_ReturnAmount = Convert.ToDecimal(txt_Return.Text);
            }
            catch (Exception ex)
            {
                dec_ReturnAmount = 0;
            }

            try
            {
                dec_DeliveryDiscount = Convert.ToDecimal(txt_DeliveryDiscount.Text);
            }
            catch (Exception ex)
            {
                dec_DeliveryDiscount = 0;
            }

            try
            {
                dec_Advance = Convert.ToDecimal(txt_Advance.Text);
            }
            catch (Exception ex)
            {
                dec_Advance = 0;
            }

            dec_GrandTotal = dec_Total - dec_Advance - dec_Discount + dec_CommecialTax - dec_DeliveryDiscount;

            txt_GrandTotal.Text = dec_GrandTotal.ToString("##.##");

            if (dec_ReturnAmount == 0)
            {
                txt_DiffTotal.Text = "0";
            }
            else
            {
                txt_DiffTotal.Text = (dec_GrandTotal - dec_ReturnAmount).ToString("##.##");
            }

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
            dgv_ProductList.Columns[0].HeaderText = "No";
            dgv_ProductList.Columns[0].Width = 40;
            dgv_ProductList.Columns[0].ReadOnly = true;

            dgv_ProductList.Columns[1].Visible = false; // Stock_Id

            dgv_ProductList.Columns[2].Visible = false; // Stock_Id

            dgv_ProductList.Columns[3].Visible = false; // Stock_Id

            dgv_ProductList.Columns[4].HeaderText = "Code"; // Arrival In Date
            dgv_ProductList.Columns[4].Width = 130;
            dgv_ProductList.Columns[4].ReadOnly = true;

            dgv_ProductList.Columns[5].HeaderText = "Description"; // Product Code
            dgv_ProductList.Columns[5].Width = 280;
            dgv_ProductList.Columns[5].ReadOnly = true;

            dgv_ProductList.Columns[6].HeaderText = "Quantity"; // Product Description
            dgv_ProductList.Columns[6].Width = 90;
            dgv_ProductList.Columns[6].ReadOnly = true;

            dgv_ProductList.Columns[7].HeaderText = "Measurement"; // No Of Cartons
            dgv_ProductList.Columns[7].Width = 100;
            dgv_ProductList.Columns[7].ReadOnly = true;

            dgv_ProductList.Columns[8].HeaderText = "Rate"; // Product Description
            dgv_ProductList.Columns[8].Width = 100;
            dgv_ProductList.Columns[8].ReadOnly = true;

            dgv_ProductList.Columns[9].HeaderText = "Amount"; // No Of Cartons
            dgv_ProductList.Columns[9].Width = 120;
            dgv_ProductList.Columns[9].ReadOnly = true;
            dgv_ProductList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv_ProductList.Columns[10].Visible = false;

            dgv_ProductList.Columns[11].HeaderText = "Remark"; // No Of Cartons
            dgv_ProductList.Columns[11].Width = 60;
            dgv_ProductList.Columns[11].ReadOnly = true;
            dgv_ProductList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void clearProductDetail()
        {
            rdo_isCarton.Checked = true;
            cbx_Product.Text = string.Empty;
            txt_ProductDescription.Text = string.Empty;
            txt_Rate.Text = string.Empty;
            txt_Amount.Text = string.Empty;
            txt_Quantity.Text = string.Empty;
            chb_FOC.Checked = false;
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            int int_NoOfProductsInStore = 0;
            int int_NoOfProductsSale = 0;

            BLLProductInStore obj_BLLProductInStore = new BLLProductInStore();
            BLLProduct obj_BLLProduct = new BLLProduct();

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
            //else if (invoice.Invoice_Id == Guid.Empty)
            //{
            //    bool_Test = false;
            //    ErrorProvider.SetError(btn_Save, "Please Save Invoice First");
            //    string str_error = ErrorProvider.GetError(btn_Save);
            //    MessageBox.Show(str_error);
            //}
            else if (txt_Invoice_No.Text.Length <= 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Invoice_No, "Generate New Invoice");
                string str_error = ErrorProvider.GetError(txt_Invoice_No);
                MessageBox.Show(str_error);
            }
            else if (cbx_Customer.Text.Length == 0 || cbx_Customer.SelectedValue == null)
            {
                bool_Test = false;
                ErrorProvider.SetError(cbx_Customer, "Please Select Customer First");
                string str_error = ErrorProvider.GetError(cbx_Customer);
                MessageBox.Show(str_error);
            }
            else if (int_NoOfProductsSale > int_NoOfProductsInStore)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Quantity, "Not Enough Product");
                string str_error = ErrorProvider.GetError(txt_Quantity);
                MessageBox.Show(str_error);
            }
            else
            {
                try
                {
                    DEProductInStore productInStore = new DEProductInStore();
                    productInStore.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

                    DEProduct product = new DEProduct();
                    product.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);

                    DataTable dt_ProductInStore = obj_BLLProductInStore.LoadProductInStoreTableByProductId(productInStore);
                    obj_BLLProduct.LoadProductRow(product);

                    if (dt_ProductInStore.Rows.Count > 0)
                    {
                        int_NoOfProductsInStore = Convert.ToInt32(dt_ProductInStore.Rows[0][0].ToString());
                    }

                    if (rdo_isCarton.Checked == true)
                    {
                        int_NoOfProductsSale = product.NoOfUnitsPerCarton * Convert.ToInt32(txt_Quantity.Text);
                    }
                    else
                    {
                        int_NoOfProductsSale = Convert.ToInt32(txt_Quantity.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data Entry");

                    ErrorProvider.Clear();
                    return bool_Test;
                }
            }

            if (int_NoOfProductsSale > int_NoOfProductsInStore)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Quantity, "Not Enough Products in Store. Do you want to continue anyway?");
                string str_error = ErrorProvider.GetError(txt_Quantity);

                DialogResult Colse_Result;
                Colse_Result = MessageBox.Show(str_error, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Colse_Result == DialogResult.Yes)
                {
                    bool_Test = true;
                }

                //MessageBox.Show(str_error);
            }

            ErrorProvider.Clear();
            return bool_Test;
        }

        private void btn_Receive_Click(object sender, EventArgs e)
        {
            if (invoice.Invoice_Id == Guid.Empty)
            {
                ErrorProvider.SetError(btn_Save, "Please Save Invoice First");
                string str_error = ErrorProvider.GetError(btn_Save);
                MessageBox.Show(str_error);
                ErrorProvider.Clear();
            }
            else
            {
                if (btn_Receive.Text == "Paid")
                {
                    Frm_PaymentDate frm_PaymentDate = new Frm_PaymentDate();

                    if (frm_PaymentDate.ShowDialog() == DialogResult.OK)
                    {
                        BLLInvoice obj_BLLInvoice = new BLLInvoice();

                        invoice.PayDate = frm_PaymentDate.PaymentDate;
                        invoice.isPaid = true;

                        int int_Result = obj_BLLInvoice.UpdateData(invoice);

                        if (int_Result > 0)
                        {
                            btn_Save.Enabled = false;
                            btn_Add.Enabled = false;
                            btn_Receive.Text = "UnPaid";
                            btn_DeleteRow.Enabled = false;

                            lbl_PaymentDate.Text = invoice.PayDate.ToShortDateString();
                            lbl_PaymentStatus.Visible = true;
                            lbl_PaymentDate.Visible = true;
                        } // end of if(int_Result > 0)
                    } // end of frm_PaymentDate.ShowD()...
                } ////  end of if("Paid")
                else
                {
                    DialogResult Colse_Result;
                    Colse_Result = MessageBox.Show(" Are you sure you want to UnPaid ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Colse_Result == DialogResult.Yes)
                    {
                        BLLInvoice obj_BLLInvoice = new BLLInvoice();

                        invoice.PayDate = DEGlobal.dateTime_DefaultDate;
                        invoice.isPaid = false;

                        int int_Result = obj_BLLInvoice.UpdateData(invoice);

                        if (int_Result > 0)
                        {
                            btn_Save.Enabled = true;
                            btn_Add.Enabled = true;
                            btn_Receive.Text = "Paid";
                            btn_DeleteRow.Enabled = true;

                            lbl_PaymentDate.Text = "Date";
                            lbl_PaymentStatus.Visible = false;
                            lbl_PaymentDate.Visible = false;
                        }
                    }
                }

                if (ctrlSale != null)
                {
                    ctrlSale.search();
                }
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (txt_Invoice_No.Text.Length <= 0)
            {
                ErrorProvider.SetError(txt_Invoice_No, "Please Enter Invoice No");
                string str_error = ErrorProvider.GetError(txt_Invoice_No);
                MessageBox.Show(str_error);
                ErrorProvider.Clear();
            }
            else if (cbx_Customer.Text.Length == 0 || cbx_Customer.SelectedValue == null)
            {
                ErrorProvider.SetError(cbx_Customer, "Please Select Customer");
                string str_error = ErrorProvider.GetError(cbx_Customer);
                MessageBox.Show(str_error);
                ErrorProvider.Clear();
            }
            else if (dtp_InvoiceDueDate.Value < dtp_InvoiceDate.Value)
            {
                ErrorProvider.SetError(dtp_InvoiceDueDate, "Due Date must greater than Invoice Date");
                string str_error = ErrorProvider.GetError(dtp_InvoiceDueDate);
                MessageBox.Show(str_error);
                ErrorProvider.Clear();
            }
            else
            {
                try
                {
                    assignInvoiceData();

                    if (invoice.Invoice_Id == Guid.Empty)
                    {
                        this.saveInvoice();
                    }
                    else
                    {
                        this.upDateInvoice();
                        MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                    }

                    if (ctrlSale != null)
                    {
                        ctrlSale.search();
                    }
                    
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void assignInvoiceData()
        {
            invoice.Invoice_Date = Convert.ToDateTime(dtp_InvoiceDate.Text);
            invoice.Invoice_No = txt_Invoice_No.Text.Trim();
            invoice.Customer_Name = txt_Name.Text;
            invoice.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            invoice.IsPromotion = chb_IsPromotion.Checked;
            invoice.IsInclusiveTax = chb_InclusiveTax.Checked;
            invoice.IsSample = chb_IsSample.Checked;
            invoice.PromDesc = txt_PromDesc.Text;
            invoice.PONumber = txt_PONumber.Text;

            try
            {
                invoice.Total = Convert.ToDecimal(txt_Total.Text);
            }
            catch (Exception ex)
            {
                invoice.Total = 0;
            }

            try
            {
                invoice.CommercialTax = Convert.ToDecimal(txt_CommercialTax.Text);
            }
            catch (Exception ex)
            {
                invoice.CommercialTax = 0;
            }

            try
            {
                invoice.Advance = Convert.ToDecimal(txt_Advance.Text);
            }
            catch (Exception ex)
            {
                invoice.Advance = 0;
            }

            try
            {
                invoice.DiscountPercent = Convert.ToDecimal(txt_DiscountPercent.Text);
            }
            catch (Exception ex)
            {
                invoice.DiscountPercent = 0;
            }

            try
            {
                invoice.Discount = Convert.ToDecimal(txt_Discount.Text);
            }
            catch (Exception ex)
            {
                invoice.Discount = 0;
            }

            try
            {
                invoice.DDPercent = Convert.ToDecimal(txt_DDPercent.Text);
            }
            catch (Exception ex)
            {
                invoice.DDPercent = 0;
            }

            try
            {
                invoice.DeliveryDiscount = Convert.ToDecimal(txt_DeliveryDiscount.Text);
            }
            catch (Exception ex)
            {
                invoice.DeliveryDiscount = 0;
            }

            try
            {
                invoice.GrandTotal = Convert.ToDecimal(txt_GrandTotal.Text);
            }
            catch (Exception ex)
            {
                invoice.GrandTotal = 0;
            }

            invoice.Invoice_Due_Date = Convert.ToDateTime(dtp_InvoiceDueDate.Text);

            invoice.Remark = txt_Remark.Text;

        }

        private void upDateInvoice()
        {
            BLLInvoice obj_BLLInvoice = new BLLInvoice();
            try
            {
                int int_Result = obj_BLLInvoice.UpdateData(invoice);

                if (int_Result > 0)
                {                   

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {

                obj_BLLInvoice = null;
            }
        }

        private void txt_Discount_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(dt_ProductList);
        }

        private void btn_PreviewInvoice_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Invoice_No.Text.Length <= 0 || invoice.Invoice_Id == Guid.Empty)
                {
                    ErrorProvider.SetError(txt_Invoice_No, "Please Generate New Invoice");
                    string str_error = ErrorProvider.GetError(txt_Invoice_No);
                    MessageBox.Show(str_error);
                    ErrorProvider.Clear();
                }
                else
                {
                    Frm_ConsignInvoiceReport frm_ConsignInvoiceReport = new Frm_ConsignInvoiceReport(invoice.Invoice_Id);
                    frm_ConsignInvoiceReport.ShowDialog();
                }
            }
            catch (Exception ex)
            {                
                MessageBox.Show("Please Check your data back and Save");            
            }
        }



        private void btn_Return_Click(object sender, EventArgs e)
        {
            if (invoice.isReturn == false)
            {
                DialogResult Colse_Result;
                Colse_Result = MessageBox.Show(" Are you sure you want to change the Return Status ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Colse_Result == DialogResult.Yes)
                {
                    if (invoice.Invoice_Id == Guid.Empty)
                    {                        
                        ErrorProvider.SetError(btn_Save, "Please Save Invoice First");
                        string str_error = ErrorProvider.GetError(btn_Save);
                        MessageBox.Show(str_error);
                        ErrorProvider.Clear();
                    }
                    else
                    {

                        lbl_ReturnStatus.Text = "Yes";
                        invoice.isReturn = true;
                        this.upDateInvoice();

                        FrmConsignmentReturn frm_ConsignmentReturn = new FrmConsignmentReturn(this, invoice);
                        frm_ConsignmentReturn.ShowDialog();
                    }
                }
            }
            else
            {
                FrmConsignmentReturn frm_ConsignmentReturn = new FrmConsignmentReturn(this,invoice);
                frm_ConsignmentReturn.ShowDialog();
            }
        }

        private void txt_DiscountPercent_TextChanged(object sender, EventArgs e)
        {
            calculateDiscount();    
        }

        private void txt_DiscountPercent_KeyDown(object sender, KeyEventArgs e)
        {
            calculateDiscount();
        }

        private void txt_DiscountPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
                UIControl.KeyValidateForDecimal(sender, e);  
        }

        private void calculateDiscount()
        {
            Decimal dec_Discount = 0;
            Decimal dec_Amount = 0;
            Decimal dec_Percent = 0;

            try
            {
                dec_Amount = Convert.ToDecimal(txt_Total.Text);
            }
            catch (Exception ex)
            {
                dec_Amount = 0;
            }

            try
            {
                dec_Percent = Convert.ToDecimal(txt_DiscountPercent.Text);
            }
            catch (Exception ex)
            {
                dec_Percent = 0;
            }

            dec_Discount = (dec_Amount / 100) * dec_Percent;

            txt_Discount.Text = dec_Discount.ToString("##.##");


        }

        private void txt_Advance_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(dt_ProductList);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.dt_DateAndTime = dt_DateAndTime.AddSeconds(1);
            lbl_Date.Text = dt_DateAndTime.ToLongDateString();
            lbl_Time.Text = dt_DateAndTime.ToLongTimeString();
        }

        private void dtp_InvoiceDueDate_Leave(object sender, EventArgs e)
        {
            cbx_Product.Focus();
        }

        private void assignRate()
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
                    Decimal dec_tax = 0;

                    if (rdo_Price1.Checked == true)
                    {

                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price, 5);
                                txt_Rate.Text = (product.Carton_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price, 5);
                                txt_Rate.Text = (product.Unit_Price - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
                        }
                    }
                    else
                    {
                        if (rdo_isCarton.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Carton_Price2, 5);
                                txt_Rate.Text = (product.Carton_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Carton_Price2.ToString();
                        }
                        else if (rdo_isUnit.Checked == true)
                        {
                            ///
                            if (chb_InclusiveTaxItem.Checked == true)
                            {
                                dec_tax = calculateTax(product.Unit_Price2, 5);
                                txt_Rate.Text = (product.Unit_Price2 - dec_tax).ToString();
                            }
                            else
                                txt_Rate.Text = product.Unit_Price2.ToString();
                        }
                        else if (rdo_CartonPricePerUnits.Checked == true)
                        {
                            ///
                            if (product.Carton_Price2 == 0)
                                txt_Rate.Text = "0.00";
                            else
                            {
                                if (chb_InclusiveTaxItem.Checked == true)
                                {
                                    decimal amount = product.Carton_Price2 / product.NoOfUnitsPerCarton;
                                    dec_tax = calculateTax(amount, 5);
                                    txt_Rate.Text = (amount - dec_tax).ToString("##.##");
                                }
                                else
                                    txt_Rate.Text = (product.Carton_Price2 / product.NoOfUnitsPerCarton).ToString("##.##");
                            }
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

        private void chb_FOC_CheckedChanged(object sender, EventArgs e)
        {
            //if (chb_FOC.Checked)
            //{
            //    txt_Rate.Text = "0";
            //    txt_Amount.Text = string.Empty;
            //}
            //else
            //{
                assignRate();

                try
                {
                    Decimal dec_Rate = Convert.ToDecimal(txt_Rate.Text);
                    Decimal dec_Quantity = Convert.ToDecimal(txt_Quantity.Text);
                    Decimal dec_Total = dec_Rate * dec_Quantity;

                    if (chb_FOC.Checked)
                    {
                        txt_Amount.Text = string.Empty;
                    }
                    else
                    {
                        txt_Amount.Text = dec_Total.ToString();
                    }

                }
                catch (Exception ex)
                {

                }
            //}
        }

        private void chb_FOC_Leave(object sender, EventArgs e)
        {
            btn_Add.Focus();
        }

        private void chb_FOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Add.Focus();
            }
        }

        private void chb_IsPromotion_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_IsPromotion.Checked)
            {
                lbl_PromDesc.Visible = true;
                txt_PromDesc.Visible = true;
            }
            else
            {
                lbl_PromDesc.Visible = false;
                txt_PromDesc.Visible = false;
            }
        }

        private void chb_InclusiveTax_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_InclusiveTax.Checked == true)
                chb_InclusiveTaxItem.Checked = true;
            else
                chb_InclusiveTaxItem.Checked = false;

            BindDataGridView();
        }

        private void txt_DDPercent_TextChanged(object sender, EventArgs e)
        {
            calculateDeliverDiscount();
        }

        private void txt_DeliveryDiscount_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(dt_ProductList);
        }

        private void txt_Return_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(dt_ProductList);
        }

        private void txt_CommercialTax_TextChanged(object sender, EventArgs e)
        {
            calculateTotal(dt_ProductList);
        }



    }
}
