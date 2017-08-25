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
    public partial class Frm_InvoiceSaleReport : Form
    {
        public Frm_InvoiceSaleReport()
        {
            InitializeComponent();

            bindCashierCombo();

            bindCustomerCombo();

            bindCsutomerGroupCombo();

            dtp_DueDate.Checked = false;
            rdo_Cash.Checked = true;

            rdo_All.Checked = true;

            lbl_Customer.Visible = true;
            cbx_Customer.Visible = true;
            lbl_CustomerGroup.Visible = false;
            cbx_CustomerGroup.Visible = false;

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

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

        private void Frm_InvoiceSaleReport_Load(object sender, EventArgs e)
        {
            this.search();            
        }

        private void search()
        {
            BLLInvoice obj_BLLInvoice = new BLLInvoice();

            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

            DateTime dateTime_Due_Date = DEGlobal.dateTime_DefaultDate;

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

            ////////////////////////////// By Customer
            if (rdo_Customer.Checked)
            {
                if (rdo_All.Checked == true)
                {
                    String str_PONo = "";

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    //////////////////////
                }
                else
                {
                    Boolean bool_isPaid;

                    if (rdo_Paid.Checked == true)
                    {
                        bool_isPaid = true;
                    }
                    else
                    {
                        bool_isPaid = false;
                    }

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaid(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }



                } //// end of (rdo_all.checked == false)
                ////////////// end of By Customer
            }
            /////////////////    By Customer Group
            else
            {
                if (rdo_All.Checked == true)
                {
                    String str_PONo = "";

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(dateTime_From, dateTime_To, dateTime_Current, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(dateTime_From, dateTime_To, dateTime_Current, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        }
                        else
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateByCustomerGroup(dateTime_From, dateTime_To, dateTime_Current, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        }

                    }
                    //////////////////////
                }
                else
                {
                    Boolean bool_isPaid;

                    if (rdo_Paid.Checked == true)
                    {
                        bool_isPaid = true;
                    }
                    else
                    {
                        bool_isPaid = false;
                    }

                    if (rdo_Cash.Checked == true)
                    {
                        int_InvoiceType_Id = 1;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }
                    else if (rdo_Credit.Checked == true)
                    {
                        int_InvoiceType_Id = 2;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }
                    else if (rdo_Consignment.Checked == true)
                    {
                        int_InvoiceType_Id = 3;

                        if (chb_NotPaidAndOverDueDate.Checked == false)
                        {
                            if (dtp_DueDate.Checked == true)
                            {
                                dateTime_Due_Date = dtp_DueDate.Value.Date;
                            }
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterPaidOrNotPaidByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, bool_isPaid);
                        }
                        else
                        {
                            //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                        }

                    }

                }
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

            rptv_InvoiceSaleReport.Clear();
            rptv_InvoiceSaleReport.Reset();

            rptv_InvoiceSaleReport.ProcessingMode = ProcessingMode.Local;           

            LocalReport localReport = rptv_InvoiceSaleReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_InvoiceSaleReport.rdlc";

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
                parSaleReportType.Values.Add("Cash Invoice Report");
            }
            else if (rdo_Credit.Checked == true)
            {
                parSaleReportType.Values.Add("Credit Invoice Report");
            }
            else
            {
                parSaleReportType.Values.Add("Consignment Invoice Report");
            }


            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

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

            rptv_InvoiceSaleReport.LocalReport.SetParameters(new ReportParameter[] { parCashier, parIsCashier, parDateFrom, parDateTo, parIsCash,parIsCredit,parIsConsignment,parSaleReportType,parIsCustomer,parCustomer });

            localReport.DataSources.Add(ds_InvoiceSale);

            rptv_InvoiceSaleReport.RefreshReport();
        }

        private void chb_NotPaidAndOverDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_NotPaidAndOverDueDate.Checked == true)
            {
                lbl_DueDate.Visible = false;

                dtp_DueDate.Checked = false;
                dtp_DueDate.Visible = false;

                rdo_All.Checked = true;
                rdo_All.Enabled = false;
                rdo_Paid.Enabled = false;
                rdo_NotPaid.Enabled = false;
            }
            else
            {
                lbl_DueDate.Visible = true;                
                dtp_DueDate.Visible = true;

                rdo_All.Checked = true;
                rdo_All.Enabled = true;
                rdo_Paid.Enabled = true;
                rdo_NotPaid.Enabled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void cbx_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void cbx_Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Cash_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Credit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Consignment_KeyDown(object sender, KeyEventArgs e)
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

        private void chb_NotPaidAndOverDueDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void dtp_DueDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_Paid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void rdo_NotPaid_KeyDown(object sender, KeyEventArgs e)
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
