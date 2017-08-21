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
    public partial class FrmCatagory : Form
    {
        public FrmCatagory()
        {
            InitializeComponent();
        }

        private void FrmCatagory_Load(object sender, EventArgs e)
        {
            clearScreen();
            BindDataGridView();
            FormatDataGridViewStyle();
        }

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_Catagory);
        }

        private void clearScreen()
        {
            txt_CatagoryDescription.Tag = 0;
            txt_CatagoryDescription.Text = string.Empty;
            txt_FilteredDescription.Text = string.Empty;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_CatagoryDescription.Tag = 0;
            txt_CatagoryDescription.Text = string.Empty;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                this.save();
            }
        }

        private void AssignData(DECatagory catagory)
        {
            catagory.Catagory_Id = Convert.ToInt32(txt_CatagoryDescription.Tag);
            catagory.Catagory_Description = txt_CatagoryDescription.Text.Trim();
            catagory.ModifiedBy = DEGlobal.str_UserName;
        }

        private void save()
        {
            DECatagory catagory = new DECatagory();
            AssignData(catagory);

            BLLCatagory obj_BLLCatagory = new BLLCatagory();
            try
            {
                int int_Result = obj_BLLCatagory.InsertData(catagory);

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
                catagory = null;
                obj_BLLCatagory = null;
            }
        }

        private void BindDataGridView()
        {
            DECatagory catagory = new DECatagory();

            BLLCatagory obj_BLLCatagory = new BLLCatagory();

            DataTable dt_Catagory;           

            if (txt_FilteredDescription.Text.Trim().Length <= 0)
            {
                dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllData();           
            }
            else
            {
                catagory.Catagory_Description = txt_FilteredDescription.Text;
                dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllDataByCatagoryDescription(catagory);
            }

            dgv_Catagory.DataSource = dt_Catagory;

            NumberingTableForDataGridView(dt_Catagory);

            FormatDataGridView();
        }

        private void FormatDataGridView()
        {
            dgv_Catagory.Columns[0].HeaderText = "No";
            dgv_Catagory.Columns[0].Width = 60;
            dgv_Catagory.Columns[0].ReadOnly = true;

            dgv_Catagory.Columns[1].Visible = false; // Catagory_Id

            dgv_Catagory.Columns[2].HeaderText = "Category Description"; // Item Name
            dgv_Catagory.Columns[2].Width = 450;
            dgv_Catagory.Columns[2].ReadOnly = true;

            dgv_Catagory.Columns[3].Visible = false; // Active
            dgv_Catagory.Columns[4].Visible = false; // ModifiedBy
            dgv_Catagory.Columns[5].Visible = false; // ModifiedDate
        }

        private void NumberingTableForDataGridView(DataTable dt_Temp)
        {
            for (int i = 0; i < dt_Temp.Rows.Count; i++)
            {
                dt_Temp.Rows[i][0] = i + 1;
            }
        }

        private Boolean ValidateUserInput()
        {
            bool bool_Test = true;

            if (txt_CatagoryDescription.Text.Trim().Length == 0)
            {
                bool_Test = false;
                ErrorProvider.SetError(txt_CatagoryDescription, "Enter Catagory Description");
                string str_error = ErrorProvider.GetError(txt_CatagoryDescription);
                MessageBox.Show(str_error);
            }           

            ErrorProvider.Clear();
            return bool_Test;
        }

        private void txt_FilteredDescription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BindDataGridView();
            }
        }

        private void dgv_Catagory_DoubleClick(object sender, EventArgs e)
        {
            DECatagory catagory = new DECatagory();
            catagory.Catagory_Id = Convert.ToInt32(dgv_Catagory.CurrentRow.Cells[1].Value);

            BLLCatagory obj_BLLCatagory = new BLLCatagory();
            bool bool_Result = obj_BLLCatagory.LoadCatagoryRow(catagory);

            if (bool_Result == true)
            {                
                DisplayData(catagory);
            }
            else
            {
                MessageBox.Show("Record is not found.");
            }

            catagory = null;
            obj_BLLCatagory = null;
        }

        private void DisplayData(DECatagory catagory)
        {
            txt_CatagoryDescription.Tag = catagory.Catagory_Id;
            txt_CatagoryDescription.Text = catagory.Catagory_Description;
        }

    }
}
