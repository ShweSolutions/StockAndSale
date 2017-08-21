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
    public partial class Frm_CustomerReport : Form
    {
        public Frm_CustomerReport()
        {
            InitializeComponent();
        }

        DataTable dt_Customer;

        public Frm_CustomerReport(DataTable dt_CustomerTemp)
        {
            InitializeComponent();

            this.dt_Customer = dt_CustomerTemp;
        }

        private void Frm_CustomerReport_Load(object sender, EventArgs e)
        {
            bindCustomerReport();
        }

        private void bindCustomerReport()
        {
            rptv_CustomerReport.Clear();
            rptv_CustomerReport.Reset();

            rptv_CustomerReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_CustomerReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CustomerReport.rdlc";

            ReportDataSource ds_customer = new ReportDataSource();
            ds_customer.Name = "DS_GeneralReport_dt_Customer";
            ds_customer.Value = dt_Customer;
            
            localReport.DataSources.Add(ds_customer);

            rptv_CustomerReport.RefreshReport();
        }
    }
}
