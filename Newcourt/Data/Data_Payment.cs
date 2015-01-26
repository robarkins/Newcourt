using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    class Data_Payment
    {
        public int PaymentID { get; set; }
        public int SupplierID { get; set; }
        public String BankAccountCode { get; set; }
        public String Username { get; set; }
        public decimal Amount { get; set; }
        public DateTime? TimeProcessed { get; set; }

        public static void SavePayments(List<Data_Payment> payments)
        {
            try
            { 
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    // Delete unprocessed payments for current user before saving new ones
                    DeleteUnprocessedPayments(Global.Username);

                    foreach(var i in payments)
                    {
                        ctx.Payments.Add(new Payments()
                        {
                            SupplierID = i.SupplierID,
                            BankAccountCode = i.BankAccountCode,
                            Username = i.Username,
                            Amount = i.Amount
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

        public static void DeleteUnprocessedPayments(String username)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    List<Payments> payments = ctx.Payments.Where(a => a.Username == username && a.TimeProcessed == null).ToList();

                    if (payments != null)
                    {
                        foreach(var i in payments)
                        {
                            ctx.Payments.Remove(i);
                            ctx.SaveChanges();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
