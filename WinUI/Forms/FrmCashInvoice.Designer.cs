namespace StockAndSale
{
    partial class FrmCashInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashInvoice));
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.cbx_Customer = new MTGCComboBox();
            this.gbx_InvoiceInfo = new System.Windows.Forms.GroupBox();
            this.chb_IsSample = new System.Windows.Forms.CheckBox();
            this.chb_InclusiveTax = new System.Windows.Forms.CheckBox();
            this.txt_PONumber = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_PromDesc = new System.Windows.Forms.TextBox();
            this.lbl_PromDesc = new System.Windows.Forms.Label();
            this.chb_IsPromotion = new System.Windows.Forms.CheckBox();
            this.btn_NewInvoiceNo = new System.Windows.Forms.Button();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Invoice_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chb_InclusiveTaxItem = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Price2 = new System.Windows.Forms.RadioButton();
            this.rdo_Price1 = new System.Windows.Forms.RadioButton();
            this.rdo_CartonPricePerUnits = new System.Windows.Forms.RadioButton();
            this.chb_FOC = new System.Windows.Forms.CheckBox();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Rate = new System.Windows.Forms.TextBox();
            this.rdo_isUnit = new System.Windows.Forms.RadioButton();
            this.rdo_isCarton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.cbx_Product = new MTGCComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ProductList = new System.Windows.Forms.DataGridView();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Advance = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_GrandTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Discount = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_DeleteRow = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_PreviewInvoice = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_Remark = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_DiscountPercent = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDetailDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.txt_CommercialTax = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_DDPercent = new System.Windows.Forms.TextBox();
            this.txt_DeliveryDiscount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lbl_PaymentDate = new System.Windows.Forms.Label();
            this.lbl_PaymentStatus = new System.Windows.Forms.Label();
            this.btn_Receive = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_ReturnStatus = new System.Windows.Forms.Label();
            this.btn_Return = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txt_DiffTotal = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_Return = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            this.gbx_InvoiceInfo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PreviewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Receive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.DirtyPaletteCounter = 849;
            this.btn_Save.Location = new System.Drawing.Point(12, 12);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Save.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Save.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Save.Size = new System.Drawing.Size(80, 32);
            this.btn_Save.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Save.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Save.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Save.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Save.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Save.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Save.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Save.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Save.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save";
            this.btn_Save.Values.ExtraText = "";
            this.btn_Save.Values.Image = null;
            this.btn_Save.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Save.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Save.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_CartonPrice
            // 
            this.lbl_CartonPrice.AutoSize = true;
            this.lbl_CartonPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartonPrice.Location = new System.Drawing.Point(47, 23);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(40, 20);
            this.lbl_CartonPrice.TabIndex = 507;
            this.lbl_CartonPrice.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(93, 23);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(187, 20);
            this.txt_Name.TabIndex = 1;
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
            this.cbx_Customer.Location = new System.Drawing.Point(93, 58);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(187, 22);
            this.cbx_Customer.TabIndex = 2;
            this.cbx_Customer.Leave += new System.EventHandler(this.cbx_Customer_Leave);
            this.cbx_Customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Customer_KeyDown);
            // 
            // gbx_InvoiceInfo
            // 
            this.gbx_InvoiceInfo.Controls.Add(this.chb_IsSample);
            this.gbx_InvoiceInfo.Controls.Add(this.chb_InclusiveTax);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_PONumber);
            this.gbx_InvoiceInfo.Controls.Add(this.label18);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_PromDesc);
            this.gbx_InvoiceInfo.Controls.Add(this.lbl_PromDesc);
            this.gbx_InvoiceInfo.Controls.Add(this.chb_IsPromotion);
            this.gbx_InvoiceInfo.Controls.Add(this.btn_NewInvoiceNo);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_PhoneNo);
            this.gbx_InvoiceInfo.Controls.Add(this.label5);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Address);
            this.gbx_InvoiceInfo.Controls.Add(this.label4);
            this.gbx_InvoiceInfo.Controls.Add(this.label1);
            this.gbx_InvoiceInfo.Controls.Add(this.cbx_Customer);
            this.gbx_InvoiceInfo.Controls.Add(this.dtp_InvoiceDate);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Name);
            this.gbx_InvoiceInfo.Controls.Add(this.label3);
            this.gbx_InvoiceInfo.Controls.Add(this.lbl_CartonPrice);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Invoice_No);
            this.gbx_InvoiceInfo.Controls.Add(this.label2);
            this.gbx_InvoiceInfo.Location = new System.Drawing.Point(12, 53);
            this.gbx_InvoiceInfo.Name = "gbx_InvoiceInfo";
            this.gbx_InvoiceInfo.Size = new System.Drawing.Size(958, 152);
            this.gbx_InvoiceInfo.TabIndex = 510;
            this.gbx_InvoiceInfo.TabStop = false;
            this.gbx_InvoiceInfo.Text = "Invoice Information";
            // 
            // chb_IsSample
            // 
            this.chb_IsSample.AutoSize = true;
            this.chb_IsSample.Location = new System.Drawing.Point(478, 127);
            this.chb_IsSample.Name = "chb_IsSample";
            this.chb_IsSample.Size = new System.Drawing.Size(99, 17);
            this.chb_IsSample.TabIndex = 541;
            this.chb_IsSample.Text = "Sample Invoice";
            this.chb_IsSample.UseVisualStyleBackColor = true;
            // 
            // chb_InclusiveTax
            // 
            this.chb_InclusiveTax.AutoSize = true;
            this.chb_InclusiveTax.Location = new System.Drawing.Point(362, 127);
            this.chb_InclusiveTax.Name = "chb_InclusiveTax";
            this.chb_InclusiveTax.Size = new System.Drawing.Size(89, 17);
            this.chb_InclusiveTax.TabIndex = 540;
            this.chb_InclusiveTax.Text = "Inclusive Tax";
            this.chb_InclusiveTax.UseVisualStyleBackColor = true;
            this.chb_InclusiveTax.CheckedChanged += new System.EventHandler(this.chb_InclusiveTax_CheckedChanged);
            // 
            // txt_PONumber
            // 
            this.txt_PONumber.Location = new System.Drawing.Point(697, 96);
            this.txt_PONumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PONumber.Name = "txt_PONumber";
            this.txt_PONumber.Size = new System.Drawing.Size(202, 20);
            this.txt_PONumber.TabIndex = 533;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(623, 97);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 20);
            this.label18.TabIndex = 534;
            this.label18.Text = "PO Number";
            // 
            // txt_PromDesc
            // 
            this.txt_PromDesc.Location = new System.Drawing.Point(93, 125);
            this.txt_PromDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PromDesc.Name = "txt_PromDesc";
            this.txt_PromDesc.Size = new System.Drawing.Size(187, 20);
            this.txt_PromDesc.TabIndex = 531;
            this.txt_PromDesc.Visible = false;
            // 
            // lbl_PromDesc
            // 
            this.lbl_PromDesc.AutoSize = true;
            this.lbl_PromDesc.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PromDesc.Location = new System.Drawing.Point(5, 125);
            this.lbl_PromDesc.Name = "lbl_PromDesc";
            this.lbl_PromDesc.Size = new System.Drawing.Size(84, 20);
            this.lbl_PromDesc.TabIndex = 532;
            this.lbl_PromDesc.Text = "Prom: Reason";
            this.lbl_PromDesc.Visible = false;
            // 
            // chb_IsPromotion
            // 
            this.chb_IsPromotion.AutoSize = true;
            this.chb_IsPromotion.Location = new System.Drawing.Point(93, 96);
            this.chb_IsPromotion.Name = "chb_IsPromotion";
            this.chb_IsPromotion.Size = new System.Drawing.Size(116, 17);
            this.chb_IsPromotion.TabIndex = 530;
            this.chb_IsPromotion.Text = "Promotion Voucher";
            this.chb_IsPromotion.UseVisualStyleBackColor = true;
            this.chb_IsPromotion.CheckedChanged += new System.EventHandler(this.chb_IsPromotion_CheckedChanged);
            // 
            // btn_NewInvoiceNo
            // 
            this.btn_NewInvoiceNo.Location = new System.Drawing.Point(930, 21);
            this.btn_NewInvoiceNo.Name = "btn_NewInvoiceNo";
            this.btn_NewInvoiceNo.Size = new System.Drawing.Size(22, 23);
            this.btn_NewInvoiceNo.TabIndex = 4;
            this.btn_NewInvoiceNo.Text = "New";
            this.btn_NewInvoiceNo.UseVisualStyleBackColor = true;
            this.btn_NewInvoiceNo.Visible = false;
            this.btn_NewInvoiceNo.Click += new System.EventHandler(this.btn_NewInvoiceNo_Click);
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.BackColor = System.Drawing.Color.White;
            this.txt_PhoneNo.Location = new System.Drawing.Point(362, 93);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.ReadOnly = true;
            this.txt_PhoneNo.Size = new System.Drawing.Size(221, 20);
            this.txt_PhoneNo.TabIndex = 516;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(293, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 517;
            this.label5.Text = "Phone No";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.Location = new System.Drawing.Point(362, 23);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(221, 55);
            this.txt_Address.TabIndex = 515;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 514;
            this.label4.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 509;
            this.label1.Text = "Customer";
            // 
            // dtp_InvoiceDate
            // 
            this.dtp_InvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDate.Location = new System.Drawing.Point(697, 60);
            this.dtp_InvoiceDate.Name = "dtp_InvoiceDate";
            this.dtp_InvoiceDate.Size = new System.Drawing.Size(202, 20);
            this.dtp_InvoiceDate.TabIndex = 5;
            this.dtp_InvoiceDate.Leave += new System.EventHandler(this.dtp_InvoiceDate_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 512;
            this.label3.Text = "Invoice Date";
            // 
            // txt_Invoice_No
            // 
            this.txt_Invoice_No.BackColor = System.Drawing.Color.White;
            this.txt_Invoice_No.Location = new System.Drawing.Point(697, 23);
            this.txt_Invoice_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Invoice_No.Name = "txt_Invoice_No";
            this.txt_Invoice_No.Size = new System.Drawing.Size(202, 20);
            this.txt_Invoice_No.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(616, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 511;
            this.label2.Text = "Invoice No";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chb_InclusiveTaxItem);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.rdo_CartonPricePerUnits);
            this.groupBox2.Controls.Add(this.chb_FOC);
            this.groupBox2.Controls.Add(this.btn_Reset);
            this.groupBox2.Controls.Add(this.btn_Add);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Quantity);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_Amount);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Rate);
            this.groupBox2.Controls.Add(this.rdo_isUnit);
            this.groupBox2.Controls.Add(this.rdo_isCarton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_ProductDescription);
            this.groupBox2.Controls.Add(this.cbx_Product);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgv_ProductList);
            this.groupBox2.Location = new System.Drawing.Point(12, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 362);
            this.groupBox2.TabIndex = 511;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product List";
            // 
            // chb_InclusiveTaxItem
            // 
            this.chb_InclusiveTaxItem.AutoSize = true;
            this.chb_InclusiveTaxItem.Location = new System.Drawing.Point(630, 73);
            this.chb_InclusiveTaxItem.Name = "chb_InclusiveTaxItem";
            this.chb_InclusiveTaxItem.Size = new System.Drawing.Size(70, 17);
            this.chb_InclusiveTaxItem.TabIndex = 541;
            this.chb_InclusiveTaxItem.Text = "Tax Rate";
            this.chb_InclusiveTaxItem.UseVisualStyleBackColor = true;
            this.chb_InclusiveTaxItem.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Price2);
            this.groupBox1.Controls.Add(this.rdo_Price1);
            this.groupBox1.Location = new System.Drawing.Point(166, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 33);
            this.groupBox1.TabIndex = 531;
            this.groupBox1.TabStop = false;
            // 
            // rdo_Price2
            // 
            this.rdo_Price2.AutoSize = true;
            this.rdo_Price2.Location = new System.Drawing.Point(103, 10);
            this.rdo_Price2.Name = "rdo_Price2";
            this.rdo_Price2.Size = new System.Drawing.Size(61, 17);
            this.rdo_Price2.TabIndex = 1;
            this.rdo_Price2.TabStop = true;
            this.rdo_Price2.Text = "Price_2";
            this.rdo_Price2.UseVisualStyleBackColor = true;
            this.rdo_Price2.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // rdo_Price1
            // 
            this.rdo_Price1.AutoSize = true;
            this.rdo_Price1.Location = new System.Drawing.Point(16, 10);
            this.rdo_Price1.Name = "rdo_Price1";
            this.rdo_Price1.Size = new System.Drawing.Size(61, 17);
            this.rdo_Price1.TabIndex = 0;
            this.rdo_Price1.TabStop = true;
            this.rdo_Price1.Text = "Price_1";
            this.rdo_Price1.UseVisualStyleBackColor = true;
            this.rdo_Price1.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // rdo_CartonPricePerUnits
            // 
            this.rdo_CartonPricePerUnits.AutoSize = true;
            this.rdo_CartonPricePerUnits.Location = new System.Drawing.Point(380, 73);
            this.rdo_CartonPricePerUnits.Name = "rdo_CartonPricePerUnits";
            this.rdo_CartonPricePerUnits.Size = new System.Drawing.Size(112, 17);
            this.rdo_CartonPricePerUnits.TabIndex = 530;
            this.rdo_CartonPricePerUnits.TabStop = true;
            this.rdo_CartonPricePerUnits.Text = "Carton Price/Units";
            this.rdo_CartonPricePerUnits.UseVisualStyleBackColor = true;
            this.rdo_CartonPricePerUnits.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // chb_FOC
            // 
            this.chb_FOC.AutoSize = true;
            this.chb_FOC.Location = new System.Drawing.Point(503, 73);
            this.chb_FOC.Name = "chb_FOC";
            this.chb_FOC.Size = new System.Drawing.Size(47, 17);
            this.chb_FOC.TabIndex = 529;
            this.chb_FOC.Text = "FOC";
            this.chb_FOC.UseVisualStyleBackColor = true;
            this.chb_FOC.Leave += new System.EventHandler(this.chb_FOC_Leave);
            this.chb_FOC.CheckedChanged += new System.EventHandler(this.chb_FOC_CheckedChanged);
            this.chb_FOC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chb_FOC_KeyDown);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(89, 83);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(63, 23);
            this.btn_Reset.TabIndex = 528;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(20, 83);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(63, 23);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            this.btn_Add.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_Add_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(501, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 527;
            this.label10.Text = "Quantity";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(503, 46);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(104, 20);
            this.txt_Quantity.TabIndex = 6;
            this.txt_Quantity.TextChanged += new System.EventHandler(this.txt_Quantity_TextChanged);
            this.txt_Quantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Quantity_KeyDown);
            this.txt_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Quantity_KeyPress);
            this.txt_Quantity.Enter += new System.EventHandler(this.txt_Quantity_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(747, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 525;
            this.label9.Text = "Amount";
            // 
            // txt_Amount
            // 
            this.txt_Amount.BackColor = System.Drawing.Color.White;
            this.txt_Amount.Location = new System.Drawing.Point(749, 46);
            this.txt_Amount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.ReadOnly = true;
            this.txt_Amount.Size = new System.Drawing.Size(150, 20);
            this.txt_Amount.TabIndex = 524;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(627, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 523;
            this.label8.Text = "Rate";
            // 
            // txt_Rate
            // 
            this.txt_Rate.BackColor = System.Drawing.Color.White;
            this.txt_Rate.Location = new System.Drawing.Point(629, 46);
            this.txt_Rate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Rate.Name = "txt_Rate";
            this.txt_Rate.ReadOnly = true;
            this.txt_Rate.Size = new System.Drawing.Size(104, 20);
            this.txt_Rate.TabIndex = 522;
            this.txt_Rate.TextChanged += new System.EventHandler(this.txt_Rate_TextChanged);
            // 
            // rdo_isUnit
            // 
            this.rdo_isUnit.AutoSize = true;
            this.rdo_isUnit.Location = new System.Drawing.Point(445, 47);
            this.rdo_isUnit.Name = "rdo_isUnit";
            this.rdo_isUnit.Size = new System.Drawing.Size(44, 17);
            this.rdo_isUnit.TabIndex = 521;
            this.rdo_isUnit.TabStop = true;
            this.rdo_isUnit.Text = "Unit";
            this.rdo_isUnit.UseVisualStyleBackColor = true;
            this.rdo_isUnit.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // rdo_isCarton
            // 
            this.rdo_isCarton.AutoSize = true;
            this.rdo_isCarton.Location = new System.Drawing.Point(380, 47);
            this.rdo_isCarton.Name = "rdo_isCarton";
            this.rdo_isCarton.Size = new System.Drawing.Size(56, 17);
            this.rdo_isCarton.TabIndex = 520;
            this.rdo_isCarton.TabStop = true;
            this.rdo_isCarton.Text = "Carton";
            this.rdo_isCarton.UseVisualStyleBackColor = true;
            this.rdo_isCarton.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(162, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 519;
            this.label7.Text = "Description";
            // 
            // txt_ProductDescription
            // 
            this.txt_ProductDescription.BackColor = System.Drawing.Color.White;
            this.txt_ProductDescription.Location = new System.Drawing.Point(164, 44);
            this.txt_ProductDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductDescription.Name = "txt_ProductDescription";
            this.txt_ProductDescription.ReadOnly = true;
            this.txt_ProductDescription.Size = new System.Drawing.Size(197, 20);
            this.txt_ProductDescription.TabIndex = 518;
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
            this.cbx_Product.Location = new System.Drawing.Point(20, 43);
            this.cbx_Product.ManagingFastMouseMoving = true;
            this.cbx_Product.ManagingFastMouseMovingInterval = 30;
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.SelectedItem = null;
            this.cbx_Product.SelectedValue = null;
            this.cbx_Product.Size = new System.Drawing.Size(132, 22);
            this.cbx_Product.TabIndex = 5;
            this.cbx_Product.Leave += new System.EventHandler(this.cbx_Product_Leave);
            this.cbx_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Product_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 513;
            this.label6.Text = "Product";
            // 
            // dgv_ProductList
            // 
            this.dgv_ProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ProductList.Location = new System.Drawing.Point(6, 112);
            this.dgv_ProductList.Name = "dgv_ProductList";
            this.dgv_ProductList.Size = new System.Drawing.Size(946, 250);
            this.dgv_ProductList.TabIndex = 0;
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(679, 582);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Total.Size = new System.Drawing.Size(232, 20);
            this.txt_Total.TabIndex = 512;
            this.txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Total_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(622, 582);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 513;
            this.label11.Text = "Total";
            // 
            // txt_Advance
            // 
            this.txt_Advance.Location = new System.Drawing.Point(679, 608);
            this.txt_Advance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Advance.Name = "txt_Advance";
            this.txt_Advance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Advance.Size = new System.Drawing.Size(232, 20);
            this.txt_Advance.TabIndex = 514;
            this.txt_Advance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Advance.TextChanged += new System.EventHandler(this.txt_Advance_TextChanged);
            this.txt_Advance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Advance_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(603, 608);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 20);
            this.label12.TabIndex = 515;
            this.label12.Text = "Advance";
            // 
            // txt_GrandTotal
            // 
            this.txt_GrandTotal.BackColor = System.Drawing.Color.White;
            this.txt_GrandTotal.Location = new System.Drawing.Point(679, 712);
            this.txt_GrandTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_GrandTotal.Name = "txt_GrandTotal";
            this.txt_GrandTotal.ReadOnly = true;
            this.txt_GrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_GrandTotal.Size = new System.Drawing.Size(232, 20);
            this.txt_GrandTotal.TabIndex = 518;
            this.txt_GrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(586, 712);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 519;
            this.label13.Text = "Grand Total";
            // 
            // txt_Discount
            // 
            this.txt_Discount.Location = new System.Drawing.Point(763, 658);
            this.txt_Discount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Discount.Name = "txt_Discount";
            this.txt_Discount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Discount.Size = new System.Drawing.Size(148, 20);
            this.txt_Discount.TabIndex = 516;
            this.txt_Discount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Discount.TextChanged += new System.EventHandler(this.txt_Discount_TextChanged);
            this.txt_Discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Discount_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(603, 660);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 20);
            this.label14.TabIndex = 517;
            this.label14.Text = "Discount";
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.ForeColor = System.Drawing.Color.Maroon;
            this.btn_DeleteRow.Location = new System.Drawing.Point(18, 581);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(97, 23);
            this.btn_DeleteRow.TabIndex = 530;
            this.btn_DeleteRow.Text = "Delete Row";
            this.btn_DeleteRow.UseVisualStyleBackColor = true;
            this.btn_DeleteRow.Click += new System.EventHandler(this.button2_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // btn_PreviewInvoice
            // 
            this.btn_PreviewInvoice.DirtyPaletteCounter = 851;
            this.btn_PreviewInvoice.Location = new System.Drawing.Point(116, 12);
            this.btn_PreviewInvoice.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_PreviewInvoice.Name = "btn_PreviewInvoice";
            this.btn_PreviewInvoice.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_PreviewInvoice.Size = new System.Drawing.Size(122, 32);
            this.btn_PreviewInvoice.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_PreviewInvoice.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviewInvoice.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_PreviewInvoice.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_PreviewInvoice.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PreviewInvoice.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_PreviewInvoice.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_PreviewInvoice.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_PreviewInvoice.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_PreviewInvoice.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_PreviewInvoice.TabIndex = 531;
            this.btn_PreviewInvoice.Text = "Preview Invoice";
            this.btn_PreviewInvoice.Values.ExtraText = "";
            this.btn_PreviewInvoice.Values.Image = null;
            this.btn_PreviewInvoice.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_PreviewInvoice.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_PreviewInvoice.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_PreviewInvoice.Values.Text = "Preview Invoice";
            this.btn_PreviewInvoice.Click += new System.EventHandler(this.btn_PreviewInvoice_Click);
            // 
            // txt_Remark
            // 
            this.txt_Remark.Location = new System.Drawing.Point(252, 584);
            this.txt_Remark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Remark.Multiline = true;
            this.txt_Remark.Name = "txt_Remark";
            this.txt_Remark.Size = new System.Drawing.Size(287, 105);
            this.txt_Remark.TabIndex = 532;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(176, 584);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 20);
            this.label15.TabIndex = 533;
            this.label15.Text = "Remark";
            // 
            // txt_DiscountPercent
            // 
            this.txt_DiscountPercent.Location = new System.Drawing.Point(679, 659);
            this.txt_DiscountPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiscountPercent.Name = "txt_DiscountPercent";
            this.txt_DiscountPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DiscountPercent.Size = new System.Drawing.Size(55, 20);
            this.txt_DiscountPercent.TabIndex = 534;
            this.txt_DiscountPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DiscountPercent.TextChanged += new System.EventHandler(this.txt_DiscountPercent_TextChanged);
            this.txt_DiscountPercent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DiscountPercent_KeyDown);
            this.txt_DiscountPercent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(736, 658);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 20);
            this.label16.TabIndex = 535;
            this.label16.Text = "%";
            // 
            // dtp_InvoiceDetailDate
            // 
            this.dtp_InvoiceDetailDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDetailDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDetailDate.Location = new System.Drawing.Point(18, 671);
            this.dtp_InvoiceDetailDate.Name = "dtp_InvoiceDetailDate";
            this.dtp_InvoiceDetailDate.Size = new System.Drawing.Size(54, 20);
            this.dtp_InvoiceDetailDate.TabIndex = 518;
            this.dtp_InvoiceDetailDate.Visible = false;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Time.Location = new System.Drawing.Point(14, 648);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 20);
            this.lbl_Time.TabIndex = 545;
            this.lbl_Time.Text = "time";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Date.Location = new System.Drawing.Point(14, 626);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(34, 20);
            this.lbl_Date.TabIndex = 544;
            this.lbl_Date.Text = "date";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // txt_CommercialTax
            // 
            this.txt_CommercialTax.BackColor = System.Drawing.Color.White;
            this.txt_CommercialTax.Location = new System.Drawing.Point(679, 634);
            this.txt_CommercialTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CommercialTax.Name = "txt_CommercialTax";
            this.txt_CommercialTax.ReadOnly = true;
            this.txt_CommercialTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_CommercialTax.Size = new System.Drawing.Size(232, 20);
            this.txt_CommercialTax.TabIndex = 546;
            this.txt_CommercialTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_CommercialTax.TextChanged += new System.EventHandler(this.txt_CommercialTax_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(565, 634);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 20);
            this.label17.TabIndex = 547;
            this.label17.Text = "Commercial Tax";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(736, 682);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 20);
            this.label19.TabIndex = 551;
            this.label19.Text = "%";
            // 
            // txt_DDPercent
            // 
            this.txt_DDPercent.Location = new System.Drawing.Point(679, 683);
            this.txt_DDPercent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DDPercent.Name = "txt_DDPercent";
            this.txt_DDPercent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DDPercent.Size = new System.Drawing.Size(55, 20);
            this.txt_DDPercent.TabIndex = 550;
            this.txt_DDPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DDPercent.TextChanged += new System.EventHandler(this.txt_DDPercent_TextChanged);
            // 
            // txt_DeliveryDiscount
            // 
            this.txt_DeliveryDiscount.Location = new System.Drawing.Point(763, 682);
            this.txt_DeliveryDiscount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DeliveryDiscount.Name = "txt_DeliveryDiscount";
            this.txt_DeliveryDiscount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_DeliveryDiscount.Size = new System.Drawing.Size(148, 20);
            this.txt_DeliveryDiscount.TabIndex = 548;
            this.txt_DeliveryDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_DeliveryDiscount.TextChanged += new System.EventHandler(this.txt_DeliveryDiscount_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(558, 684);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(102, 20);
            this.label20.TabIndex = 549;
            this.label20.Text = "Delivery Discount";
            // 
            // lbl_PaymentDate
            // 
            this.lbl_PaymentDate.AutoSize = true;
            this.lbl_PaymentDate.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentDate.Location = new System.Drawing.Point(740, 17);
            this.lbl_PaymentDate.Name = "lbl_PaymentDate";
            this.lbl_PaymentDate.Size = new System.Drawing.Size(35, 20);
            this.lbl_PaymentDate.TabIndex = 553;
            this.lbl_PaymentDate.Text = "Date";
            this.lbl_PaymentDate.Visible = false;
            // 
            // lbl_PaymentStatus
            // 
            this.lbl_PaymentStatus.AutoSize = true;
            this.lbl_PaymentStatus.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PaymentStatus.Location = new System.Drawing.Point(586, 17);
            this.lbl_PaymentStatus.Name = "lbl_PaymentStatus";
            this.lbl_PaymentStatus.Size = new System.Drawing.Size(153, 20);
            this.lbl_PaymentStatus.TabIndex = 552;
            this.lbl_PaymentStatus.Text = "Invoice is already Paid on :";
            this.lbl_PaymentStatus.Visible = false;
            // 
            // btn_Receive
            // 
            this.btn_Receive.DirtyPaletteCounter = 861;
            this.btn_Receive.Location = new System.Drawing.Point(890, 12);
            this.btn_Receive.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Receive.Size = new System.Drawing.Size(80, 32);
            this.btn_Receive.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Receive.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receive.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Receive.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Receive.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Receive.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Receive.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Receive.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Receive.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Receive.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Receive.TabIndex = 554;
            this.btn_Receive.Text = "Paid";
            this.btn_Receive.Values.ExtraText = "";
            this.btn_Receive.Values.Image = null;
            this.btn_Receive.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Receive.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Receive.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Receive.Values.Text = "Paid";
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // lbl_ReturnStatus
            // 
            this.lbl_ReturnStatus.AutoSize = true;
            this.lbl_ReturnStatus.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReturnStatus.Location = new System.Drawing.Point(355, 20);
            this.lbl_ReturnStatus.Name = "lbl_ReturnStatus";
            this.lbl_ReturnStatus.Size = new System.Drawing.Size(85, 20);
            this.lbl_ReturnStatus.TabIndex = 573;
            this.lbl_ReturnStatus.Text = "Return Status";
            // 
            // btn_Return
            // 
            this.btn_Return.DirtyPaletteCounter = 869;
            this.btn_Return.Location = new System.Drawing.Point(262, 12);
            this.btn_Return.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Return.Name = "btn_Return";
            this.btn_Return.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Return.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Return.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Return.Size = new System.Drawing.Size(80, 32);
            this.btn_Return.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Return.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Return.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Return.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Return.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Return.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Return.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Return.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Return.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Return.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Return.TabIndex = 572;
            this.btn_Return.Text = "Return";
            this.btn_Return.Values.ExtraText = "";
            this.btn_Return.Values.Image = null;
            this.btn_Return.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Return.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Return.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Return.Values.Text = "Return";
            this.btn_Return.Click += new System.EventHandler(this.btn_Return_Click);
            // 
            // txt_DiffTotal
            // 
            this.txt_DiffTotal.BackColor = System.Drawing.Color.White;
            this.txt_DiffTotal.Location = new System.Drawing.Point(446, 707);
            this.txt_DiffTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiffTotal.Name = "txt_DiffTotal";
            this.txt_DiffTotal.ReadOnly = true;
            this.txt_DiffTotal.Size = new System.Drawing.Size(92, 20);
            this.txt_DiffTotal.TabIndex = 584;
            this.txt_DiffTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(347, 707);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 20);
            this.label23.TabIndex = 585;
            this.label23.Text = "Difference Total";
            // 
            // txt_Return
            // 
            this.txt_Return.BackColor = System.Drawing.Color.White;
            this.txt_Return.Location = new System.Drawing.Point(253, 707);
            this.txt_Return.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Return.Name = "txt_Return";
            this.txt_Return.ReadOnly = true;
            this.txt_Return.Size = new System.Drawing.Size(92, 20);
            this.txt_Return.TabIndex = 582;
            this.txt_Return.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Return.TextChanged += new System.EventHandler(this.txt_Return_TextChanged_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(196, 707);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(46, 20);
            this.label22.TabIndex = 583;
            this.label22.Text = "Return";
            // 
            // FrmCashInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 740);
            this.Controls.Add(this.txt_DiffTotal);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txt_Return);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.lbl_ReturnStatus);
            this.Controls.Add(this.btn_Return);
            this.Controls.Add(this.lbl_PaymentDate);
            this.Controls.Add(this.lbl_PaymentStatus);
            this.Controls.Add(this.btn_Receive);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txt_DDPercent);
            this.Controls.Add(this.txt_DeliveryDiscount);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txt_CommercialTax);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_InvoiceDetailDate);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_DiscountPercent);
            this.Controls.Add(this.txt_Remark);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btn_PreviewInvoice);
            this.Controls.Add(this.btn_DeleteRow);
            this.Controls.Add(this.txt_GrandTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_Discount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Advance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_InvoiceInfo);
            this.Controls.Add(this.btn_Save);
            this.Name = "FrmCashInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cash Invoice";
            this.Load += new System.EventHandler(this.FrmCashInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            this.gbx_InvoiceInfo.ResumeLayout(false);
            this.gbx_InvoiceInfo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_PreviewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Receive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_Name;
        private MTGCComboBox cbx_Customer;
        private System.Windows.Forms.GroupBox gbx_InvoiceInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Invoice_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.RadioButton rdo_isUnit;
        private System.Windows.Forms.RadioButton rdo_isCarton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ProductDescription;
        private MTGCComboBox cbx_Product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Button btn_NewInvoiceNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Advance;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_GrandTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_Discount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_DeleteRow;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_PreviewInvoice;
        private System.Windows.Forms.TextBox txt_Remark;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_DiscountPercent;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDetailDate;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.CheckBox chb_FOC;
        private System.Windows.Forms.CheckBox chb_IsPromotion;
        private System.Windows.Forms.TextBox txt_PromDesc;
        private System.Windows.Forms.Label lbl_PromDesc;
        private System.Windows.Forms.TextBox txt_PONumber;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rdo_CartonPricePerUnits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Price2;
        private System.Windows.Forms.RadioButton rdo_Price1;
        private System.Windows.Forms.CheckBox chb_InclusiveTax;
        private System.Windows.Forms.CheckBox chb_InclusiveTaxItem;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_DDPercent;
        private System.Windows.Forms.TextBox txt_DeliveryDiscount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_CommercialTax;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chb_IsSample;
        private System.Windows.Forms.Label lbl_PaymentDate;
        private System.Windows.Forms.Label lbl_PaymentStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Receive;
        private System.Windows.Forms.Label lbl_ReturnStatus;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Return;
        private System.Windows.Forms.TextBox txt_DiffTotal;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_Return;
        private System.Windows.Forms.Label label22;
    }
}