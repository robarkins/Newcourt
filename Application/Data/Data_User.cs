using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_User
    {
        public String Username { get; set; }
        public String Password { get; set; }
        public String IsAdmin { get; set; }
        public DateTime? LastLoggedIn { get; set; }

        public static bool UserLogin(String username, String password)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return ctx.Users.FirstOrDefault(a => a.Username == username && a.Password == password) != null;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
