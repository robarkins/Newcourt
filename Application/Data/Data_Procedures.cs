using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_Procedures
    {
        public static String GenerateSEPAPaymentsXML(String bankAccountCode, DateTime paymentDate, String username, ref int batch)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    ObjectParameter output = new ObjectParameter("Batch", typeof(int));
                    String result = ctx.GenerateSEPAPaymentXML(bankAccountCode, paymentDate, username, output).FirstOrDefault();
                    batch = Convert.ToInt32(output.Value);
                    return result;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
