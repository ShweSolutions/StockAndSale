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
    public partial class Frm_PaymentDate : Form
    {
        public DateTime PaymentDate { get { return dtp_PaymentDate.Value; } set { dtp_PaymentDate.Value = value; } }

        public Frm_PaymentDate()
        {
            InitializeComponent();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ok_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change payment status.", "StockAndSale Management System", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
