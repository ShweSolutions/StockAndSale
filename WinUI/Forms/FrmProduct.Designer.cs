namespace StockAndSale
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.gbx_ProductInfo = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ReorderCtn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MinLvl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CartonPrice2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UnitPrice2 = new System.Windows.Forms.TextBox();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_CartonPrice = new System.Windows.Forms.TextBox();
            this.lbl_UnitPrice = new System.Windows.Forms.Label();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.cbx_Catagory = new MTGCComboBox();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.lbl_NoOfUnits = new System.Windows.Forms.Label();
            this.txt_NoOfUnits = new System.Windows.Forms.TextBox();
            this.lbl_Weight = new System.Windows.Forms.Label();
            this.txt_Weight = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Code = new System.Windows.Forms.Label();
            this.txt_Code = new System.Windows.Forms.TextBox();
            this.dgv_Product = new System.Windows.Forms.DataGridView();
            this.gbx_ProductList = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbx_Filter = new System.Windows.Forms.GroupBox();
            this.lbl_FilteredCode = new System.Windows.Forms.Label();
            this.txt_FilteredCode = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txt_SrNo = new System.Windows.Forms.TextBox();
            this.gbx_ProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).BeginInit();
            this.gbx_ProductList.SuspendLayout();
            this.gbx_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_ProductInfo
            // 
            this.gbx_ProductInfo.Controls.Add(this.label5);
            this.gbx_ProductInfo.Controls.Add(this.txt_SrNo);
            this.gbx_ProductInfo.Controls.Add(this.label3);
            this.gbx_ProductInfo.Controls.Add(this.txt_ReorderCtn);
            this.gbx_ProductInfo.Controls.Add(this.label4);
            this.gbx_ProductInfo.Controls.Add(this.txt_MinLvl);
            this.gbx_ProductInfo.Controls.Add(this.label1);
            this.gbx_ProductInfo.Controls.Add(this.txt_CartonPrice2);
            this.gbx_ProductInfo.Controls.Add(this.label2);
            this.gbx_ProductInfo.Controls.Add(this.txt_UnitPrice2);
            this.gbx_ProductInfo.Controls.Add(this.lbl_CartonPrice);
            this.gbx_ProductInfo.Controls.Add(this.txt_CartonPrice);
            this.gbx_ProductInfo.Controls.Add(this.lbl_UnitPrice);
            this.gbx_ProductInfo.Controls.Add(this.txt_UnitPrice);
            this.gbx_ProductInfo.Controls.Add(this.cbx_Catagory);
            this.gbx_ProductInfo.Controls.Add(this.lbl_Catagory);
            this.gbx_ProductInfo.Controls.Add(this.lbl_NoOfUnits);
            this.gbx_ProductInfo.Controls.Add(this.txt_NoOfUnits);
            this.gbx_ProductInfo.Controls.Add(this.lbl_Weight);
            this.gbx_ProductInfo.Controls.Add(this.txt_Weight);
            this.gbx_ProductInfo.Controls.Add(this.lbl_Description);
            this.gbx_ProductInfo.Controls.Add(this.txt_Description);
            this.gbx_ProductInfo.Controls.Add(this.btn_Reset);
            this.gbx_ProductInfo.Controls.Add(this.btn_Save);
            this.gbx_ProductInfo.Controls.Add(this.lbl_Code);
            this.gbx_ProductInfo.Controls.Add(this.txt_Code);
            this.gbx_ProductInfo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ProductInfo.Location = new System.Drawing.Point(12, 89);
            this.gbx_ProductInfo.Name = "gbx_ProductInfo";
            this.gbx_ProductInfo.Size = new System.Drawing.Size(301, 617);
            this.gbx_ProductInfo.TabIndex = 549;
            this.gbx_ProductInfo.TabStop = false;
            this.gbx_ProductInfo.Text = "Product SetUp Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 456);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 513;
            this.label3.Text = "Reorder Cartons";
            // 
            // txt_ReorderCtn
            // 
            this.txt_ReorderCtn.Location = new System.Drawing.Point(128, 453);
            this.txt_ReorderCtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ReorderCtn.Name = "txt_ReorderCtn";
            this.txt_ReorderCtn.Size = new System.Drawing.Size(160, 27);
            this.txt_ReorderCtn.TabIndex = 512;
            this.txt_ReorderCtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ReorderCtn_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 511;
            this.label4.Text = "Min. Stock Lvl. (units)";
            // 
            // txt_MinLvl
            // 
            this.txt_MinLvl.Location = new System.Drawing.Point(128, 409);
            this.txt_MinLvl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MinLvl.Name = "txt_MinLvl";
            this.txt_MinLvl.Size = new System.Drawing.Size(160, 27);
            this.txt_MinLvl.TabIndex = 510;
            this.txt_MinLvl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MinLvl_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 509;
            this.label1.Text = "Carton Price (2)";
            // 
            // txt_CartonPrice2
            // 
            this.txt_CartonPrice2.Location = new System.Drawing.Point(128, 365);
            this.txt_CartonPrice2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CartonPrice2.Name = "txt_CartonPrice2";
            this.txt_CartonPrice2.Size = new System.Drawing.Size(160, 27);
            this.txt_CartonPrice2.TabIndex = 507;
            this.txt_CartonPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CartonPrice2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 323);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 508;
            this.label2.Text = "Unit Price (2)";
            // 
            // txt_UnitPrice2
            // 
            this.txt_UnitPrice2.Location = new System.Drawing.Point(128, 320);
            this.txt_UnitPrice2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_UnitPrice2.Name = "txt_UnitPrice2";
            this.txt_UnitPrice2.Size = new System.Drawing.Size(160, 27);
            this.txt_UnitPrice2.TabIndex = 506;
            this.txt_UnitPrice2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitPrice2_KeyPress);
            // 
            // lbl_CartonPrice
            // 
            this.lbl_CartonPrice.AutoSize = true;
            this.lbl_CartonPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CartonPrice.Location = new System.Drawing.Point(26, 279);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(96, 20);
            this.lbl_CartonPrice.TabIndex = 505;
            this.lbl_CartonPrice.Text = "Carton Price (1)";
            // 
            // txt_CartonPrice
            // 
            this.txt_CartonPrice.Location = new System.Drawing.Point(128, 276);
            this.txt_CartonPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CartonPrice.Name = "txt_CartonPrice";
            this.txt_CartonPrice.Size = new System.Drawing.Size(160, 27);
            this.txt_CartonPrice.TabIndex = 6;
            this.txt_CartonPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CartonPrice_KeyPress);
            // 
            // lbl_UnitPrice
            // 
            this.lbl_UnitPrice.AutoSize = true;
            this.lbl_UnitPrice.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UnitPrice.Location = new System.Drawing.Point(40, 236);
            this.lbl_UnitPrice.Name = "lbl_UnitPrice";
            this.lbl_UnitPrice.Size = new System.Drawing.Size(82, 20);
            this.lbl_UnitPrice.TabIndex = 503;
            this.lbl_UnitPrice.Text = "Unit Price (1)";
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(128, 233);
            this.txt_UnitPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(160, 27);
            this.txt_UnitPrice.TabIndex = 5;
            this.txt_UnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_UnitPrice_KeyPress);
            // 
            // cbx_Catagory
            // 
            this.cbx_Catagory.ArrowBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(239)))), ((int)(((byte)(107)))));
            this.cbx_Catagory.ArrowColor = System.Drawing.Color.Black;
            this.cbx_Catagory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(255)))), ((int)(((byte)(208)))));
            this.cbx_Catagory.BindedControl = ((MTGCComboBox.ControlloAssociato)(resources.GetObject("cbx_Catagory.BindedControl")));
            this.cbx_Catagory.BorderStyle = MTGCComboBox.TipiBordi.Fixed3D;
            this.cbx_Catagory.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.cbx_Catagory.ColumnNum = 1;
            this.cbx_Catagory.ColumnWidth = "121";
            this.cbx_Catagory.DisabledArrowBoxColor = System.Drawing.SystemColors.Control;
            this.cbx_Catagory.DisabledArrowColor = System.Drawing.Color.LightGray;
            this.cbx_Catagory.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.cbx_Catagory.DisabledBorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbx_Catagory.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.cbx_Catagory.DisplayMember = "Text";
            this.cbx_Catagory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbx_Catagory.DropDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
            this.cbx_Catagory.DropDownForeColor = System.Drawing.Color.Black;
            this.cbx_Catagory.DropDownStyle = MTGCComboBox.CustomDropDownStyle.DropDown;
            this.cbx_Catagory.DropDownWidth = 140;
            this.cbx_Catagory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Catagory.GridLineColor = System.Drawing.Color.LightGray;
            this.cbx_Catagory.GridLineHorizontal = false;
            this.cbx_Catagory.GridLineVertical = false;
            this.cbx_Catagory.LoadingType = MTGCComboBox.CaricamentoCombo.ComboBoxItem;
            this.cbx_Catagory.Location = new System.Drawing.Point(128, 498);
            this.cbx_Catagory.ManagingFastMouseMoving = true;
            this.cbx_Catagory.ManagingFastMouseMovingInterval = 30;
            this.cbx_Catagory.Name = "cbx_Catagory";
            this.cbx_Catagory.SelectedItem = null;
            this.cbx_Catagory.SelectedValue = null;
            this.cbx_Catagory.Size = new System.Drawing.Size(160, 22);
            this.cbx_Catagory.TabIndex = 7;
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Location = new System.Drawing.Point(60, 500);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(58, 20);
            this.lbl_Catagory.TabIndex = 500;
            this.lbl_Catagory.Text = "Category";
            // 
            // lbl_NoOfUnits
            // 
            this.lbl_NoOfUnits.AutoSize = true;
            this.lbl_NoOfUnits.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoOfUnits.Location = new System.Drawing.Point(49, 191);
            this.lbl_NoOfUnits.Name = "lbl_NoOfUnits";
            this.lbl_NoOfUnits.Size = new System.Drawing.Size(72, 20);
            this.lbl_NoOfUnits.TabIndex = 499;
            this.lbl_NoOfUnits.Text = "No Of Units";
            // 
            // txt_NoOfUnits
            // 
            this.txt_NoOfUnits.Location = new System.Drawing.Point(128, 188);
            this.txt_NoOfUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NoOfUnits.Name = "txt_NoOfUnits";
            this.txt_NoOfUnits.Size = new System.Drawing.Size(160, 27);
            this.txt_NoOfUnits.TabIndex = 4;
            this.txt_NoOfUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoOfUnits_KeyPress);
            // 
            // lbl_Weight
            // 
            this.lbl_Weight.AutoSize = true;
            this.lbl_Weight.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Weight.Location = new System.Drawing.Point(52, 148);
            this.lbl_Weight.Name = "lbl_Weight";
            this.lbl_Weight.Size = new System.Drawing.Size(70, 20);
            this.lbl_Weight.TabIndex = 497;
            this.lbl_Weight.Text = "Weight (g)";
            // 
            // txt_Weight
            // 
            this.txt_Weight.Location = new System.Drawing.Point(128, 145);
            this.txt_Weight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Weight.Name = "txt_Weight";
            this.txt_Weight.Size = new System.Drawing.Size(160, 27);
            this.txt_Weight.TabIndex = 3;
            this.txt_Weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Weight_KeyPress);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(49, 79);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(69, 20);
            this.lbl_Description.TabIndex = 495;
            this.lbl_Description.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.Location = new System.Drawing.Point(128, 79);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(160, 49);
            this.txt_Description.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.DirtyPaletteCounter = 789;
            this.btn_Reset.Location = new System.Drawing.Point(210, 577);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Reset.Size = new System.Drawing.Size(78, 32);
            this.btn_Reset.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Reset.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Reset.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Reset.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Reset.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Reset.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Reset.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Reset.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.Values.ExtraText = "";
            this.btn_Reset.Values.Image = null;
            this.btn_Reset.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Reset.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Reset.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Reset.Values.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.DirtyPaletteCounter = 789;
            this.btn_Save.Location = new System.Drawing.Point(101, 577);
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
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.Values.ExtraText = "";
            this.btn_Save.Values.Image = null;
            this.btn_Save.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Save.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Save.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Code
            // 
            this.lbl_Code.AutoSize = true;
            this.lbl_Code.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Code.Location = new System.Drawing.Point(81, 38);
            this.lbl_Code.Name = "lbl_Code";
            this.lbl_Code.Size = new System.Drawing.Size(37, 20);
            this.lbl_Code.TabIndex = 493;
            this.lbl_Code.Text = "Code";
            // 
            // txt_Code
            // 
            this.txt_Code.Location = new System.Drawing.Point(128, 35);
            this.txt_Code.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Code.Name = "txt_Code";
            this.txt_Code.Size = new System.Drawing.Size(160, 27);
            this.txt_Code.TabIndex = 1;
            // 
            // dgv_Product
            // 
            this.dgv_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Product.Location = new System.Drawing.Point(3, 16);
            this.dgv_Product.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Product.Name = "dgv_Product";
            this.dgv_Product.ReadOnly = true;
            this.dgv_Product.Size = new System.Drawing.Size(685, 601);
            this.dgv_Product.TabIndex = 4;
            this.dgv_Product.DoubleClick += new System.EventHandler(this.dgv_Product_DoubleClick);
            // 
            // gbx_ProductList
            // 
            this.gbx_ProductList.Controls.Add(this.dgv_Product);
            this.gbx_ProductList.Location = new System.Drawing.Point(319, 89);
            this.gbx_ProductList.Name = "gbx_ProductList";
            this.gbx_ProductList.Size = new System.Drawing.Size(691, 620);
            this.gbx_ProductList.TabIndex = 550;
            this.gbx_ProductList.TabStop = false;
            this.gbx_ProductList.Text = "Product List";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Title.Location = new System.Drawing.Point(12, 27);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(73, 26);
            this.lbl_Title.TabIndex = 551;
            this.lbl_Title.Text = "Product";
            // 
            // gbx_Filter
            // 
            this.gbx_Filter.Controls.Add(this.lbl_FilteredCode);
            this.gbx_Filter.Controls.Add(this.txt_FilteredCode);
            this.gbx_Filter.Location = new System.Drawing.Point(319, 27);
            this.gbx_Filter.Name = "gbx_Filter";
            this.gbx_Filter.Size = new System.Drawing.Size(688, 56);
            this.gbx_Filter.TabIndex = 552;
            this.gbx_Filter.TabStop = false;
            this.gbx_Filter.Text = "Filter";
            // 
            // lbl_FilteredCode
            // 
            this.lbl_FilteredCode.AutoSize = true;
            this.lbl_FilteredCode.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilteredCode.Location = new System.Drawing.Point(11, 20);
            this.lbl_FilteredCode.Name = "lbl_FilteredCode";
            this.lbl_FilteredCode.Size = new System.Drawing.Size(37, 20);
            this.lbl_FilteredCode.TabIndex = 495;
            this.lbl_FilteredCode.Text = "Code";
            // 
            // txt_FilteredCode
            // 
            this.txt_FilteredCode.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilteredCode.Location = new System.Drawing.Point(54, 20);
            this.txt_FilteredCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FilteredCode.Name = "txt_FilteredCode";
            this.txt_FilteredCode.Size = new System.Drawing.Size(187, 25);
            this.txt_FilteredCode.TabIndex = 10;
            this.txt_FilteredCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FilteredCode_KeyDown);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 515;
            this.label5.Text = "Serial No.";
            // 
            // txt_SrNo
            // 
            this.txt_SrNo.Location = new System.Drawing.Point(128, 535);
            this.txt_SrNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SrNo.Name = "txt_SrNo";
            this.txt_SrNo.Size = new System.Drawing.Size(160, 27);
            this.txt_SrNo.TabIndex = 514;
            this.txt_SrNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SrNo_KeyPress);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.gbx_Filter);
            this.Controls.Add(this.gbx_ProductInfo);
            this.Controls.Add(this.gbx_ProductList);
            this.Controls.Add(this.lbl_Title);
            this.Name = "FrmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.gbx_ProductInfo.ResumeLayout(false);
            this.gbx_ProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Product)).EndInit();
            this.gbx_ProductList.ResumeLayout(false);
            this.gbx_Filter.ResumeLayout(false);
            this.gbx_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_ProductInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.Label lbl_Code;
        private System.Windows.Forms.TextBox txt_Code;
        private System.Windows.Forms.DataGridView dgv_Product;
        private System.Windows.Forms.GroupBox gbx_ProductList;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_NoOfUnits;
        private System.Windows.Forms.TextBox txt_NoOfUnits;
        private System.Windows.Forms.Label lbl_Weight;
        private System.Windows.Forms.TextBox txt_Weight;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_CartonPrice;
        private System.Windows.Forms.Label lbl_UnitPrice;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private MTGCComboBox cbx_Catagory;
        private System.Windows.Forms.Label lbl_Catagory;
        private System.Windows.Forms.GroupBox gbx_Filter;
        private System.Windows.Forms.Label lbl_FilteredCode;
        private System.Windows.Forms.TextBox txt_FilteredCode;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ReorderCtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MinLvl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CartonPrice2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UnitPrice2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_SrNo;
    }
}