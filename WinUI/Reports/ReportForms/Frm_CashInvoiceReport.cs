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
    public partial class Frm_CashInvoiceReport : Form
    {
        public Frm_CashInvoiceReport()
        {
            InitializeComponent();
            chb_ShowLetterHead.Checked = true;
            chb_ShowLetterFooter.Checked = true;
        }

        Guid invoice_Id = Guid.Empty;

        public Frm_CashInvoiceReport(Guid temp_Invoice_Id)
        {
            InitializeComponent();
            invoice_Id = temp_Invoice_Id;
            chb_ShowLetterHead.Checked = true;
            chb_ShowLetterFooter.Checked = true;
        }

        private void Frm_CashInvoiceReport_Load(object sender, EventArgs e)
        {
            bindCashInvoiceReport();
        }

        private void bindCashInvoiceReport()
        {
            DataTable dt_Invoice;
            DataTable dt_InvoiceDetail;

            DEInvoice invoice = new DEInvoice();
            invoice.Invoice_Id = invoice_Id;

            DEInvoiceDetail invoiceDetail = new DEInvoiceDetail();
            invoiceDetail.Invoice_Id = invoice_Id;

            BLLInvoice obj_BLLInvoice = new BLLInvoice();
            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            dt_Invoice = obj_BLLInvoice.LoadInvoiceTableForAllDataByInvoice_Id(invoice);
            dt_InvoiceDetail = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);
                        
            NumberingTableForDataGridView(dt_InvoiceDetail);
                        
            rptv_CashInvoiceReport.Clear();
            rptv_CashInvoiceReport.Reset();

            rptv_CashInvoiceReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_CashInvoiceReport.LocalReport;

            if(chb_SmallSize.Checked == false)
                localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CashInvoiceReport.rdlc";
            else
                localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_CashInvoiceA5Report.rdlc";

            ReportDataSource ds_Invoice = new ReportDataSource();
            ds_Invoice.Name = "DS_InvoiceReport_dt_Invoice";
            ds_Invoice.Value = dt_Invoice;

            ReportDataSource ds_InvoiceDetail = new ReportDataSource();
            ds_InvoiceDetail.Name = "DS_InvoiceReport_dt_InvoiceDetail";
            ds_InvoiceDetail.Value = dt_InvoiceDetail;

            ReportParameter parTotal = new ReportParameter();
            parTotal.Name = "parTotal";

            ReportParameter parAdvance = new ReportParameter();
            parAdvance.Name = "parAdvance";

            ReportParameter parDiscount = new ReportParameter();
            parDiscount.Name = "parDiscount";

            ReportParameter parCommercialTax = new ReportParameter();
            parCommercialTax.Name = "parCommercialTax";

            ReportParameter parDeliveryDiscount = new ReportParameter();
            parDeliveryDiscount.Name = "parDeliveryDiscount";

            ReportParameter parGrandTotal = new ReportParameter();
            parGrandTotal.Name = "parGrandTotal";

            ReportParameter parInvoiceNo = new ReportParameter();
            parInvoiceNo.Name = "parInvoiceNo";

            ReportParameter parInvoiceDate = new ReportParameter();
            parInvoiceDate.Name = "parInvoiceDate";

            ReportParameter parCustomerName = new ReportParameter();
            parCustomerName.Name = "parCustomerName";

            ReportParameter parCustomerShop = new ReportParameter();
            parCustomerShop.Name = "parCustomerShop";

            ReportParameter parAddress = new ReportParameter();
            parAddress.Name = "parAddress";            

            ReportParameter parPhone = new ReportParameter();
            parPhone.Name = "parPhone";

            ReportParameter parPONumber = new ReportParameter();
            parPONumber.Name = "parPONumber";

            ReportParameter parPromDesc = new ReportParameter();
            parPromDesc.Name = "parPromDesc";

            ReportParameter parIsPromotion = new ReportParameter();
            parIsPromotion.Name = "parIsPromotion";

            ReportParameter parShow = new ReportParameter();
            parShow.Name = "parShowLetterHead";
            parShow.Values.Add(chb_ShowLetterHead.Checked.ToString());

            ReportParameter parShowFooter = new ReportParameter();
            parShowFooter.Name = "parShowLetterFooter";
            parShowFooter.Values.Add(chb_ShowLetterFooter.Checked.ToString());

            Boolean bool_HasRow = obj_BLLInvoice.LoadInvoiceRow(invoice);

            if (true)
            {
                parTotal.Values.Add(invoice.Total.ToString());
                parAdvance.Values.Add(invoice.Advance.ToString());
                parDiscount.Values.Add(invoice.Discount.ToString());
                parCommercialTax.Values.Add(invoice.CommercialTax.ToString());
                parDeliveryDiscount.Values.Add(invoice.DeliveryDiscount.ToString());
                parGrandTotal.Values.Add(invoice.GrandTotal.ToString());

                parInvoiceNo.Values.Add(invoice.Invoice_No.ToString());
                parInvoiceDate.Values.Add(invoice.Invoice_Date.ToString());
                parCustomerName.Values.Add(invoice.Customer_Name);
                parCustomerShop.Values.Add(invoice.Customer_Description);
                parAddress.Values.Add(invoice.Address);
                parPhone.Values.Add(invoice.Phone);
                parPONumber.Values.Add(invoice.PONumber);
                parPromDesc.Values.Add(invoice.PromDesc);
                parIsPromotion.Values.Add(invoice.IsPromotion.ToString());                
            }


            rptv_CashInvoiceReport.LocalReport.SetParameters(new ReportParameter[] { parTotal, parAdvance, parDiscount, parGrandTotal, parInvoiceNo, parInvoiceDate, parCustomerName, parCustomerShop, parAddress, parPhone, parShow, parShowFooter, parPONumber, parPromDesc, parIsPromotion, parDeliveryDiscount, parCommercialTax });

            localReport.DataSources.Add(ds_InvoiceDetail);
            localReport.DataSources.Add(ds_Invoice);

            rptv_CashInvoiceReport.RefreshReport();
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void chb_ShowLetterHead_CheckedChanged(object sender, EventArgs e)
        {
            bindCashInvoiceReport();
        }

        private void chb_SmallSize_CheckedChanged(object sender, EventArgs e)
        {
            bindCashInvoiceReport();
        }

        private void chb_ShowLetterFooter_CheckedChanged(object sender, EventArgs e)
        {
            bindCashInvoiceReport();
        }
    }
}
