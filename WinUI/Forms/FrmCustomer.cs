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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }

        DataTable dt_Customer;

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            clearScreen();
            BindDataGridView();
            FormatDataGridViewStyle();
        }

        private void bindCatagoryCombo()
        {
            BLLCustomerCategory obj_BLLCatagory = new BLLCustomerCategory();
            DataTable dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllData();

            cbx_Catagory.Items.Clear();
            cbx_Catagory.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Catagory.SourceDataString = new string[] { "Catagory_Description", "Catagory_Id", "Catagory_Id", "Catagory_Id" };
            cbx_Catagory.ColumnNum = 3;
            cbx_Catagory.ColumnWidth = "150;0;0,0";
            cbx_Catagory.SourceDataTable = dt_Catagory;

            cbx_Catagory.Text = string.Empty;
        }

        private void BindDataGridView()
        {
            DECustomer customer = new DECustomer();

            BLLCustomer obj_BLLCustomer = new BLLCustomer();

            DataTable dt_Customer;

            if (txt_FilteredCustomerDescription.Text.Trim().Length <= 0)
            {
                dt_Customer = obj_BLLCustomer.LoadCustomerTableForAllData();
            }
            else
            {
                customer.Customer_Description = txt_FilteredCustomerDescription.Text;
                dt_Customer = obj_BLLCustomer.LoadCustomerTableForAllDataByCustomerDescription(customer);
            }

            dgv_Customer.DataSource = dt_Customer;

            this.dt_Customer = dt_Customer;

            NumberingTableForDataGridView(dt_Customer);

            FormatDataGridView();
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private void FormatDataGridView()
        {
            dgv_Customer.Columns[0].HeaderText = "No";
            dgv_Customer.Columns[0].Width = 50;
            dgv_Customer.Columns[0].ReadOnly = true;

            dgv_Customer.Columns[1].Visible = false; // Customer_Id

            dgv_Customer.Columns[2].HeaderText = "Customer Description"; // Customer_Description
            dgv_Customer.Columns[2].Width = 150;
            dgv_Customer.Columns[2].ReadOnly = true;

            dgv_Customer.Columns[3].HeaderText = "Address"; 
            dgv_Customer.Columns[3].Width = 250;
            dgv_Customer.Columns[3].ReadOnly = true;

            dgv_Customer.Columns[4].HeaderText = "Phone"; // Item Name
            dgv_Customer.Columns[4].Width = 150;
            dgv_Customer.Columns[4].ReadOnly = true;

            dgv_Customer.Columns[5].Visible = false;

            dgv_Customer.Columns[6].HeaderText = "Category"; // Item Name
            dgv_Customer.Columns[6].Width = 150;
            dgv_Customer.Columns[6].ReadOnly = true;

            dgv_Customer.Columns[7].Visible = false; // Active
            dgv_Customer.Columns[8].Visible = false; // ModifiedBy
            dgv_Customer.Columns[9].Visible = false; // ModifiedDate
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_Customer);
        }

        private void clearScreen()
        {
            txt_CustomerDescription.Tag = 0;
            txt_CustomerDescription.Text = string.Empty;
            txt_Address.Text = string.Empty;
            txt_PhoneNo.Text = string.Empty;
            //txt_FilteredCustomerDescription.Text = string.Empty;

            bindCatagoryCombo();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            clearScreen();           
        }

        private void AssignData(DECustomer customer)
        {
            customer.Customer_Id = Convert.ToInt32(txt_CustomerDescription.Tag);
            customer.Customer_Description = txt_CustomerDescription.Text.Trim();

            try
            {
                customer.Catagory_Id = Convert.ToInt32(cbx_Catagory.SelectedItem.Col3);
            }
            catch (Exception ex)
            {
                customer.Catagory_Id = 0;
            }

            customer.Address = txt_Address.Text;
            customer.Phone = txt_PhoneNo.Text;
            customer.ModifiedBy = DEGlobal.str_UserName;
        }

        private void save()
        {
            DECustomer customer = new DECustomer();
            AssignData(customer);

            BLLCustomer obj_BLLCustomer = new BLLCustomer();
            try
            {
                int int_Result = obj_BLLCustomer.InsertData(customer);

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
                customer = null;
                obj_BLLCustomer = null;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                this.save();
            }
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            if (txt_CustomerDescription.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_CustomerDescription, "Enter Customer Description");
                string str_error = ErrorProvider.GetError(txt_CustomerDescription);
                MessageBox.Show(str_error);
            }
            else if (cbx_Catagory.Text.Trim().Length == 0 || cbx_Catagory.SelectedValue == null)
            {
                bool_Test = false;
                ErrorProvider.SetError(cbx_Catagory, "Please Select Customer Catagory");
                string str_error = ErrorProvider.GetError(cbx_Catagory);
                MessageBox.Show(str_error);
            }

            ErrorProvider.Clear();
            return bool_Test;
        }

        private void txt_FilteredCustomerDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataGridView();
            }
        }

        private void dgv_Customer_DoubleClick(object sender, EventArgs e)
        {
            DECustomer customer = new DECustomer();
            customer.Customer_Id = Convert.ToInt32(dgv_Customer.CurrentRow.Cells[1].Value);

            BLLCustomer obj_BLLCustomer = new BLLCustomer();
            bool bool_Result = obj_BLLCustomer.LoadCustomerRow(customer);

            if (bool_Result == true)
            {
                DisplayData(customer);
            }
            else
            {
                MessageBox.Show("Record is not found.");
            }

            customer = null;
            obj_BLLCustomer = null;
        }

        private void DisplayData(DECustomer customer)
        {
            txt_CustomerDescription.Tag = customer.Customer_Id;
            txt_CustomerDescription.Text = customer.Customer_Description;
            txt_Address.Text = customer.Address;
            txt_PhoneNo.Text = customer.Phone;
            cbx_Catagory.SelectedValue = customer.Catagory_Id.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Customer.CurrentRow != null)
            {
                DialogResult Colse_Result;
                Colse_Result = MessageBox.Show(" Are you sure you want to Delete ?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Colse_Result == DialogResult.Yes)
                {
                    DECustomer customer = new DECustomer();
                    customer.Customer_Id = Convert.ToInt32(dgv_Customer.CurrentRow.Cells[1].Value);
                    customer.Active = false;

                    BLLCustomer obj_BLLCustomer = new BLLCustomer();

                    int int_Result = obj_BLLCustomer.UpdateCustomerOnlyActiveByCustomerId(customer);

                    if (int_Result > 0)
                    {
                        //MessageBox.Show("Delete Successfully");
                        BindDataGridView();
                    }

                    obj_BLLCustomer = null;
                    customer = null;
                } 
                
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Frm_CustomerReport frm_CustomerReport = new Frm_CustomerReport(this.dt_Customer);

            frm_CustomerReport.ShowDialog();
        }
    }
}
