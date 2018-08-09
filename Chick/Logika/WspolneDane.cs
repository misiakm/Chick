using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Security;

namespace WD
{
    public static class WspolneDane
    {
        public static string GenerujKlucz()
        {
            return Membership.GeneratePassword(20, 0).Replace('%','A').Replace('&','B') + DateTime.Now.ToString("yyyyMMdd_hhmmss");
        }
    }
}