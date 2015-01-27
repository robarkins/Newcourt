using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_SupplierType
    {
        public String SupplierTypeCode { get; set; }
        public String Name { get; set; }

        public static List<Data_SupplierType> GetSupplierTypes()
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.SupplierTypes
                            select new Data_SupplierType()
                            {
                                SupplierTypeCode = a.SupplierTypeCode,
                                Name = a.Name
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static Data_SupplierType GetSupplierType(String supplierTypeCode)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.SupplierTypes
                            where a.SupplierTypeCode == supplierTypeCode
                            select new Data_SupplierType()
                            {
                                SupplierTypeCode = a.SupplierTypeCode,
                                Name = a.Name
                            }).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveSupplierType(Data_SupplierType supplierType)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    SupplierTypes record = ctx.SupplierTypes.FirstOrDefault(a => a.SupplierTypeCode == supplierType.SupplierTypeCode);

                    if (record != null)
                    {
                        record.Name = supplierType.Name;
                    }
                    else
                    {
                        ctx.SupplierTypes.Add(new SupplierTypes()
                        {
                            SupplierTypeCode = supplierType.SupplierTypeCode,
                            Name = supplierType.Name
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

        public static bool DeleteSupplierType(String supplierTypeCode)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {

                    if (CanDeleteSupplierType(supplierTypeCode))
                    {
                        SupplierTypes supplierType = ctx.SupplierTypes.FirstOrDefault(a => a.SupplierTypeCode == supplierTypeCode);

                        if (supplierType != null)
                        {
                            ctx.SupplierTypes.Remove(supplierType);
                            ctx.SaveChanges();
                            return true;
                        }
                    }
                        
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static bool CanDeleteSupplierType(String supplierTypeCode)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    // Check Suppliers
                    List<Data_Supplier> supplier = Data_Supplier.GetSuppliersBySupplierType(supplierTypeCode);

                    if (supplier.Count >= 1)
                    {
                        return false;
                    }
                }

                return true;
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
                return String.Format("{0} - {1}", SupplierTypeCode, Name);
            }
        }
    }
}
