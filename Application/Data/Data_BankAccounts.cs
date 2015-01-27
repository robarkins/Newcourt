using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_BankAccounts
    {
        public String BankAccountCode { get; set; }
        public String BankAccountName { get; set; }
        public String BIC { get; set; }
        public String IBAN { get; set; }
        public String OIN { get; set; }

        public static List<Data_BankAccounts> GetBankAccounts()
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.BankAccounts
                            select new Data_BankAccounts()
                            {
                                BankAccountCode = a.BankAccountCode,
                                BankAccountName = a.BankAccountName,
                                BIC = a.BIC,
                                IBAN = a.IBAN,
                                OIN = a.OIN
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

        public static void SaveBankAccount(Data_BankAccounts bankAccount)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    BankAccounts record = ctx.BankAccounts.FirstOrDefault(a => a.BankAccountCode == bankAccount.BankAccountCode);

                    if (record != null)
                    {
                        record.BankAccountName = bankAccount.BankAccountName;
                        record.BIC = bankAccount.BIC;
                        record.IBAN = bankAccount.IBAN;
                        record.OIN = bankAccount.OIN;
                    }
                    else
                    {
                        ctx.BankAccounts.Add(new BankAccounts()
                        {
                            BankAccountCode = bankAccount.BankAccountCode,
                            BankAccountName = bankAccount.BankAccountName,
                            BIC = bankAccount.BIC,
                            IBAN = bankAccount.IBAN,
                            OIN = bankAccount.IBAN
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
