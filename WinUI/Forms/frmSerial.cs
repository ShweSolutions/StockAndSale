using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.IO;
using System.Net.NetworkInformation;

namespace StockAndSale
{
    public partial class frmSerial : Form
    {
        public frmSerial()
        {
            InitializeComponent();
        }


        StringBuilder stb_Serial = new StringBuilder();
        StringBuilder stb_Text = new StringBuilder();
        StringBuilder stb_ttt = new StringBuilder();

        private string GetMACAddress()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                //if (nic.OperationalStatus == OperationalStatus.Down)
                //{
                    macAddresses = nic.GetPhysicalAddress().ToString();
                    break;
                //}
            }

            return macAddresses;
        }


        private void frmSerial_Load(object sender, EventArgs e)
        {
            string str_MACAddress = GetMACAddress();
            string str_FullCPUID = getID();
            string str_4CPUID = str_FullCPUID.Substring((str_FullCPUID.Length - 4), 4);

            string str_CPUID = str_MACAddress + str_4CPUID;


            for (int i = 0; i < str_CPUID.Length; i++)
            {
                char c = ChangeCharForTest(str_CPUID[i]);
                stb_Text.Insert(i, c);
            }

            stb_Text.Insert(4, '-');
            stb_Text.Insert(9, '-');
            stb_Text.Insert(14, '-');

            this.lbl_GeneratedCode.Text = stb_Text.ToString();


        }

        private char ChangeCharForTest(char c)
        {
            int int_ascii = c;
            char ch = '\0';
            if (int_ascii >= 65 && int_ascii <= 90)
            {
                //int int_ascii = c;
                int_ascii += 7;
                if (int_ascii > 90) { int_ascii = int_ascii - 90 - 1 + 65; }
                else if (int_ascii < 65) { int_ascii = int_ascii - 65 + 90 + 1; }

                ch = Convert.ToChar(int_ascii);
            }
            else if (int_ascii >= 48 && int_ascii <= 57)
            {
                // int int_ascii = c;
                int_ascii += 3;
                if (int_ascii > 57) { int_ascii = int_ascii - 57 - 1 + 48; }
                else if (int_ascii < 48) { int_ascii = int_ascii - 48 + 57 + 1; }
                ch = Convert.ToChar(int_ascii);
            }
            else if (int_ascii >= 97 && int_ascii <= 122)
            {
                // int int_ascii = c;
                int_ascii += 5;
                if (int_ascii > 122) { int_ascii = int_ascii - 122 - 1 + 97; }
                else if (int_ascii < 97) { int_ascii = int_ascii - 97 + 122 + 1; }
                ch = Convert.ToChar(int_ascii);
            }

            return ch;
        }


        private String getID()
        {

            ManagementObjectCollection mbsList = null;
            ManagementObjectSearcher mbs = new ManagementObjectSearcher("Select * From Win32_processor");
            mbsList = mbs.Get();
            string id = "";
            foreach (ManagementObject mo in mbsList)
            {
                id = mo["ProcessorID"].ToString();
            }

            return id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txt_Serial1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.Alt || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back) { }
            else
            {
                if (this.txt_Serial1.Text.Length >= 3) this.btn_Activate.Focus();
            }
        }

        private void txt_Serial2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.Alt || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back) { }
            else
            {
                if (this.txt_Serial2.Text.Length >= 3) this.txt_Serial3.Focus();
            }
        }

        private void txt_Serial3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.Alt || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back) { }
            else
            {
                if (this.txt_Serial3.Text.Length >= 3) this.txt_Serial1.Focus();
            }
        }

        private void txt_Serial4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Shift || e.KeyCode == Keys.ShiftKey || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.LShiftKey || e.KeyCode == Keys.RShiftKey || e.KeyCode == Keys.Alt || e.KeyCode == Keys.ControlKey || e.KeyCode == Keys.Control || e.KeyCode == Keys.CapsLock || e.KeyCode == Keys.Tab || e.KeyCode == Keys.Back) { }
            else
            {
                if (this.txt_Serial4.Text.Length >= 3) this.txt_Serial2.Focus();
            }
        }

        private void btn_Activate_Click(object sender, EventArgs e)
        {
            if (txt_Serial1.Text.Length <= 0 || txt_Serial2.Text.Length <= 0 || txt_Serial3.Text.Length <= 0 || txt_Serial4.Text.Length <= 0)
            {
                MessageBox.Show("Please enter serial number Completely");
            }
            else
            {
                if (check())
                {
                    StringBuilder stb_Serial = new StringBuilder();

                    stb_Serial.Insert(0, txt_Serial1.Text);
                    stb_Serial.Insert(4, txt_Serial2.Text);
                    stb_Serial.Insert(8, txt_Serial3.Text);
                    stb_Serial.Insert(12, txt_Serial4.Text);

                    WriteToFile(stb_Serial.ToString());                    
                    FrmMain frm_Main = new FrmMain();
                    frm_Main.Show();

                    this.Hide();                    
                    
                }
                else MessageBox.Show("Invalid ! Check back your serial code");
            }
        }

        private void WriteToFile(string str_Serial)
        {
            StreamWriter SW;
            SW = File.CreateText("D:\\Serial.txt");           
            //string str_Serial = this.stb_ttt.ToString();
            //SW.WriteLine("God is greatest of them all");
            SW.WriteLine(str_Serial);
            string str_FilePath = @"D:\\Serial.txt";

            File.SetAttributes(str_FilePath, FileAttributes.ReadOnly | FileAttributes.Hidden | FileAttributes.System);
                    

            SW.Close();
            
        }

        private Boolean check()
        {
            Boolean check;           

            stb_ttt.Insert(0, txt_Serial1.Text);
            stb_ttt.Insert(4, txt_Serial2.Text);
            stb_ttt.Insert(8, txt_Serial3.Text);
            stb_ttt.Insert(12, txt_Serial4.Text);

            string str_MACAddress = GetMACAddress();
            string str_FullCPUID = getID();
            string str_4CPUID = str_FullCPUID.Substring((str_FullCPUID.Length - 4), 4);

            string str_CPUID = str_MACAddress + str_4CPUID;

            string str_ForTest = stb_ttt.ToString();
            StringBuilder stb_Check = new StringBuilder();

            for (int i = 0; i < str_ForTest.Length; i++)
            {
                char c = ChangeCharForCheck(str_ForTest[i]);
                stb_Check.Insert(i, c);
            }

            if (str_CPUID.Equals(stb_Check.ToString()))
                check = true;

            else check = false;

            stb_ttt.Remove(0, stb_ttt.Length);


            return check;
        }

        private char ChangeCharForCheck(char c)
        {
            int int_ascii = c;
            char ch = '\0';
            if (int_ascii >= 65 && int_ascii <= 90)
            {
                //int int_ascii = c;
                int_ascii -= 15;
                if (int_ascii > 90) { int_ascii = int_ascii - 90 - 1 + 65; }
                else if (int_ascii < 65) { int_ascii = int_ascii - 65 + 90 + 1; }

                ch = Convert.ToChar(int_ascii);
            }
            else if (int_ascii >= 48 && int_ascii <= 57)
            {
                // int int_ascii = c;
                int_ascii -= 7;
                if (int_ascii > 57) { int_ascii = int_ascii - 57 - 1 + 48; }
                else if (int_ascii < 48) { int_ascii = int_ascii - 48 + 57 + 1; }
                ch = Convert.ToChar(int_ascii);
            }
            else if (int_ascii >= 97 && int_ascii <= 122)
            {
                // int int_ascii = c;
                int_ascii -= 15;
                if (int_ascii > 122) { int_ascii = int_ascii - 122 - 1 + 97; }
                else if (int_ascii < 97) { int_ascii = int_ascii - 97 + 122 + 1; }
                ch = Convert.ToChar(int_ascii);
            }

            return ch;
        }

    }
}
