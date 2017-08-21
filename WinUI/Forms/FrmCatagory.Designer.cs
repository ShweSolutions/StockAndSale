namespace StockAndSale
{
    partial class FrmCatagory
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
            this.gbx_CatagoryInfo = new System.Windows.Forms.GroupBox();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_CatagoryDescription = new System.Windows.Forms.Label();
            this.txt_CatagoryDescription = new System.Windows.Forms.TextBox();
            this.gbx_CatagoryList = new System.Windows.Forms.GroupBox();
            this.dgv_Catagory = new System.Windows.Forms.DataGridView();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbx_Filter = new System.Windows.Forms.GroupBox();
            this.lbl_FilteredDescription = new System.Windows.Forms.Label();
            this.txt_FilteredDescription = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbx_CatagoryInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            this.gbx_CatagoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catagory)).BeginInit();
            this.gbx_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbx_CatagoryInfo
            // 
            this.gbx_CatagoryInfo.Controls.Add(this.btn_Reset);
            this.gbx_CatagoryInfo.Controls.Add(this.btn_Save);
            this.gbx_CatagoryInfo.Controls.Add(this.lbl_CatagoryDescription);
            this.gbx_CatagoryInfo.Controls.Add(this.txt_CatagoryDescription);
            this.gbx_CatagoryInfo.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CatagoryInfo.Location = new System.Drawing.Point(28, 86);
            this.gbx_CatagoryInfo.Name = "gbx_CatagoryInfo";
            this.gbx_CatagoryInfo.Size = new System.Drawing.Size(352, 131);
            this.gbx_CatagoryInfo.TabIndex = 543;
            this.gbx_CatagoryInfo.TabStop = false;
            this.gbx_CatagoryInfo.Text = "Category SetUp Information";
            // 
            // btn_Reset
            // 
            this.btn_Reset.DirtyPaletteCounter = 777;
            this.btn_Reset.Location = new System.Drawing.Point(244, 78);
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
            this.btn_Reset.TabIndex = 3;
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
            this.btn_Save.DirtyPaletteCounter = 777;
            this.btn_Save.Location = new System.Drawing.Point(135, 78);
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
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.Values.ExtraText = "";
            this.btn_Save.Values.Image = null;
            this.btn_Save.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Save.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Save.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Save.Values.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_CatagoryDescription
            // 
            this.lbl_CatagoryDescription.AutoSize = true;
            this.lbl_CatagoryDescription.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CatagoryDescription.Location = new System.Drawing.Point(6, 39);
            this.lbl_CatagoryDescription.Name = "lbl_CatagoryDescription";
            this.lbl_CatagoryDescription.Size = new System.Drawing.Size(122, 20);
            this.lbl_CatagoryDescription.TabIndex = 493;
            this.lbl_CatagoryDescription.Text = "Category Description";
            // 
            // txt_CatagoryDescription
            // 
            this.txt_CatagoryDescription.Location = new System.Drawing.Point(135, 36);
            this.txt_CatagoryDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_CatagoryDescription.Name = "txt_CatagoryDescription";
            this.txt_CatagoryDescription.Size = new System.Drawing.Size(187, 27);
            this.txt_CatagoryDescription.TabIndex = 1;
            // 
            // gbx_CatagoryList
            // 
            this.gbx_CatagoryList.Controls.Add(this.dgv_Catagory);
            this.gbx_CatagoryList.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_CatagoryList.Location = new System.Drawing.Point(386, 86);
            this.gbx_CatagoryList.Name = "gbx_CatagoryList";
            this.gbx_CatagoryList.Size = new System.Drawing.Size(614, 614);
            this.gbx_CatagoryList.TabIndex = 544;
            this.gbx_CatagoryList.TabStop = false;
            this.gbx_CatagoryList.Text = "Product Category List";
            // 
            // dgv_Catagory
            // 
            this.dgv_Catagory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Catagory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Catagory.Location = new System.Drawing.Point(3, 21);
            this.dgv_Catagory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_Catagory.Name = "dgv_Catagory";
            this.dgv_Catagory.ReadOnly = true;
            this.dgv_Catagory.Size = new System.Drawing.Size(608, 590);
            this.dgv_Catagory.TabIndex = 4;
            this.dgv_Catagory.DoubleClick += new System.EventHandler(this.dgv_Catagory_DoubleClick);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Title.Location = new System.Drawing.Point(26, 31);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(150, 26);
            this.lbl_Title.TabIndex = 548;
            this.lbl_Title.Text = "Product Category";
            // 
            // gbx_Filter
            // 
            this.gbx_Filter.Controls.Add(this.lbl_FilteredDescription);
            this.gbx_Filter.Controls.Add(this.txt_FilteredDescription);
            this.gbx_Filter.Location = new System.Drawing.Point(386, 20);
            this.gbx_Filter.Name = "gbx_Filter";
            this.gbx_Filter.Size = new System.Drawing.Size(614, 60);
            this.gbx_Filter.TabIndex = 549;
            this.gbx_Filter.TabStop = false;
            this.gbx_Filter.Text = "Filter";
            // 
            // lbl_FilteredDescription
            // 
            this.lbl_FilteredDescription.AutoSize = true;
            this.lbl_FilteredDescription.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilteredDescription.Location = new System.Drawing.Point(20, 25);
            this.lbl_FilteredDescription.Name = "lbl_FilteredDescription";
            this.lbl_FilteredDescription.Size = new System.Drawing.Size(122, 20);
            this.lbl_FilteredDescription.TabIndex = 495;
            this.lbl_FilteredDescription.Text = "Category Description";
            // 
            // txt_FilteredDescription
            // 
            this.txt_FilteredDescription.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FilteredDescription.Location = new System.Drawing.Point(147, 25);
            this.txt_FilteredDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_FilteredDescription.Name = "txt_FilteredDescription";
            this.txt_FilteredDescription.Size = new System.Drawing.Size(187, 25);
            this.txt_FilteredDescription.TabIndex = 494;
            this.txt_FilteredDescription.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FilteredDescription_KeyDown);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmCatagory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.gbx_Filter);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.gbx_CatagoryList);
            this.Controls.Add(this.gbx_CatagoryInfo);
            this.Name = "FrmCatagory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Category";
            this.Load += new System.EventHandler(this.FrmCatagory_Load);
            this.gbx_CatagoryInfo.ResumeLayout(false);
            this.gbx_CatagoryInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            this.gbx_CatagoryList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Catagory)).EndInit();
            this.gbx_Filter.ResumeLayout(false);
            this.gbx_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_CatagoryInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.Label lbl_CatagoryDescription;
        private System.Windows.Forms.TextBox txt_CatagoryDescription;
        private System.Windows.Forms.GroupBox gbx_CatagoryList;
        private System.Windows.Forms.DataGridView dgv_Catagory;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbx_Filter;
        private System.Windows.Forms.Label lbl_FilteredDescription;
        private System.Windows.Forms.TextBox txt_FilteredDescription;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}