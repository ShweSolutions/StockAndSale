namespace StockAndSale
{
    partial class CtrlProductInStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlProductInStore));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Result = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdo_MRP = new System.Windows.Forms.RadioButton();
            this.rdo_Normal = new System.Windows.Forms.RadioButton();
            this.lbl_NoOfUnits = new System.Windows.Forms.Label();
            this.txt_NoOfUnits = new System.Windows.Forms.TextBox();
            this.btn_Print = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.cbx_Catagory = new MTGCComboBox();
            this.lbl_Catagory = new System.Windows.Forms.Label();
            this.btn_Search = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_CartonPrice = new System.Windows.Forms.Label();
            this.txt_ProductCode = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).BeginInit();
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
            this.groupBox2.Controls.Add(this.dgv_Result);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1000, 541);
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
            this.dgv_Result.Size = new System.Drawing.Size(994, 522);
            this.dgv_Result.TabIndex = 0;
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
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbl_NoOfUnits);
            this.groupBox1.Controls.Add(this.txt_NoOfUnits);
            this.groupBox1.Controls.Add(this.btn_Print);
            this.groupBox1.Controls.Add(this.cbx_Catagory);
            this.groupBox1.Controls.Add(this.lbl_Catagory);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lbl_CartonPrice);
            this.groupBox1.Controls.Add(this.txt_ProductCode);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 130);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtered Area";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdo_MRP);
            this.groupBox3.Controls.Add(this.rdo_Normal);
            this.groupBox3.Location = new System.Drawing.Point(322, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 76);
            this.groupBox3.TabIndex = 531;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mode";
            // 
            // rdo_MRP
            // 
            this.rdo_MRP.AutoSize = true;
            this.rdo_MRP.Location = new System.Drawing.Point(7, 53);
            this.rdo_MRP.Name = "rdo_MRP";
            this.rdo_MRP.Size = new System.Drawing.Size(159, 17);
            this.rdo_MRP.TabIndex = 1;
            this.rdo_MRP.TabStop = true;
            this.rdo_MRP.Text = "Requirement Planning Mode";
            this.rdo_MRP.UseVisualStyleBackColor = true;
            this.rdo_MRP.CheckedChanged += new System.EventHandler(this.rdo_MRP_CheckedChanged);
            this.rdo_MRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_MRP_KeyDown);
            // 
            // rdo_Normal
            // 
            this.rdo_Normal.AutoSize = true;
            this.rdo_Normal.Location = new System.Drawing.Point(7, 20);
            this.rdo_Normal.Name = "rdo_Normal";
            this.rdo_Normal.Size = new System.Drawing.Size(88, 17);
            this.rdo_Normal.TabIndex = 0;
            this.rdo_Normal.TabStop = true;
            this.rdo_Normal.Text = "Normal Mode";
            this.rdo_Normal.UseVisualStyleBackColor = true;
            this.rdo_Normal.CheckedChanged += new System.EventHandler(this.rdo_MRP_CheckedChanged);
            this.rdo_Normal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Normal_KeyDown);
            // 
            // lbl_NoOfUnits
            // 
            this.lbl_NoOfUnits.AutoSize = true;
            this.lbl_NoOfUnits.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoOfUnits.Location = new System.Drawing.Point(514, 32);
            this.lbl_NoOfUnits.Name = "lbl_NoOfUnits";
            this.lbl_NoOfUnits.Size = new System.Drawing.Size(96, 20);
            this.lbl_NoOfUnits.TabIndex = 530;
            this.lbl_NoOfUnits.Text = " No of Units <=";
            // 
            // txt_NoOfUnits
            // 
            this.txt_NoOfUnits.Location = new System.Drawing.Point(616, 32);
            this.txt_NoOfUnits.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_NoOfUnits.Name = "txt_NoOfUnits";
            this.txt_NoOfUnits.Size = new System.Drawing.Size(121, 20);
            this.txt_NoOfUnits.TabIndex = 529;
            this.txt_NoOfUnits.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_NoOfUnits_KeyDown);
            this.txt_NoOfUnits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NoOfUnits_KeyPress);
            // 
            // btn_Print
            // 
            this.btn_Print.DirtyPaletteCounter = 791;
            this.btn_Print.Location = new System.Drawing.Point(916, 67);
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
            this.btn_Print.TabIndex = 528;
            this.btn_Print.Text = "Print";
            this.btn_Print.Values.ExtraText = "";
            this.btn_Print.Values.Image = null;
            this.btn_Print.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Print.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Print.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Print.Values.Text = "Print";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
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
            this.cbx_Catagory.Location = new System.Drawing.Point(113, 73);
            this.cbx_Catagory.ManagingFastMouseMoving = true;
            this.cbx_Catagory.ManagingFastMouseMovingInterval = 30;
            this.cbx_Catagory.Name = "cbx_Catagory";
            this.cbx_Catagory.SelectedItem = null;
            this.cbx_Catagory.SelectedValue = null;
            this.cbx_Catagory.Size = new System.Drawing.Size(187, 22);
            this.cbx_Catagory.TabIndex = 526;
            this.cbx_Catagory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbx_Catagory_KeyDown);
            // 
            // lbl_Catagory
            // 
            this.lbl_Catagory.AutoSize = true;
            this.lbl_Catagory.Location = new System.Drawing.Point(25, 77);
            this.lbl_Catagory.Name = "lbl_Catagory";
            this.lbl_Catagory.Size = new System.Drawing.Size(49, 13);
            this.lbl_Catagory.TabIndex = 527;
            this.lbl_Catagory.Text = "Category";
            // 
            // btn_Search
            // 
            this.btn_Search.DirtyPaletteCounter = 807;
            this.btn_Search.Location = new System.Drawing.Point(616, 67);
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
            this.btn_Search.TabIndex = 525;
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
            this.lbl_CartonPrice.Location = new System.Drawing.Point(23, 32);
            this.lbl_CartonPrice.Name = "lbl_CartonPrice";
            this.lbl_CartonPrice.Size = new System.Drawing.Size(84, 20);
            this.lbl_CartonPrice.TabIndex = 524;
            this.lbl_CartonPrice.Text = "Product Code";
            // 
            // txt_ProductCode
            // 
            this.txt_ProductCode.Location = new System.Drawing.Point(113, 32);
            this.txt_ProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ProductCode.Name = "txt_ProductCode";
            this.txt_ProductCode.Size = new System.Drawing.Size(187, 20);
            this.txt_ProductCode.TabIndex = 523;
            this.txt_ProductCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProductCode_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 59);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(394, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 26);
            this.label1.TabIndex = 525;
            this.label1.Text = "Product In Store";
            // 
            // CtrlProductInStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CtrlProductInStore";
            this.Size = new System.Drawing.Size(1000, 730);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Result)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Print)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Search;
        private System.Windows.Forms.Label lbl_CartonPrice;
        private System.Windows.Forms.TextBox txt_ProductCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private MTGCComboBox cbx_Catagory;
        private System.Windows.Forms.Label lbl_Catagory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Result;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Print;
        private System.Windows.Forms.Label lbl_NoOfUnits;
        private System.Windows.Forms.TextBox txt_NoOfUnits;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdo_MRP;
        private System.Windows.Forms.RadioButton rdo_Normal;

    }
}
