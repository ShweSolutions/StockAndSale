namespace StockAndSale
{
    partial class Frm_ProductInvoiceReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProductInvoiceReport));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_All = new System.Windows.Forms.RadioButton();
            this.rdo_Return = new System.Windows.Forms.RadioButton();
            this.rdo_Sale = new System.Windows.Forms.RadioButton();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.rptv_ProductInvoiceReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Product = new MTGCComboBox();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_All);
            this.groupBox3.Controls.Add(this.rdo_Return);
            this.groupBox3.Controls.Add(this.rdo_Sale);
            this.groupBox3.Location = new System.Drawing.Point(420, 57);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(241, 35);
            this.groupBox3.TabIndex = 535;
            this.groupBox3.TabStop = false;
            // 
            // rdo_All
            // 
            this.rdo_All.AutoSize = true;
            this.rdo_All.Location = new System.Drawing.Point(184, 12);
            this.rdo_All.Name = "rdo_All";
            this.rdo_All.Size = new System.Drawing.Size(36, 17);
            this.rdo_All.TabIndex = 2;
            this.rdo_All.TabStop = true;
            this.rdo_All.Text = "All";
            this.rdo_All.UseVisualStyleBackColor = true;
            this.rdo_All.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_All_KeyDown);
            // 
            // rdo_Return
            // 
            this.rdo_Return.AutoSize = true;
            this.rdo_Return.Location = new System.Drawing.Point(88, 12);
            this.rdo_Return.Name = "rdo_Return";
            this.rdo_Return.Size = new System.Drawing.Size(81, 17);
            this.rdo_Return.TabIndex = 1;
            this.rdo_Return.TabStop = true;
            this.rdo_Return.Text = "Return Only";
            this.rdo_Return.UseVisualStyleBackColor = true;
            this.rdo_Return.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Return_KeyDown);
            // 
            // rdo_Sale
            // 
            this.rdo_Sale.AutoSize = true;
            this.rdo_Sale.Location = new System.Drawing.Point(7, 12);
            this.rdo_Sale.Name = "rdo_Sale";
            this.rdo_Sale.Size = new System.Drawing.Size(70, 17);
            this.rdo_Sale.TabIndex = 0;
            this.rdo_Sale.TabStop = true;
            this.rdo_Sale.Text = "Sale Only";
            this.rdo_Sale.UseVisualStyleBackColor = true;
            this.rdo_Sale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Sale_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 819;
            this.btn_Search.Location = new System.Drawing.Point(420, 108);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Search.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Search.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Search.Size = new System.Drawing.Size(121, 32);
            this.btn_Search.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Search.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Search.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Search.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Search.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Search.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Search.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Search.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Search.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Search.TabIndex = 528;
            this.btn_Search.Text = "Search";
            this.btn_Search.Values.ExtraText = "";
            this.btn_Search.Values.Image = null;
            this.btn_Search.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Search.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Search.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Search.Values.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            this.btn_Search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Search_KeyDown);
            // 
            // dtp_InvoiceDateTo
            // 
            this.dtp_InvoiceDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(625, 22);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtp_InvoiceDateTo.TabIndex = 527;
            this.dtp_InvoiceDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateTo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(420, 22);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 525;
            this.dtp_InvoiceDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateFrom_KeyDown);
            // 
            // rptv_ProductInvoiceReport
            // 
            this.rptv_ProductInvoiceReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_ProductInvoiceReport.Location = new System.Drawing.Point(0, 160);
            this.rptv_ProductInvoiceReport.Name = "rptv_ProductInvoiceReport";
            this.rptv_ProductInvoiceReport.Size = new System.Drawing.Size(1016, 571);
            this.rptv_ProductInvoiceReport.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 524;
            this.label1.Text = "Invoice Date From";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Product);
            this.groupBox1.Controls.Add(this.lbl_ProductCode);
            this.groupBox1.Controls.Add(this.lbl_Description);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 160);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // cbx_Product
            // 
            this.cbx_Product.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_Product.ArrowColor = System.Drawing.Color.Black;
            this.cbx_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_Product.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_Product.BindedControl")));
            this.cbx_Product.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_Product.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_Product.ColumnNum = 1;
            this.cbx_Product.ColumnWidth = "121";
            this.cbx_Product.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_Product.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_Product.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_Product.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_Product.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Product.DisplayMember = "Text";
            this.cbx_Product.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Product.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_Product.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_Product.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_Product.DropDownWidth = 140;
            this.cbx_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Product.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Product.GridLineHorizontal = false;
            this.cbx_Product.GridLineVertical = false;
            this.cbx_Product.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Product.Location = new System.Drawing.Point(113, 27);
            this.cbx_Product.ManagingFastMouseMoving = true;
            this.cbx_Product.ManagingFastMouseMovingInterval = 30;
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.SelectedItem = null;
            this.cbx_Product.SelectedValue = null;
            this.cbx_Product.Size = new System.Drawing.Size(178, 22);
            this.cbx_Product.TabIndex = 536;
            this.cbx_Product.Leave += new System.EventHandler(this.cbx_Product_Leave);
            this.cbx_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Product_KeyDown);
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(18, 31);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(72, 13);
            this.lbl_ProductCode.TabIndex = 539;
            this.lbl_ProductCode.Text = "Product Code";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(18, 61);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(69, 20);
            this.lbl_Description.TabIndex = 538;
            this.lbl_Description.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(113, 61);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(178, 49);
            this.txt_Description.TabIndex = 537;
            // 
            // Frm_ProductInvoiceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.rptv_ProductInvoiceReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ProductInvoiceReport";
            this.Text = "Product Invoice Report";
            this.Load += new System.EventHandler(this.Frm_ProductInvoiceReport_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_All;
        private System.Windows.Forms.RadioButton rdo_Return;
        private System.Windows.Forms.RadioButton rdo_Sale;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private Microsoft.Reporting.WinForms.ReportViewer rptv_ProductInvoiceReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MTGCComboBox cbx_Product;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
    }
}