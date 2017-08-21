namespace StockAndSale
{
    partial class Frm_CustomerReport
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
            this.rptv_CustomerReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptv_CustomerReport
            // 
            this.rptv_CustomerReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_CustomerReport.Location = new System.Drawing.Point(0, 0);
            this.rptv_CustomerReport.Name = "rptv_CustomerReport";
            this.rptv_CustomerReport.Size = new System.Drawing.Size(1016, 731);
            this.rptv_CustomerReport.TabIndex = 0;
            // 
            // Frm_CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.rptv_CustomerReport);
            this.Name = "Frm_CustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Report";
            this.Load += new System.EventHandler(this.Frm_CustomerReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_CustomerReport;
    }
}