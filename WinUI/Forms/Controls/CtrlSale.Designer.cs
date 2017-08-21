namespace StockAndSale
{
    partial class CtrlSale
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlSale));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl_Result = new System.Windows.Forms.TabControl();
            this.tp_CashDown = new System.Windows.Forms.TabPage();
            this.dgv_CashDown = new System.Windows.Forms.DataGridView();
            this.tp_Credit = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgv_Credit = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_DueDateCredit = new System.Windows.Forms.Label();
            this.dtp_InvoiceDueDateCredit = new System.Windows.Forms.DateTimePicker();
            this.tp_Consign = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgv_Consign = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_DueDateConsignment = new System.Windows.Forms.Label();
            this.dtp_InvoiceDueDateConsignment = new System.Windows.Forms.DateTimePicker();
            this.tp_CancelInvoice = new System.Windows.Forms.TabPage();
            this.dgv_CancelInvoice = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chb_SampleInvoiceOnly = new System.Windows.Forms.CheckBox();
            this.chb_PromotionInvoiceOnly = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_Cashier = new MTGCComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.chb_NotPaidAndOverDueDate = new System.Windows.Forms.CheckBox();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.cbx_Customer = new MTGCComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CancelInvoice = new System.Windows.Forms.Button();
            this.btn_PreviewInvoice = new System.Windows.Forms.Button();
            this.btn_NewConsign = new System.Windows.Forms.Button();
            this.btn_NewCredit = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_NewCash = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_PONo = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl_Result.SuspendLayout();
            this.tp_CashDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDown)).BeginInit();
            this.tp_Credit.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credit)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tp_Consign.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consign)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tp_CancelInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CancelInvoice)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 671);
            this.panel2.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 130);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 541);
            this.panel4.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl_Result);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 541);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // tabControl_Result
            // 
            this.tabControl_Result.Controls.Add(this.tp_CashDown);
            this.tabControl_Result.Controls.Add(this.tp_Credit);
            this.tabControl_Result.Controls.Add(this.tp_Consign);
            this.tabControl_Result.Controls.Add(this.tp_CancelInvoice);
            this.tabControl_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Result.Location = new System.Drawing.Point(3, 16);
            this.tabControl_Result.Name = "tabControl_Result";
            this.tabControl_Result.SelectedIndex = 0;
            this.tabControl_Result.Size = new System.Drawing.Size(994, 522);
            this.tabControl_Result.TabIndex = 0;
            this.tabControl_Result.SelectedIndexChanged += new System.EventHandler(this.tabControl_Result_SelectedIndexChanged);
            // 
            // tp_CashDown
            // 
            this.tp_CashDown.Controls.Add(this.dgv_CashDown);
            this.tp_CashDown.Location = new System.Drawing.Point(4, 22);
            this.tp_CashDown.Name = "tp_CashDown";
            this.tp_CashDown.Padding = new System.Windows.Forms.Padding(3);
            this.tp_CashDown.Size = new System.Drawing.Size(986, 496);
            this.tp_CashDown.TabIndex = 0;
            this.tp_CashDown.Text = "Cash Down";
            this.tp_CashDown.UseVisualStyleBackColor = true;
            // 
            // dgv_CashDown
            // 
            this.dgv_CashDown.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CashDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CashDown.Location = new System.Drawing.Point(3, 3);
            this.dgv_CashDown.Name = "dgv_CashDown";
            this.dgv_CashDown.ReadOnly = true;
            this.dgv_CashDown.Size = new System.Drawing.Size(980, 490);
            this.dgv_CashDown.TabIndex = 0;
            // 
            // tp_Credit
            // 
            this.tp_Credit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tp_Credit.Controls.Add(this.groupBox6);
            this.tp_Credit.Controls.Add(this.groupBox3);
            this.tp_Credit.Location = new System.Drawing.Point(4, 22);
            this.tp_Credit.Name = "tp_Credit";
            this.tp_Credit.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Credit.Size = new System.Drawing.Size(986, 496);
            this.tp_Credit.TabIndex = 1;
            this.tp_Credit.Text = "    Credit     ";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgv_Credit);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(3, 43);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(980, 450);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            // 
            // dgv_Credit
            // 
            this.dgv_Credit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Credit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Credit.Location = new System.Drawing.Point(3, 16);
            this.dgv_Credit.Name = "dgv_Credit";
            this.dgv_Credit.ReadOnly = true;
            this.dgv_Credit.Size = new System.Drawing.Size(974, 431);
            this.dgv_Credit.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbl_DueDateCredit);
            this.groupBox3.Controls.Add(this.dtp_InvoiceDueDateCredit);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(980, 40);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // lbl_DueDateCredit
            // 
            this.lbl_DueDateCredit.AutoSize = true;
            this.lbl_DueDateCredit.Location = new System.Drawing.Point(15, 18);
            this.lbl_DueDateCredit.Name = "lbl_DueDateCredit";
            this.lbl_DueDateCredit.Size = new System.Drawing.Size(53, 13);
            this.lbl_DueDateCredit.TabIndex = 2;
            this.lbl_DueDateCredit.Text = "Due Date";
            // 
            // dtp_InvoiceDueDateCredit
            // 
            this.dtp_InvoiceDueDateCredit.CustomFormat = "dd/MM/yyyy";
            this.dtp_InvoiceDueDateCredit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDueDateCredit.Location = new System.Drawing.Point(74, 14);
            this.dtp_InvoiceDueDateCredit.Name = "dtp_InvoiceDueDateCredit";
            this.dtp_InvoiceDueDateCredit.ShowCheckBox = true;
            this.dtp_InvoiceDueDateCredit.Size = new System.Drawing.Size(109, 20);
            this.dtp_InvoiceDueDateCredit.TabIndex = 1;
            this.dtp_InvoiceDueDateCredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDueDateCredit_KeyDown);
            // 
            // tp_Consign
            // 
            this.tp_Consign.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tp_Consign.Controls.Add(this.groupBox5);
            this.tp_Consign.Controls.Add(this.groupBox4);
            this.tp_Consign.Location = new System.Drawing.Point(4, 22);
            this.tp_Consign.Name = "tp_Consign";
            this.tp_Consign.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Consign.Size = new System.Drawing.Size(986, 496);
            this.tp_Consign.TabIndex = 2;
            this.tp_Consign.Text = "    Consign    ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dgv_Consign);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 43);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(980, 450);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // dgv_Consign
            // 
            this.dgv_Consign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Consign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Consign.Location = new System.Drawing.Point(3, 16);
            this.dgv_Consign.Name = "dgv_Consign";
            this.dgv_Consign.ReadOnly = true;
            this.dgv_Consign.Size = new System.Drawing.Size(974, 431);
            this.dgv_Consign.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_DueDateConsignment);
            this.groupBox4.Controls.Add(this.dtp_InvoiceDueDateConsignment);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(980, 40);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // lbl_DueDateConsignment
            // 
            this.lbl_DueDateConsignment.AutoSize = true;
            this.lbl_DueDateConsignment.Location = new System.Drawing.Point(14, 18);
            this.lbl_DueDateConsignment.Name = "lbl_DueDateConsignment";
            this.lbl_DueDateConsignment.Size = new System.Drawing.Size(53, 13);
            this.lbl_DueDateConsignment.TabIndex = 4;
            this.lbl_DueDateConsignment.Text = "Due Date";
            // 
            // dtp_InvoiceDueDateConsignment
            // 
            this.dtp_InvoiceDueDateConsignment.CustomFormat = "dd/MM/yyyy";
            this.dtp_InvoiceDueDateConsignment.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDueDateConsignment.Location = new System.Drawing.Point(73, 14);
            this.dtp_InvoiceDueDateConsignment.Name = "dtp_InvoiceDueDateConsignment";
            this.dtp_InvoiceDueDateConsignment.ShowCheckBox = true;
            this.dtp_InvoiceDueDateConsignment.Size = new System.Drawing.Size(109, 20);
            this.dtp_InvoiceDueDateConsignment.TabIndex = 3;
            this.dtp_InvoiceDueDateConsignment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDueDateConsignment_KeyDown);
            // 
            // tp_CancelInvoice
            // 
            this.tp_CancelInvoice.Controls.Add(this.dgv_CancelInvoice);
            this.tp_CancelInvoice.Location = new System.Drawing.Point(4, 22);
            this.tp_CancelInvoice.Name = "tp_CancelInvoice";
            this.tp_CancelInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tp_CancelInvoice.Size = new System.Drawing.Size(986, 496);
            this.tp_CancelInvoice.TabIndex = 3;
            this.tp_CancelInvoice.Text = "Cancel Invoice";
            this.tp_CancelInvoice.UseVisualStyleBackColor = true;
            // 
            // dgv_CancelInvoice
            // 
            this.dgv_CancelInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CancelInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_CancelInvoice.Location = new System.Drawing.Point(3, 3);
            this.dgv_CancelInvoice.Name = "dgv_CancelInvoice";
            this.dgv_CancelInvoice.Size = new System.Drawing.Size(980, 490);
            this.dgv_CancelInvoice.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 130);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_PONo);
            this.groupBox1.Controls.Add(this.chb_SampleInvoiceOnly);
            this.groupBox1.Controls.Add(this.chb_PromotionInvoiceOnly);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbx_Cashier);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chb_NotPaidAndOverDueDate);
            this.groupBox1.Controls.Add(this.lbl_CartonPrice);
            this.groupBox1.Controls.Add(this.txt_InvoiceNo);
            this.groupBox1.Controls.Add(this.cbx_Customer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // chb_SampleInvoiceOnly
            // 
            this.chb_SampleInvoiceOnly.AutoSize = true;
            this.chb_SampleInvoiceOnly.Location = new System.Drawing.Point(644, 97);
            this.chb_SampleInvoiceOnly.Name = "chb_SampleInvoiceOnly";
            this.chb_SampleInvoiceOnly.Size = new System.Drawing.Size(123, 17);
            this.chb_SampleInvoiceOnly.TabIndex = 521;
            this.chb_SampleInvoiceOnly.Text = "Sample Invoice Only";
            this.chb_SampleInvoiceOnly.UseVisualStyleBackColor = true;
            // 
            // chb_PromotionInvoiceOnly
            // 
            this.chb_PromotionInvoiceOnly.AutoSize = true;
            this.chb_PromotionInvoiceOnly.Location = new System.Drawing.Point(415, 97);
            this.chb_PromotionInvoiceOnly.Name = "chb_PromotionInvoiceOnly";
            this.chb_PromotionInvoiceOnly.Size = new System.Drawing.Size(135, 17);
            this.chb_PromotionInvoiceOnly.TabIndex = 520;
            this.chb_PromotionInvoiceOnly.Text = "Promotion Invoice Only";
            this.chb_PromotionInvoiceOnly.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 519;
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
            this.cbx_Cashier.Location = new System.Drawing.Point(415, 60);
            this.cbx_Cashier.ManagingFastMouseMoving = true;
            this.cbx_Cashier.ManagingFastMouseMovingInterval = 30;
            this.cbx_Cashier.Name = "cbx_Cashier";
            this.cbx_Cashier.SelectedItem = null;
            this.cbx_Cashier.SelectedValue = null;
            this.cbx_Cashier.Size = new System.Drawing.Size(187, 22);
            this.cbx_Cashier.TabIndex = 518;
            this.cbx_Cashier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Cashier_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 517;
            this.label3.Text = "Customer";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 821;
            this.btn_Search.Location = new System.Drawing.Point(816, 87);
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
            this.btn_Search.TabIndex = 516;
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
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(577, 24);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(121, 20);
            this.dtp_InvoiceDateTo.TabIndex = 515;
            this.dtp_InvoiceDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateTo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 514;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(415, 24);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(121, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 513;
            this.dtp_InvoiceDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 512;
            this.label1.Text = "Invoice Date From";
            // 
            // chb_NotPaidAndOverDueDate
            // 
            this.chb_NotPaidAndOverDueDate.AutoSize = true;
            this.chb_NotPaidAndOverDueDate.Location = new System.Drawing.Point(97, 97);
            this.chb_NotPaidAndOverDueDate.Name = "chb_NotPaidAndOverDueDate";
            this.chb_NotPaidAndOverDueDate.Size = new System.Drawing.Size(163, 17);
            this.chb_NotPaidAndOverDueDate.TabIndex = 510;
            this.chb_NotPaidAndOverDueDate.Text = "Not Paid and Over Due Date";
            this.chb_NotPaidAndOverDueDate.UseVisualStyleBackColor = true;
            this.chb_NotPaidAndOverDueDate.CheckedChanged += new System.EventHandler(this.chb_NotPaidAndOverDueDate_CheckedChanged);
            this.chb_NotPaidAndOverDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chb_NotPaidAndOverDueDate_KeyDown);
            // 
            // lbl_CartonPrice
            // 
            this.lbl_CartonPrice.AutoSize = true;
            this.lbl_CartonPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartonPrice.Location = new System.Drawing.Point(8, 28);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(67, 20);
            this.lbl_CartonPrice.TabIndex = 509;
            this.lbl_CartonPrice.Text = "Invoice No";
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.Location = new System.Drawing.Point(97, 25);
            this.txt_InvoiceNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.Size = new System.Drawing.Size(187, 20);
            this.txt_InvoiceNo.TabIndex = 506;
            this.txt_InvoiceNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_InvoiceNo_KeyDown);
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
            this.cbx_Customer.Location = new System.Drawing.Point(97, 58);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(187, 22);
            this.cbx_Customer.TabIndex = 507;
            this.cbx_Customer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Customer_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_CancelInvoice);
            this.panel1.Controls.Add(this.btn_PreviewInvoice);
            this.panel1.Controls.Add(this.btn_NewConsign);
            this.panel1.Controls.Add(this.btn_NewCredit);
            this.panel1.Controls.Add(this.btn_Edit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_NewCash);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 59);
            this.panel1.TabIndex = 4;
            // 
            // btn_CancelInvoice
            // 
            this.btn_CancelInvoice.Location = new System.Drawing.Point(895, 10);
            this.btn_CancelInvoice.Name = "btn_CancelInvoice";
            this.btn_CancelInvoice.Size = new System.Drawing.Size(95, 37);
            this.btn_CancelInvoice.TabIndex = 533;
            this.btn_CancelInvoice.Text = "Cancel Invoice";
            this.btn_CancelInvoice.UseVisualStyleBackColor = true;
            this.btn_CancelInvoice.Click += new System.EventHandler(this.btn_CancelInvoice_Click);
            // 
            // btn_PreviewInvoice
            // 
            this.btn_PreviewInvoice.Location = new System.Drawing.Point(667, 10);
            this.btn_PreviewInvoice.Name = "btn_PreviewInvoice";
            this.btn_PreviewInvoice.Size = new System.Drawing.Size(101, 37);
            this.btn_PreviewInvoice.TabIndex = 532;
            this.btn_PreviewInvoice.Text = "Preview Invoice";
            this.btn_PreviewInvoice.UseVisualStyleBackColor = true;
            this.btn_PreviewInvoice.Click += new System.EventHandler(this.btn_PreviewInvoice_Click);
            // 
            // btn_NewConsign
            // 
            this.btn_NewConsign.Enabled = false;
            this.btn_NewConsign.Location = new System.Drawing.Point(267, 10);
            this.btn_NewConsign.Name = "btn_NewConsign";
            this.btn_NewConsign.Size = new System.Drawing.Size(117, 37);
            this.btn_NewConsign.TabIndex = 531;
            this.btn_NewConsign.Text = "New Consign Invoice";
            this.btn_NewConsign.UseVisualStyleBackColor = true;
            this.btn_NewConsign.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_NewCredit
            // 
            this.btn_NewCredit.Enabled = false;
            this.btn_NewCredit.Location = new System.Drawing.Point(138, 10);
            this.btn_NewCredit.Name = "btn_NewCredit";
            this.btn_NewCredit.Size = new System.Drawing.Size(106, 37);
            this.btn_NewCredit.TabIndex = 530;
            this.btn_NewCredit.Text = "New Credit Invoice";
            this.btn_NewCredit.UseVisualStyleBackColor = true;
            this.btn_NewCredit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Location = new System.Drawing.Point(789, 10);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(85, 37);
            this.btn_Edit.TabIndex = 529;
            this.btn_Edit.Text = "Edit Invoice";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(463, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 526;
            this.label4.Text = "Sale";
            // 
            // btn_NewCash
            // 
            this.btn_NewCash.Enabled = false;
            this.btn_NewCash.Location = new System.Drawing.Point(12, 10);
            this.btn_NewCash.Name = "btn_NewCash";
            this.btn_NewCash.Size = new System.Drawing.Size(103, 37);
            this.btn_NewCash.TabIndex = 0;
            this.btn_NewCash.Text = "New Cash Invoice";
            this.btn_NewCash.UseVisualStyleBackColor = true;
            this.btn_NewCash.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(766, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 523;
            this.label6.Text = "PO No";
            // 
            // txt_PONo
            // 
            this.txt_PONo.Location = new System.Drawing.Point(816, 24);
            this.txt_PONo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PONo.Name = "txt_PONo";
            this.txt_PONo.Size = new System.Drawing.Size(158, 20);
            this.txt_PONo.TabIndex = 522;
            // 
            // CtrlSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CtrlSale";
            this.Size = new System.Drawing.Size(1000, 730);
            this.Load += new System.EventHandler(this.CtrlSale_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl_Result.ResumeLayout(false);
            this.tp_CashDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CashDown)).EndInit();
            this.tp_Credit.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Credit)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tp_Consign.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Consign)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tp_CancelInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CancelInvoice)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_NewCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl_Result;
        private System.Windows.Forms.TabPage tp_CashDown;
        private System.Windows.Forms.TabPage tp_Credit;
        private System.Windows.Forms.TabPage tp_Consign;
        private System.Windows.Forms.DataGridView dgv_CashDown;
        private System.Windows.Forms.DataGridView dgv_Credit;
        private System.Windows.Forms.DataGridView dgv_Consign;
        private System.Windows.Forms.CheckBox chb_NotPaidAndOverDueDate;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_InvoiceNo;
        private MTGCComboBox cbx_Customer;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_NewCredit;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_NewConsign;
        private System.Windows.Forms.Button btn_PreviewInvoice;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDueDateCredit;
        private System.Windows.Forms.Label lbl_DueDateCredit;
        private System.Windows.Forms.Label lbl_DueDateConsignment;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDueDateConsignment;
        private System.Windows.Forms.Label label5;
        private MTGCComboBox cbx_Cashier;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_CancelInvoice;
        private System.Windows.Forms.TabPage tp_CancelInvoice;
        private System.Windows.Forms.DataGridView dgv_CancelInvoice;
        private System.Windows.Forms.CheckBox chb_PromotionInvoiceOnly;
        private System.Windows.Forms.CheckBox chb_SampleInvoiceOnly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_PONo;

    }
}
