using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_PaymentStaging
    {
        public String Username { get; set; }
        public int SuppplierId { get; set; }
        public decimal Amount { get; set; }
        public String FirstName { get; set; }
        public String Surname { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String Address5 { get; set; }
        public String SupplierTypeCode { get; set; }

        public static List<Data_PaymentStaging> GetPaymentStagingByUsername(String username)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.PaymentStaging
                            where a.Username == username
                            select new Data_PaymentStaging()
                            {
                                Username = a.Username,
                                SuppplierId = a.SupplierId,
                                Amount = a.Amount,
                                FirstName = a.Suppliers.FirstName,
                                Surname = a.Suppliers.Surname,
                                Address1 = a.Suppliers.Address1,
                                Address2 = a.Suppliers.Address2,
                                Address3 = a.Suppliers.Address3,
                                Address4 = a.Suppliers.Address4,
                                Address5 = a.Suppliers.Address5,
                                SupplierTypeCode = a.Suppliers.SupplierTypeCode
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SavePaymentStaging(String username, List<Data_PaymentStaging> payments)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    List<PaymentStaging> records = ctx.PaymentStaging.Where(a => a.Username == username).ToList();

                    foreach(var i in payments)
                    {
                        PaymentStaging current = records.FirstOrDefault(a => a.Username == i.Username && a.SupplierId == i.SuppplierId);

                        if (current != null)
                        {
                            current.Amount = i.Amount;
                        }
                        else
                        {
                            ctx.PaymentStaging.Add(new PaymentStaging()
                            {
                                Username = i.Username,
                                SupplierId = i.SuppplierId,
                                Amount = i.Amount
                            });
                        }
                    }

                    ctx.SaveChanges();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void DeleteFromPaymentStaging(String username, int supplierId)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    PaymentStaging payment = ctx.PaymentStaging.FirstOrDefault(a => a.Username == username && a.SupplierId == supplierId);

                    if (payment != null)
                    {
                        ctx.PaymentStaging.Remove(payment);
                        ctx.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public String Address
        {
            get
            {
                String addr = String.Empty;

                if (!String.IsNullOrWhiteSpace(Address1))
                {
                    addr += String.Format("{0}, ", Address1);
                }

                if (!String.IsNullOrWhiteSpace(Address2))
                {
                    addr += String.Format("{0}, ", Address2);
                }

                if (!String.IsNullOrWhiteSpace(Address3))
                {
                    addr += String.Format("{0}, ", Address3);
                }

                if (!String.IsNullOrWhiteSpace(Address4))
                {
                    addr += String.Format("{0}, ", Address4);
                }

                if (!String.IsNullOrWhiteSpace(Address5))
                {
                    addr += String.Format("{0}, ", Address5);
                }

                return addr.Substring(0, addr.Length - 2);
            }
        }
    }
}
