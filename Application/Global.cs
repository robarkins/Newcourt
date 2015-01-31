using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt
{
    public class Global
    {
        public static String Username { get; set; }
        public const String FKVIOLATIONMSG = "{0} {1} cannot be deleted as it is currently referenced by another record in the system!";

        public static void InitGlobalVariables(String username)
        {
            Username = username;
        }
    }
}
