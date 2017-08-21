namespace StockAndSale
{
    partial class Frm_InvoiceSaleReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InvoiceSaleReport));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_All = new System.Windows.Forms.RadioButton();
            this.rdo_NotPaid = new System.Windows.Forms.RadioButton();
            this.rdo_Paid = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdo_Consignment = new System.Windows.Forms.RadioButton();
            this.rdo_Credit = new System.Windows.Forms.RadioButton();
            this.rdo_Cash = new System.Windows.Forms.RadioButton();
            this.dtp_DueDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_DueDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Cashier = new MTGCComboBox();
            this.lbl_Customer = new System.Windows.Forms.Label();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_NotPaidAndOverDueDate = new System.Windows.Forms.CheckBox();
            this.cbx_Customer = new MTGCComboBox();
            this.rptv_InvoiceSaleReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rdo_CustomerGroup = new System.Windows.Forms.RadioButton();
            this.rdo_Customer = new System.Windows.Forms.RadioButton();
            this.lbl_CustomerGroup = new System.Windows.Forms.Label();
            this.cbx_CustomerGroup = new MTGCComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_CustomerGroup);
            this.groupBox1.Controls.Add(this.cbx_CustomerGroup);
            this.groupBox1.Controls.Add(this.rdo_CustomerGroup);
            this.groupBox1.Controls.Add(this.rdo_Customer);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dtp_DueDate);
            this.groupBox1.Controls.Add(this.lbl_DueDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_Cashier);
            this.groupBox1.Controls.Add(this.lbl_Customer);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chb_NotPaidAndOverDueDate);
            this.groupBox1.Controls.Add(this.cbx_Customer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_All);
            this.groupBox3.Controls.Add(this.rdo_NotPaid);
            this.groupBox3.Controls.Add(this.rdo_Paid);
            this.groupBox3.Location = new System.Drawing.Point(602, 75);
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
            // rdo_NotPaid
            // 
            this.rdo_NotPaid.AutoSize = true;
            this.rdo_NotPaid.Location = new System.Drawing.Point(88, 12);
            this.rdo_NotPaid.Name = "rdo_NotPaid";
            this.rdo_NotPaid.Size = new System.Drawing.Size(90, 17);
            this.rdo_NotPaid.TabIndex = 1;
            this.rdo_NotPaid.TabStop = true;
            this.rdo_NotPaid.Text = "Not Paid Only";
            this.rdo_NotPaid.UseVisualStyleBackColor = true;
            this.rdo_NotPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_NotPaid_KeyDown);
            // 
            // rdo_Paid
            // 
            this.rdo_Paid.AutoSize = true;
            this.rdo_Paid.Location = new System.Drawing.Point(7, 12);
            this.rdo_Paid.Name = "rdo_Paid";
            this.rdo_Paid.Size = new System.Drawing.Size(70, 17);
            this.rdo_Paid.TabIndex = 0;
            this.rdo_Paid.TabStop = true;
            this.rdo_Paid.Text = "Paid Only";
            this.rdo_Paid.UseVisualStyleBackColor = true;
            this.rdo_Paid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Paid_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_Consignment);
            this.groupBox2.Controls.Add(this.rdo_Credit);
            this.groupBox2.Controls.Add(this.rdo_Cash);
            this.groupBox2.Location = new System.Drawing.Point(106, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 36);
            this.groupBox2.TabIndex = 534;
            this.groupBox2.TabStop = false;
            // 
            // rdo_Consignment
            // 
            this.rdo_Consignment.AutoSize = true;
            this.rdo_Consignment.Location = new System.Drawing.Point(139, 13);
            this.rdo_Consignment.Name = "rdo_Consignment";
            this.rdo_Consignment.Size = new System.Drawing.Size(86, 17);
            this.rdo_Consignment.TabIndex = 2;
            this.rdo_Consignment.TabStop = true;
            this.rdo_Consignment.Text = "Consignment";
            this.rdo_Consignment.UseVisualStyleBackColor = true;
            this.rdo_Consignment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Consignment_KeyDown);
            // 
            // rdo_Credit
            // 
            this.rdo_Credit.AutoSize = true;
            this.rdo_Credit.Location = new System.Drawing.Point(71, 13);
            this.rdo_Credit.Name = "rdo_Credit";
            this.rdo_Credit.Size = new System.Drawing.Size(52, 17);
            this.rdo_Credit.TabIndex = 1;
            this.rdo_Credit.TabStop = true;
            this.rdo_Credit.Text = "Credit";
            this.rdo_Credit.UseVisualStyleBackColor = true;
            this.rdo_Credit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Credit_KeyDown);
            // 
            // rdo_Cash
            // 
            this.rdo_Cash.AutoSize = true;
            this.rdo_Cash.Location = new System.Drawing.Point(7, 13);
            this.rdo_Cash.Name = "rdo_Cash";
            this.rdo_Cash.Size = new System.Drawing.Size(49, 17);
            this.rdo_Cash.TabIndex = 0;
            this.rdo_Cash.TabStop = true;
            this.rdo_Cash.Text = "Cash";
            this.rdo_Cash.UseVisualStyleBackColor = true;
            this.rdo_Cash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Cash_KeyDown);
            // 
            // dtp_DueDate
            // 
            this.dtp_DueDate.CustomFormat = "dd/MM/yyyy";
            this.dtp_DueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_DueDate.Location = new System.Drawing.Point(420, 133);
            this.dtp_DueDate.Name = "dtp_DueDate";
            this.dtp_DueDate.ShowCheckBox = true;
            this.dtp_DueDate.Size = new System.Drawing.Size(156, 20);
            this.dtp_DueDate.TabIndex = 533;
            this.dtp_DueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_DueDate_KeyDown);
            // 
            // lbl_DueDate
            // 
            this.lbl_DueDate.AutoSize = true;
            this.lbl_DueDate.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DueDate.Location = new System.Drawing.Point(353, 133);
            this.lbl_DueDate.Name = "lbl_DueDate";
            this.lbl_DueDate.Size = new System.Drawing.Size(61, 20);
            this.lbl_DueDate.TabIndex = 532;
            this.lbl_DueDate.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 531;
            this.label5.Text = "Cashier";
            // 
            // cbx_Cashier
            // 
            this.cbx_Cashier.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_Cashier.ArrowColor = System.Drawing.Color.Black;
            this.cbx_Cashier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_Cashier.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_Cashier.BindedControl")));
            this.cbx_Cashier.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_Cashier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_Cashier.ColumnNum = 1;
            this.cbx_Cashier.ColumnWidth = "121";
            this.cbx_Cashier.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_Cashier.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_Cashier.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_Cashier.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_Cashier.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Cashier.DisplayMember = "Text";
            this.cbx_Cashier.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Cashier.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_Cashier.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_Cashier.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_Cashier.DropDownWidth = 140;
            this.cbx_Cashier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Cashier.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Cashier.GridLineHorizontal = false;
            this.cbx_Cashier.GridLineVertical = false;
            this.cbx_Cashier.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Cashier.Location = new System.Drawing.Point(106, 88);
            this.cbx_Cashier.ManagingFastMouseMoving = true;
            this.cbx_Cashier.ManagingFastMouseMovingInterval = 30;
            this.cbx_Cashier.Name = "cbx_Cashier";
            this.cbx_Cashier.SelectedItem = null;
            this.cbx_Cashier.SelectedValue = null;
            this.cbx_Cashier.Size = new System.Drawing.Size(187, 22);
            this.cbx_Cashier.TabIndex = 530;
            this.cbx_Cashier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Cashier_KeyDown);
            // 
            // lbl_Customer
            // 
            this.lbl_Customer.AutoSize = true;
            this.lbl_Customer.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer.Location = new System.Drawing.Point(17, 53);
            this.lbl_Customer.Name = "lbl_Customer";
            this.lbl_Customer.Size = new System.Drawing.Size(61, 20);
            this.lbl_Customer.TabIndex = 529;
            this.lbl_Customer.Text = "Customer";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 815;
            this.btn_Search.Location = new System.Drawing.Point(609, 124);
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
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(625, 48);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtp_InvoiceDateTo.TabIndex = 527;
            this.dtp_InvoiceDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateTo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(599, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(420, 48);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(156, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 525;
            this.dtp_InvoiceDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 524;
            this.label1.Text = "Invoice Date From";
            // 
            // chb_NotPaidAndOverDueDate
            // 
            this.chb_NotPaidAndOverDueDate.AutoSize = true;
            this.chb_NotPaidAndOverDueDate.Location = new System.Drawing.Point(420, 91);
            this.chb_NotPaidAndOverDueDate.Name = "chb_NotPaidAndOverDueDate";
            this.chb_NotPaidAndOverDueDate.Size = new System.Drawing.Size(163, 17);
            this.chb_NotPaidAndOverDueDate.TabIndex = 523;
            this.chb_NotPaidAndOverDueDate.Text = "Not Paid and Over Due Date";
            this.chb_NotPaidAndOverDueDate.UseVisualStyleBackColor = true;
            this.chb_NotPaidAndOverDueDate.CheckedChanged += new System.EventHandler(this.chb_NotPaidAndOverDueDate_CheckedChanged);
            this.chb_NotPaidAndOverDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chb_NotPaidAndOverDueDate_KeyDown);
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
            this.cbx_Customer.Location = new System.Drawing.Point(106, 51);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(187, 22);
            this.cbx_Customer.TabIndex = 521;
            this.cbx_Customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Customer_KeyDown);
            // 
            // rptv_InvoiceSaleReport
            // 
            this.rptv_InvoiceSaleReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_InvoiceSaleReport.Location = new System.Drawing.Point(0, 167);
            this.rptv_InvoiceSaleReport.Name = "rptv_InvoiceSaleReport";
            this.rptv_InvoiceSaleReport.Size = new System.Drawing.Size(1022, 554);
            this.rptv_InvoiceSaleReport.TabIndex = 1;
            // 
            // rdo_CustomerGroup
            // 
            this.rdo_CustomerGroup.AutoSize = true;
            this.rdo_CustomerGroup.Location = new System.Drawing.Point(208, 19);
            this.rdo_CustomerGroup.Name = "rdo_CustomerGroup";
            this.rdo_CustomerGroup.Size = new System.Drawing.Size(116, 17);
            this.rdo_CustomerGroup.TabIndex = 547;
            this.rdo_CustomerGroup.Text = "By Customer Group";
            this.rdo_CustomerGroup.UseVisualStyleBackColor = true;
            // 
            // rdo_Customer
            // 
            this.rdo_Customer.AutoSize = true;
            this.rdo_Customer.Checked = true;
            this.rdo_Customer.Location = new System.Drawing.Point(106, 19);
            this.rdo_Customer.Name = "rdo_Customer";
            this.rdo_Customer.Size = new System.Drawing.Size(84, 17);
            this.rdo_Customer.TabIndex = 546;
            this.rdo_Customer.TabStop = true;
            this.rdo_Customer.Text = "By Customer";
            this.rdo_Customer.UseVisualStyleBackColor = true;
            this.rdo_Customer.CheckedChanged += new System.EventHandler(this.rdo_Customer_CheckedChanged);
            // 
            // lbl_CustomerGroup
            // 
            this.lbl_CustomerGroup.AutoSize = true;
            this.lbl_CustomerGroup.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CustomerGroup.Location = new System.Drawing.Point(5, 53);
            this.lbl_CustomerGroup.Name = "lbl_CustomerGroup";
            this.lbl_CustomerGroup.Size = new System.Drawing.Size(98, 20);
            this.lbl_CustomerGroup.TabIndex = 549;
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
            this.cbx_CustomerGroup.Location = new System.Drawing.Point(106, 52);
            this.cbx_CustomerGroup.ManagingFastMouseMoving = true;
            this.cbx_CustomerGroup.ManagingFastMouseMovingInterval = 30;
            this.cbx_CustomerGroup.Name = "cbx_CustomerGroup";
            this.cbx_CustomerGroup.SelectedItem = null;
            this.cbx_CustomerGroup.SelectedValue = null;
            this.cbx_CustomerGroup.Size = new System.Drawing.Size(187, 22);
            this.cbx_CustomerGroup.TabIndex = 548;
            // 
            // Frm_InvoiceSaleReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.rptv_InvoiceSaleReport);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_InvoiceSaleReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Sale Report";
            this.Load += new System.EventHandler(this.Frm_InvoiceSaleReport_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer rptv_InvoiceSaleReport;
        private System.Windows.Forms.DateTimePicker dtp_DueDate;
        private System.Windows.Forms.Label lbl_DueDate;
        private System.Windows.Forms.Label label5;
        private MTGCComboBox cbx_Cashier;
        private System.Windows.Forms.Label lbl_Customer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chb_NotPaidAndOverDueDate;
        private MTGCComboBox cbx_Customer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdo_Consignment;
        private System.Windows.Forms.RadioButton rdo_Credit;
        private System.Windows.Forms.RadioButton rdo_Cash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_All;
        private System.Windows.Forms.RadioButton rdo_NotPaid;
        private System.Windows.Forms.RadioButton rdo_Paid;
        private System.Windows.Forms.RadioButton rdo_CustomerGroup;
        private System.Windows.Forms.RadioButton rdo_Customer;
        private System.Windows.Forms.Label lbl_CustomerGroup;
        private MTGCComboBox cbx_CustomerGroup;
    }
}