#region  +++ Source Code Information  +++
/*
	Project Name	:	HRMSWIN
	Project Type	:	Class Library
	Code Platform	:	Microsoft Visual C#.NET
	File Name		:	ClsUIGlobal.cs
	Summary			:	Global variable predefined
	Reference		:   
	
	Change History
	==============
	Date					Update Description				Update By
	------------------------------------------------------------------
	12 Sep 2006				Include ObjectItem Class		Myat Ko Ko
	------------------------------------------------------------------
	Copyright 2005-2007 HICOM Co., Ltd.  All rights reserved.	
*/
#endregion
using System;
using System.Data;
using System.Collections;


namespace StockAndSale
{
    public class UIGlobal
    {
        public static int g_intID = 0;

          public static int int_TripID=0;

        public static string g_strString = string.Empty;

        public static string err_message = string.Empty;

        /// <summary>
        /// Default variable for NULL Date fields
        /// </summary>
        public static int g_intCurrentLogInUser = 0;

        public static int Temp_TechnicianService = 0;

        public static DateTime dateTime_StartDate = DEGlobal.dateTime_DefaultDate;

        public static DateTime dateTime_EndDate = DEGlobal.dateTime_DefaultDate;
      
    }
}




