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
        public bool IsAdmin { get; set; }
        public DateTime? LastLoggedIn { get; set; }

        public static List<Data_User> GetUsers()
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Users
                            select new Data_User()
                            {
                                Username = a.Username, 
                                Password = a.Password,
                                IsAdmin = a.IsAdmin == 1,
                                LastLoggedIn = a.LastLoggedIn
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static Data_User GetUserByUsername(String username)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Users
                            where a.Username == username
                            select new Data_User()
                            {
                                Username = a.Username,
                                Password = a.Password,
                                IsAdmin = a.IsAdmin == 1,
                                LastLoggedIn = a.LastLoggedIn
                            }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Data_User GetUser(String username, String password)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Users
                            where a.Username == username && a.Password == password
                            select new Data_User()
                            {
                                Username = a.Username,
                                Password = a.Password,
                                IsAdmin = a.IsAdmin == 1,
                                LastLoggedIn = a.LastLoggedIn
                            }).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveUser(Data_User user)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    Users record = ctx.Users.FirstOrDefault(a => a.Username == user.Username);

                    if (record != null)
                    {
                        record.Password = user.Password;
                        record.IsAdmin = user.IsAdmin ? (byte)1 : (byte)0;
                    }
                    else
                    {
                        ctx.Users.Add(new Users()
                        {
                            Username = user.Username,
                            Password = user.Password,
                            IsAdmin = user.IsAdmin ? (byte)1 : (byte)0
                        });
                    }

                    ctx.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
