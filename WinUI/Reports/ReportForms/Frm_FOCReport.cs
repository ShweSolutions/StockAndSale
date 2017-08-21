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
    public partial class Frm_FOCReport : Form
    {
        public Frm_FOCReport()
        {
            InitializeComponent();

            bindCustomerCombo();
            bindProductCombo();

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            this.search();
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




        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        private void search()
        {
            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();

            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

            int product_Id;
            int customer_Id;

            try
            {
                product_Id = Convert.ToInt32(cbx_Product.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                product_Id = 0;
            }

            try
            {
                customer_Id = Convert.ToInt32(cbx_Customer.SelectedItem.Col4);
            }
            catch (Exception ex)
            {
                customer_Id = 0;
            }            

            DataTable dt_Data = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForFOCReport(dateTime_From, dateTime_To, customer_Id, product_Id);

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
            rptv_FOCReport.Clear();
            rptv_FOCReport.Reset();

            rptv_FOCReport.ProcessingMode = ProcessingMode.Local;

            LocalReport localReport = rptv_FOCReport.LocalReport;

            localReport.ReportEmbeddedResource = "StockAndSale.WinUI.Reports.Classes.Rpt_FOCReport.rdlc";

            ReportDataSource ds_FOC = new ReportDataSource();
            ds_FOC.Name = "DS_InvoiceReport_dt_FOC";
            ds_FOC.Value = dt_Data;

            ReportParameter parProduct = new ReportParameter();
            parProduct.Name = "parProduct";

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
                parProduct.Values.Add(Convert.ToString(cbx_Product.SelectedItem.Col2));
            }
            catch (Exception ex)
            {
                parProduct.Values.Add("");
            }

            ReportParameter parDateFrom = new ReportParameter();
            parDateFrom.Name = "parDateFrom";

            ReportParameter parDateTo = new ReportParameter();
            parDateTo.Name = "parDateTo";

            parDateFrom.Values.Add(dtp_InvoiceDateFrom.Value.Date.ToString());
            parDateTo.Values.Add(dtp_InvoiceDateTo.Value.Date.ToString());

            rptv_FOCReport.LocalReport.SetParameters(new ReportParameter[] { parDateFrom, parDateTo, parCustomer, parProduct });

            localReport.DataSources.Add(ds_FOC);

            rptv_FOCReport.RefreshReport();
        }

        private void cbx_Customer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
                {
                    MessageBox.Show("Invalid Customer");
                    cbx_Customer.Text = string.Empty;
                    txt_Address.Text = string.Empty;
                    txt_PhoneNo.Text = string.Empty;
                    //cbx_Customer.Focus();
                }
                else
                {
                    txt_Address.Text = cbx_Customer.SelectedItem.Col2;
                    txt_PhoneNo.Text = cbx_Customer.SelectedItem.Col3;
                    //cbx_Product.Focus();
                    
                }

                this.search();
            }
        }

        private void cbx_Customer_Leave(object sender, EventArgs e)
        {
            if (cbx_Customer.Text.Trim().Length == 0 || cbx_Customer.SelectedValue == null)
            {
                MessageBox.Show("Invalid Customer");
                cbx_Customer.Text = string.Empty;
                txt_Address.Text = string.Empty;
                txt_PhoneNo.Text = string.Empty;
                //cbx_Customer.Focus();
            }
            else
            {
                txt_Address.Text = cbx_Customer.SelectedItem.Col2;
                txt_PhoneNo.Text = cbx_Customer.SelectedItem.Col3;
                //cbx_Product.Focus();
            }
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
                }

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

        private void btn_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void Frm_FOCReport_Load(object sender, EventArgs e)
        {

        }
    }
}
