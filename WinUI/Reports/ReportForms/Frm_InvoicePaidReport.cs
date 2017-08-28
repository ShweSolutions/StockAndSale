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
    public partial class Frm_InvoicePaidReport : Form
    {
        public Frm_InvoicePaidReport()
        {
            InitializeComponent();

            bindCashierCombo();

            bindCustomerCombo();

            bindCsutomerGroupCombo();

            
            rdo_Cash.Checked = true;

            
            lbl_Customer.Visible = true;
            cbx_Customer.Visible = true;
            lbl_CustomerGroup.Visible = false;
            cbx_CustomerGroup.Visible = false;

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_PaidDateFrom.Value = dateTime_From;

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

        private void bindCashierCombo()
        {
            BLLUser obj_BLLUser = new BLLUser();
            DataTable dt_User = obj_BLLUser.LoadUserTableForAllData();

            cbx_Cashier.Items.Clear();
            cbx_Cashier.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Cashier.SourceDataString = new string[] { "Name", "LoginName", "UserId", "UserId" };
            cbx_Cashier.ColumnNum = 4;
            cbx_Cashier.ColumnWidth = "150;0;0;0";
            cbx_Cashier.SourceDataTable = dt_User;

            cbx_Cashier.Text = string.Empty;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void search()
        {
            BLLInvoice obj_BLLInvoice = new BLLInvoice();

            DateTime dateTime_From = Convert.ToDateTime(dtp_PaidDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_PaidDateTo.Value.Date.AddHours(23.9));

            //DateTime dateTime_Due_Date = DEGlobal.dateTime_DefaultDate;

            DateTime dateTime_Current = DEGlobal.dateTime_ToDayDate;

            String str_InvoiceNo = string.Empty;

            int int_Customer_Id = 0;

            int int_CustomerGroup_Id = 0;

            int int_InvoiceType_Id = 0;

            String user = string.Empty;

            try
            {
                int_CustomerGroup_Id = Convert.ToInt32(cbx_CustomerGroup.SelectedItem.Col3);
                //customer.Catagory_Description = cbx_CustomerGroup.SelectedText;
            }
            catch (Exception ex)
            {
                int_CustomerGroup_Id = 0;
                //customer.Customer_Description = "";
            }

            try
            {
                int_Customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            }
            catch (Exception ex)
            {
                int_Customer_Id = 0;
            }

            try
            {
                user = Convert.ToString(cbx_Cashier.SelectedItem.Col2);
            }
            catch (Exception ex)
            {
                user = string.Empty;
            }

            DataTable dt_InvoiceList = new DataTable();

            ////////////////////////////// By Customer ///////////////
            if (rdo_Customer.Checked)
            {
                
                    String str_PONo = "";

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;                        
                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;                      
                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;                        
                    }

                    dt_InvoiceList = obj_BLLInvoice.LoadPaidInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    //////////////////////
                
                
                ////////////// end of By Customer
            }
            /////////////////    By Customer Group
            else
            {
                
                    String str_PONo = "";

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;
                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;

                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;
                    }

                    dt_InvoiceList = obj_BLLInvoice.LoadPaidInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    //////////////////////
                
                
            }

            bindReport(dt_InvoiceList);

        }

        private void bindReport(DataTable dt_InvoiceSale)
        {
            String user = string.Empty;
            String customer = string.Empty;

            String isCash = "false";
            String isCredit = "false";
            String isConsignment = "false";

            try
            {
                user = Convert.ToString(cbx_Cashier.SelectedItem.Col2);
            }
            catch (Exception ex)
            {
                user = string.Empty;
            }

            try
            {
                customer = Convert.ToString(cbx_Customer.SelectedItem.Col1);
            }
            catch (Exception ex)
            {
                customer = string.Empty;
            }

            rptv_InvoicePaidReport.Clear();
            rptv_InvoicePaidReport.Reset();

            rptv_InvoicePaidReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_InvoicePaidReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_InvoicePaidReport.rdlc";

            ReportDataSource ds_InvoiceSale = new ReportDataSource();
            ds_InvoiceSale.Name = "DS_InvoiceReport_dt_Invoice";
            ds_InvoiceSale.Value = dt_InvoiceSale;

            ReportParameter parCashier = new ReportParameter();
            parCashier.Name = "parCashier";

            ReportParameter parIsCashier = new ReportParameter();
            parIsCashier.Name = "parIsCashier";

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            ReportParameter parIsCash = new ReportParameter();
            parIsCash.Name = "parIsCash";

            ReportParameter parIsCredit = new ReportParameter();
            parIsCredit.Name = "parIsCredit";

            ReportParameter parIsConsignment = new ReportParameter();
            parIsConsignment.Name = "parIsConsignment";

            ReportParameter parSaleReportType = new ReportParameter();
            parSaleReportType.Name = "parSaleReportType";

            ReportParameter parCustomer = new ReportParameter();
            parCustomer.Name = "parCustomer";

            ReportParameter parIsCustomer = new ReportParameter();
            parIsCustomer.Name = "parIsCustomer";

            if (rdo_Cash.Checked == true)
            {
                parSaleReportType.Values.Add("Cash Invoice (Paid) Report");
            }
            else if (rdo_Credit.Checked == true)
            {
                parSaleReportType.Values.Add("Credit Invoice (Paid) Report");
            }
            else
            {
                parSaleReportType.Values.Add("Consignment Invoice (Paid) Report");
            }


            parDateFrom.Values.Add(dtp_PaidDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_PaidDateTo.Value.Date.ToString());

            if (rdo_Cash.Checked == true)
            {
                parIsCash.Values.Add("true");
            }
            else
            {
                parIsCash.Values.Add("false");
            }

            if (rdo_Credit.Checked == true)
            {
                parIsCredit.Values.Add("true");
            }
            else
            {
                parIsCredit.Values.Add("false");
            }

            if (rdo_Consignment.Checked == true)
            {
                parIsConsignment.Values.Add("true");
            }
            else
            {
                parIsConsignment.Values.Add("false");
            }

            try
            {
                parCashier.Values.Add(Convert.ToString(cbx_Cashier.SelectedItem.Col1));
            }
            catch (Exception ex)
            {
                parCashier.Values.Add("");
            }

            try
            {
                parCustomer.Values.Add(Convert.ToString(cbx_Customer.SelectedItem.Col1));
            }
            catch (Exception ex)
            {
                parCustomer.Values.Add("");
            }

            if (user == string.Empty)
            {
                parIsCashier.Values.Add("false");
            }
            else
            {
                parIsCashier.Values.Add("true");
            }

            if (customer == string.Empty)
            {
                parIsCustomer.Values.Add("false");
            }
            else
            {
                parIsCustomer.Values.Add("true");
            }

            rptv_InvoicePaidReport.LocalReport.SetParameters(new ReportParameter[] { parCashier, parIsCashier, parDateFrom, parDateTo, parIsCash, parIsCredit, parIsConsignment, parSaleReportType, parIsCustomer, parCustomer });

            localReport.DataSources.Add(ds_InvoiceSale);

            rptv_InvoicePaidReport.RefreshReport();
        }

        private void rdo_Customer_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Customer.Checked)
            {
                lbl_Customer.Visible = true;
                cbx_Customer.Visible = true;
                lbl_CustomerGroup.Visible = false;
                cbx_CustomerGroup.Visible = false;

            }
            else
            {
                lbl_Customer.Visible = false;
                cbx_Customer.Visible = false;
                lbl_CustomerGroup.Visible = true;
                cbx_CustomerGroup.Visible = true;

            }
        }
    }
}
