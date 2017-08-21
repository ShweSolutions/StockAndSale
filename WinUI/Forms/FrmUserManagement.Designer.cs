namespace StockAndSale
{
    partial class FrmUserManagement
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.gbx_UserList = new System.Windows.Forms.GroupBox();
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.gbx_UserInformation = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Remove = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Add = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.dgv_UserPermission = new System.Windows.Forms.DataGridView();
            this.dgv_ExistingPermission = new System.Windows.Forms.DataGridView();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_LoginName = new System.Windows.Forms.Label();
            this.txt_LoginName = new System.Windows.Forms.TextBox();
            this.btn_Reset = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_Save = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.gbx_UserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.gbx_UserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExistingPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_Title.Location = new System.Drawing.Point(24, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(154, 26);
            this.lbl_Title.TabIndex = 551;
            this.lbl_Title.Text = "User Management";
            // 
            // gbx_UserList
            // 
            this.gbx_UserList.Controls.Add(this.dgv_UserList);
            this.gbx_UserList.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_UserList.Location = new System.Drawing.Point(496, 48);
            this.gbx_UserList.Name = "gbx_UserList";
            this.gbx_UserList.Size = new System.Drawing.Size(514, 651);
            this.gbx_UserList.TabIndex = 550;
            this.gbx_UserList.TabStop = false;
            this.gbx_UserList.Text = "User List";
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_UserList.Location = new System.Drawing.Point(3, 21);
            this.dgv_UserList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.ReadOnly = true;
            this.dgv_UserList.Size = new System.Drawing.Size(508, 627);
            this.dgv_UserList.TabIndex = 4;
            this.dgv_UserList.DoubleClick += new System.EventHandler(this.dgv_UserList_DoubleClick);
            // 
            // gbx_UserInformation
            // 
            this.gbx_UserInformation.Controls.Add(this.label1);
            this.gbx_UserInformation.Controls.Add(this.label4);
            this.gbx_UserInformation.Controls.Add(this.btn_Remove);
            this.gbx_UserInformation.Controls.Add(this.btn_Add);
            this.gbx_UserInformation.Controls.Add(this.dgv_UserPermission);
            this.gbx_UserInformation.Controls.Add(this.dgv_ExistingPermission);
            this.gbx_UserInformation.Controls.Add(this.lbl_ConfirmPassword);
            this.gbx_UserInformation.Controls.Add(this.txt_ConfirmPassword);
            this.gbx_UserInformation.Controls.Add(this.lbl_Password);
            this.gbx_UserInformation.Controls.Add(this.txt_Password);
            this.gbx_UserInformation.Controls.Add(this.lbl_LoginName);
            this.gbx_UserInformation.Controls.Add(this.txt_LoginName);
            this.gbx_UserInformation.Controls.Add(this.btn_Reset);
            this.gbx_UserInformation.Controls.Add(this.btn_Save);
            this.gbx_UserInformation.Controls.Add(this.lbl_UserName);
            this.gbx_UserInformation.Controls.Add(this.txt_Name);
            this.gbx_UserInformation.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_UserInformation.Location = new System.Drawing.Point(26, 48);
            this.gbx_UserInformation.Name = "gbx_UserInformation";
            this.gbx_UserInformation.Size = new System.Drawing.Size(464, 651);
            this.gbx_UserInformation.TabIndex = 549;
            this.gbx_UserInformation.TabStop = false;
            this.gbx_UserInformation.Text = "User SetUp Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 504;
            this.label4.Text = "User Permission";
            // 
            // btn_Remove
            // 
            this.btn_Remove.DirtyPaletteCounter = 793;
            this.btn_Remove.Location = new System.Drawing.Point(207, 310);
            this.btn_Remove.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Remove.Size = new System.Drawing.Size(34, 32);
            this.btn_Remove.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Remove.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Remove.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Remove.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Remove.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Remove.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Remove.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Remove.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Remove.TabIndex = 503;
            this.btn_Remove.Text = "<<";
            this.btn_Remove.Values.ExtraText = "";
            this.btn_Remove.Values.Image = null;
            this.btn_Remove.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Remove.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Remove.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Remove.Values.Text = "<<";
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.DirtyPaletteCounter = 791;
            this.btn_Add.Location = new System.Drawing.Point(207, 268);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 11, 3, 11);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.OverrideDefault.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Add.OverrideDefault.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.OverrideFocus.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Add.OverrideFocus.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.btn_Add.Size = new System.Drawing.Size(34, 32);
            this.btn_Add.StateCommon.Back.Color1 = System.Drawing.Color.SkyBlue;
            this.btn_Add.StateCommon.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.StateCommon.Content.LongText.Font = new System.Drawing.Font("Zawgyi-One", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Add.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Add.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.StateNormal.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Add.StateNormal.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btn_Add.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btn_Add.StatePressed.Back.Color1 = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Add.StatePressed.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.StateTracking.Back.Color1 = System.Drawing.Color.SteelBlue;
            this.btn_Add.StateTracking.Back.Color2 = System.Drawing.Color.SteelBlue;
            this.btn_Add.TabIndex = 502;
            this.btn_Add.Text = ">>";
            this.btn_Add.Values.ExtraText = "";
            this.btn_Add.Values.Image = null;
            this.btn_Add.Values.ImageStates.ImageCheckedNormal = null;
            this.btn_Add.Values.ImageStates.ImageCheckedPressed = null;
            this.btn_Add.Values.ImageStates.ImageCheckedTracking = null;
            this.btn_Add.Values.Text = ">>";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // dgv_UserPermission
            // 
            this.dgv_UserPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserPermission.Location = new System.Drawing.Point(247, 255);
            this.dgv_UserPermission.Name = "dgv_UserPermission";
            this.dgv_UserPermission.Size = new System.Drawing.Size(211, 324);
            this.dgv_UserPermission.TabIndex = 501;
            this.dgv_UserPermission.DoubleClick += new System.EventHandler(this.dgv_UserPermission_DoubleClick);
            // 
            // dgv_ExistingPermission
            // 
            this.dgv_ExistingPermission.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ExistingPermission.Location = new System.Drawing.Point(6, 255);
            this.dgv_ExistingPermission.Name = "dgv_ExistingPermission";
            this.dgv_ExistingPermission.Size = new System.Drawing.Size(195, 324);
            this.dgv_ExistingPermission.TabIndex = 500;
            this.dgv_ExistingPermission.DoubleClick += new System.EventHandler(this.dgv_ExistingPermission_DoubleClick);
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(17, 185);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(105, 20);
            this.lbl_ConfirmPassword.TabIndex = 499;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(138, 182);
            this.txt_ConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(187, 27);
            this.txt_ConfirmPassword.TabIndex = 4;
            this.txt_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(17, 133);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(60, 20);
            this.lbl_Password.TabIndex = 497;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(138, 130);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(187, 27);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // lbl_LoginName
            // 
            this.lbl_LoginName.AutoSize = true;
            this.lbl_LoginName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginName.Location = new System.Drawing.Point(17, 85);
            this.lbl_LoginName.Name = "lbl_LoginName";
            this.lbl_LoginName.Size = new System.Drawing.Size(73, 20);
            this.lbl_LoginName.TabIndex = 495;
            this.lbl_LoginName.Text = "Login Name";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(138, 82);
            this.txt_LoginName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Size = new System.Drawing.Size(187, 27);
            this.txt_LoginName.TabIndex = 2;
            // 
            // btn_Reset
            // 
            this.btn_Reset.DirtyPaletteCounter = 789;
            this.btn_Reset.Location = new System.Drawing.Point(247, 605);
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
            this.btn_Save.DirtyPaletteCounter = 789;
            this.btn_Save.Location = new System.Drawing.Point(138, 605);
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
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserName.Location = new System.Drawing.Point(17, 39);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(61, 20);
            this.lbl_UserName.TabIndex = 493;
            this.lbl_UserName.Text = "Full Name";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(138, 36);
            this.txt_Name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(187, 27);
            this.txt_Name.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Zawgyi-One", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 505;
            this.label1.Text = "Existing Permission";
            // 
            // FrmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1022, 721);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.gbx_UserList);
            this.Controls.Add(this.gbx_UserInformation);
            this.Name = "FrmUserManagement";
            this.Text = "User Management";
            this.Load += new System.EventHandler(this.FrmUserManagement_Load);
            this.gbx_UserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.gbx_UserInformation.ResumeLayout(false);
            this.gbx_UserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Remove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ExistingPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Reset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.GroupBox gbx_UserList;
        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.GroupBox gbx_UserInformation;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Reset;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Save;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_Name;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Remove;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_Add;
        private System.Windows.Forms.DataGridView dgv_UserPermission;
        private System.Windows.Forms.DataGridView dgv_ExistingPermission;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_LoginName;
        private System.Windows.Forms.TextBox txt_LoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label label1;
    }
}