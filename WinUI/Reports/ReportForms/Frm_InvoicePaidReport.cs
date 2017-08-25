using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

                    dt_InvoiceList = obj_BLLInvoice.LoadPaidInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
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

                    dt_InvoiceList = obj_BLLInvoice.LoadPaidInvoiceTableForAllDataByFilterByCustomerGroup(dateTime_From, dateTime_To, int_CustomerGroup_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    //////////////////////
                
                
            }

            bindReport(dt_InvoiceList);

        }

        private void bindReport(DataTable dt_InvoiceSale)
        {

        }
    }
}
