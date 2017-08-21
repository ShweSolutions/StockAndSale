namespace StockAndSale
{
    partial class FrmCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomer));
            this.gbx_CustomerInfo = new System.Windows.Forms.GroupBox();
            this.lbl_PhoneNo = new System.Windows.Forms.Label();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_CustomerDescription = new System.Windows.Forms.TextBox();
            this.dgv_Customer = new System.Windows.Forms.DataGridView();
            this.gbx_CustomerList = new System.Windows.Forms.GroupBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbx_Filter = new System.Windows.Forms.GroupBox();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_FilterDescription = new System.Windows.Forms.Label();
            this.txt_FilteredCustomerDescription = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_Delete = new System.Windows.Forms.Button();
            this.cbx_Catagory = new MTGCComboBox();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.gbx_CustomerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).BeginInit();
            this.gbx_CustomerList.SuspendLayout();
            this.gbx_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_CustomerInfo
            // 
            this.gbx_CustomerInfo.Controls.Add(this.cbx_Catagory);
            this.gbx_CustomerInfo.Controls.Add(this.lbl_Catagory);
            this.gbx_CustomerInfo.Controls.Add(this.lbl_PhoneNo);
            this.gbx_CustomerInfo.Controls.Add(this.txt_PhoneNo);
            this.gbx_CustomerInfo.Controls.Add(this.lbl_Address);
            this.gbx_CustomerInfo.Controls.Add(this.txt_Address);
            this.gbx_CustomerInfo.Controls.Add(this.btn_Reset);
            this.gbx_CustomerInfo.Controls.Add(this.btn_Save);
            this.gbx_CustomerInfo.Controls.Add(this.lbl_Description);
            this.gbx_CustomerInfo.Controls.Add(this.txt_CustomerDescription);
            this.gbx_CustomerInfo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CustomerInfo.Location = new System.Drawing.Point(28, 91);
            this.gbx_CustomerInfo.Name = "gbx_CustomerInfo";
            this.gbx_CustomerInfo.Size = new System.Drawing.Size(352, 318);
            this.gbx_CustomerInfo.TabIndex = 549;
            this.gbx_CustomerInfo.TabStop = false;
            this.gbx_CustomerInfo.Text = "Customer SetUp Information";
            // 
            // lbl_PhoneNo
            // 
            this.lbl_PhoneNo.AutoSize = true;
            this.lbl_PhoneNo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PhoneNo.Location = new System.Drawing.Point(6, 163);
            this.lbl_PhoneNo.Name = "lbl_PhoneNo";
            this.lbl_PhoneNo.Size = new System.Drawing.Size(67, 20);
            this.lbl_PhoneNo.TabIndex = 497;
            this.lbl_PhoneNo.Text = "Phone No:";
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.Location = new System.Drawing.Point(93, 160);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.Size = new System.Drawing.Size(238, 27);
            this.txt_PhoneNo.TabIndex = 3;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(6, 83);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(52, 20);
            this.lbl_Address.TabIndex = 495;
            this.lbl_Address.Text = "Address";
            // 
            // txt_Address
            // 
            this.txt_Address.Location = new System.Drawing.Point(93, 83);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(238, 56);
            this.txt_Address.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.DirtyPaletteCounter = 781;
            this.btn_Reset.Location = new System.Drawing.Point(214, 261);
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
            this.btn_Reset.TabIndex = 5;
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
            this.btn_Save.DirtyPaletteCounter = 781;
            this.btn_Save.Location = new System.Drawing.Point(93, 261);
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
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "Save";
            this.btn_Save.Values.ExtraText = "";
            this.btn_Save.Values.Image = null;
            this.btn_Save.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Save.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Save.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(6, 39);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(69, 20);
            this.lbl_Description.TabIndex = 493;
            this.lbl_Description.Text = "Description";
            // 
            // txt_CustomerDescription
            // 
            this.txt_CustomerDescription.Location = new System.Drawing.Point(93, 36);
            this.txt_CustomerDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CustomerDescription.Name = "txt_CustomerDescription";
            this.txt_CustomerDescription.Size = new System.Drawing.Size(238, 27);
            this.txt_CustomerDescription.TabIndex = 1;
            // 
            // dgv_Customer
            // 
            this.dgv_Customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Customer.Location = new System.Drawing.Point(3, 16);
            this.dgv_Customer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Customer.Name = "dgv_Customer";
            this.dgv_Customer.ReadOnly = true;
            this.dgv_Customer.Size = new System.Drawing.Size(600, 540);
            this.dgv_Customer.TabIndex = 4;
            this.dgv_Customer.DoubleClick += new System.EventHandler(this.dgv_Customer_DoubleClick);
            // 
            // gbx_CustomerList
            // 
            this.gbx_CustomerList.Controls.Add(this.dgv_Customer);
            this.gbx_CustomerList.Location = new System.Drawing.Point(404, 91);
            this.gbx_CustomerList.Name = "gbx_CustomerList";
            this.gbx_CustomerList.Size = new System.Drawing.Size(606, 559);
            this.gbx_CustomerList.TabIndex = 550;
            this.gbx_CustomerList.TabStop = false;
            this.gbx_CustomerList.Text = "Customer List";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Title.Location = new System.Drawing.Point(33, 23);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(88, 26);
            this.lbl_Title.TabIndex = 551;
            this.lbl_Title.Text = "Customer";
            // 
            // gbx_Filter
            // 
            this.gbx_Filter.Controls.Add(this.btn_Print);
            this.gbx_Filter.Controls.Add(this.lbl_FilterDescription);
            this.gbx_Filter.Controls.Add(this.txt_FilteredCustomerDescription);
            this.gbx_Filter.Location = new System.Drawing.Point(404, 23);
            this.gbx_Filter.Name = "gbx_Filter";
            this.gbx_Filter.Size = new System.Drawing.Size(603, 62);
            this.gbx_Filter.TabIndex = 552;
            this.gbx_Filter.TabStop = false;
            this.gbx_Filter.Text = "Filter";
            // 
            // btn_Print
            // 
            this.btn_Print.DirtyPaletteCounter = 783;
            this.btn_Print.Location = new System.Drawing.Point(517, 19);
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
            this.btn_Print.TabIndex = 498;
            this.btn_Print.Text = "Print";
            this.btn_Print.Values.ExtraText = "";
            this.btn_Print.Values.Image = null;
            this.btn_Print.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Print.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Print.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // lbl_FilterDescription
            // 
            this.lbl_FilterDescription.AutoSize = true;
            this.lbl_FilterDescription.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilterDescription.Location = new System.Drawing.Point(7, 23);
            this.lbl_FilterDescription.Name = "lbl_FilterDescription";
            this.lbl_FilterDescription.Size = new System.Drawing.Size(69, 20);
            this.lbl_FilterDescription.TabIndex = 495;
            this.lbl_FilterDescription.Text = "Description";
            // 
            // txt_FilteredCustomerDescription
            // 
            this.txt_FilteredCustomerDescription.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilteredCustomerDescription.Location = new System.Drawing.Point(82, 23);
            this.txt_FilteredCustomerDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FilteredCustomerDescription.Name = "txt_FilteredCustomerDescription";
            this.txt_FilteredCustomerDescription.Size = new System.Drawing.Size(238, 25);
            this.txt_FilteredCustomerDescription.TabIndex = 6;
            this.txt_FilteredCustomerDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FilteredCustomerDescription_KeyDown);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // btn_Delete
            // 
            this.btn_Delete.ForeColor = System.Drawing.Color.Maroon;
            this.btn_Delete.Location = new System.Drawing.Point(404, 656);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(76, 33);
            this.btn_Delete.TabIndex = 553;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.cbx_Catagory.Location = new System.Drawing.Point(93, 213);
            this.cbx_Catagory.ManagingFastMouseMoving = true;
            this.cbx_Catagory.ManagingFastMouseMovingInterval = 30;
            this.cbx_Catagory.Name = "cbx_Catagory";
            this.cbx_Catagory.SelectedItem = null;
            this.cbx_Catagory.SelectedValue = null;
            this.cbx_Catagory.Size = new System.Drawing.Size(160, 22);
            this.cbx_Catagory.TabIndex = 501;
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Location = new System.Drawing.Point(6, 215);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(58, 20);
            this.lbl_Catagory.TabIndex = 502;
            this.lbl_Catagory.Text = "Category";
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.gbx_Filter);
            this.Controls.Add(this.gbx_CustomerInfo);
            this.Controls.Add(this.gbx_CustomerList);
            this.Controls.Add(this.lbl_Title);
            this.Name = "FrmCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.gbx_CustomerInfo.ResumeLayout(false);
            this.gbx_CustomerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer)).EndInit();
            this.gbx_CustomerList.ResumeLayout(false);
            this.gbx_Filter.ResumeLayout(false);
            this.gbx_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_CustomerInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_CustomerDescription;
        private System.Windows.Forms.DataGridView dgv_Customer;
        private System.Windows.Forms.GroupBox gbx_CustomerList;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_PhoneNo;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.GroupBox gbx_Filter;
        private System.Windows.Forms.Label lbl_FilterDescription;
        private System.Windows.Forms.TextBox txt_FilteredCustomerDescription;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private System.Windows.Forms.Button btn_Delete;
        private MTGCComboBox cbx_Catagory;
        private System.Windows.Forms.Label lbl_Catagory;
    }
}