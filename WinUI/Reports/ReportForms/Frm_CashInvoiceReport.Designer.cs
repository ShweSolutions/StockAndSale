namespace StockAndSale
{
    partial class Frm_CashInvoiceReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptv_CashInvoiceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_ShowLetterHead = new System.Windows.Forms.CheckBox();
            this.chb_SmallSize = new System.Windows.Forms.CheckBox();
            this.chb_ShowLetterFooter = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rptv_CashInvoiceReport
            // 
            this.rptv_CashInvoiceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_CashInvoiceReport.Location = new System.Drawing.Point(3, 16);
            this.rptv_CashInvoiceReport.Name = "rptv_CashInvoiceReport";
            this.rptv_CashInvoiceReport.Size = new System.Drawing.Size(1016, 670);
            this.rptv_CashInvoiceReport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rptv_CashInvoiceReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 689);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // chb_ShowLetterHead
            // 
            this.chb_ShowLetterHead.AutoSize = true;
            this.chb_ShowLetterHead.Location = new System.Drawing.Point(129, 4);
            this.chb_ShowLetterHead.Name = "chb_ShowLetterHead";
            this.chb_ShowLetterHead.Size = new System.Drawing.Size(121, 17);
            this.chb_ShowLetterHead.TabIndex = 6;
            this.chb_ShowLetterHead.Text = "Show Letter Header";
            this.chb_ShowLetterHead.UseVisualStyleBackColor = true;
            this.chb_ShowLetterHead.CheckedChanged += new System.EventHandler(this.chb_ShowLetterHead_CheckedChanged);
            // 
            // chb_SmallSize
            // 
            this.chb_SmallSize.AutoSize = true;
            this.chb_SmallSize.Location = new System.Drawing.Point(12, 5);
            this.chb_SmallSize.Name = "chb_SmallSize";
            this.chb_SmallSize.Size = new System.Drawing.Size(74, 17);
            this.chb_SmallSize.TabIndex = 5;
            this.chb_SmallSize.Text = "Small Size";
            this.chb_SmallSize.UseVisualStyleBackColor = true;
            this.chb_SmallSize.CheckedChanged += new System.EventHandler(this.chb_SmallSize_CheckedChanged);
            // 
            // chb_ShowLetterFooter
            // 
            this.chb_ShowLetterFooter.AutoSize = true;
            this.chb_ShowLetterFooter.Location = new System.Drawing.Point(274, 5);
            this.chb_ShowLetterFooter.Name = "chb_ShowLetterFooter";
            this.chb_ShowLetterFooter.Size = new System.Drawing.Size(116, 17);
            this.chb_ShowLetterFooter.TabIndex = 7;
            this.chb_ShowLetterFooter.Text = "Show Letter Footer";
            this.chb_ShowLetterFooter.UseVisualStyleBackColor = true;
            this.chb_ShowLetterFooter.Visible = false;
            this.chb_ShowLetterFooter.CheckedChanged += new System.EventHandler(this.chb_ShowLetterFooter_CheckedChanged);
            // 
            // Frm_CashInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.chb_ShowLetterFooter);
            this.Controls.Add(this.chb_ShowLetterHead);
            this.Controls.Add(this.chb_SmallSize);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CashInvoiceReport";
            this.Text = "Cash Invoice Report";
            this.Load += new System.EventHandler(this.Frm_CashInvoiceReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_CashInvoiceReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chb_ShowLetterHead;
        private System.Windows.Forms.CheckBox chb_SmallSize;
        private System.Windows.Forms.CheckBox chb_ShowLetterFooter;
    }
}