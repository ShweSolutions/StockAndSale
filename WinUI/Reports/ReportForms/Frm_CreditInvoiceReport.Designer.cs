namespace StockAndSale
{
    partial class Frm_CreditInvoiceReport
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
            this.rptv_CreditInvoiceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.chb_SmallSize = new System.Windows.Forms.CheckBox();
            this.chb_ShowLetterHead = new System.Windows.Forms.CheckBox();
            this.chb_ShowLetterFooter = new System.Windows.Forms.CheckBox();
            this.chb_Return = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // rptv_CreditInvoiceReport
            // 
            this.rptv_CreditInvoiceReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rptv_CreditInvoiceReport.Location = new System.Drawing.Point(0, 46);
            this.rptv_CreditInvoiceReport.Name = "rptv_CreditInvoiceReport";
            this.rptv_CreditInvoiceReport.Size = new System.Drawing.Size(1022, 685);
            this.rptv_CreditInvoiceReport.TabIndex = 0;
            // 
            // chb_SmallSize
            // 
            this.chb_SmallSize.AutoSize = true;
            this.chb_SmallSize.Location = new System.Drawing.Point(137, 12);
            this.chb_SmallSize.Name = "chb_SmallSize";
            this.chb_SmallSize.Size = new System.Drawing.Size(74, 17);
            this.chb_SmallSize.TabIndex = 1;
            this.chb_SmallSize.Text = "Small Size";
            this.chb_SmallSize.UseVisualStyleBackColor = true;
            this.chb_SmallSize.CheckedChanged += new System.EventHandler(this.chb_SmallSize_CheckedChanged);
            // 
            // chb_ShowLetterHead
            // 
            this.chb_ShowLetterHead.AutoSize = true;
            this.chb_ShowLetterHead.Location = new System.Drawing.Point(254, 12);
            this.chb_ShowLetterHead.Name = "chb_ShowLetterHead";
            this.chb_ShowLetterHead.Size = new System.Drawing.Size(121, 17);
            this.chb_ShowLetterHead.TabIndex = 2;
            this.chb_ShowLetterHead.Text = "Show Letter Header";
            this.chb_ShowLetterHead.UseVisualStyleBackColor = true;
            this.chb_ShowLetterHead.CheckedChanged += new System.EventHandler(this.chb_ShowLetterHead_CheckedChanged);
            // 
            // chb_ShowLetterFooter
            // 
            this.chb_ShowLetterFooter.AutoSize = true;
            this.chb_ShowLetterFooter.Location = new System.Drawing.Point(405, 11);
            this.chb_ShowLetterFooter.Name = "chb_ShowLetterFooter";
            this.chb_ShowLetterFooter.Size = new System.Drawing.Size(116, 17);
            this.chb_ShowLetterFooter.TabIndex = 3;
            this.chb_ShowLetterFooter.Text = "Show Letter Footer";
            this.chb_ShowLetterFooter.UseVisualStyleBackColor = true;
            this.chb_ShowLetterFooter.Visible = false;
            this.chb_ShowLetterFooter.CheckedChanged += new System.EventHandler(this.chb_ShowLetterFooter_CheckedChanged);
            // 
            // chb_Return
            // 
            this.chb_Return.AutoSize = true;
            this.chb_Return.Location = new System.Drawing.Point(12, 12);
            this.chb_Return.Name = "chb_Return";
            this.chb_Return.Size = new System.Drawing.Size(88, 17);
            this.chb_Return.TabIndex = 4;
            this.chb_Return.Text = "Show Return";
            this.chb_Return.UseVisualStyleBackColor = true;
            this.chb_Return.CheckedChanged += new System.EventHandler(this.chb_Return_CheckedChanged);
            // 
            // Frm_CreditInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.chb_Return);
            this.Controls.Add(this.chb_ShowLetterFooter);
            this.Controls.Add(this.chb_ShowLetterHead);
            this.Controls.Add(this.chb_SmallSize);
            this.Controls.Add(this.rptv_CreditInvoiceReport);
            this.Name = "Frm_CreditInvoiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Credit Invoice Report";
            this.Load += new System.EventHandler(this.Frm_CreditInvoiceReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_CreditInvoiceReport;
        private System.Windows.Forms.CheckBox chb_SmallSize;
        private System.Windows.Forms.CheckBox chb_ShowLetterHead;
        private System.Windows.Forms.CheckBox chb_ShowLetterFooter;
        private System.Windows.Forms.CheckBox chb_Return;
    }
}