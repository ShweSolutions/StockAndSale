using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Management;
using System.Text;
using System.Net.NetworkInformation;

namespace StockAndSale
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       /// This is Testing Comment to commit to Git
        [STAThread]
        static void Main()
        {
            StreamReader SR;
            string S;
            try
            {
                SR = File.OpenText("D:\\Serial.txt");
                S = SR.ReadLine();
                // MessageBox.Show(S);                   
                SR.Close();

                if (check(S))
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new FrmTechanicianReport());
                    Application.Run(new FrmMain());
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    //Application.Run(new FrmTechanicianReport());
                    Application.Run(new FrmMain());
                }
            }
            catch (FileNotFoundException fnfe)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                //Application.Run(new FrmTechanicianReport());
                Application.Run(new FrmMain());
            }

        }

        private static char ChangeCharForCheck(char c)
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

        private static string GetMACAddress()
        {
            string macAddresses = "";
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                //if (nic.OperationalStatus == OperationalStatus.Up)
                //{
                macAddresses = nic.GetPhysicalAddress().ToString();
                break;
                //}
            }

            return macAddresses;
        }

        private static Boolean check(string str_Serial)
        {
            Boolean check;

            string str_MACAddress = GetMACAddress();
            string str_FullCPUID = getID();
            string str_4CPUID = str_FullCPUID.Substring((str_FullCPUID.Length - 4), 4);

            string str_CPUID = str_MACAddress + str_4CPUID;

            StringBuilder stb_Temp = new StringBuilder();

            for (int i = 0; i < str_Serial.Length; i++)
            {
                char c = Program.ChangeCharForCheck(str_Serial[i]);
                stb_Temp.Insert(i, c);
            }

            if (str_CPUID.Equals(stb_Temp.ToString()))
                check = true;

            else check = false;


            return check;
        }

        private static String getID()
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
    }
}
