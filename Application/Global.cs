using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt
{
    public class Global
    {
        public const String FKVIOLATIONMSG = "{0} {1} cannot be deleted as it is currently referenced by another record in the system!";
        public const String DBVERSION = "1.0.0.1";

        public static String Username { get; set; }
        public static bool IsAdmin { get; set; }

        public static void InitGlobalVariables(String username, bool isAdmin)
        {
            Username = username;
            IsAdmin = isAdmin;
        }
    }
}