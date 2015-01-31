using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_SystemParameters
    {
        public String DatabaseVersion { get; set; }
        public String CompanyName { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String Address5 { get; set; }
        public String Phone { get; set; }
        public String VatRegNo { get; set; }
        public int SepaFileCount { get; set; }

        public static Data_SystemParameters GetSystemParameters()
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.SystemParameters
                            select new Data_SystemParameters()
                            {
                                DatabaseVersion = a.DatabaseVersion,
                                CompanyName = a.CompanyName,
                                Address1 = a.Address1,
                                Address2 = a.Address2,
                                Address3 = a.Address3,
                                Address4 = a.Address4,
                                Address5 = a.Address5,
                                VatRegNo = a.VatRegNo,
                                SepaFileCount = a.SepaFileCount ?? 0
                            }).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveSystemParameters(Data_SystemParameters systemParams)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    SystemParameters param = ctx.SystemParameters.FirstOrDefault();

                    if (param != null)
                    {
                        param.CompanyName = systemParams.CompanyName;
                    }
                    else
                    {
                        ctx.SystemParameters.Add(new SystemParameters()
                        {
                            ID = 1,
                            CompanyName = systemParams.CompanyName
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int GetSepaFileCount()
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return ctx.SystemParameters.FirstOrDefault().SepaFileCount ?? 0;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
