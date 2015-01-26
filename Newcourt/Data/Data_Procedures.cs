using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_Procedures
    {
        public static String GenerateSEPAPaymentsXML(String bankAccountCode, DateTime paymentDate, String username)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return ctx.GenerateSEPAPaymentXML(bankAccountCode, paymentDate, username).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
