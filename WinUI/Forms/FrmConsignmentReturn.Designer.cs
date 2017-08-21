namespace StockAndSale
{
    partial class FrmConsignmentReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsignmentReturn));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.gbx_InvoiceInfo = new System.Windows.Forms.GroupBox();
            this.dtp_InvoiceDueDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Invoice_No = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Customer = new MTGCComboBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_DeleteRow = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_Time = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.dtp_InvoiceDetailDate = new System.Windows.Forms.DateTimePicker();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdo_Price2 = new System.Windows.Forms.RadioButton();
            this.rdo_Price1 = new System.Windows.Forms.RadioButton();
            this.rdo_CartonPricePerUnits = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).BeginInit();
            this.gbx_InvoiceInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdo_CartonPricePerUnits);
            this.groupBox2.Controls.Add(this.groupBox1);
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
            this.groupBox2.Location = new System.Drawing.Point(32, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 404);
            this.groupBox2.TabIndex = 555;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product List";
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
            this.btn_Add.Size = new System.Drawing.Size(60, 23);
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
            this.txt_Amount.Size = new System.Drawing.Size(150, 20);
            this.txt_Amount.TabIndex = 524;
            this.txt_Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Amount_KeyPress);
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
            this.txt_Rate.Size = new System.Drawing.Size(104, 20);
            this.txt_Rate.TabIndex = 522;
            this.txt_Rate.TextChanged += new System.EventHandler(this.txt_Rate_TextChanged);
            this.txt_Rate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Rate_KeyPress);
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
            this.dgv_ProductList.Size = new System.Drawing.Size(946, 286);
            this.dgv_ProductList.TabIndex = 0;
            // 
            // gbx_InvoiceInfo
            // 
            this.gbx_InvoiceInfo.Controls.Add(this.dtp_InvoiceDueDate);
            this.gbx_InvoiceInfo.Controls.Add(this.label16);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_PhoneNo);
            this.gbx_InvoiceInfo.Controls.Add(this.label5);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Address);
            this.gbx_InvoiceInfo.Controls.Add(this.label4);
            this.gbx_InvoiceInfo.Controls.Add(this.dtp_InvoiceDate);
            this.gbx_InvoiceInfo.Controls.Add(this.label3);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Invoice_No);
            this.gbx_InvoiceInfo.Controls.Add(this.label2);
            this.gbx_InvoiceInfo.Controls.Add(this.label1);
            this.gbx_InvoiceInfo.Controls.Add(this.cbx_Customer);
            this.gbx_InvoiceInfo.Controls.Add(this.txt_Name);
            this.gbx_InvoiceInfo.Controls.Add(this.lbl_CartonPrice);
            this.gbx_InvoiceInfo.Location = new System.Drawing.Point(32, 30);
            this.gbx_InvoiceInfo.Name = "gbx_InvoiceInfo";
            this.gbx_InvoiceInfo.Size = new System.Drawing.Size(958, 127);
            this.gbx_InvoiceInfo.TabIndex = 556;
            this.gbx_InvoiceInfo.TabStop = false;
            this.gbx_InvoiceInfo.Text = "Invoice Information";
            // 
            // dtp_InvoiceDueDate
            // 
            this.dtp_InvoiceDueDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDueDate.Enabled = false;
            this.dtp_InvoiceDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDueDate.Location = new System.Drawing.Point(94, 89);
            this.dtp_InvoiceDueDate.Name = "dtp_InvoiceDueDate";
            this.dtp_InvoiceDueDate.Size = new System.Drawing.Size(202, 20);
            this.dtp_InvoiceDueDate.TabIndex = 518;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 20);
            this.label16.TabIndex = 519;
            this.label16.Text = "Due Date";
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.BackColor = System.Drawing.Color.White;
            this.txt_PhoneNo.Enabled = false;
            this.txt_PhoneNo.Location = new System.Drawing.Point(678, 89);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.ReadOnly = true;
            this.txt_PhoneNo.Size = new System.Drawing.Size(221, 20);
            this.txt_PhoneNo.TabIndex = 516;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 517;
            this.label5.Text = "Phone No";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.Enabled = false;
            this.txt_Address.Location = new System.Drawing.Point(678, 19);
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
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(620, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 514;
            this.label4.Text = "Address";
            // 
            // dtp_InvoiceDate
            // 
            this.dtp_InvoiceDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDate.Enabled = false;
            this.dtp_InvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDate.Location = new System.Drawing.Point(94, 56);
            this.dtp_InvoiceDate.Name = "dtp_InvoiceDate";
            this.dtp_InvoiceDate.Size = new System.Drawing.Size(202, 20);
            this.dtp_InvoiceDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 512;
            this.label3.Text = "Invoice Date";
            // 
            // txt_Invoice_No
            // 
            this.txt_Invoice_No.BackColor = System.Drawing.Color.White;
            this.txt_Invoice_No.Enabled = false;
            this.txt_Invoice_No.Location = new System.Drawing.Point(94, 19);
            this.txt_Invoice_No.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Invoice_No.Name = "txt_Invoice_No";
            this.txt_Invoice_No.ReadOnly = true;
            this.txt_Invoice_No.Size = new System.Drawing.Size(202, 20);
            this.txt_Invoice_No.TabIndex = 510;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 511;
            this.label2.Text = "Invoice No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 509;
            this.label1.Text = "Customer";
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
            this.cbx_Customer.Enabled = false;
            this.cbx_Customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Customer.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Customer.GridLineHorizontal = false;
            this.cbx_Customer.GridLineVertical = false;
            this.cbx_Customer.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Customer.Location = new System.Drawing.Point(383, 54);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(187, 22);
            this.cbx_Customer.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Enabled = false;
            this.txt_Name.Location = new System.Drawing.Point(383, 19);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(187, 20);
            this.txt_Name.TabIndex = 3;
            // 
            // lbl_CartonPrice
            // 
            this.lbl_CartonPrice.AutoSize = true;
            this.lbl_CartonPrice.Enabled = false;
            this.lbl_CartonPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartonPrice.Location = new System.Drawing.Point(337, 19);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(40, 20);
            this.lbl_CartonPrice.TabIndex = 507;
            this.lbl_CartonPrice.Text = "Name";
            // 
            // txt_Total
            // 
            this.txt_Total.BackColor = System.Drawing.Color.White;
            this.txt_Total.Location = new System.Drawing.Point(741, 589);
            this.txt_Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(249, 20);
            this.txt_Total.TabIndex = 557;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(684, 589);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 20);
            this.label11.TabIndex = 558;
            this.label11.Text = "Total";
            // 
            // btn_DeleteRow
            // 
            this.btn_DeleteRow.ForeColor = System.Drawing.Color.Maroon;
            this.btn_DeleteRow.Location = new System.Drawing.Point(38, 587);
            this.btn_DeleteRow.Name = "btn_DeleteRow";
            this.btn_DeleteRow.Size = new System.Drawing.Size(97, 23);
            this.btn_DeleteRow.TabIndex = 564;
            this.btn_DeleteRow.Text = "Delete Row";
            this.btn_DeleteRow.UseVisualStyleBackColor = true;
            this.btn_DeleteRow.Click += new System.EventHandler(this.btn_DeleteRow_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Time.Location = new System.Drawing.Point(34, 676);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(33, 20);
            this.lbl_Time.TabIndex = 577;
            this.lbl_Time.Text = "time";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbl_Date.Location = new System.Drawing.Point(34, 654);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(34, 20);
            this.lbl_Date.TabIndex = 576;
            this.lbl_Date.Text = "date";
            // 
            // dtp_InvoiceDetailDate
            // 
            this.dtp_InvoiceDetailDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDetailDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDetailDate.Location = new System.Drawing.Point(38, 699);
            this.dtp_InvoiceDetailDate.Name = "dtp_InvoiceDetailDate";
            this.dtp_InvoiceDetailDate.Size = new System.Drawing.Size(54, 20);
            this.dtp_InvoiceDetailDate.TabIndex = 575;
            this.dtp_InvoiceDetailDate.Visible = false;
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdo_Price2);
            this.groupBox1.Controls.Add(this.rdo_Price1);
            this.groupBox1.Location = new System.Drawing.Point(168, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 33);
            this.groupBox1.TabIndex = 533;
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
            this.rdo_CartonPricePerUnits.Location = new System.Drawing.Point(380, 83);
            this.rdo_CartonPricePerUnits.Name = "rdo_CartonPricePerUnits";
            this.rdo_CartonPricePerUnits.Size = new System.Drawing.Size(112, 17);
            this.rdo_CartonPricePerUnits.TabIndex = 534;
            this.rdo_CartonPricePerUnits.TabStop = true;
            this.rdo_CartonPricePerUnits.Text = "Carton Price/Units";
            this.rdo_CartonPricePerUnits.UseVisualStyleBackColor = true;
            this.rdo_CartonPricePerUnits.CheckedChanged += new System.EventHandler(this.rdo_isCarton_CheckedChanged);
            // 
            // FrmConsignmentReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 731);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.dtp_InvoiceDetailDate);
            this.Controls.Add(this.btn_DeleteRow);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbx_InvoiceInfo);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmConsignmentReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return";
            this.Load += new System.EventHandler(this.FrmConsignmentReturn_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ProductList)).EndInit();
            this.gbx_InvoiceInfo.ResumeLayout(false);
            this.gbx_InvoiceInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Rate;
        private System.Windows.Forms.RadioButton rdo_isUnit;
        private System.Windows.Forms.RadioButton rdo_isCarton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_ProductDescription;
        private MTGCComboBox cbx_Product;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ProductList;
        private System.Windows.Forms.GroupBox gbx_InvoiceInfo;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDueDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Invoice_No;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MTGCComboBox cbx_Customer;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_DeleteRow;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label lbl_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDetailDate;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdo_Price2;
        private System.Windows.Forms.RadioButton rdo_Price1;
        private System.Windows.Forms.RadioButton rdo_CartonPricePerUnits;
    }
}