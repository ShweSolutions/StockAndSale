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
    public partial class FrmUserManagement : Form
    {
        public FrmUserManagement()
        {
            InitializeComponent();
        }

        DataTable dt_UserPermission;

        DEUser user = new DEUser();

        private void clearScreen()
        {
            user.UserId = Guid.Empty;
            user.Name = string.Empty;
            user.LoginName = string.Empty;
            user.Password = string.Empty;

            txt_Name.Text = string.Empty;
            txt_LoginName.Text = string.Empty;
            txt_Password.Text = string.Empty;
            txt_ConfirmPassword.Text = string.Empty;

            dt_UserPermission.Rows.Clear();
        }

        private void CreateUserPermissionDataTable()
        {
            dt_UserPermission = new DataTable();

            dt_UserPermission.Columns.Add("No", Type.GetType("System.Int32"));
            dt_UserPermission.Columns.Add("Permission", Type.GetType("System.String"));
        }

        private void FrmUserManagement_Load(object sender, EventArgs e)
        {
            CreateUserPermissionDataTable();
            clearScreen();
            FormatDataGridViewStyle();
            bindExistedPermissionDataGridView();
            BindDataGridView();
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_ExistingPermission);
            UIControl.FormatDataGridView(dgv_UserPermission);
            UIControl.FormatDataGridView(dgv_UserList);
        }

        private void bindExistedPermissionDataGridView()
        {
            BLLPermission obj_BLLPermission = new BLLPermission();

            DataTable dt_Permission;

            dt_Permission = obj_BLLPermission.LoadPermissionTableForAllData();

            dgv_ExistingPermission.DataSource = dt_Permission;           

            FormatExistingPermissionDataGridView();
        }

        private void FormatExistingPermissionDataGridView()
        {
            dgv_ExistingPermission.Columns[0].HeaderText = "No";
            dgv_ExistingPermission.Columns[0].Width = 30;
            dgv_ExistingPermission.Columns[0].ReadOnly = true;

            dgv_ExistingPermission.Columns[1].HeaderText = "Permission"; // Item Name
            dgv_ExistingPermission.Columns[1].Width = 160;
            dgv_ExistingPermission.Columns[1].ReadOnly = true;
        }

        private void FormatUserPermissionDataGridView()
        {
            dgv_UserPermission.Columns[0].HeaderText = "No";
            dgv_UserPermission.Columns[0].Width = 30;
            dgv_UserPermission.Columns[0].ReadOnly = true;

            dgv_UserPermission.Columns[1].HeaderText = "Permission"; // Item Name
            dgv_UserPermission.Columns[1].Width = 160;
            dgv_UserPermission.Columns[1].ReadOnly = true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidataUserInput())
            {
                this.save();
            }
        }

        private void save()
        {
            user.Name = txt_Name.Text;
            user.LoginName = txt_LoginName.Text;
            user.Password = txt_Password.Text;

            if (user.UserId == Guid.Empty)
            {
                saveNewUser();
            }
            else
            {
                UpdateUser();
            }
        }

        private void UpdateUser()
        {
            BLLUser obj_BLLUser = new BLLUser();

            try
            {
                int int_Result = obj_BLLUser.UpdateData(user, dt_UserPermission);

                if (int_Result > 0)
                {
                    MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                    BindDataGridView();
                    clearScreen();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                user = new DEUser();
                obj_BLLUser = null;
            }
        }

        private void saveNewUser()
        {
            user.UserId = Guid.NewGuid();

            BLLUser obj_BLLUser = new BLLUser();

            try
            {
                int int_Result = obj_BLLUser.InsertData(user, dt_UserPermission);

                if (int_Result > 0)
                {
                    MessageBox.Show(UIConstantMessage.Const_strSaveSuccessfully);
                    BindDataGridView();
                    clearScreen();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                user = new DEUser();
                obj_BLLUser = null;
            }
        }

        private void BindDataGridView()
        {
            BLLUser obj_BLLUser = new BLLUser();

            DataTable dt_User;

            dt_User = obj_BLLUser.LoadUserTableForAllData();

            dgv_UserList.DataSource = dt_User;

            NumberingTableForDataGridView(dt_User);

            FormatUserListDataGridView();
        }

        private void FormatUserListDataGridView()
        {
            dgv_UserList.Columns[0].HeaderText = "No";
            dgv_UserList.Columns[0].Width = 30;
            dgv_UserList.Columns[0].ReadOnly = true;

            dgv_UserList.Columns[1].Visible = false;

            dgv_UserList.Columns[2].HeaderText = "Full Name";
            dgv_UserList.Columns[2].Width = 160;
            dgv_UserList.Columns[2].ReadOnly = true;

            dgv_UserList.Columns[3].HeaderText = "Login Name";
            dgv_UserList.Columns[3].Width = 140;
            dgv_UserList.Columns[3].ReadOnly = true;

            dgv_UserList.Columns[4].HeaderText = "Password";
            dgv_UserList.Columns[4].Width = 140;
            dgv_UserList.Columns[4].ReadOnly = true;

            dgv_UserList.Columns[5].Visible = false;
            dgv_UserList.Columns[6].Visible = false;
            dgv_UserList.Columns[7].Visible = false;
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private Boolean ValidataUserInput()
        {
            string str_Password = txt_Password.Text;
            string str_ConfirmPassword = txt_ConfirmPassword.Text;
            
            bool bool_Test = true;

            if (txt_Name.Text.Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_Name, "Enter UserName");
                string str_error = ErrorProvider.GetError(txt_Name);
                MessageBox.Show(str_error);
            }
            else if (txt_LoginName.Text.Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_LoginName, "Enter LoginName");
                string str_error = ErrorProvider.GetError(txt_LoginName);
                MessageBox.Show(str_error);
            }
            else if( user.UserId == Guid.Empty  && checkUserExistedOrNot(txt_LoginName.Text))
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_LoginName, "LoginName already Existed. Please Choose Another");
                string str_error = ErrorProvider.GetError(txt_LoginName);
                MessageBox.Show(str_error);
            }
            else if (str_Password != str_ConfirmPassword)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_ConfirmPassword, "Password And ConfirmPassword does not Match");
                string str_error = ErrorProvider.GetError(txt_ConfirmPassword);
                MessageBox.Show(str_error);
            }
            
            ErrorProvider.Clear();
            return bool_Test;
        }

        private Boolean checkUserExistedOrNot(String str_LoginName)
        {
            DEUser user = new DEUser();
            user.LoginName = str_LoginName;

            DALUser obj_DALUser = new DALUser();

            Boolean bool_HasRow = obj_DALUser.LoadUserRowByLoginName(user);

            return bool_HasRow;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            addPermission();
        }

        private void addPermission()
        {
            Boolean check = true;

            Int32 int_PermissionId = Convert.ToInt32(dgv_ExistingPermission.CurrentRow.Cells[0].Value.ToString());
            String str_Permission = Convert.ToString(dgv_ExistingPermission.CurrentRow.Cells[1].Value.ToString());

            for (int i = 0; i < dgv_UserPermission.Rows.Count; i++)
            {
                if (int_PermissionId == Convert.ToInt32(dgv_UserPermission.Rows[i].Cells[0].Value.ToString()))
                {
                    check = false;
                }
            }

            if (check)
            {

                DataRow dr_UserPermission = dt_UserPermission.NewRow();
                dr_UserPermission[0] = int_PermissionId;
                dr_UserPermission[1] = str_Permission;
                dt_UserPermission.Rows.Add(dr_UserPermission);
            }

            dgv_UserPermission.DataSource = dt_UserPermission;

            FormatUserPermissionDataGridView();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            removePermission();
        }

        private void removePermission()
        {
            dt_UserPermission.Rows.RemoveAt(dgv_UserPermission.CurrentRow.Index);

            dgv_UserPermission.DataSource = dt_UserPermission;

            FormatUserPermissionDataGridView();
        }

        private void dgv_UserList_DoubleClick(object sender, EventArgs e)
        {
            user.UserId = new Guid(Convert.ToString(dgv_UserList.CurrentRow.Cells[1].Value));

            BLLUser obj_BLLUser = new BLLUser();
            bool bool_Result = obj_BLLUser.LoadUserRow(user);

            if (bool_Result == true)
            {
                DisplayData(user);

                dt_UserPermission = obj_BLLUser.LoadUserPermissionTableForAllDataByUserId(user);

                dgv_UserPermission.DataSource = dt_UserPermission;

                FormatUserPermissionDataGridView();

            }
            else
            {
                MessageBox.Show("Record is not found.");
            }

            obj_BLLUser = null;
        }

        private void DisplayData(DEUser user)
        {
            txt_Name.Text = user.Name;
            txt_LoginName.Text = user.LoginName;
            txt_Password.Text = user.Password;
            txt_ConfirmPassword.Text = user.Password;
        }

        private void dgv_ExistingPermission_DoubleClick(object sender, EventArgs e)
        {
            addPermission();
        }

        private void dgv_UserPermission_DoubleClick(object sender, EventArgs e)
        {
            removePermission();
        }
    }
}
