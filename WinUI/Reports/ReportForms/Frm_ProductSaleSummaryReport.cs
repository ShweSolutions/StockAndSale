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
    public partial class Frm_ProductSaleSummaryReport : Form
    {
        public Frm_ProductSaleSummaryReport()
        {
            InitializeComponent();

            bindCatagoryCombo();

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            rdo_Sale.Checked = true;

            this.search();
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

        

        private void Frm_ProductSaleSummaryReport_Load(object sender, EventArgs e)
        {
            //search();
        }

        private void search()
        {
            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

            DECatagory category = new DECatagory();

            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();
            BLLInvoiceReturnDetail obj_BLLInvoiceReturnDetail = new BLLInvoiceReturnDetail();

            try
            {
                category.Catagory_Id = Convert.ToInt32(cbx_Category.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                category.Catagory_Id = 0;
            }

            DataTable dt_Sale = obj_BLLInvoiceDetail.LoadProductSaleSummaryTableForAllDataByInvoiceDate(dateTime_From, dateTime_To, category.Catagory_Id);
            
            DataTable dt_Return = obj_BLLInvoiceReturnDetail.LoadProductReturnSummaryTableForAllDataByInvoiceDate(dateTime_From, dateTime_To, category.Catagory_Id);

            if (rdo_Sale.Checked == true)
                bindSaleSummaryReport(dt_Sale);
            else if (rdo_Return.Checked == true)
                bindReturnSummaryReport(dt_Return);

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void bindSaleSummaryReport(DataTable dt_Data)
        {
            rptv_ProductSummaryReport.Clear();
            rptv_ProductSummaryReport.Reset();

            rptv_ProductSummaryReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_ProductSummaryReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_ProductSaleSummaryReport.rdlc";

            ReportDataSource ds_SaleReturnSummary = new ReportDataSource();
            ds_SaleReturnSummary.Name = "DS_SaleReturnSummaryReport_dt_SaleSummary";
            ds_SaleReturnSummary.Value = dt_Data;            

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parCategory = new ReportParameter();
            parCategory.Name = "parCategory";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());
            parCategory.Values.Add(cbx_Category.Text);

            rptv_ProductSummaryReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo, parCategory});

            localReport.DataSources.Add(ds_SaleReturnSummary);

            rptv_ProductSummaryReport.RefreshReport();
        }


        private void bindReturnSummaryReport(DataTable dt_Data)
        {
            rptv_ProductSummaryReport.Clear();
            rptv_ProductSummaryReport.Reset();

            rptv_ProductSummaryReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_ProductSummaryReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_ProductReturnSummaryReport.rdlc";

            ReportDataSource ds_SaleReturnSummary = new ReportDataSource();
            ds_SaleReturnSummary.Name = "DS_SaleReturnSummaryReport_dt_ReturnSummary";
            ds_SaleReturnSummary.Value = dt_Data;

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parCategory = new ReportParameter();
            parCategory.Name = "parCategory";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());
            parCategory.Values.Add(cbx_Category.Text);

            rptv_ProductSummaryReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo, parCategory });

            localReport.DataSources.Add(ds_SaleReturnSummary);

            rptv_ProductSummaryReport.RefreshReport();
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

        private void btn_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }


    }
}
