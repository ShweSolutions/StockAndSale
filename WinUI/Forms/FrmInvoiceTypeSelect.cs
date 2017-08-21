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
    public partial class FrmInvoiceTypeSelect : Form
    {
        public FrmInvoiceTypeSelect()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            FrmCashInvoice frm_CashInvoice = new FrmCashInvoice();
            this.Close();
            frm_CashInvoice.ShowDialog();            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            FrmCreditInvoice frm_CreditInvoice = new FrmCreditInvoice();
            this.Close();
            frm_CreditInvoice.ShowDialog();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            FrmConsignmentInvoice frm_Consignment_Invoice = new FrmConsignmentInvoice();
            this.Close();
            frm_Consignment_Invoice.ShowDialog();
        }
    }
}
