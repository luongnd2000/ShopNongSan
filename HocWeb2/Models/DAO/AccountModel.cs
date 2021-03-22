using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HocWeb2.Models
{
    public class AccountModel
    {
        private QuanLyShop_Context context = null;
        public AccountModel()
        {
            context = new QuanLyShop_Context();
        }
        public bool Login(string username,string password)
        {
            object[] sqlParam=
            {
                new SqlParameter("@UserName",username),
                new SqlParameter("@Passw",password)
            };

            var res = context.Database.SqlQuery<bool>("Sp_Account_login @UserName,@Passw",sqlParam).SingleOrDefault();
            return res;
        }
    }
}