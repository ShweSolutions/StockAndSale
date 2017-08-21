namespace StockAndSale
{
    partial class Frm_FOCReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FOCReport));
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dtp_InvoiceDateTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbx_Product = new MTGCComboBox();
            this.lbl_ProductCode = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.txt_PhoneNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_InvoiceDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Customer = new MTGCComboBox();
            this.rptv_FOCReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 529;
            this.label3.Text = "Customer";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 835;
            this.btn_Search.Location = new System.Drawing.Point(643, 89);
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
            this.dtp_InvoiceDateTo.Location = new System.Drawing.Point(643, 22);
            this.dtp_InvoiceDateTo.Name = "dtp_InvoiceDateTo";
            this.dtp_InvoiceDateTo.Size = new System.Drawing.Size(171, 20);
            this.dtp_InvoiceDateTo.TabIndex = 527;
            this.dtp_InvoiceDateTo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateTo_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_Product);
            this.groupBox1.Controls.Add(this.lbl_ProductCode);
            this.groupBox1.Controls.Add(this.lbl_Description);
            this.groupBox1.Controls.Add(this.txt_Description);
            this.groupBox1.Controls.Add(this.txt_PhoneNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_Address);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_InvoiceDateFrom);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbx_Customer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1016, 154);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
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
            this.cbx_Product.Location = new System.Drawing.Point(420, 57);
            this.cbx_Product.ManagingFastMouseMoving = true;
            this.cbx_Product.ManagingFastMouseMovingInterval = 30;
            this.cbx_Product.Name = "cbx_Product";
            this.cbx_Product.SelectedItem = null;
            this.cbx_Product.SelectedValue = null;
            this.cbx_Product.Size = new System.Drawing.Size(178, 22);
            this.cbx_Product.TabIndex = 540;
            this.cbx_Product.Leave += new System.EventHandler(this.cbx_Product_Leave);
            this.cbx_Product.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Product_KeyDown);
            // 
            // lbl_ProductCode
            // 
            this.lbl_ProductCode.AutoSize = true;
            this.lbl_ProductCode.Location = new System.Drawing.Point(325, 61);
            this.lbl_ProductCode.Name = "lbl_ProductCode";
            this.lbl_ProductCode.Size = new System.Drawing.Size(72, 13);
            this.lbl_ProductCode.TabIndex = 543;
            this.lbl_ProductCode.Text = "Product Code";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(325, 98);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(69, 20);
            this.lbl_Description.TabIndex = 542;
            this.lbl_Description.Text = "Description";
            // 
            // txt_Description
            // 
            this.txt_Description.BackColor = System.Drawing.Color.White;
            this.txt_Description.Location = new System.Drawing.Point(420, 89);
            this.txt_Description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Description.Multiline = true;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.ReadOnly = true;
            this.txt_Description.Size = new System.Drawing.Size(178, 49);
            this.txt_Description.TabIndex = 541;
            // 
            // txt_PhoneNo
            // 
            this.txt_PhoneNo.BackColor = System.Drawing.Color.White;
            this.txt_PhoneNo.Location = new System.Drawing.Point(106, 118);
            this.txt_PhoneNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_PhoneNo.Name = "txt_PhoneNo";
            this.txt_PhoneNo.ReadOnly = true;
            this.txt_PhoneNo.Size = new System.Drawing.Size(187, 20);
            this.txt_PhoneNo.TabIndex = 538;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 539;
            this.label5.Text = "Phone No";
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.Location = new System.Drawing.Point(106, 59);
            this.txt_Address.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Address.Multiline = true;
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(187, 49);
            this.txt_Address.TabIndex = 537;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 536;
            this.label4.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 526;
            this.label2.Text = "To";
            // 
            // dtp_InvoiceDateFrom
            // 
            this.dtp_InvoiceDateFrom.CustomFormat = "dd/MMM/yyyy";
            this.dtp_InvoiceDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_InvoiceDateFrom.Location = new System.Drawing.Point(420, 22);
            this.dtp_InvoiceDateFrom.Name = "dtp_InvoiceDateFrom";
            this.dtp_InvoiceDateFrom.Size = new System.Drawing.Size(178, 20);
            this.dtp_InvoiceDateFrom.TabIndex = 525;
            this.dtp_InvoiceDateFrom.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtp_InvoiceDateFrom_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 26);
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
            this.cbx_Customer.Location = new System.Drawing.Point(106, 25);
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
            // rptv_FOCReport
            // 
            this.rptv_FOCReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptv_FOCReport.Location = new System.Drawing.Point(0, 0);
            this.rptv_FOCReport.Name = "rptv_FOCReport";
            this.rptv_FOCReport.Size = new System.Drawing.Size(1016, 577);
            this.rptv_FOCReport.TabIndex = 3;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rptv_FOCReport);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 577);
            this.panel2.TabIndex = 4;
            // 
            // Frm_FOCReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1016, 731);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_FOCReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOC Report";
            this.Load += new System.EventHandler(this.Frm_FOCReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Search)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateTo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_PhoneNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_InvoiceDateFrom;
        private System.Windows.Forms.Label label1;
        private MTGCComboBox cbx_Customer;
        private Microsoft.Reporting.WinForms.ReportViewer rptv_FOCReport;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private MTGCComboBox cbx_Product;
        private System.Windows.Forms.Label lbl_ProductCode;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.Panel panel2;
    }
}