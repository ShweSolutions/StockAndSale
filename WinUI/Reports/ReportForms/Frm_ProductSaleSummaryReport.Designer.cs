namespace StockAndSale
{
    partial class Frm_ProductSaleSummaryReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ProductSaleSummaryReport));
            this.rptv_ProductSummaryReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Return = new System.Windows.Forms.RadioButton();
            this.rdo_Sale = new System.Windows.Forms.RadioButton();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Category = new MTGCComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // rptv_ProductSummaryReport
            // 
            this.rptv_ProductSummaryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_ProductSummaryReport.Location = new System.Drawing.Point(0, 112);
            this.rptv_ProductSummaryReport.Name = "rptv_ProductSummaryReport";
            this.rptv_ProductSummaryReport.Size = new System.Drawing.Size(1016, 619);
            this.rptv_ProductSummaryReport.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.rdo_Return);
            this.groupBox1.Controls.Add(this.rdo_Sale);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 112);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // rdo_Return
            // 
            this.rdo_Return.AutoSize = true;
            this.rdo_Return.Location = new System.Drawing.Point(432, 69);
            this.rdo_Return.Name = "rdo_Return";
            this.rdo_Return.Size = new System.Drawing.Size(103, 17);
            this.rdo_Return.TabIndex = 530;
            this.rdo_Return.TabStop = true;
            this.rdo_Return.Text = "Return Summary";
            this.rdo_Return.UseVisualStyleBackColor = true;
            this.rdo_Return.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Return_KeyDown);
            // 
            // rdo_Sale
            // 
            this.rdo_Sale.AutoSize = true;
            this.rdo_Sale.Location = new System.Drawing.Point(314, 69);
            this.rdo_Sale.Name = "rdo_Sale";
            this.rdo_Sale.Size = new System.Drawing.Size(92, 17);
            this.rdo_Sale.TabIndex = 529;
            this.rdo_Sale.TabStop = true;
            this.rdo_Sale.Text = "Sale Summary";
            this.rdo_Sale.UseVisualStyleBackColor = true;
            this.rdo_Sale.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Sale_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 825;
            this.btn_Search.Location = new System.Drawing.Point(579, 20);
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
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(314, 22);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtp_InvoiceDateTo.TabIndex = 527;
            this.dtp_InvoiceDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateTo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(109, 22);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 525;
            this.dtp_InvoiceDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 524;
            this.label1.Text = "Invoice Date From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 543;
            this.label6.Text = "Category";
            // 
            // cbx_Category
            // 
            this.cbx_Category.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_Category.ArrowColor = System.Drawing.Color.Black;
            this.cbx_Category.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_Category.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_Category.BindedControl")));
            this.cbx_Category.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_Category.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_Category.ColumnNum = 1;
            this.cbx_Category.ColumnWidth = "121";
            this.cbx_Category.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_Category.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_Category.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_Category.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_Category.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Category.DisplayMember = "Text";
            this.cbx_Category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Category.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_Category.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_Category.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_Category.DropDownWidth = 140;
            this.cbx_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Category.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Category.GridLineHorizontal = false;
            this.cbx_Category.GridLineVertical = false;
            this.cbx_Category.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Category.Location = new System.Drawing.Point(109, 64);
            this.cbx_Category.ManagingFastMouseMoving = true;
            this.cbx_Category.ManagingFastMouseMovingInterval = 30;
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.SelectedItem = null;
            this.cbx_Category.SelectedValue = null;
            this.cbx_Category.Size = new System.Drawing.Size(156, 22);
            this.cbx_Category.TabIndex = 542;
            // 
            // Frm_ProductSaleSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.rptv_ProductSummaryReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ProductSaleSummaryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Sale/Return Summary Report";
            this.Load += new System.EventHandler(this.Frm_ProductSaleSummaryReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptv_ProductSummaryReport;
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_Return;
        private System.Windows.Forms.RadioButton rdo_Sale;
        private System.Windows.Forms.Label label6;
        private MTGCComboBox cbx_Category;
    }
}