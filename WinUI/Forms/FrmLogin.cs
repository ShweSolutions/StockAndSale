using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockAndSale
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login()
        {
            if (true)//checkExpire())  /////////////////////////  Expiration Check /////////////////
            {
                DEUser User = new DEUser();
                BLLUser obj_BLLUser = new BLLUser();

                try
                {

                    if (txt_LoginName.Text.Trim().Length == 0)
                        MessageBox.Show("Enter Login Name");
                    else
                    {
                        bool bool_Result;

                        User.LoginName = txt_LoginName.Text;
                        User.Password = txt_Password.Text;

                        bool_Result = obj_BLLUser.LoadUserByLoginNameAndPassword(User);

                        if (bool_Result == true)
                        {
                            DEGlobal.str_UserName = User.LoginName;

                            DEGlobal.dt_UserPermission = obj_BLLUser.LoadUserPermissionTableForAllDataByUserId(User);

                            for (int i = 0; i < DEGlobal.dt_UserPermission.Rows.Count; i++)
                            {
                                if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 1)
                                {
                                    DEGlobal.bool_ProductManagement = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 2)
                                {
                                    DEGlobal.bool_CatagoryManagement = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 3)
                                {
                                    DEGlobal.bool_CustomerManagement = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 4)
                                {
                                    DEGlobal.bool_CreateCash = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 5)
                                {
                                    DEGlobal.bool_CreateCredit = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 6)
                                {
                                    DEGlobal.bool_CreateConsign = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 7)
                                {
                                    DEGlobal.bool_EditCash = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 8)
                                {
                                    DEGlobal.bool_EditCredit = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 9)
                                {
                                    DEGlobal.bool_EditConsign = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 10)
                                {
                                    DEGlobal.bool_NewArrival = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 11)
                                {
                                    DEGlobal.bool_EditArrival = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 12)
                                {
                                    DEGlobal.bool_UserManagement = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 13)
                                {
                                    DEGlobal.bool_DataBaseBackup = true;
                                }
                                else if (Convert.ToInt32(DEGlobal.dt_UserPermission.Rows[i][0].ToString()) == 14)
                                {
                                    DEGlobal.bool_CancelInvoice = true;
                                }

                            }

                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Login name and password.");
                            txt_LoginName.Text = string.Empty;
                            txt_Password.Text = string.Empty;
                            txt_LoginName.Focus();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Close();
                }
                finally
                {
                    User = null;
                    obj_BLLUser = null;
                }
            }
            else
            {
                MessageBox.Show("Software is Trial Version and has been expired,\nPlease Contact 09-400494659, Zar Ni Minn, Software Developer,\nLogicForce Software Development Team.","Expiration Alert");
            }

        }

        private Boolean checkExpire()
        {
            Boolean check = true;

            DEInvoiceNo invNo = new DEInvoiceNo();
            invNo.Type = 1;
            BLLInvoiceNo obj_BLLInvoice_No = new BLLInvoiceNo();

            try
            {
                obj_BLLInvoice_No.LoadInvoiceNoRow(invNo);

                if (invNo.Current_Id > 125)
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                check = false;
            }
            return check;
        }

        private void txt_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Login();
            }
        }


    }
}
