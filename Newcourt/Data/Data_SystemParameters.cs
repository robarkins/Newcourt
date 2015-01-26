﻿using System;
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
                                CompanyName = a.CompanyName
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
    }
}