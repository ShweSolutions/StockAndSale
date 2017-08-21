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
    public partial class Frm_ProductInvoiceReport : Form
    {
        public Frm_ProductInvoiceReport()
        {
            InitializeComponent();

            bindProductCombo();            

            rdo_All.Checked = true;

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            this.search();
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

        private void Frm_ProductInvoiceReport_Load(object sender, EventArgs e)
        {
            this.search();
        }

        private void search()
        {            
            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();
            BLLInvoiceReturnDetail obj_BLLInvoiceReturnDetail = new BLLInvoiceReturnDetail();
            BLLProduct obj_BLLProduct = new BLLProduct();

            DEInvoiceDetail invDetail = new DEInvoiceDetail();
            DEInvoiceReturnDetail invRDetail = new DEInvoiceReturnDetail();

            DEProduct product = new DEProduct();           

            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));              

            try
            {
                invDetail.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);
                invRDetail.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);
                product.Product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                invDetail.Product_Id = 0;
                invRDetail.Product_Id = 0;
                product.Product_Id = 0;
            }

            

            DataTable dt_Sale = new DataTable();
            DataTable dt_Return = new DataTable();

            dt_Sale = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceDate(invDetail, dateTime_From, dateTime_To);
            dt_Return = obj_BLLInvoiceReturnDetail.LoadInvoiceReturnDetailTableForAllDataByInvoiceDate(invRDetail, dateTime_From, dateTime_To);
            
            obj_BLLProduct.LoadProductRow(product);

            bindReport(product,dt_Sale,dt_Return);

        }

        private void bindReport(DEProduct product, DataTable dt_Sale , DataTable dt_Return)
        {
            String str_Product_Code;
            String str_Product_Description;

            try
            {
                str_Product_Code = Convert.ToString(cbx_Product.SelectedItem.Col1);
            }
            catch (Exception ex)
            {
                str_Product_Code = string.Empty;
            }

            try
            {
                str_Product_Description = Convert.ToString(cbx_Product.SelectedItem.Col2);
            }
            catch (Exception ex)
            {
                str_Product_Description = string.Empty;
            }

            rptv_ProductInvoiceReport.Clear();
            rptv_ProductInvoiceReport.Reset();

            rptv_ProductInvoiceReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_ProductInvoiceReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_ProductInvoiceReport.rdlc";

            ReportDataSource ds_InvoiceSale = new ReportDataSource();
            ds_InvoiceSale.Name = "DS_InvoiceReport_dt_ProductSale";
            ds_InvoiceSale.Value = dt_Sale;

            ReportDataSource ds_InvoiceReturn = new ReportDataSource();
            ds_InvoiceReturn.Name = "DS_InvoiceReport_dt_ProductReturn";
            ds_InvoiceReturn.Value = dt_Return; 

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parShowSale = new ReportParameter();
            parShowSale.Name = "parShowSale";

            ReportParameter parShowReturn = new ReportParameter();
            parShowReturn.Name = "parShowReturn";

            ReportParameter parProductCode = new ReportParameter();
            parProductCode.Name = "parProductCode";

            ReportParameter parProductDescription = new ReportParameter();
            parProductDescription.Name = "parProductDescription";

            ReportParameter parNoOfUnitsPerCarton = new ReportParameter();
            parNoOfUnitsPerCarton.Name = "parNoOfUnitsPerCarton";
            
            
            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

            if (rdo_All.Checked)
            {
                parShowSale.Values.Add("true");
                parShowReturn.Values.Add("true");
            }
            else if (rdo_Sale.Checked)
            {
                parShowSale.Values.Add("true");
                parShowReturn.Values.Add("false");
            }
            else
            {
                parShowSale.Values.Add("false");
                parShowReturn.Values.Add("true");
            }

            parProductCode.Values.Add(str_Product_Code);
            parProductDescription.Values.Add(product.Product_Description);
            parNoOfUnitsPerCarton.Values.Add(product.NoOfUnitsPerCarton.ToString());

            rptv_ProductInvoiceReport.LocalReport.SetParameters(new ReportParameter[] {  parDateFrom, parDateTo,parShowSale,parShowReturn,parProductCode,parProductDescription,parNoOfUnitsPerCarton});

            localReport.DataSources.Add(ds_InvoiceSale);
            localReport.DataSources.Add(ds_InvoiceReturn);

            rptv_ProductInvoiceReport.RefreshReport();
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
                    this.search();
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void btn_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void dtp_InvoiceDateFrom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void dtp_InvoiceDateTo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Sale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Return_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_All_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

    }
}
