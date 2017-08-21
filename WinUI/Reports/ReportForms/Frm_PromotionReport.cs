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
    public partial class Frm_PromotionReport : Form
    {
        public Frm_PromotionReport()
        {
            InitializeComponent();

            bindCatagoryCombo();
            bindCustomerCombo();

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

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

        private void Frm_PromotionReport_Load(object sender, EventArgs e)
        {

        }

        private void search()
        {
            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

            int category_Id;
            int customer_Id;

            try
            {
                category_Id = Convert.ToInt32(cbx_Category.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                category_Id = 0;
            }

            try
            {
                customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            }
            catch (Exception ex)
            {
                customer_Id = 0;
            }

            DataTable dt_Data = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForPromotionReport(dateTime_From, dateTime_To, customer_Id, category_Id);

            NumberingTableForDataGridView(dt_Data);

            bindReport(dt_Data);

            obj_BLLInvoiceDetail = null;
        }


        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void bindReport(DataTable dt_Data)
        {
            rptv_PromotionReport.Clear();
            rptv_PromotionReport.Reset();

            rptv_PromotionReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_PromotionReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_PromotionReport.rdlc";

            ReportDataSource ds_Promotion = new ReportDataSource();
            ds_Promotion.Name = "DS_InvoiceReport_dt_Promotion";
            ds_Promotion.Value = dt_Data;

            ReportParameter parCategory = new ReportParameter();
            parCategory.Name = "parCategory";

            ReportParameter parCustomer = new ReportParameter();
            parCustomer.Name = "parCustomer";

            try
            {
                parCustomer.Values.Add(Convert.ToString(cbx_Customer.SelectedItem.Col1));
            }
            catch (Exception ex)
            {
                parCustomer.Values.Add("");
            }

            try
            {
                parCategory.Values.Add(Convert.ToString(cbx_Category.SelectedItem.Col1));
            }
            catch (Exception ex)
            {
                parCategory.Values.Add("");
            }

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

            rptv_PromotionReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo, parCustomer, parCategory });

            localReport.DataSources.Add(ds_Promotion);

            rptv_PromotionReport.RefreshReport();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }




    }
}
