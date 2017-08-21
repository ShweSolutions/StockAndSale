namespace StockAndSale
{
    partial class Frm_PaymentDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_PaymentDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Ok = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Cancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Date";
            // 
            // dtp_PaymentDate
            // 
            this.dtp_PaymentDate.CustomFormat = "dd/MMM/yyyy";
            this.dtp_PaymentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_PaymentDate.Location = new System.Drawing.Point(99, 25);
            this.dtp_PaymentDate.Name = "dtp_PaymentDate";
            this.dtp_PaymentDate.Size = new System.Drawing.Size(178, 20);
            this.dtp_PaymentDate.TabIndex = 1;
            // 
            // btn_Ok
            // 
            this.btn_Ok.DirtyPaletteCounter = 805;
            this.btn_Ok.Location = new System.Drawing.Point(99, 59);
            this.btn_Ok.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Ok.Size = new System.Drawing.Size(80, 32);
            this.btn_Ok.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Ok.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Ok.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Ok.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ok.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Ok.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Ok.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Ok.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Ok.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Ok.TabIndex = 10;
            this.btn_Ok.Text = "Ok";
            this.btn_Ok.Values.ExtraText = "";
            this.btn_Ok.Values.Image = null;
            this.btn_Ok.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Ok.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Ok.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Ok.Values.Text = "Ok";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DirtyPaletteCounter = 807;
            this.btn_Cancel.Location = new System.Drawing.Point(197, 59);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Cancel.Size = new System.Drawing.Size(80, 32);
            this.btn_Cancel.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Cancel.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Cancel.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Cancel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Cancel.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Cancel.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Cancel.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Cancel.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Values.ExtraText = "";
            this.btn_Cancel.Values.Image = null;
            this.btn_Cancel.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Cancel.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Cancel.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Cancel.Values.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Frm_PaymentDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(303, 124);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.dtp_PaymentDate);
            this.Controls.Add(this.label1);
            this.Name = "Frm_PaymentDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_PaymentDate";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Ok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_PaymentDate;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Ok;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Cancel;
    }
}