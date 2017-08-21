using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

namespace StockAndSale
{
    public partial class FrmBackupDatabase : Form
    {
        public FrmBackupDatabase()
        {
            InitializeComponent();
        }

        String str_Name = string.Empty;

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            fldBrowser.ShowDialog();
            str_Name = fldBrowser.SelectedPath;
            lbl_FileLocation.Visible = true;
            lbl_FileLocation.Text = str_Name;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            if (str_Name != string.Empty)
            {
                DEDataBackUp DataBackUp = new DEDataBackUp();
                BLLDataBackUp obj_BLLDataBackUp = new BLLDataBackUp();
                try
                {
                    // Set Minimum to 1 to represent the first file being copied.
                    ProBar.Minimum = 1;
                    // Set Maximum to the total number of Users created.
                    ProBar.Maximum = 4;
                    // Set the initial value of the ProgressBar.
                    ProBar.Value = 1;
                    // Set the Step property to a value of 1 to represent each user is being created.
                    ProBar.Step = 1;
                    ProBar.PerformStep();
                    DataBackUp.DBBackUpName = ConfigurationManager.AppSettings.Get("DBBackUpName");
                    DataBackUp.DBBackupFilePath = str_Name + "\\"+DateTime.Today.ToLongDateString()+ "StockAndSale.bak";
                    int int_Result = obj_BLLDataBackUp.CreateDBBackupFile(DataBackUp);
                    ProBar.PerformStep();
                    label9.Visible = true;
                    label9.Text = "Data Backup is Successfully Saved In" + "  " + DataBackUp.DBBackupFilePath;
                    label9.ForeColor = System.Drawing.Color.Blue;
                    ProBar.Maximum = 3;
                }
                catch (Exception ex)
                {
                    label9.Visible = true;
                    label9.Text = ex.Message;
                    label9.ForeColor = System.Drawing.Color.Red;
                }
                finally
                {
                    obj_BLLDataBackUp = null;
                }
            }
            else
            {
                label9.Visible = true;
                label9.Text = "Choose Folder Name";
                label9.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
