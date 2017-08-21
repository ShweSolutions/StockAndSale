using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace StockAndSale
{
    public class UIControl
    {
        public static void FormatDataGridView(System.Windows.Forms.DataGridView dgvDataGridView)
        {

            dgvDataGridView.RowHeadersWidth = 25;
            dgvDataGridView.BackgroundColor =System.Drawing.Color.LightSteelBlue;
                //FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            dgvDataGridView.BorderStyle = BorderStyle.None;
            //dgvDataGridView.RowHeadersVisible = false;
            dgvDataGridView.BackColor = System.Drawing.Color.LightSteelBlue;
            //FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            dgvDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
               // FromArgb(((int)(((byte)(124)))), ((int)(((byte)(186)))), ((int)(((byte)(209)))));
            dgvDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dgvDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black ;
            dgvDataGridView.AllowUserToAddRows = false;
            dgvDataGridView.AllowUserToDeleteRows = false;

        }

        public static string FormatNrc(string CustomerNrc)
        {
            string nrc = CustomerNrc;

            int start_index = nrc.IndexOf('(');
            int end_index = nrc.IndexOf(')');
            int length = end_index - start_index;

            nrc = nrc.Remove(start_index, length + 1);
            string naing = "(N)";
            nrc = nrc.Insert(nrc.Length - 6, naing);

            while (nrc.Contains(" "))
            {
                int index = nrc.IndexOf(' ');
                nrc = nrc.Remove(index, 1);
            }

            return nrc;
        }

        public static Boolean ValidateForNrc(string nrc)
        {
            Boolean check = false;
            if ((nrc.Contains("/")) && (nrc.Contains("(")) && (nrc.Contains(")")))
            {
                try
                {
                    string str_Location = nrc.Substring(0, 1);
                    int location = Convert.ToInt32(str_Location);
                    string str_number = nrc.Substring(nrc.Length - 6, 6);                    
                    int int_number = Convert.ToInt32(str_number);
                    check = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("error" + ex);
                }
            }

            return check;
        }


        public static string ThousandsSeparatorFormat(string str_Content)
        {
            string str_Minus = str_Content;
            string str_DecimalIndex = "";
            if (str_Content.Trim().Length != 0)
            {
                int int_Index = str_Content.IndexOf(".");
                if (int_Index > 0)
                {
                    str_DecimalIndex = str_Content.Substring(str_Content.IndexOf("."));
                    str_Content = str_Content.Replace(str_DecimalIndex, "");
                }
                str_Content = str_Content.Replace("-", "");
                str_Content = str_Content.Replace(",", "");
                int len = str_Content.Length;

                if (len > 3)
                {
                    str_Content = str_Content.Insert(len - 3, ",");
                    len = len - 3;
                    while (len > 3)
                    {
                        str_Content = str_Content.Insert(len - 3, ",");
                        len = len - 3;
                    }
                }
            }
            if (str_Minus.Contains("-") == true)
                str_Content = "-" + str_Content;
            return str_Content;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public static void KeyValidateForInteger(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar != (Char)Keys.Back && e.KeyChar.ToString() != "0" && e.KeyChar.ToString() != "1" && e.KeyChar.ToString() != "2" && e.KeyChar.ToString() != "3" && e.KeyChar.ToString() != "4" && e.KeyChar.ToString() != "5" && e.KeyChar.ToString() != "6" && e.KeyChar.ToString() != "7" && e.KeyChar.ToString() != "8" && e.KeyChar.ToString() != "9")
            {
                e.Handled = true;
            }
        }

        public static void KeyValidateForDecimal(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() != "." && e.KeyChar != (Char)Keys.Back && e.KeyChar.ToString() != "0" && e.KeyChar.ToString() != "1" && e.KeyChar.ToString() != "2" && e.KeyChar.ToString() != "3" && e.KeyChar.ToString() != "4" && e.KeyChar.ToString() != "5" && e.KeyChar.ToString() != "6" && e.KeyChar.ToString() != "7" && e.KeyChar.ToString() != "8" && e.KeyChar.ToString() != "9")
            {
                e.Handled = true;
            }
            if (e.KeyChar.ToString() == ".")
            {
                int int_Index = ((TextBox)sender).Text.IndexOf(".");
                if (int_Index != -1)
                {
                    e.Handled = true;
                }
            }
        }

        public static void AllowAllKey(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            e.Handled = false;
        }

    }
}
