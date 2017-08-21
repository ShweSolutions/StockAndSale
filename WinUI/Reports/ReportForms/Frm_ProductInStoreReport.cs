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
    public partial class Frm_ProductInStoreReport : Form
    {
        public Frm_ProductInStoreReport()
        {
            InitializeComponent();
        }

        DataTable dt_ProductInStore;

        public Frm_ProductInStoreReport(DataTable dt_Temp)
        {
            InitializeComponent();

            this.dt_ProductInStore = dt_Temp;
        }


        private void Frm_ProductInStoreReport_Load(object sender, EventArgs e)
        {
            bindReport();
        }

        private void bindReport()
        {
            rptv_ProductInStoreReport.Clear();
            rptv_ProductInStoreReport.Reset();

            rptv_ProductInStoreReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_ProductInStoreReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_ProductInStoreReport.rdlc";

            ReportDataSource ds_productInStore = new ReportDataSource();
            ds_productInStore.Name = "DS_GeneralReport_dt_ProductInStore";
            ds_productInStore.Value = dt_ProductInStore;

            ReportParameter Current_Date = new ReportParameter();
            Current_Date.Name = "Current_Date";

            Current_Date.Values.Add(DateTime.Today.Date.ToString());

            rptv_ProductInStoreReport.LocalReport.SetParameters(new ReportParameter[] { Current_Date });

            localReport.DataSources.Add(ds_productInStore);

            rptv_ProductInStoreReport.RefreshReport();
        }
    }
}
