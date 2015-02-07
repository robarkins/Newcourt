using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt
{
    public class Common
    {
        public const String KEY_USERLOGIN = "UserLogin";
        public const String KEY_WINDOWSTATE = "WindowState";

        public enum FormMode
        {
            Add = 1,
            Edit = 2,
            View = 3
        }
    }
}
