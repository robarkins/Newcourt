using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_BankAccounts
    {
        public int BankAccountID { get; set; }
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
                                BankAccountID = a.BankAccountID,
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

        public static void SaveBankAccounts(List<Data_BankAccounts> bankAccounts)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    foreach(var i in bankAccounts)
                    {
                        BankAccounts record = ctx.BankAccounts.FirstOrDefault(a => a.BankAccountID == i.BankAccountID);

                        if (record != null)
                        {
                            record.BankAccountName = i.BankAccountName;
                            record.BIC = i.BIC;
                            record.IBAN = i.IBAN;
                            record.OIN = i.OIN;
                        }
                        else
                        {
                            
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public String CodeName
        {
            get
            {
                return String.Format("{0} - {1}", BankAccountID, BankAccountName);
            }
        }
    }
}
