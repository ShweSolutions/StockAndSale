using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockAndSale
{
    public partial class CtrlProductInStore : UserControl
    {
        public CtrlProductInStore()
        {
            InitializeComponent();

            rdo_Normal.Checked = true;

            bindProductCatagoryCombo();

            FormatDataGridViewStyle();

            this.Search();
        }

        DataTable dt_ProductInStore;

        private void FormatDataGridViewStyle()
        {
            UIControl.FormatDataGridView(dgv_Result);
        }

        private void bindProductCatagoryCombo()
        {
            BLLCatagory obj_BLLCatagory = new BLLCatagory();
            DataTable dt_Catagory = obj_BLLCatagory.LoadCatagoryTableForAllData();

            cbx_Catagory.Items.Clear();
            cbx_Catagory.LoadingType = MTGCComboBox.CaricamentoCombo.DataTable;
            cbx_Catagory.SourceDataString = new string[] { "Catagory_Description", "Catagory_Id", "Catagory_Id", "Catagory_Id" };
            cbx_Catagory.ColumnNum = 3;
            cbx_Catagory.ColumnWidth = "150;0;0,0";
            cbx_Catagory.SourceDataTable = dt_Catagory;

            cbx_Catagory.Text = string.Empty;
        }

        private void Search()
        {            
            String product_Code = txt_ProductCode.Text;

            int int_CatagoryId = 0;

            if (cbx_Catagory.Text.Trim().Length == 0 || cbx_Catagory.SelectedValue == null)
            {
                int_CatagoryId = 0;
            }
            else
            {
                try
                {
                    int_CatagoryId = Convert.ToInt32(cbx_Catagory.SelectedItem.Col3);
                }
                catch (Exception ex)
                {
                    int_CatagoryId = 0;
                }
            }

            BLLProductInStore obj_BLLProductInStore = new BLLProductInStore();

            DataTable dt_Product;

            int int_noOfUnits;

            if (rdo_Normal.Checked == true)
            {

                try
                {
                    int_noOfUnits = Convert.ToInt32(txt_NoOfUnits.Text.ToString());

                    dt_Product = obj_BLLProductInStore.LoadProductInStoreTableForAllDataByCatagoryIdAndProductCodeAndNoOfUnits(int_CatagoryId, product_Code, int_noOfUnits);

                }
                catch (Exception ex)
                {
                    dt_Product = obj_BLLProductInStore.LoadProductInStoreTableForAllDataByCatagoryIdAndProductCode(int_CatagoryId, product_Code);
                }
                
            }
            else
            {
                dt_Product = obj_BLLProductInStore.LoadProductInStoreTableMRPModeForAllDataByCatagoryIdAndProductCode(int_CatagoryId, product_Code);
            }

            dgv_Result.DataSource = dt_Product;

            NumberingTableForDataGridView(dt_Product);

            this.dt_ProductInStore = dt_Product;

            FormatDataGridView();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.Search();
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
            dgv_Result.Columns[0].HeaderText = "No"; // No
            dgv_Result.Columns[0].Width = 50;
            dgv_Result.Columns[0].ReadOnly = true;

            dgv_Result.Columns[1].Visible = false; // Product_Id

            dgv_Result.Columns[2].HeaderText = "Product_Code"; // Product_Code
            dgv_Result.Columns[2].Width = 100;
            dgv_Result.Columns[2].ReadOnly = true;

            dgv_Result.Columns[3].HeaderText = "Product_Description"; // Product_Description
            dgv_Result.Columns[3].Width = 240;
            dgv_Result.Columns[3].ReadOnly = true;            

            dgv_Result.Columns[4].HeaderText = "Total No Of Units In Store"; // Total No Of Units In Store
            dgv_Result.Columns[4].Width = 180;
            dgv_Result.Columns[4].ReadOnly = true;

            dgv_Result.Columns[5].HeaderText = "No of Cartons In Store"; // No Of Cartons In Store
            dgv_Result.Columns[5].Width = 130;
            dgv_Result.Columns[5].ReadOnly = true;

            dgv_Result.Columns[6].HeaderText = "No of Units In Store"; // No Of Units In Store
            dgv_Result.Columns[6].Width = 130;
            dgv_Result.Columns[6].ReadOnly = true;

            dgv_Result.Columns[7].HeaderText = "No Of Units Per Carton"; // No Of Units Per Carton
            dgv_Result.Columns[7].Width = 130;
            dgv_Result.Columns[7].ReadOnly = true;

            dgv_Result.Columns[8].HeaderText = "Minimum Level"; // No Of Units Per Carton
            dgv_Result.Columns[8].Width = 130;
            dgv_Result.Columns[8].ReadOnly = true;

            dgv_Result.Columns[9].HeaderText = "Reorder Cartons"; // No Of Units Per Carton
            dgv_Result.Columns[9].Width = 130;
            dgv_Result.Columns[9].ReadOnly = true;
        }

        private void txt_ProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void cbx_Catagory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            Frm_ProductInStoreReport frm_ProductInStoreReport = new Frm_ProductInStoreReport(this.dt_ProductInStore);
            frm_ProductInStoreReport.ShowDialog();
        }

        private void txt_NoOfUnits_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);
        }

        private void txt_NoOfUnits_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void rdo_MRP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_Normal.Checked == true)
            {
                this.lbl_NoOfUnits.Visible = true;
                this.txt_NoOfUnits.Visible = true;
            }
            else
            {
                this.lbl_NoOfUnits.Visible = false;
                this.txt_NoOfUnits.Visible = false;
            }
        }

        private void rdo_Normal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        private void rdo_MRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
            }
        }

        /*
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            UIControl.KeyValidateForInteger(sender, e);    
        }
         * */

    }
}
