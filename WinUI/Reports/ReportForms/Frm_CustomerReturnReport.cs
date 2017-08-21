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
    public partial class Frm_CustomerReturnReport : Form
    {
        public Frm_CustomerReturnReport()
        {
            InitializeComponent();
        }

        DataTable dt_CustomerReturn;

        public Frm_CustomerReturnReport(DataTable dt_Temp)
        {
            InitializeComponent();

            this.dt_CustomerReturn = dt_Temp;
        }

        private void bindReport()
        {
            rptv_CustomerReturnReport.Clear();
            rptv_CustomerReturnReport.Reset();

            rptv_CustomerReturnReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_CustomerReturnReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CustomerReturnWithoutInvoiceNoRepot.rdlc";

            ReportDataSource ds_CustomerReturn = new ReportDataSource();
            ds_CustomerReturn.Name = "DS_GeneralReport_dt_CustomerReturn";
            ds_CustomerReturn.Value = dt_CustomerReturn;

            ReportParameter Current_Date = new ReportParameter();
            Current_Date.Name = "Current_Date";

            Current_Date.Values.Add(DateTime.Today.Date.ToString());

            rptv_CustomerReturnReport.LocalReport.SetParameters(new ReportParameter[] { Current_Date });

            localReport.DataSources.Add(ds_CustomerReturn);

            rptv_CustomerReturnReport.RefreshReport();
        }

        private void Frm_CustomerReturnReport_Load(object sender, EventArgs e)
        {
            bindReport();
        }
    }
}
