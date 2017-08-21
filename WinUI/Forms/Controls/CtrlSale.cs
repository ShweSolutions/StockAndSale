using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockAndSale
{
    public partial class CtrlSale : UserControl
    {
        public CtrlSale()
        {            
            InitializeComponent();

            bindCustomerCombo();

            bindCashierCombo();

            dtp_InvoiceDueDateCredit.Checked = false;
            dtp_InvoiceDueDateConsignment.Checked = false;

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            FormatDataGridViewStyle();
        
            this.search();
        }

        FrmMain frmMain;

        public CtrlSale(FrmMain mainTemp)
        {            
            InitializeComponent();

            frmMain = mainTemp;

            bindCustomerCombo();

            bindCashierCombo();

            dtp_InvoiceDueDateCredit.Checked = false;
            dtp_InvoiceDueDateConsignment.Checked = false;

            DateTime dateTime_From = DateTime.Today;

            dateTime_From = dateTime_From.AddDays(-30);

            dtp_InvoiceDateFrom.Value = dateTime_From;

            FormatDataGridViewStyle();
        
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

         private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_CashDown);
            UIControl.FormatDataGridView(dgv_Credit);
            UIControl.FormatDataGridView(dgv_Consign);
            UIControl.FormatDataGridView(dgv_CancelInvoice);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCashInvoice frm_CashInvoice = new FrmCashInvoice(this);
            frm_CashInvoice.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCreditInvoice frm_CreditInvoice = new FrmCreditInvoice(this);
            frm_CreditInvoice.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmConsignmentInvoice frm_ConsignmentInvoice = new FrmConsignmentInvoice(this);
            frm_ConsignmentInvoice.ShowDialog();
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.search();
        }

        public void search()
        {
            BLLInvoice obj_BLLInvoice = new BLLInvoice();

            DateTime dateTime_From = Convert.ToDateTime(dtp_InvoiceDateFrom.Value);
            DateTime dateTime_To = Convert.ToDateTime(dtp_InvoiceDateTo.Value.Date.AddHours(23.9));

            DateTime dateTime_Due_Date = DEGlobal.dateTime_DefaultDate;           

            DateTime dateTime_Current = DEGlobal.dateTime_ToDayDate;

            String str_InvoiceNo = txt_InvoiceNo.Text;

            String str_PONo = txt_PONo.Text;
            
            int int_Customer_Id = 0;

            int int_InvoiceType_Id = 0;

            String user = string.Empty;

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

            Boolean IsPromotion;

            Boolean IsSample;

            IsPromotion = chb_PromotionInvoiceOnly.Checked;

            IsSample = chb_SampleInvoiceOnly.Checked;


            if (tabControl_Result.SelectedTab == tp_CashDown)
            {
                int_InvoiceType_Id = 1;

                DataTable dt_InvoiceList;

                if (chb_NotPaidAndOverDueDate.Checked == false)
                {
                    if (IsPromotion)
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionAndSampleOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    }
                    else
                    {
                        if (IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterSampleInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);

                    }
                }
                else
                {
                    if (IsPromotion)
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSampleOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                    else
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                }

                NumberingTableForDataGridView(dt_InvoiceList);

                dgv_CashDown.DataSource = dt_InvoiceList;               

                FormatCashDownDataGridView();

            }
            else if (tabControl_Result.SelectedTab == tp_Credit)
            {
                int_InvoiceType_Id = 2;

                DataTable dt_InvoiceList;

                if (chb_NotPaidAndOverDueDate.Checked == false)
                {
                    if (dtp_InvoiceDueDateCredit.Checked == true)
                    {
                        dateTime_Due_Date = dtp_InvoiceDueDateCredit.Value.Date;
                    }

                    if (IsPromotion)
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionAndSampleOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    }
                    else
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterSampleInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    }
                
                    //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id,dateTime_Due_Date,user);
                }
                else
                {
                    if (IsPromotion)
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSampleOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                    else
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                
                    //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id,user);
                }

                NumberingTableForDataGridView(dt_InvoiceList);

                dgv_Credit.DataSource = dt_InvoiceList;                

                FormatCreditDataGridView();

            }
            else if (tabControl_Result.SelectedTab == tp_Consign)
            {
                int_InvoiceType_Id = 3;

                DataTable dt_InvoiceList;

                if (chb_NotPaidAndOverDueDate.Checked == false)
                {
                    if (dtp_InvoiceDueDateConsignment.Checked == true)
                    {
                        dateTime_Due_Date = dtp_InvoiceDueDateConsignment.Value.Date;
                    }

                    if (IsPromotion)
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionAndSampleOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterForPromotionOnly(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    }
                    else
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterSampleInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user, str_PONo);
                    }
                                    
                    //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilter(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, dateTime_Due_Date, user);
                }
                else
                {
                    if (IsPromotion)
                    {
                        if (IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionAndSampleOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateForPromotionOnly(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                    else
                    {
                        if(IsSample)
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDateSampleInvoice(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                        else
                            dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user, str_PONo);
                    }
                
                    //dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterNotPaidOverDueDate(dateTime_From, dateTime_To, dateTime_Current, int_Customer_Id, str_InvoiceNo, int_InvoiceType_Id, user);
                }
                
                NumberingTableForDataGridView(dt_InvoiceList);
                
                dgv_Consign.DataSource = dt_InvoiceList;
                
                FormatConsignmentDataGridView();
            }
            else
            {
                DataTable dt_InvoiceList;

                
                    dt_InvoiceList = obj_BLLInvoice.LoadInvoiceTableForAllDataByFilterCancelInvoice(dateTime_From, dateTime_To, int_Customer_Id, str_InvoiceNo);

                    NumberingTableForDataGridView(dt_InvoiceList);                

                    dgv_CancelInvoice.DataSource = dt_InvoiceList;

                    FormatCancelDataGridView();
            }


            }

        private void FormatCancelDataGridView()
        {
            dgv_CancelInvoice.Columns[0].HeaderText = "No";
            dgv_CancelInvoice.Columns[0].Width = 50;
            dgv_CancelInvoice.Columns[0].ReadOnly = true;

            dgv_CancelInvoice.Columns[1].Visible = false;

            dgv_CancelInvoice.Columns[2].HeaderText = "Invoice No";
            dgv_CancelInvoice.Columns[2].Width = 100;
            dgv_CancelInvoice.Columns[2].ReadOnly = true;

            dgv_CancelInvoice.Columns[3].HeaderText = "Invoice Date";
            dgv_CancelInvoice.Columns[3].Width = 90;
            dgv_CancelInvoice.Columns[3].ReadOnly = true;

            dgv_CancelInvoice.Columns[4].HeaderText = "Due Date";
            dgv_CancelInvoice.Columns[4].Width = 90;
            dgv_CancelInvoice.Columns[4].ReadOnly = true;

            dgv_CancelInvoice.Columns[5].HeaderText = "Customer Name";
            dgv_CancelInvoice.Columns[5].Width = 120;
            dgv_CancelInvoice.Columns[5].ReadOnly = true;

            dgv_CancelInvoice.Columns[6].Visible = false;

            dgv_CancelInvoice.Columns[7].HeaderText = "Customer Shop";
            dgv_CancelInvoice.Columns[7].Width = 150;
            dgv_CancelInvoice.Columns[7].ReadOnly = true;

            dgv_CancelInvoice.Columns[8].HeaderText = "Address";
            dgv_CancelInvoice.Columns[8].Width = 200;
            dgv_CancelInvoice.Columns[8].ReadOnly = true;

            dgv_CancelInvoice.Columns[9].HeaderText = "Phone";
            dgv_CancelInvoice.Columns[9].Width = 100;
            dgv_CancelInvoice.Columns[9].ReadOnly = true;

            dgv_CancelInvoice.Columns[10].HeaderText = "Total";
            dgv_CancelInvoice.Columns[10].Width = 100;
            dgv_CancelInvoice.Columns[10].ReadOnly = true;

            dgv_CancelInvoice.Columns[11].HeaderText = "Advance";
            dgv_CancelInvoice.Columns[11].Width = 100;
            dgv_CancelInvoice.Columns[11].ReadOnly = true;

            dgv_CancelInvoice.Columns[12].HeaderText = "Discount";
            dgv_CancelInvoice.Columns[12].Width = 100;
            dgv_CancelInvoice.Columns[12].ReadOnly = true;

            dgv_CancelInvoice.Columns[13].HeaderText = "GrandTotal";
            dgv_CancelInvoice.Columns[13].Width = 100;
            dgv_CancelInvoice.Columns[13].ReadOnly = true;

            dgv_CancelInvoice.Columns[14].Visible = false;

            dgv_CancelInvoice.Columns[15].HeaderText = "Invoice Type";
            dgv_CancelInvoice.Columns[15].Width = 100;
            dgv_CancelInvoice.Columns[15].ReadOnly = true;

            dgv_CancelInvoice.Columns[16].Visible = false;

            dgv_CancelInvoice.Columns[17].Visible = false;

            dgv_CancelInvoice.Columns[18].Visible = false;

            dgv_CancelInvoice.Columns[19].Visible = false;

            dgv_CancelInvoice.Columns[20].HeaderText = "Remark";
            dgv_CancelInvoice.Columns[20].Width = 200;
            dgv_CancelInvoice.Columns[20].ReadOnly = true;

            dgv_CancelInvoice.Columns[21].Visible = false;

            dgv_CancelInvoice.Columns[22].HeaderText = "Cashier";
            dgv_CancelInvoice.Columns[22].Width = 100;
            dgv_CancelInvoice.Columns[22].ReadOnly = true;

            dgv_CancelInvoice.Columns[23].Visible = false;
        }

        private void FormatCashDownDataGridView()
        {
            dgv_CashDown.Columns[0].HeaderText = "No";
            dgv_CashDown.Columns[0].Width = 50;
            dgv_CashDown.Columns[0].ReadOnly = true;

            dgv_CashDown.Columns[1].Visible = false;

            dgv_CashDown.Columns[2].HeaderText = "Invoice No";
            dgv_CashDown.Columns[2].Width = 100;
            dgv_CashDown.Columns[2].ReadOnly = true;

            dgv_CashDown.Columns[3].HeaderText = "Invoice Date";
            dgv_CashDown.Columns[3].Width = 90;
            dgv_CashDown.Columns[3].ReadOnly = true;

            dgv_CashDown.Columns[4].HeaderText = "Due Date";
            dgv_CashDown.Columns[4].Width = 90;
            dgv_CashDown.Columns[4].ReadOnly = true;

            dgv_CashDown.Columns[5].HeaderText = "Customer Name";
            dgv_CashDown.Columns[5].Width = 120;
            dgv_CashDown.Columns[5].ReadOnly = true;

            dgv_CashDown.Columns[6].Visible = false;

            dgv_CashDown.Columns[7].HeaderText = "Customer Shop";
            dgv_CashDown.Columns[7].Width = 150;
            dgv_CashDown.Columns[7].ReadOnly = true;

            dgv_CashDown.Columns[8].HeaderText = "Address";
            dgv_CashDown.Columns[8].Width = 200;
            dgv_CashDown.Columns[8].ReadOnly = true;

            dgv_CashDown.Columns[9].HeaderText = "Phone";
            dgv_CashDown.Columns[9].Width = 100;
            dgv_CashDown.Columns[9].ReadOnly = true;

            dgv_CashDown.Columns[10].HeaderText = "Total";
            dgv_CashDown.Columns[10].Width = 100;
            dgv_CashDown.Columns[10].ReadOnly = true;

            dgv_CashDown.Columns[11].HeaderText = "Advance";
            dgv_CashDown.Columns[11].Width = 100;
            dgv_CashDown.Columns[11].ReadOnly = true;

            dgv_CashDown.Columns[12].HeaderText = "Comm; Tax";
            dgv_CashDown.Columns[12].Width = 100;
            dgv_CashDown.Columns[12].ReadOnly = true;

            dgv_CashDown.Columns[13].HeaderText = "Discount";
            dgv_CashDown.Columns[13].Width = 100;
            dgv_CashDown.Columns[13].ReadOnly = true;

            dgv_CashDown.Columns[14].HeaderText = "Deli; Disc;";
            dgv_CashDown.Columns[14].Width = 100;
            dgv_CashDown.Columns[14].ReadOnly = true;

            dgv_CashDown.Columns[15].HeaderText = "GrandTotal";
            dgv_CashDown.Columns[15].Width = 100;
            dgv_CashDown.Columns[15].ReadOnly = true;

            dgv_CashDown.Columns[16].Visible = false;

            dgv_CashDown.Columns[17].Visible = false;

            dgv_CashDown.Columns[18].Visible = false;

            dgv_CashDown.Columns[19].Visible = false;

            dgv_CashDown.Columns[20].Visible = false;

            dgv_CashDown.Columns[21].Visible = false;

            dgv_CashDown.Columns[22].Visible = false;            

            dgv_CashDown.Columns[23].HeaderText = "Remark";
            dgv_CashDown.Columns[23].Width = 200;
            dgv_CashDown.Columns[23].ReadOnly = true;            

            dgv_CashDown.Columns[24].Visible = false;

            dgv_CashDown.Columns[25].HeaderText = "Cashier";
            dgv_CashDown.Columns[25].Width = 100;
            dgv_CashDown.Columns[25].ReadOnly = true;

            dgv_CashDown.Columns[26].Visible = false;

        }

        private void FormatCreditDataGridView()
        {
            dgv_Credit.Columns[0].HeaderText = "No";
            dgv_Credit.Columns[0].Width = 50;
            dgv_Credit.Columns[0].ReadOnly = true;

            dgv_Credit.Columns[1].Visible = false;

            dgv_Credit.Columns[2].HeaderText = "Invoice No";
            dgv_Credit.Columns[2].Width = 100;
            dgv_Credit.Columns[2].ReadOnly = true;

            dgv_Credit.Columns[3].HeaderText = "Invoice Date";
            dgv_Credit.Columns[3].Width = 90;
            dgv_Credit.Columns[3].ReadOnly = true;

            dgv_Credit.Columns[4].HeaderText = "Due Date";
            dgv_Credit.Columns[4].Width = 90;
            dgv_Credit.Columns[4].ReadOnly = true;

            dgv_Credit.Columns[5].HeaderText = "Customer Name";
            dgv_Credit.Columns[5].Width = 100;
            dgv_Credit.Columns[5].ReadOnly = true;

            dgv_Credit.Columns[6].Visible = false;

            dgv_Credit.Columns[7].HeaderText = "Customer Shop";
            dgv_Credit.Columns[7].Width = 100;
            dgv_Credit.Columns[7].ReadOnly = true;

            dgv_Credit.Columns[8].HeaderText = "Address";
            dgv_Credit.Columns[8].Width = 200;
            dgv_Credit.Columns[8].ReadOnly = true;

            dgv_Credit.Columns[9].HeaderText = "Phone";
            dgv_Credit.Columns[9].Width = 80;
            dgv_Credit.Columns[9].ReadOnly = true;

            dgv_Credit.Columns[10].HeaderText = "Total";
            dgv_Credit.Columns[10].Width = 80;
            dgv_Credit.Columns[10].ReadOnly = true;

            dgv_Credit.Columns[11].HeaderText = "Advance";
            dgv_Credit.Columns[11].Width = 80;
            dgv_Credit.Columns[11].ReadOnly = true;

            dgv_Credit.Columns[12].HeaderText = "Comm; Tax";
            dgv_Credit.Columns[12].Width = 80;
            dgv_Credit.Columns[12].ReadOnly = true;

            dgv_Credit.Columns[13].HeaderText = "Discount";
            dgv_Credit.Columns[13].Width = 80;
            dgv_Credit.Columns[13].ReadOnly = true;

            dgv_Credit.Columns[14].HeaderText = "Deli; Disc;";
            dgv_Credit.Columns[14].Width = 80;
            dgv_Credit.Columns[14].ReadOnly = true;

            dgv_Credit.Columns[15].HeaderText = "GrandTotal";
            dgv_Credit.Columns[15].Width = 80;
            dgv_Credit.Columns[15].ReadOnly = true;

            dgv_Credit.Columns[16].HeaderText = "Return Amount";
            dgv_Credit.Columns[16].Width = 100;
            dgv_Credit.Columns[16].ReadOnly = true;

            dgv_Credit.Columns[17].HeaderText = "Difference";
            dgv_Credit.Columns[17].Width = 100;
            dgv_Credit.Columns[17].ReadOnly = true;

            dgv_Credit.Columns[18].Visible = false;

            dgv_Credit.Columns[19].Visible = false;

            dgv_Credit.Columns[20].HeaderText = "isPaid";
            dgv_Credit.Columns[20].Width = 80;
            dgv_Credit.Columns[20].ReadOnly = true;

            dgv_Credit.Columns[21].HeaderText = "PayDate";
            dgv_Credit.Columns[21].Width = 100;
            dgv_Credit.Columns[21].ReadOnly = true;

            dgv_Credit.Columns[22].HeaderText = "isReturn";
            dgv_Credit.Columns[22].Width = 80;
            dgv_Credit.Columns[22].ReadOnly = true;            

            dgv_Credit.Columns[23].HeaderText = "Remark";
            dgv_Credit.Columns[23].Width = 200;
            dgv_Credit.Columns[23].ReadOnly = true;            

            dgv_Credit.Columns[24].Visible = false;

            dgv_Credit.Columns[25].HeaderText = "Cashier";
            dgv_Credit.Columns[25].Width = 100;
            dgv_Credit.Columns[25].ReadOnly = true;

            dgv_Credit.Columns[26].Visible = false;

        }

        private void FormatConsignmentDataGridView()
        {
            dgv_Consign.Columns[0].HeaderText = "No";
            dgv_Consign.Columns[0].Width = 50;
            dgv_Consign.Columns[0].ReadOnly = true;

            dgv_Consign.Columns[1].Visible = false;

            dgv_Consign.Columns[2].HeaderText = "Invoice No";
            dgv_Consign.Columns[2].Width = 100;
            dgv_Consign.Columns[2].ReadOnly = true;

            dgv_Consign.Columns[3].HeaderText = "Invoice Date";
            dgv_Consign.Columns[3].Width = 90;
            dgv_Consign.Columns[3].ReadOnly = true;

            dgv_Consign.Columns[4].HeaderText = "Due Date";
            dgv_Consign.Columns[4].Width = 90;
            dgv_Consign.Columns[4].ReadOnly = true;

            dgv_Consign.Columns[5].HeaderText = "Customer Name";
            dgv_Consign.Columns[5].Width = 100;
            dgv_Consign.Columns[5].ReadOnly = true;

            dgv_Consign.Columns[6].Visible = false;

            dgv_Consign.Columns[7].HeaderText = "Customer Shop";
            dgv_Consign.Columns[7].Width = 100;
            dgv_Consign.Columns[7].ReadOnly = true;

            dgv_Consign.Columns[8].HeaderText = "Address";
            dgv_Consign.Columns[8].Width = 200;
            dgv_Consign.Columns[8].ReadOnly = true;

            dgv_Consign.Columns[9].HeaderText = "Phone";
            dgv_Consign.Columns[9].Width = 80;
            dgv_Consign.Columns[9].ReadOnly = true;

            dgv_Consign.Columns[10].HeaderText = "Total";
            dgv_Consign.Columns[10].Width = 80;
            dgv_Consign.Columns[10].ReadOnly = true;

            dgv_Consign.Columns[11].HeaderText = "Advance";
            dgv_Consign.Columns[11].Width = 80;
            dgv_Consign.Columns[11].ReadOnly = true;

            dgv_Consign.Columns[12].HeaderText = "Comm; Tax";
            dgv_Consign.Columns[12].Width = 80;
            dgv_Consign.Columns[12].ReadOnly = true;

            dgv_Consign.Columns[13].HeaderText = "Discount";
            dgv_Consign.Columns[13].Width = 80;
            dgv_Consign.Columns[13].ReadOnly = true;

            dgv_Consign.Columns[14].HeaderText = "Deli; Disc;";
            dgv_Consign.Columns[14].Width = 80;
            dgv_Consign.Columns[14].ReadOnly = true;

            dgv_Consign.Columns[15].HeaderText = "GrandTotal";
            dgv_Consign.Columns[15].Width = 80;
            dgv_Consign.Columns[15].ReadOnly = true;

            dgv_Consign.Columns[16].HeaderText = "Return Amount";
            dgv_Consign.Columns[16].Width = 100;
            dgv_Consign.Columns[16].ReadOnly = true;

            dgv_Consign.Columns[17].HeaderText = "Difference";
            dgv_Consign.Columns[17].Width = 100;
            dgv_Consign.Columns[17].ReadOnly = true; 

            dgv_Consign.Columns[18].Visible = false;

            dgv_Consign.Columns[19].Visible = false;

            dgv_Consign.Columns[20].HeaderText = "isPaid";
            dgv_Consign.Columns[20].Width = 80;
            dgv_Consign.Columns[20].ReadOnly = true;

            dgv_Consign.Columns[21].HeaderText = "PayDate";
            dgv_Consign.Columns[21].Width = 80;
            dgv_Consign.Columns[21].ReadOnly = true;

            dgv_Consign.Columns[22].HeaderText = "isReturn";
            dgv_Consign.Columns[22].Width = 80;
            dgv_Consign.Columns[22].ReadOnly = true;           

            dgv_Consign.Columns[23].HeaderText = "Remark";
            dgv_Consign.Columns[23].Width = 200;
            dgv_Consign.Columns[23].ReadOnly = true;

            dgv_Consign.Columns[24].Visible = false;

            dgv_Consign.Columns[25].HeaderText = "Cashier";
            dgv_Consign.Columns[25].Width = 100;
            dgv_Consign.Columns[25].ReadOnly = true;

            dgv_Consign.Columns[26].Visible = false;

        }

        private void tabControl_Result_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.search();
        }

        private void txt_InvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void cbx_Customer_KeyDown(object sender, KeyEventArgs e)
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

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DEInvoice invoice = new DEInvoice();

            if (tabControl_Result.SelectedTab == tp_CashDown)
            {
                if (DEGlobal.bool_EditCash)
                {
                    if (dgv_CashDown.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_CashDown.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        FrmCashInvoice frm_CashInvoice = new FrmCashInvoice(invoice,this);
                        frm_CashInvoice.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }

            }
            else if (tabControl_Result.SelectedTab == tp_Credit)
            {
                if (DEGlobal.bool_EditCredit)
                {
                    if (dgv_Credit.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Credit.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        FrmCreditInvoice frm_CreditInvoice = new FrmCreditInvoice(invoice,this);
                        frm_CreditInvoice.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }
            }
            else if (tabControl_Result.SelectedTab == tp_Consign)
            {
                if (DEGlobal.bool_EditConsign)
                {
                    if (dgv_Consign.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Consign.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        FrmConsignmentInvoice frm_ConsignmentInvoice = new FrmConsignmentInvoice(invoice,this);
                        frm_ConsignmentInvoice.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }
            }
        }

        private void CtrlSale_Load(object sender, EventArgs e)
        {
            ControlPermission();
        }

        private void ControlPermission()
        {
            if (DEGlobal.bool_CreateCash)
            {
                this.btn_NewCash.Enabled = true;
            }
            else
            {
                this.btn_NewCash.Enabled = false;
            }

            if (DEGlobal.bool_CreateCredit)
            {
                this.btn_NewCredit.Enabled = true;
            }
            else
            {
                this.btn_NewCredit.Enabled = false;
            }

            if (DEGlobal.bool_CreateConsign)
            {
                this.btn_NewConsign.Enabled = true;
            }
            else
            {
                this.btn_NewConsign.Enabled = false;
            }
        }

        private void btn_PreviewInvoice_Click(object sender, EventArgs e)
        {
            DEInvoice invoice = new DEInvoice();

            if (tabControl_Result.SelectedTab == tp_CashDown)
            {
                if (true)//DEGlobal.bool_EditCash)
                {
                    if (dgv_CashDown.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_CashDown.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        Frm_CashInvoiceReport frm_CashInvoiceReport = new Frm_CashInvoiceReport(invoice.Invoice_Id);
                        frm_CashInvoiceReport.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }

            }
            else if (tabControl_Result.SelectedTab == tp_Credit)
            {
                if (true)//DEGlobal.bool_EditCredit)
                {
                    if (dgv_Credit.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Credit.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        Frm_CreditInvoiceReport frm_CreditInvoiceReport = new Frm_CreditInvoiceReport(invoice.Invoice_Id);
                        frm_CreditInvoiceReport.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }
            }
            else if (tabControl_Result.SelectedTab == tp_Consign)
            {
                if (true)//DEGlobal.bool_EditConsign)
                {
                    if (dgv_Consign.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Consign.CurrentRow.Cells["Invoice_Id"].Value.ToString());

                        Frm_ConsignInvoiceReport frm_ConsignmentInvoice = new Frm_ConsignInvoiceReport(invoice.Invoice_Id);
                        frm_ConsignmentInvoice.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }
            }
        }

        private void chb_NotPaidAndOverDueDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_NotPaidAndOverDueDate.Checked == true)
            {
                lbl_DueDateConsignment.Visible = false;
                lbl_DueDateCredit.Visible = false;
                dtp_InvoiceDueDateConsignment.Checked = false;
                dtp_InvoiceDueDateConsignment.Visible = false;
                dtp_InvoiceDueDateCredit.Checked = false;
                dtp_InvoiceDueDateCredit.Visible = false;
            }
            else
            {
                lbl_DueDateConsignment.Visible = true;
                lbl_DueDateCredit.Visible = true;
                dtp_InvoiceDueDateConsignment.Visible = true;
                dtp_InvoiceDueDateCredit.Visible = true;
            }

            this.search();
        }

        private void dtp_InvoiceDueDateConsignment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void dtp_InvoiceDueDateCredit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        private void btn_CancelInvoice_Click(object sender, EventArgs e)
        {
            DEInvoice invoice = new DEInvoice();
            DEInvoiceDetail invoiceDetail = new DEInvoiceDetail();
            DEInvoiceReturnDetail invoiceReturnDetail = new DEInvoiceReturnDetail();

            BLLInvoiceDetail obj_BLLInvoiceDetail = new BLLInvoiceDetail();
            BLLInvoiceReturnDetail obj_BLLInvoiceReturnDetail = new BLLInvoiceReturnDetail();
            BLLInvoice obj_BLLInvoice = new BLLInvoice();

            DataTable dt_InvoiceDetail = new DataTable();
            DataTable dt_ReturnInvoiceDetail = new DataTable();

            if (tabControl_Result.SelectedTab == tp_CashDown)
            {
                if (DEGlobal.bool_CancelInvoice)
                {
                    if (dgv_CashDown.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_CashDown.CurrentRow.Cells["Invoice_Id"].Value.ToString());
                        obj_BLLInvoice.LoadInvoiceRow(invoice);

                        DialogResult Colse_Result;
                        Colse_Result = MessageBox.Show(" Are you sure you want to Cancel the following Invoice ? \n" + invoice.Invoice_No.ToString(), "Invoice Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Colse_Result == DialogResult.Yes)
                        {
                            invoice.Active = false;
                            obj_BLLInvoice.UpdateData(invoice);

                            invoiceDetail.Invoice_Id = invoice.Invoice_Id;

                            dt_InvoiceDetail = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);

                            for (int i = 0; i < dt_InvoiceDetail.Rows.Count; i++)
                            {
                                invoiceDetail.InvoiceDetail_Id = new Guid(dt_InvoiceDetail.Rows[i][1].ToString());
                                invoiceDetail.Invoice_Id = new Guid(dt_InvoiceDetail.Rows[i][2].ToString());
                                invoiceDetail.Product_Id = Convert.ToInt32(dt_InvoiceDetail.Rows[i][3].ToString());
                                invoiceDetail.Qty = Convert.ToInt32(dt_InvoiceDetail.Rows[i][6].ToString());

                                if (Convert.ToString(dt_InvoiceDetail.Rows[i][7].ToString()).Equals("Cartons"))
                                {
                                    invoiceDetail.isCarton = true;
                                }
                                else
                                {
                                    invoiceDetail.isCarton = false;
                                }

                                invoiceDetail.Price = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][8].ToString());
                                invoiceDetail.Amount = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][9].ToString());                                
                                invoiceDetail.Active = false;

                                int int_Result = obj_BLLInvoiceDetail.CancelDetailInvoice(invoiceDetail);
                            }

                            search();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }

            }////////////////////////  end of IF

            if (tabControl_Result.SelectedTab == tp_Credit)
            {
                if (DEGlobal.bool_CancelInvoice)
                {
                    if (dgv_Credit.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Credit.CurrentRow.Cells["Invoice_Id"].Value.ToString());
                        obj_BLLInvoice.LoadInvoiceRow(invoice);

                        DialogResult Colse_Result;
                        Colse_Result = MessageBox.Show(" Are you sure you want to Cancel the following Invoice ? \n" + invoice.Invoice_No.ToString(), "Invoice Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Colse_Result == DialogResult.Yes)
                        {
                            invoice.Active = false;
                            obj_BLLInvoice.UpdateData(invoice);

                            invoiceDetail.Invoice_Id = invoice.Invoice_Id;

                            dt_InvoiceDetail = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);

                            for (int i = 0; i < dt_InvoiceDetail.Rows.Count; i++)
                            {
                                invoiceDetail.InvoiceDetail_Id = new Guid(dt_InvoiceDetail.Rows[i][1].ToString());
                                invoiceDetail.Invoice_Id = new Guid(dt_InvoiceDetail.Rows[i][2].ToString());
                                invoiceDetail.Product_Id = Convert.ToInt32(dt_InvoiceDetail.Rows[i][3].ToString());
                                
                                invoiceDetail.Qty = Convert.ToInt32(dt_InvoiceDetail.Rows[i][6].ToString());

                                if (Convert.ToString(dt_InvoiceDetail.Rows[i][7].ToString()).Equals("Cartons"))
                                {
                                    invoiceDetail.isCarton = true;
                                }
                                else
                                {
                                    invoiceDetail.isCarton = false;
                                }

                                invoiceDetail.Price = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][8].ToString());
                                invoiceDetail.Amount = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][9].ToString());
                                invoiceDetail.Active = false;

                                int int_Result = obj_BLLInvoiceDetail.CancelDetailInvoice(invoiceDetail);
                            }

                            search();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }

            }////////////////////////  end of else IF

            if (tabControl_Result.SelectedTab == tp_Consign)
            {
                if (DEGlobal.bool_CancelInvoice)
                {
                    if (dgv_Consign.CurrentRow != null)
                    {
                        invoice.Invoice_Id = new Guid(dgv_Consign.CurrentRow.Cells["Invoice_Id"].Value.ToString());
                        obj_BLLInvoice.LoadInvoiceRow(invoice);

                        DialogResult Colse_Result;
                        Colse_Result = MessageBox.Show(" Are you sure you want to Cancel the following Invoice ? \n" + invoice.Invoice_No.ToString(), "Invoice Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Colse_Result == DialogResult.Yes)
                        {
                            invoice.Active = false;
                            obj_BLLInvoice.UpdateData(invoice);

                            invoiceDetail.Invoice_Id = invoice.Invoice_Id;

                            invoiceReturnDetail.Invoice_Id = invoice.Invoice_Id;

                            dt_InvoiceDetail = obj_BLLInvoiceDetail.LoadInvoiceDetailTableForAllDataByInvoiceId(invoiceDetail);

                            dt_ReturnInvoiceDetail = obj_BLLInvoiceReturnDetail.LoadInvoiceReturnDetailTableForAllDataByInvoiceId(invoiceReturnDetail);

                            for (int i = 0; i < dt_InvoiceDetail.Rows.Count; i++)
                            {
                                invoiceDetail.InvoiceDetail_Id = new Guid(dt_InvoiceDetail.Rows[i][1].ToString());
                                invoiceDetail.Invoice_Id = new Guid(dt_InvoiceDetail.Rows[i][2].ToString());
                                invoiceDetail.Product_Id = Convert.ToInt32(dt_InvoiceDetail.Rows[i][3].ToString());
                                
                                invoiceDetail.Qty = Convert.ToInt32(dt_InvoiceDetail.Rows[i][6].ToString());

                                if (Convert.ToString(dt_InvoiceDetail.Rows[i][7].ToString()).Equals("Cartons"))
                                {
                                    invoiceDetail.isCarton = true;
                                }
                                else
                                {
                                    invoiceDetail.isCarton = false;
                                }

                                invoiceDetail.Price = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][8].ToString());
                                invoiceDetail.Amount = Convert.ToDecimal(dt_InvoiceDetail.Rows[i][9].ToString());
                                invoiceDetail.Active = false;

                                int int_Result = obj_BLLInvoiceDetail.CancelDetailInvoice(invoiceDetail);
                            }

                            for (int i = 0; i < dt_ReturnInvoiceDetail.Rows.Count; i++)
                            {
                                invoiceReturnDetail.InvoiceReturnDetail_Id = new Guid(dt_ReturnInvoiceDetail.Rows[i][1].ToString());
                                invoiceReturnDetail.Invoice_Id = new Guid(dt_ReturnInvoiceDetail.Rows[i][2].ToString());
                                invoiceReturnDetail.Product_Id = Convert.ToInt32(dt_ReturnInvoiceDetail.Rows[i][3].ToString());
                                
                                invoiceReturnDetail.Qty = Convert.ToInt32(dt_ReturnInvoiceDetail.Rows[i][6].ToString());

                                if (Convert.ToString(dt_ReturnInvoiceDetail.Rows[i][7].ToString()).Equals("Cartons"))
                                {
                                    invoiceReturnDetail.isCarton = true;
                                }
                                else
                                {
                                    invoiceReturnDetail.isCarton = false;
                                }

                                invoiceReturnDetail.Price = Convert.ToDecimal(dt_ReturnInvoiceDetail.Rows[i][8].ToString());
                                invoiceReturnDetail.Amount = Convert.ToDecimal(dt_ReturnInvoiceDetail.Rows[i][9].ToString());
                                invoiceReturnDetail.Active = false;

                                int int_Result = obj_BLLInvoiceReturnDetail.CancelReturnInvoice(invoiceReturnDetail);

                            }

                            search();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please Select Row");
                    }
                }
                else
                {
                    MessageBox.Show("Access Denied!");
                }

            }////////////////////////  end of else IF


            }
            

        private void cbx_Cashier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.search();
            }
        }

        

            }
            }

    
            
        

        

    

        
