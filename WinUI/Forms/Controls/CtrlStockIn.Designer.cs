namespace StockAndSale
{
    partial class CtrlStockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlStockIn));
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.dtp_InDateTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_RResult = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbx_Customer = new MTGCComboBox();
            this.btn_RSearch = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_RProductCode = new System.Windows.Forms.TextBox();
            this.dtp_ReturnDateTo = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_ReturnDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CustomerReturn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_EditArrival = new System.Windows.Forms.Button();
            this.btn_NewArrival = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RResult)).BeginInit();
            this.panel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1000, 730);
            this.panel4.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 65);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1000, 665);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(992, 639);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product Arrival";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 128);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(986, 508);
            this.panel5.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Result);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(986, 508);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dgv_Result
            // 
            this.dgv_Result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Result.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Result.Location = new System.Drawing.Point(3, 16);
            this.dgv_Result.Name = "dgv_Result";
            this.dgv_Result.Size = new System.Drawing.Size(980, 489);
            this.dgv_Result.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 125);
            this.panel3.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lbl_CartonPrice);
            this.groupBox1.Controls.Add(this.txt_ProductCode);
            this.groupBox1.Controls.Add(this.dtp_InDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(986, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 819;
            this.btn_Search.Location = new System.Drawing.Point(286, 67);
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
            this.btn_Search.TabIndex = 522;
            this.btn_Search.Text = "Search";
            this.btn_Search.Values.ExtraText = "";
            this.btn_Search.Values.Image = null;
            this.btn_Search.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Search.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Search.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Search.Values.Text = "Search";
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lbl_CartonPrice
            // 
            this.lbl_CartonPrice.AutoSize = true;
            this.lbl_CartonPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartonPrice.Location = new System.Drawing.Point(34, 73);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(84, 20);
            this.lbl_CartonPrice.TabIndex = 521;
            this.lbl_CartonPrice.Text = "Product Code";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Location = new System.Drawing.Point(124, 73);
            this.txt_ProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(121, 20);
            this.txt_ProductCode.TabIndex = 520;
            this.txt_ProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductCode_KeyDown);
            // 
            // dtp_InDateTo
            // 
            this.dtp_InDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InDateTo.Location = new System.Drawing.Point(286, 25);
            this.dtp_InDateTo.Name = "dtp_InDateTo";
            this.dtp_InDateTo.Size = new System.Drawing.Size(121, 20);
            this.dtp_InDateTo.TabIndex = 519;
            this.dtp_InDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InDateTo_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 518;
            this.label2.Text = "To";
            // 
            // dtp_InDateFrom
            // 
            this.dtp_InDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InDateFrom.Location = new System.Drawing.Point(124, 25);
            this.dtp_InDateFrom.Name = "dtp_InDateFrom";
            this.dtp_InDateFrom.Size = new System.Drawing.Size(121, 20);
            this.dtp_InDateFrom.TabIndex = 517;
            this.dtp_InDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InDateFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 516;
            this.label1.Text = "Arrival In_Date From";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(992, 639);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Customer Return";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 128);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(986, 508);
            this.panel7.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgv_RResult);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(986, 508);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            // 
            // dgv_RResult
            // 
            this.dgv_RResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_RResult.Location = new System.Drawing.Point(3, 16);
            this.dgv_RResult.Name = "dgv_RResult";
            this.dgv_RResult.Size = new System.Drawing.Size(980, 489);
            this.dgv_RResult.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Silver;
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(986, 125);
            this.panel6.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Print);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.cbx_Customer);
            this.groupBox3.Controls.Add(this.btn_RSearch);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_RProductCode);
            this.groupBox3.Controls.Add(this.dtp_ReturnDateTo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtp_ReturnDateFrom);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(986, 125);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtered Area";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 524;
            this.label7.Text = "Customer";
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
            this.cbx_Customer.Location = new System.Drawing.Point(123, 59);
            this.cbx_Customer.ManagingFastMouseMoving = true;
            this.cbx_Customer.ManagingFastMouseMovingInterval = 30;
            this.cbx_Customer.Name = "cbx_Customer";
            this.cbx_Customer.SelectedItem = null;
            this.cbx_Customer.SelectedValue = null;
            this.cbx_Customer.Size = new System.Drawing.Size(202, 22);
            this.cbx_Customer.TabIndex = 523;
            // 
            // btn_RSearch
            // 
            this.btn_RSearch.DirtyPaletteCounter = 821;
            this.btn_RSearch.Location = new System.Drawing.Point(547, 79);
            this.btn_RSearch.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_RSearch.Name = "btn_RSearch";
            this.btn_RSearch.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_RSearch.Size = new System.Drawing.Size(121, 32);
            this.btn_RSearch.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_RSearch.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RSearch.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_RSearch.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_RSearch.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RSearch.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_RSearch.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_RSearch.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_RSearch.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_RSearch.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_RSearch.TabIndex = 522;
            this.btn_RSearch.Text = "Search";
            this.btn_RSearch.Values.ExtraText = "";
            this.btn_RSearch.Values.Image = null;
            this.btn_RSearch.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_RSearch.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_RSearch.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_RSearch.Values.Text = "Search";
            this.btn_RSearch.Click += new System.EventHandler(this.btn_RSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 521;
            this.label4.Text = "Product Code";
            // 
            // txt_RProductCode
            // 
            this.txt_RProductCode.Location = new System.Drawing.Point(124, 95);
            this.txt_RProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_RProductCode.Name = "txt_RProductCode";
            this.txt_RProductCode.Size = new System.Drawing.Size(121, 20);
            this.txt_RProductCode.TabIndex = 520;
            // 
            // dtp_ReturnDateTo
            // 
            this.dtp_ReturnDateTo.CustomFormat = "dd/MMM/yyyy";
            this.dtp_ReturnDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReturnDateTo.Location = new System.Drawing.Point(286, 25);
            this.dtp_ReturnDateTo.Name = "dtp_ReturnDateTo";
            this.dtp_ReturnDateTo.Size = new System.Drawing.Size(121, 20);
            this.dtp_ReturnDateTo.TabIndex = 519;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 518;
            this.label5.Text = "To";
            // 
            // dtp_ReturnDateFrom
            // 
            this.dtp_ReturnDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_ReturnDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ReturnDateFrom.Location = new System.Drawing.Point(124, 25);
            this.dtp_ReturnDateFrom.Name = "dtp_ReturnDateFrom";
            this.dtp_ReturnDateFrom.Size = new System.Drawing.Size(121, 20);
            this.dtp_ReturnDateFrom.TabIndex = 517;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 516;
            this.label6.Text = "Return_Date From";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.btn_CustomerReturn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_EditArrival);
            this.panel1.Controls.Add(this.btn_NewArrival);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 65);
            this.panel1.TabIndex = 2;
            // 
            // btn_CustomerReturn
            // 
            this.btn_CustomerReturn.Location = new System.Drawing.Point(244, 9);
            this.btn_CustomerReturn.Name = "btn_CustomerReturn";
            this.btn_CustomerReturn.Size = new System.Drawing.Size(94, 40);
            this.btn_CustomerReturn.TabIndex = 527;
            this.btn_CustomerReturn.Text = "Customer Return";
            this.btn_CustomerReturn.UseVisualStyleBackColor = true;
            this.btn_CustomerReturn.Click += new System.EventHandler(this.btn_CustomerReturn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(522, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 526;
            this.label3.Text = "Stock In";
            // 
            // btn_EditArrival
            // 
            this.btn_EditArrival.Enabled = false;
            this.btn_EditArrival.Location = new System.Drawing.Point(133, 9);
            this.btn_EditArrival.Name = "btn_EditArrival";
            this.btn_EditArrival.Size = new System.Drawing.Size(89, 40);
            this.btn_EditArrival.TabIndex = 3;
            this.btn_EditArrival.Text = "Edit Arrival";
            this.btn_EditArrival.UseVisualStyleBackColor = true;
            this.btn_EditArrival.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NewArrival
            // 
            this.btn_NewArrival.Enabled = false;
            this.btn_NewArrival.Location = new System.Drawing.Point(19, 9);
            this.btn_NewArrival.Name = "btn_NewArrival";
            this.btn_NewArrival.Size = new System.Drawing.Size(94, 40);
            this.btn_NewArrival.TabIndex = 2;
            this.btn_NewArrival.Text = "New Arrival";
            this.btn_NewArrival.UseVisualStyleBackColor = true;
            this.btn_NewArrival.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 730);
            this.panel2.TabIndex = 3;
            // 
            // btn_Print
            // 
            this.btn_Print.DirtyPaletteCounter = 795;
            this.btn_Print.Location = new System.Drawing.Point(888, 79);
            this.btn_Print.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Print.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Print.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Print.Size = new System.Drawing.Size(78, 32);
            this.btn_Print.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Print.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Print.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Print.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Print.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Print.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Print.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Print.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Print.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Print.TabIndex = 529;
            this.btn_Print.Text = "Print";
            this.btn_Print.Values.ExtraText = "";
            this.btn_Print.Values.Image = null;
            this.btn_Print.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Print.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Print.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // CtrlStockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel2);
            this.Name = "CtrlStockIn";
            this.Size = new System.Drawing.Size(1000, 730);
            this.Load += new System.EventHandler(this.CtrlStockIn_Load);
            this.panel4.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RResult)).EndInit();
            this.panel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_RSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_NewArrival;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_InDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InDateFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_EditArrival;
        private System.Windows.Forms.Button btn_CustomerReturn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgv_RResult;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_RSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_RProductCode;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDateTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_ReturnDateFrom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MTGCComboBox cbx_Customer;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
    }
}
