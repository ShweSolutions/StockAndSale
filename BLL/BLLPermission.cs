using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLPermission
    {
        public DataTable LoadPermissionTableForAllData()
        {
            DALPermission obj_DALPermission = new DALPermission();

            DataTable dt_Permission = obj_DALPermission.LoadPermissionTableForAllData();

            obj_DALPermission = null;

            return dt_Permission;
        }
    }
}
