using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    public class DEGlobal
    {

        /// <summary>
        /// Globally Default DateTime value for the whole project
        /// </summary>
        public static DateTime dateTime_DefaultDate = new DateTime(1900, 1, 1);

        public static Int32 int16_UserID = 0;
        public static string str_UserName = string.Empty;
        public static Int32 int16_UserRoleID = 0;
        public static string str_UserRole = string.Empty;

        public static DataTable dt_UserPermission = new DataTable();

        public static Boolean bool_ProductManagement = false;
        public static Boolean bool_CatagoryManagement = false;
        public static Boolean bool_CustomerManagement = false;
        public static Boolean bool_CreateCash = false;
        public static Boolean bool_CreateCredit = false;
        public static Boolean bool_CreateConsign = false;
        public static Boolean bool_EditCash = false;
        public static Boolean bool_EditCredit = false;
        public static Boolean bool_EditConsign = false;
        public static Boolean bool_NewArrival = false;
        public static Boolean bool_EditArrival = false;
        public static Boolean bool_UserManagement = false;
        public static Boolean bool_DataBaseBackup = false;
        public static Boolean bool_CancelInvoice = false;

        /// <summary>
        /// Globally Today DateTime value for the whole project
        /// </summary>
        public static DateTime dateTime_ToDayDate = DateTime.Today;

        public static int GetWeeksInMonth(DateTime dt_MonthAndYear)
        {
            object index = dt_MonthAndYear;
            int res = 0;
            //0    First day of year
            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstDay, System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);

            //1    (Default) First four day week from Sunday
            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
            Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Sunday);

            //2    First four day week from StartOfWeek
            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                    Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstFourDayWeek, System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);

            //3    First full week from Sunday
            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                    Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstFullWeek, DayOfWeek.Sunday);

            //4    First full week from StartOfWeek
            res = System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                    Convert.ToDateTime(index), System.Globalization.CalendarWeekRule.FirstFullWeek, System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek);

            return res;
        }

        public static int GetDaysInMonth(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                throw new System.ArgumentOutOfRangeException("month", month, "month must  be between 1 and 12");
            }
            if (1 == month || 3 == month || 5 == month || 7 == month || 8 == month ||
            10 == month || 12 == month)
            {
                return 31;
            }
            else if (2 == month)
            {
                // Check for leap year
                if (0 == (year % 4))
                {
                    // If date is divisible by 400, it's a leap year.
                    // Otherwise, if it's divisible by 100 it's not.
                    if (0 == (year % 400))
                    {
                        return 29;
                    }
                    else if (0 == (year % 100))
                    {
                        return 28;
                    }

                    // Divisible by 4 but not by 100 or 400
                    // so it leaps
                    return 29;
                }
                // Not a leap year
                return 28;
            }
            return 30;
        }

        public static DateTime GetDateByDayWeekMonthYear(int Day, int Week, int Month, int Year)
        {
            DateTime dt_dateValue = new DateTime(Year, Month, 1);
            int firstDay = (int)dt_dateValue.DayOfWeek;
            dt_dateValue = dt_dateValue.AddDays(Day - firstDay + (Week - 1) * 7);

            return dt_dateValue;
        }

    }
}
