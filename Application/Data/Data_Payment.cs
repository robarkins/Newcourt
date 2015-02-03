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
        public DateTime TimeProcessed { get; set; }
        public String FirstName { get; set; }
        public String Surname { get; set; }
        public String SupplierTypeCode { get; set; }

        public static List<Data_Payment> GetPayments(String username, int supplierId, String supplierTypeCode, String bankAccountCode, DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Payments
                            where (a.Username == username || username == String.Empty) && 
                            (a.SupplierID == supplierId || supplierId == 0) &&
                            (a.Suppliers.SupplierTypeCode == supplierTypeCode || supplierTypeCode == String.Empty) &&
                            (a.TimeProcessed >= dateFrom && a.TimeProcessed < dateTo)
                            select new Data_Payment()
                            {
                                PaymentID = a.PaymentID,
                                SupplierID = a.SupplierID,
                                BankAccountCode = a.BankAccountCode,
                                Username = a.Username,
                                Amount = a.Amount,
                                TimeProcessed = a.TimeProcessed,
                                FirstName = a.Suppliers.FirstName,
                                Surname = a.Suppliers.Surname,
                                SupplierTypeCode = a.Suppliers.SupplierTypeCode
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}