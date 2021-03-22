using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HocWeb2.Areas.Admin.Code
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["logginSession"] = session;

        }
        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["logginSession"];
            if (session == null)
            {
                return null;
            }
            else
            {
                return session as UserSession;
            }
        } 
    }

}