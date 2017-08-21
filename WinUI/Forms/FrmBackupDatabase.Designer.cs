namespace StockAndSale
{
    partial class FrmBackupDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBackupDatabase));
            this.fldBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Browse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBackUp = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ProBar = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_FileLocation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Browse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(5, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 537;
            this.label1.Text = "Data BackUp";
            // 
            // btn_Browse
            // 
            this.btn_Browse.DirtyPaletteCounter = 538;
            this.btn_Browse.Location = new System.Drawing.Point(314, 96);
            this.btn_Browse.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Browse.Size = new System.Drawing.Size(86, 32);
            this.btn_Browse.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Browse.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Browse.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Browse.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Browse.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Browse.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btn_Browse.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Browse.TabIndex = 535;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.Values.ExtraText = "";
            this.btn_Browse.Values.Image = null;
            this.btn_Browse.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Browse.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Browse.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Browse.Values.Text = "Browse";
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.DirtyPaletteCounter = 538;
            this.btn_Close.Location = new System.Drawing.Point(118, 260);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Close.Size = new System.Drawing.Size(98, 32);
            this.btn_Close.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Close.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Close.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Close.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btn_Close.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btn_Close.TabIndex = 534;
            this.btn_Close.Text = "Close";
            this.btn_Close.Values.ExtraText = "";
            this.btn_Close.Values.Image = null;
            this.btn_Close.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Close.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Close.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Close.Values.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(13, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 22);
            this.label9.TabIndex = 533;
            this.label9.Text = "Data Back is Successfully Saved";
            this.label9.Visible = false;
            // 
            // btnBackUp
            // 
            this.btnBackUp.DirtyPaletteCounter = 536;
            this.btnBackUp.Location = new System.Drawing.Point(14, 260);
            this.btnBackUp.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.OverrideDefault.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.OverrideFocus.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btnBackUp.Size = new System.Drawing.Size(98, 32);
            this.btnBackUp.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBackUp.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnBackUp.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.StateDisabled.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.StateNormal.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnBackUp.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnBackUp.StatePressed.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.StateTracking.Back.Color1 = System.Drawing.Color.White;
            this.btnBackUp.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            this.btnBackUp.TabIndex = 532;
            this.btnBackUp.Text = "BackUp";
            this.btnBackUp.Values.ExtraText = "";
            this.btnBackUp.Values.Image = null;
            this.btnBackUp.Values.ImageStates.ImageCheckedNormal = null;
            this.btnBackUp.Values.ImageStates.ImageCheckedPressed = null;
            this.btnBackUp.Values.ImageStates.ImageCheckedTracking = null;
            this.btnBackUp.Values.Text = "BackUp";
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click);
            // 
            // ProBar
            // 
            this.ProBar.Location = new System.Drawing.Point(12, 146);
            this.ProBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProBar.Name = "ProBar";
            this.ProBar.Size = new System.Drawing.Size(388, 32);
            this.ProBar.TabIndex = 531;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 37);
            this.pictureBox1.TabIndex = 536;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_FileLocation
            // 
            this.lbl_FileLocation.AutoSize = true;
            this.lbl_FileLocation.BackColor = System.Drawing.Color.Transparent;
            this.lbl_FileLocation.Font = new System.Drawing.Font("Zawgyi-One", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FileLocation.ForeColor = System.Drawing.Color.Black;
            this.lbl_FileLocation.Location = new System.Drawing.Point(12, 100);
            this.lbl_FileLocation.Name = "lbl_FileLocation";
            this.lbl_FileLocation.Size = new System.Drawing.Size(84, 22);
            this.lbl_FileLocation.TabIndex = 538;
            this.lbl_FileLocation.Text = "File Location";
            this.lbl_FileLocation.Visible = false;
            // 
            // FrmBackupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(630, 317);
            this.Controls.Add(this.lbl_FileLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.ProBar);
            this.Name = "FrmBackupDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Database Backup";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Browse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBackUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fldBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Browse;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private System.Windows.Forms.Label label9;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBackUp;
        private System.Windows.Forms.ProgressBar ProBar;
        private System.Windows.Forms.Label lbl_FileLocation;
    }
}