namespace StockAndSale
{
    partial class FrmProductArrival
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductArrival));
            this.gbx_Filter = new System.Windows.Forms.GroupBox();
            this.dtp_FilteredInDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_FilteredCode = new System.Windows.Forms.Label();
            this.txt_FilteredCode = new System.Windows.Forms.TextBox();
            this.gbx_ProductArrivalInfo = new System.Windows.Forms.GroupBox();
            this.lbl_NoOfCartons = new System.Windows.Forms.Label();
            this.txt_NoOfCartons = new System.Windows.Forms.TextBox();
            this.dtp_InDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Product = new MTGCComboBox();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.gbx_ArrivalProductList = new System.Windows.Forms.GroupBox();
            this.dgv_ArrivalProduct = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_NoOfUnits = new System.Windows.Forms.Label();
            this.txt_NoOfUnits = new System.Windows.Forms.TextBox();
            this.gbx_Filter.SuspendLayout();
            this.gbx_ProductArrivalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            this.gbx_ArrivalProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArrivalProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_Filter
            // 
            this.gbx_Filter.Controls.Add(this.dtp_FilteredInDate);
            this.gbx_Filter.Controls.Add(this.label2);
            this.gbx_Filter.Controls.Add(this.lbl_FilteredCode);
            this.gbx_Filter.Controls.Add(this.txt_FilteredCode);
            this.gbx_Filter.Location = new System.Drawing.Point(319, 19);
            this.gbx_Filter.Name = "gbx_Filter";
            this.gbx_Filter.Size = new System.Drawing.Size(688, 56);
            this.gbx_Filter.TabIndex = 555;
            this.gbx_Filter.TabStop = false;
            this.gbx_Filter.Text = "Filter";
            // 
            // dtp_FilteredInDate
            // 
            this.dtp_FilteredInDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_FilteredInDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_FilteredInDate.Location = new System.Drawing.Point(411, 21);
            this.dtp_FilteredInDate.Name = "dtp_FilteredInDate";
            this.dtp_FilteredInDate.Size = new System.Drawing.Size(212, 20);
            this.dtp_FilteredInDate.TabIndex = 8;
            this.dtp_FilteredInDate.ValueChanged += new System.EventHandler(this.dtp_FilteredInDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 520;
            this.label2.Text = "Arrival In_Date";
            // 
            // lbl_FilteredCode
            // 
            this.lbl_FilteredCode.AutoSize = true;
            this.lbl_FilteredCode.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilteredCode.Location = new System.Drawing.Point(22, 19);
            this.lbl_FilteredCode.Name = "lbl_FilteredCode";
            this.lbl_FilteredCode.Size = new System.Drawing.Size(84, 20);
            this.lbl_FilteredCode.TabIndex = 495;
            this.lbl_FilteredCode.Text = "Product Code";
            // 
            // txt_FilteredCode
            // 
            this.txt_FilteredCode.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilteredCode.Location = new System.Drawing.Point(112, 17);
            this.txt_FilteredCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FilteredCode.Name = "txt_FilteredCode";
            this.txt_FilteredCode.Size = new System.Drawing.Size(187, 25);
            this.txt_FilteredCode.TabIndex = 7;
            this.txt_FilteredCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FilteredCode_KeyDown);
            // 
            // gbx_ProductArrivalInfo
            // 
            this.gbx_ProductArrivalInfo.Controls.Add(this.lbl_NoOfUnits);
            this.gbx_ProductArrivalInfo.Controls.Add(this.txt_NoOfUnits);
            this.gbx_ProductArrivalInfo.Controls.Add(this.lbl_NoOfCartons);
            this.gbx_ProductArrivalInfo.Controls.Add(this.txt_NoOfCartons);
            this.gbx_ProductArrivalInfo.Controls.Add(this.dtp_InDate);
            this.gbx_ProductArrivalInfo.Controls.Add(this.label1);
            this.gbx_ProductArrivalInfo.Controls.Add(this.cbx_Product);
            this.gbx_ProductArrivalInfo.Controls.Add(this.lbl_ProductCode);
            this.gbx_ProductArrivalInfo.Controls.Add(this.lbl_Description);
            this.gbx_ProductArrivalInfo.Controls.Add(this.txt_Description);
            this.gbx_ProductArrivalInfo.Controls.Add(this.btn_Reset);
            this.gbx_ProductArrivalInfo.Controls.Add(this.btn_Save);
            this.gbx_ProductArrivalInfo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ProductArrivalInfo.Location = new System.Drawing.Point(12, 81);
            this.gbx_ProductArrivalInfo.Name = "gbx_ProductArrivalInfo";
            this.gbx_ProductArrivalInfo.Size = new System.Drawing.Size(301, 340);
            this.gbx_ProductArrivalInfo.TabIndex = 553;
            this.gbx_ProductArrivalInfo.TabStop = false;
            this.gbx_ProductArrivalInfo.Text = "Product Arrival Information";
            // 
            // lbl_NoOfCartons
            // 
            this.lbl_NoOfCartons.AutoSize = true;
            this.lbl_NoOfCartons.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoOfCartons.Location = new System.Drawing.Point(6, 182);
            this.lbl_NoOfCartons.Name = "lbl_NoOfCartons";
            this.lbl_NoOfCartons.Size = new System.Drawing.Size(86, 20);
            this.lbl_NoOfCartons.TabIndex = 523;
            this.lbl_NoOfCartons.Text = "No Of Cartons";
            // 
            // txt_NoOfCartons
            // 
            this.txt_NoOfCartons.Location = new System.Drawing.Point(101, 182);
            this.txt_NoOfCartons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NoOfCartons.Name = "txt_NoOfCartons";
            this.txt_NoOfCartons.Size = new System.Drawing.Size(178, 27);
            this.txt_NoOfCartons.TabIndex = 3;
            this.txt_NoOfCartons.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoOfCartons_KeyPress);
            // 
            // dtp_InDate
            // 
            this.dtp_InDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InDate.Location = new System.Drawing.Point(101, 29);
            this.dtp_InDate.Name = "dtp_InDate";
            this.dtp_InDate.Size = new System.Drawing.Size(121, 27);
            this.dtp_InDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 518;
            this.label1.Text = "Arrival In_Date";
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
            this.cbx_Product.Location = new System.Drawing.Point(101, 73);
            this.cbx_Product.ManagingFastMouseMoving = true;
            this.cbx_Product.ManagingFastMouseMovingInterval = 30;
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.SelectedItem = null;
            this.cbx_Product.SelectedValue = null;
            this.cbx_Product.Size = new System.Drawing.Size(178, 22);
            this.cbx_Product.TabIndex = 2;
            this.cbx_Product.Leave += new System.EventHandler(this.cbx_Product_Leave);
            this.cbx_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Product_KeyDown);
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(6, 73);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(84, 20);
            this.lbl_ProductCode.TabIndex = 500;
            this.lbl_ProductCode.Text = "Product Code";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(6, 114);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(69, 20);
            this.lbl_Description.TabIndex = 495;
            this.lbl_Description.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(101, 114);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(178, 49);
            this.txt_Description.TabIndex = 10;
            // 
            // btn_Reset
            // 
            this.btn_Reset.DirtyPaletteCounter = 793;
            this.btn_Reset.Location = new System.Drawing.Point(201, 281);
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
            this.btn_Reset.TabIndex = 6;
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
            this.btn_Save.DirtyPaletteCounter = 793;
            this.btn_Save.Location = new System.Drawing.Point(101, 281);
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
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.Values.ExtraText = "";
            this.btn_Save.Values.Image = null;
            this.btn_Save.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Save.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Save.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // gbx_ArrivalProductList
            // 
            this.gbx_ArrivalProductList.Controls.Add(this.dgv_ArrivalProduct);
            this.gbx_ArrivalProductList.Location = new System.Drawing.Point(319, 81);
            this.gbx_ArrivalProductList.Name = "gbx_ArrivalProductList";
            this.gbx_ArrivalProductList.Size = new System.Drawing.Size(691, 620);
            this.gbx_ArrivalProductList.TabIndex = 554;
            this.gbx_ArrivalProductList.TabStop = false;
            this.gbx_ArrivalProductList.Text = "Arrival Product List";
            // 
            // dgv_ArrivalProduct
            // 
            this.dgv_ArrivalProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ArrivalProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ArrivalProduct.Location = new System.Drawing.Point(3, 16);
            this.dgv_ArrivalProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_ArrivalProduct.Name = "dgv_ArrivalProduct";
            this.dgv_ArrivalProduct.ReadOnly = true;
            this.dgv_ArrivalProduct.Size = new System.Drawing.Size(685, 601);
            this.dgv_ArrivalProduct.TabIndex = 4;
            this.dgv_ArrivalProduct.DoubleClick += new System.EventHandler(this.dgv_ArrivalProduct_DoubleClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Title.Location = new System.Drawing.Point(12, 19);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(133, 26);
            this.lbl_Title.TabIndex = 556;
            this.lbl_Title.Text = "Product Arrival";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // lbl_NoOfUnits
            // 
            this.lbl_NoOfUnits.AutoSize = true;
            this.lbl_NoOfUnits.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoOfUnits.Location = new System.Drawing.Point(6, 228);
            this.lbl_NoOfUnits.Name = "lbl_NoOfUnits";
            this.lbl_NoOfUnits.Size = new System.Drawing.Size(72, 20);
            this.lbl_NoOfUnits.TabIndex = 525;
            this.lbl_NoOfUnits.Text = "No Of Units";
            // 
            // txt_NoOfUnits
            // 
            this.txt_NoOfUnits.Location = new System.Drawing.Point(101, 228);
            this.txt_NoOfUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NoOfUnits.Name = "txt_NoOfUnits";
            this.txt_NoOfUnits.Size = new System.Drawing.Size(178, 27);
            this.txt_NoOfUnits.TabIndex = 4;
            this.txt_NoOfUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoOfUnits_KeyPress);
            // 
            // FrmProductArrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.gbx_Filter);
            this.Controls.Add(this.gbx_ProductArrivalInfo);
            this.Controls.Add(this.gbx_ArrivalProductList);
            this.Name = "FrmProductArrival";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Arrival";
            this.Load += new System.EventHandler(this.FrmProductArrival_Load);
            this.gbx_Filter.ResumeLayout(false);
            this.gbx_Filter.PerformLayout();
            this.gbx_ProductArrivalInfo.ResumeLayout(false);
            this.gbx_ProductArrivalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            this.gbx_ArrivalProductList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ArrivalProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Filter;
        private System.Windows.Forms.Label lbl_FilteredCode;
        private System.Windows.Forms.TextBox txt_FilteredCode;
        private System.Windows.Forms.GroupBox gbx_ProductArrivalInfo;
        private MTGCComboBox cbx_Product;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.GroupBox gbx_ArrivalProductList;
        private System.Windows.Forms.DataGridView dgv_ArrivalProduct;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.DateTimePicker dtp_InDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_FilteredInDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NoOfCartons;
        private System.Windows.Forms.TextBox txt_NoOfCartons;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label lbl_NoOfUnits;
        private System.Windows.Forms.TextBox txt_NoOfUnits;
    }
}