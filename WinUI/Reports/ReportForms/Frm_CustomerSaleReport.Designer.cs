namespace StockAndSale
{
    partial class Frm_CustomerSaleReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CustomerSaleReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_CustomerGroup = new System.Windows.Forms.RadioButton();
            this.rdo_Customer = new System.Windows.Forms.RadioButton();
            this.lbl_CustomerGroup = new System.Windows.Forms.Label();
            this.cbx_CustomerGroup = new MTGCComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_Category = new MTGCComboBox();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.lbl_PhoneNo = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_Return = new System.Windows.Forms.RadioButton();
            this.rdo_Sale = new System.Windows.Forms.RadioButton();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Customer = new MTGCComboBox();
            this.rptv_CustomerSaleReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_CustomerGroup);
            this.groupBox1.Controls.Add(this.rdo_Customer);
            this.groupBox1.Controls.Add(this.lbl_CustomerGroup);
            this.groupBox1.Controls.Add(this.cbx_CustomerGroup);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbx_Category);
            this.groupBox1.Controls.Add(this.txt_PhoneNo);
            this.groupBox1.Controls.Add(this.lbl_PhoneNo);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.lbl_Address);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_Customer);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_Customer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // rdo_CustomerGroup
            // 
            this.rdo_CustomerGroup.AutoSize = true;
            this.rdo_CustomerGroup.Location = new System.Drawing.Point(208, 19);
            this.rdo_CustomerGroup.Name = "rdo_CustomerGroup";
            this.rdo_CustomerGroup.Size = new System.Drawing.Size(116, 17);
            this.rdo_CustomerGroup.TabIndex = 545;
            this.rdo_CustomerGroup.Text = "By Customer Group";
            this.rdo_CustomerGroup.UseVisualStyleBackColor = true;
            this.rdo_CustomerGroup.CheckedChanged += new System.EventHandler(this.rdo_Customer_CheckedChanged);
            // 
            // rdo_Customer
            // 
            this.rdo_Customer.AutoSize = true;
            this.rdo_Customer.Checked = true;
            this.rdo_Customer.Location = new System.Drawing.Point(106, 19);
            this.rdo_Customer.Name = "rdo_Customer";
            this.rdo_Customer.Size = new System.Drawing.Size(84, 17);
            this.rdo_Customer.TabIndex = 544;
            this.rdo_Customer.TabStop = true;
            this.rdo_Customer.Text = "By Customer";
            this.rdo_Customer.UseVisualStyleBackColor = true;
            this.rdo_Customer.CheckedChanged += new System.EventHandler(this.rdo_Customer_CheckedChanged);
            // 
            // lbl_CustomerGroup
            // 
            this.lbl_CustomerGroup.AutoSize = true;
            this.lbl_CustomerGroup.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerGroup.Location = new System.Drawing.Point(5, 57);
            this.lbl_CustomerGroup.Name = "lbl_CustomerGroup";
            this.lbl_CustomerGroup.Size = new System.Drawing.Size(98, 20);
            this.lbl_CustomerGroup.TabIndex = 543;
            this.lbl_CustomerGroup.Text = "Customer Group";
            // 
            // cbx_CustomerGroup
            // 
            this.cbx_CustomerGroup.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_CustomerGroup.ArrowColor = System.Drawing.Color.Black;
            this.cbx_CustomerGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_CustomerGroup.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_CustomerGroup.BindedControl")));
            this.cbx_CustomerGroup.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_CustomerGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_CustomerGroup.ColumnNum = 1;
            this.cbx_CustomerGroup.ColumnWidth = "121";
            this.cbx_CustomerGroup.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_CustomerGroup.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_CustomerGroup.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_CustomerGroup.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_CustomerGroup.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_CustomerGroup.DisplayMember = "Text";
            this.cbx_CustomerGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_CustomerGroup.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_CustomerGroup.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_CustomerGroup.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_CustomerGroup.DropDownWidth = 140;
            this.cbx_CustomerGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_CustomerGroup.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_CustomerGroup.GridLineHorizontal = false;
            this.cbx_CustomerGroup.GridLineVertical = false;
            this.cbx_CustomerGroup.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_CustomerGroup.Location = new System.Drawing.Point(106, 56);
            this.cbx_CustomerGroup.ManagingFastMouseMoving = true;
            this.cbx_CustomerGroup.ManagingFastMouseMovingInterval = 30;
            this.cbx_CustomerGroup.Name = "cbx_CustomerGroup";
            this.cbx_CustomerGroup.SelectedItem = null;
            this.cbx_CustomerGroup.SelectedValue = null;
            this.cbx_CustomerGroup.Size = new System.Drawing.Size(187, 22);
            this.cbx_CustomerGroup.TabIndex = 542;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 541;
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
            this.cbx_Category.Location = new System.Drawing.Point(414, 56);
            this.cbx_Category.ManagingFastMouseMoving = true;
            this.cbx_Category.ManagingFastMouseMovingInterval = 30;
            this.cbx_Category.Name = "cbx_Category";
            this.cbx_Category.SelectedItem = null;
            this.cbx_Category.SelectedValue = null;
            this.cbx_Category.Size = new System.Drawing.Size(169, 22);
            this.cbx_Category.TabIndex = 540;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.BackColor = System.Drawing.Color.White;
            this.txt_PhoneNo.Location = new System.Drawing.Point(106, 149);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.ReadOnly = true;
            this.txt_PhoneNo.Size = new System.Drawing.Size(187, 20);
            this.txt_PhoneNo.TabIndex = 538;
            // 
            // lbl_PhoneNo
            // 
            this.lbl_PhoneNo.AutoSize = true;
            this.lbl_PhoneNo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNo.Location = new System.Drawing.Point(25, 149);
            this.lbl_PhoneNo.Name = "lbl_PhoneNo";
            this.lbl_PhoneNo.Size = new System.Drawing.Size(63, 20);
            this.lbl_PhoneNo.TabIndex = 539;
            this.lbl_PhoneNo.Text = "Phone No";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.Location = new System.Drawing.Point(106, 90);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(187, 49);
            this.txt_Address.TabIndex = 537;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(36, 88);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(52, 20);
            this.lbl_Address.TabIndex = 536;
            this.lbl_Address.Text = "Address";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_Return);
            this.groupBox3.Controls.Add(this.rdo_Sale);
            this.groupBox3.Location = new System.Drawing.Point(414, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 35);
            this.groupBox3.TabIndex = 535;
            this.groupBox3.TabStop = false;
            // 
            // rdo_Return
            // 
            this.rdo_Return.AutoSize = true;
            this.rdo_Return.Location = new System.Drawing.Point(98, 12);
            this.rdo_Return.Name = "rdo_Return";
            this.rdo_Return.Size = new System.Drawing.Size(57, 17);
            this.rdo_Return.TabIndex = 1;
            this.rdo_Return.TabStop = true;
            this.rdo_Return.Text = "Return";
            this.rdo_Return.UseVisualStyleBackColor = true;
            // 
            // rdo_Sale
            // 
            this.rdo_Sale.AutoSize = true;
            this.rdo_Sale.Location = new System.Drawing.Point(15, 12);
            this.rdo_Sale.Name = "rdo_Sale";
            this.rdo_Sale.Size = new System.Drawing.Size(46, 17);
            this.rdo_Sale.TabIndex = 0;
            this.rdo_Sale.TabStop = true;
            this.rdo_Sale.Text = "Sale";
            this.rdo_Sale.UseVisualStyleBackColor = true;
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(27, 57);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(61, 20);
            this.lbl_Customer.TabIndex = 529;
            this.lbl_Customer.Text = "Customer";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 833;
            this.btn_Search.Location = new System.Drawing.Point(619, 121);
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
            // 
            // dtp_InvoiceDateTo
            // 
            this.dtp_InvoiceDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(619, 87);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtp_InvoiceDateTo.TabIndex = 527;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(414, 87);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(169, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 525;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 524;
            this.label1.Text = "Invoice Date From";
            // 
            // cbx_Customer
            // 
            this.cbx_Customer.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_Customer.ArrowColor = System.Drawing.Color.Black;
            this.cbx_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_Customer.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_Customer.BindedControl")));
            this.cbx_Customer.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_Customer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_Customer.ColumnNum = 1;
            this.cbx_Customer.ColumnWidth = "121";
            this.cbx_Customer.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_Customer.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_Customer.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_Customer.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_Customer.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Customer.DisplayMember = "Text";
            this.cbx_Customer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Customer.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_Customer.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_Customer.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_Customer.DropDownWidth = 140;
            this.cbx_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Customer.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Customer.GridLineHorizontal = false;
            this.cbx_Customer.GridLineVertical = false;
            this.cbx_Customer.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Customer.Location = new System.Drawing.Point(106, 56);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(187, 22);
            this.cbx_Customer.TabIndex = 521;
            this.cbx_Customer.Leave += new System.EventHandler(this.cbx_Customer_Leave);
            this.cbx_Customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Customer_KeyDown);
            // 
            // rptv_CustomerSaleReport
            // 
            this.rptv_CustomerSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_CustomerSaleReport.Location = new System.Drawing.Point(0, 0);
            this.rptv_CustomerSaleReport.Name = "rptv_CustomerSaleReport";
            this.rptv_CustomerSaleReport.Size = new System.Drawing.Size(1016, 550);
            this.rptv_CustomerSaleReport.TabIndex = 3;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rptv_CustomerSaleReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 550);
            this.panel1.TabIndex = 4;
            // 
            // Frm_CustomerSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_CustomerSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Sale Report";
            this.Load += new System.EventHandler(this.Frm_CustomerSaleReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_Return;
        private System.Windows.Forms.RadioButton rdo_Sale;
        private System.Windows.Forms.Label lbl_Customer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private System.Windows.Forms.Label label1;
        private MTGCComboBox cbx_Customer;
        private Microsoft.Reporting.WinForms.ReportViewer rptv_CustomerSaleReport;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.Label lbl_PhoneNo;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private MTGCComboBox cbx_Category;
        private System.Windows.Forms.Label lbl_CustomerGroup;
        private MTGCComboBox cbx_CustomerGroup;
        private System.Windows.Forms.RadioButton rdo_Customer;
        private System.Windows.Forms.RadioButton rdo_CustomerGroup;
    }
}