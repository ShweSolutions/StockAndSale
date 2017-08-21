using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace StockAndSale
{
    public partial class Frm_CustomerSaleReport : Form
    {
        public Frm_CustomerSaleReport()
        {
            InitializeComponent();

            bindCustomerCombo();

            bindCatagoryCombo();

            bindCsutomerGroupCombo();

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            rdo_Sale.Checked = true;

            lbl_Customer.Visible = true;
            cbx_Customer.Visible = true;
            lbl_CustomerGroup.Visible = false;
            cbx_CustomerGroup.Visible = false;

            this.search();
        }

        private void bindCsutomerGroupCombo()
        {
            BLLCustomerCategory obj_BLLCatagory = new BLLCustomerCategory();
            DataTable dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllData();

            cbx_CustomerGroup.Items.Clear();
            cbx_CustomerGroup.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_CustomerGroup.SourceDataString = new string[] { "Catagory_Description", "Catagory_Id", "Catagory_Id", "Catagory_Id" };
            cbx_CustomerGroup.ColumnNum = 3;
            cbx_CustomerGroup.ColumnWidth = "150;0;0,0";
            cbx_CustomerGroup.SourceDataTable = dt_Catagory;

            cbx_CustomerGroup.Text = string.Empty;
        }

        private void bindCatagoryCombo()
        {
            BLLCatagory obj_BLLCatagory = new BLLCatagory();
            DataTable dt_Category = obj_BLLCatagory.LoadCatagoryTableForAllData();

            cbx_Category.Items.Clear();
            cbx_Category.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Category.SourceDataString = new string[] { "Catagory_Description", "Catagory_Id", "Catagory_Id", "Catagory_Id" };
            cbx_Category.ColumnNum = 3;
            cbx_Category.ColumnWidth = "150;0;0,0";
            cbx_Category.SourceDataTable = dt_Category;

            cbx_Category.Text = string.Empty;

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

        private void Frm_CustomerSaleReport_Load(object sender, EventArgs e)
        {
            
        }

        private void search()
        {
            if(false) //(cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
            {
                ErrorProvider.SetError(cbx_Customer, "Please Select Customer");
                string str_error = ErrorProvider.GetError(cbx_Customer);
                MessageBox.Show(str_error);

                ErrorProvider.Clear();
            }
            else
            {
                BLLInvoice obj_BLLInvoice = new BLLInvoice();

                DECustomer customer = new DECustomer();
                DEInvoice invoice = new DEInvoice();

                DECatagory category = new DECatagory();
                
                DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
                DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

                try
                {
                    customer.Catagory_Id = Convert.ToInt32(cbx_CustomerGroup.SelectedItem.Col3);
                    customer.Catagory_Description = cbx_CustomerGroup.SelectedText;
                }
                catch (Exception ex)
                {
                    customer.Catagory_Id = 0;
                    customer.Customer_Description = "";
                }

                try
                {
                    customer.Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);                    
                }
                catch (Exception ex)
                {
                    customer.Customer_Id = 0;
                }

                try
                {
                    category.Catagory_Id = Convert.ToInt32(cbx_Category.SelectedItem.Col3);
                }
                catch (Exception ex)
                {
                    category.Catagory_Id = 0;
                }

                invoice.Customer_Id = customer.Customer_Id;
                customer.Customer_Description = cbx_Customer.Text;
                customer.Address = txt_Address.Text;
                customer.Phone = txt_PhoneNo.Text;

                DataTable dt_Sale = new DataTable();
                DataTable dt_Return = new DataTable();

                if (rdo_Customer.Checked)
                {
                    dt_Sale = obj_BLLInvoice.LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerId(invoice.Customer_Id, dateTime_From, dateTime_To, category.Catagory_Id);
                    dt_Return = obj_BLLInvoice.LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerId(invoice.Customer_Id, dateTime_From, dateTime_To, category.Catagory_Id);
                }
                else
                {
                    dt_Sale = obj_BLLInvoice.LoadInvoiceDetailTableForAllDataByInvoiceDateCustomerGroupId(customer.Catagory_Id, dateTime_From, dateTime_To, category.Catagory_Id);
                    dt_Return = obj_BLLInvoice.LoadProductReturnSummaryTableForAllDataByInvoiceDateCustomerId(customer.Catagory_Id, dateTime_From, dateTime_To, category.Catagory_Id);
                }

                if (rdo_Sale.Checked == true)
                    bindSaleReport(customer, dt_Sale);
                else
                    bindReturnReport(customer, dt_Return);
            }
        }

        private void bindSaleReport(DECustomer customer, DataTable dt_Sale)
        {
            rptv_CustomerSaleReport.Clear();
            rptv_CustomerSaleReport.Reset();

            rptv_CustomerSaleReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_CustomerSaleReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CustomerSaleRpt.rdlc";

            ReportDataSource ds_CustomerSaleSummary = new ReportDataSource();
            ds_CustomerSaleSummary.Name = "DS_CustomerSaleReturnRpt_dt_CustomerSale";
            ds_CustomerSaleSummary.Value = dt_Sale;

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parCustomer = new ReportParameter();
            parCustomer.Name = "parCustomer";

            ReportParameter parAddress = new ReportParameter();
            parAddress.Name = "parAddress";

            ReportParameter parPhone = new ReportParameter();
            parPhone.Name = "parPhone";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

            if (rdo_Customer.Checked)
            {
                parCustomer.Values.Add(customer.Customer_Description);
                parAddress.Values.Add(customer.Address);
                parPhone.Values.Add(customer.Phone);
            }
            else
            {
                parCustomer.Values.Add(customer.Catagory_Description);
                parAddress.Values.Add("");
                parPhone.Values.Add("");
            }

            parAddress.Values.Add(customer.Address);
            parPhone.Values.Add(customer.Phone);

            rptv_CustomerSaleReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo,parCustomer,parAddress,parPhone });

            localReport.DataSources.Add(ds_CustomerSaleSummary);

            rptv_CustomerSaleReport.RefreshReport();
        }

        private void bindReturnReport(DECustomer customer, DataTable dt_Return)
        {
            rptv_CustomerSaleReport.Clear();
            rptv_CustomerSaleReport.Reset();

            rptv_CustomerSaleReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_CustomerSaleReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CustomerReturnRpt.rdlc";

            ReportDataSource ds_CustomerSaleSummary = new ReportDataSource();
            ds_CustomerSaleSummary.Name = "DS_CustomerSaleReturnRpt_dt_CustomerReturn";
            ds_CustomerSaleSummary.Value = dt_Return;

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parCustomer = new ReportParameter();
            parCustomer.Name = "parCustomer";

            ReportParameter parAddress = new ReportParameter();
            parAddress.Name = "parAddress";

            ReportParameter parPhone = new ReportParameter();
            parPhone.Name = "parPhone";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

            if (rdo_Customer.Checked)
            {
                parCustomer.Values.Add(customer.Customer_Description);
                parAddress.Values.Add(customer.Address);
                parPhone.Values.Add(customer.Phone);
            }
            else
            {
                parCustomer.Values.Add(customer.Catagory_Description);
                parAddress.Values.Add("");
                parPhone.Values.Add("");
            }

            rptv_CustomerSaleReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo, parCustomer, parAddress, parPhone });

            localReport.DataSources.Add(ds_CustomerSaleSummary);

            rptv_CustomerSaleReport.RefreshReport();
        }

        private void cbx_Customer_Leave(object sender, EventArgs e)
        {
            if (cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
            {
                //MessageBox.Show("Invalid Customer");
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
                    //MessageBox.Show("Invalid Customer");
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void rdo_Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Customer.Checked)
            {
                lbl_Customer.Visible = true;
                cbx_Customer.Visible = true;
                lbl_CustomerGroup.Visible = false;
                cbx_CustomerGroup.Visible = false;
                lbl_Address.Visible = true;
                txt_Address.Visible = true;
                lbl_PhoneNo.Visible = true;
                txt_PhoneNo.Visible = true;
            }
            else
            {
                lbl_Customer.Visible = false;
                cbx_Customer.Visible = false;
                lbl_CustomerGroup.Visible = true;
                cbx_CustomerGroup.Visible = true;
                lbl_Address.Visible = false;
                txt_Address.Visible = false;
                lbl_PhoneNo.Visible = false;
                txt_PhoneNo.Visible = false;
            }
        }
    }
}
