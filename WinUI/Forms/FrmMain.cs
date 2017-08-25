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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmProduct frm_Product = new FrmProduct();
            frm_Product.ShowDialog();
        }

        private void customerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCustomer frm_Customer = new FrmCustomer();
            frm_Customer.ShowDialog();
        }

        private void catagoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCatagory frm_Catagory = new FrmCatagory();
            frm_Catagory.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {    
            pnlCenter.Controls.Clear();

            CtrlSale ctrl_Sale = new CtrlSale(this);
            ctrl_Sale.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(ctrl_Sale);            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Login();
            pnlCenter.Controls.Clear();

            CtrlSale ctrl_Sale = new CtrlSale(this);
            ctrl_Sale.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(ctrl_Sale);   
        }

        private void btn_StockIn_Click(object sender, EventArgs e)
        {
            pnlCenter.Controls.Clear();

            CtrlStockIn ctrl_StockIn = new CtrlStockIn();
            ctrl_StockIn.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(ctrl_StockIn);   
        }

        public void RefreshScreen()
        {
            pnlCenter.Controls.Clear();

            CtrlSale ctrl_Sale = new CtrlSale(this);
            ctrl_Sale.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(ctrl_Sale);
        }

        private void btn_Product_In_Store_Click(object sender, EventArgs e)
        {
            pnlCenter.Controls.Clear();

            CtrlProductInStore ctrl_ProductInStore = new CtrlProductInStore();
            ctrl_ProductInStore.Dock = DockStyle.Fill;

            pnlCenter.Controls.Add(ctrl_ProductInStore);   
        }

        private void userToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmUserManagement frm_UserManagement = new FrmUserManagement();
            frm_UserManagement.ShowDialog();
        }

        private void Login()
        {
            try
            {
                FrmLogin obj_FrmLogin = new FrmLogin();
                this.Visible = false;
                obj_FrmLogin.ShowDialog();

                if (DEGlobal.str_UserName != string.Empty)
                {
                    ControlPermission();
                    this.Visible = true;
                    this.Activate();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                
            }
        }

        private void ControlPermission()
        {
            if (DEGlobal.bool_ProductManagement)
            {
                this.productToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.productToolStripMenuItem2.Enabled = false;
            }

            if (DEGlobal.bool_CatagoryManagement)
            {
                this.catagoryToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.catagoryToolStripMenuItem.Enabled = false;
            }

            if (DEGlobal.bool_CustomerManagement)
            {
                this.customerToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.customerToolStripMenuItem2.Enabled = false;
            }

            if (DEGlobal.bool_UserManagement)
            {
                this.userToolStripMenuItem2.Enabled = true;
            }
            else
            {
                this.userToolStripMenuItem2.Enabled = false;
            }

            if (DEGlobal.bool_DataBaseBackup)
            {
                this.DatabaseBackupToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.DatabaseBackupToolStripMenuItem.Enabled = false;
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Colse_Result;
            Colse_Result = MessageBox.Show(" Are you sure you want to Exit ?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Colse_Result == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }

        private void DatabaseBackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackupDatabase frm_BackupDatabase = new FrmBackupDatabase();
            frm_BackupDatabase.ShowDialog();
        }

        private void invoiceSaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InvoiceSaleReport frm_InvoiceSaleReport = new Frm_InvoiceSaleReport();
            frm_InvoiceSaleReport.ShowDialog();
        }

        private void productSaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProductInvoiceReport frm_ProductInvoiceReport = new Frm_ProductInvoiceReport();
            frm_ProductInvoiceReport.ShowDialog();
        }

        private void customerSaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CustomerSaleReport frm_CustomerSaleReport = new Frm_CustomerSaleReport();
            frm_CustomerSaleReport.ShowDialog();
        }

        private void fOCReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_FOCReport frm_FOCReport = new Frm_FOCReport();
            frm_FOCReport.ShowDialog();
        }

        private void productSaleSummaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ProductSaleSummaryReport frm_ProductSaleSummaryReport = new Frm_ProductSaleSummaryReport();
            frm_ProductSaleSummaryReport.ShowDialog();
        }

        private void promotionReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PromotionReport frm_PromotionReport = new Frm_PromotionReport();
            frm_PromotionReport.ShowDialog();
        }

        private void customerCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CustomerCategory frm_Catagory = new Frm_CustomerCategory();
            frm_Catagory.ShowDialog();
        }

        private void invoicePaidReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_InvoicePaidReport frm_InvoicePaidReport = new Frm_InvoicePaidReport();
            frm_InvoicePaidReport.ShowDialog();
        }

          
        
    }
}
