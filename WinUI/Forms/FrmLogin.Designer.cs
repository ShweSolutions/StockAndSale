namespace StockAndSale
{
    partial class FrmLogin
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
            this.btn_Login = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_LoginName = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.DirtyPaletteCounter = 814;
            this.btn_Login.Location = new System.Drawing.Point(116, 146);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Login.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Login.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Login.Size = new System.Drawing.Size(71, 32);
            this.btn_Login.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Login.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Login.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Login.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Login.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Login.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Login.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Login.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Login.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.Values.ExtraText = "";
            this.btn_Login.Values.Image = null;
            this.btn_Login.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Login.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Login.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Login.Values.Text = "Login";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_LoginName
            // 
            this.lbl_LoginName.AutoSize = true;
            this.lbl_LoginName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginName.Location = new System.Drawing.Point(26, 64);
            this.lbl_LoginName.Name = "lbl_LoginName";
            this.lbl_LoginName.Size = new System.Drawing.Size(73, 20);
            this.lbl_LoginName.TabIndex = 524;
            this.lbl_LoginName.Text = "Login Name";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(116, 64);
            this.txt_LoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(176, 20);
            this.txt_LoginName.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(39, 104);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(60, 20);
            this.lbl_Password.TabIndex = 527;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(116, 104);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(176, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Password_KeyDown);
            // 
            // btn_Close
            // 
            this.btn_Close.DirtyPaletteCounter = 816;
            this.btn_Close.Location = new System.Drawing.Point(221, 146);
            this.btn_Close.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Close.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Close.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Close.Size = new System.Drawing.Size(71, 32);
            this.btn_Close.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Close.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Close.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Close.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Close.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Close.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Close.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Close.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Close.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Close.TabIndex = 4;
            this.btn_Close.Text = "Close";
            this.btn_Close.Values.ExtraText = "";
            this.btn_Close.Values.Image = null;
            this.btn_Close.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Close.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Close.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Close.Values.Text = "Close";
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 10.3F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(115, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 22);
            this.label1.TabIndex = 529;
            this.label1.Text = "Chan Myanmar Co., Ltd.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::StockAndSale.Properties.Resources.test;
            this.pictureBox1.Location = new System.Drawing.Point(26, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 528;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(358, 208);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.lbl_LoginName);
            this.Controls.Add(this.txt_LoginName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.btn_Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Login;
        private System.Windows.Forms.Label lbl_LoginName;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}