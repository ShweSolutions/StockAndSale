namespace StockAndSale
{
    partial class Frm_ConsignInvoiceReport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_ShowLetterFooter = new System.Windows.Forms.CheckBox();
            this.chb_ShowLetterHead = new System.Windows.Forms.CheckBox();
            this.chb_SmallSize = new System.Windows.Forms.CheckBox();
            this.chb_Return = new System.Windows.Forms.CheckBox();
            this.rptv_ConsignInvoiceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chb_ShowLetterFooter);
            this.groupBox1.Controls.Add(this.chb_ShowLetterHead);
            this.groupBox1.Controls.Add(this.chb_SmallSize);
            this.groupBox1.Controls.Add(this.chb_Return);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 43);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // chb_ShowLetterFooter
            // 
            this.chb_ShowLetterFooter.AutoSize = true;
            this.chb_ShowLetterFooter.Location = new System.Drawing.Point(383, 16);
            this.chb_ShowLetterFooter.Name = "chb_ShowLetterFooter";
            this.chb_ShowLetterFooter.Size = new System.Drawing.Size(116, 17);
            this.chb_ShowLetterFooter.TabIndex = 3;
            this.chb_ShowLetterFooter.Text = "Show Letter Footer";
            this.chb_ShowLetterFooter.UseVisualStyleBackColor = true;
            this.chb_ShowLetterFooter.Visible = false;
            this.chb_ShowLetterFooter.CheckedChanged += new System.EventHandler(this.chb_ShowLetterFooter_CheckedChanged);
            // 
            // chb_ShowLetterHead
            // 
            this.chb_ShowLetterHead.AutoSize = true;
            this.chb_ShowLetterHead.Location = new System.Drawing.Point(246, 16);
            this.chb_ShowLetterHead.Name = "chb_ShowLetterHead";
            this.chb_ShowLetterHead.Size = new System.Drawing.Size(121, 17);
            this.chb_ShowLetterHead.TabIndex = 2;
            this.chb_ShowLetterHead.Text = "Show Letter Header";
            this.chb_ShowLetterHead.UseVisualStyleBackColor = true;
            this.chb_ShowLetterHead.CheckedChanged += new System.EventHandler(this.chb_ShowLetterHead_CheckedChanged);
            // 
            // chb_SmallSize
            // 
            this.chb_SmallSize.AutoSize = true;
            this.chb_SmallSize.Location = new System.Drawing.Point(130, 16);
            this.chb_SmallSize.Name = "chb_SmallSize";
            this.chb_SmallSize.Size = new System.Drawing.Size(74, 17);
            this.chb_SmallSize.TabIndex = 1;
            this.chb_SmallSize.Text = "Small Size";
            this.chb_SmallSize.UseVisualStyleBackColor = true;
            this.chb_SmallSize.CheckedChanged += new System.EventHandler(this.chb_SmallSize_CheckedChanged);
            // 
            // chb_Return
            // 
            this.chb_Return.AutoSize = true;
            this.chb_Return.Location = new System.Drawing.Point(13, 16);
            this.chb_Return.Name = "chb_Return";
            this.chb_Return.Size = new System.Drawing.Size(88, 17);
            this.chb_Return.TabIndex = 0;
            this.chb_Return.Text = "Show Return";
            this.chb_Return.UseVisualStyleBackColor = true;
            this.chb_Return.CheckedChanged += new System.EventHandler(this.chb_Return_CheckedChanged);
            // 
            // rptv_ConsignInvoiceReport
            // 
            this.rptv_ConsignInvoiceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_ConsignInvoiceReport.Location = new System.Drawing.Point(0, 43);
            this.rptv_ConsignInvoiceReport.Name = "rptv_ConsignInvoiceReport";
            this.rptv_ConsignInvoiceReport.Size = new System.Drawing.Size(1022, 688);
            this.rptv_ConsignInvoiceReport.TabIndex = 1;
            // 
            // Frm_ConsignInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.rptv_ConsignInvoiceReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ConsignInvoiceReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consign Invoice Report";
            this.Load += new System.EventHandler(this.Frm_ConsignInvoiceReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptv_ConsignInvoiceReport;
        private System.Windows.Forms.CheckBox chb_Return;
        private System.Windows.Forms.CheckBox chb_ShowLetterFooter;
        private System.Windows.Forms.CheckBox chb_ShowLetterHead;
        private System.Windows.Forms.CheckBox chb_SmallSize;
    }
}