using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StockAndSale
{
    class BLLUser
    {
        public int InsertData(DEUser user, DataTable dt_Permission)
        {
            DALUser obj_DALUser = new DALUser();

            int int_Result = obj_DALUser.InsertData(user, dt_Permission);

            obj_DALUser = null;

            return int_Result;
        }

        public Boolean LoadUserRowByLoginName(DEUser user)
        {
            DALUser obj_DALUser = new DALUser();

            Boolean bool_HasRow = obj_DALUser.LoadUserRowByLoginName(user);

            obj_DALUser = null;

            return bool_HasRow;
        }

        public Boolean LoadUserRow(DEUser user)
        {
            DALUser obj_DALUser = new DALUser();

            Boolean bool_HasRow = obj_DALUser.LoadUserRow(user);

            obj_DALUser = null;

            return bool_HasRow;
        }

        public DataTable LoadUserPermissionTableForAllDataByUserId(DEUser user)
        {
            DALUser obj_DALUser = new DALUser();

            DataTable dt_User = obj_DALUser.LoadUserPermissionTableForAllDataByUserId(user);

            obj_DALUser = null;

            return dt_User;
        }

        public DataTable LoadUserTableForAllData()
        {
            DALUser obj_DALUser = new DALUser();

            DataTable dt_User = obj_DALUser.LoadUserTableForAllData();

            obj_DALUser = null;

            return dt_User;
        }

        public Boolean LoadUserByLoginNameAndPassword(DEUser User)
        {
            DALUser obj_DALUser = new DALUser();

            Boolean bool_HasRow = obj_DALUser.LoadUserByLoginNameAndPassword(User);

            obj_DALUser = null;

            return bool_HasRow;
        }

        public int UpdateData(DEUser user, DataTable dt_Permission)
        {
            DALUser obj_DALUser = new DALUser();

            int int_Result = obj_DALUser.UpdateData(user, dt_Permission);

            obj_DALUser = null;

            return int_Result;
        }
    }
}
