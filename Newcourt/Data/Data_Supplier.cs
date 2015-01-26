using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data
{
    public class Data_Supplier
    {
        public int SupplierID { get; set; }
        public String SupplierTypeCode { get; set; }
        public String FirstName { get; set; }
        public String Surname { get; set; }
        public String Address1 { get; set; }
        public String Address2 { get; set; }
        public String Address3 { get; set; }
        public String Address4 { get; set; }
        public String Address5 { get; set; }
        public String Phone { get; set; }
        public String Mobile { get; set; }
        public String PPSVat { get; set; }
        public String BankName { get; set; }
        public String BankAddress1 { get; set; }
        public String BankAddress2 { get; set; }
        public String BankAddress3 { get; set; }
        public String BankAddress4 { get; set; }
        public String BankAddress5 { get; set; }
        public String BankAccNumber { get; set; }
        public String SortCode { get; set; }
        public String BIC { get; set; }
        public String IBAN { get; set; }
        public String SupplierTypeName { get; set; }
        public decimal? PaymentAmount { get; set; }

        public static List<Data_Supplier> GetSuppliers()
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Suppliers
                            select new Data_Supplier()
                            {
                                SupplierID = a.SupplierID,
                                SupplierTypeCode = a.SupplierTypeCode,
                                FirstName = a.FirstName,
                                Surname = a.Surname,
                                Address1 = a.Address1,
                                Address2 = a.Address2,
                                Address3 = a.Address3,
                                Address4 = a.Address4,
                                Address5 = a.Address5,
                                Phone = a.Phone,
                                Mobile = a.Mobile,
                                PPSVat = a.PPSVat,
                                BankName = a.BankName,
                                BankAddress1 = a.BankAddress1,
                                BankAddress2 = a.BankAddress2,
                                BankAddress3 = a.BankAddress3,
                                BankAddress4 = a.BankAddress4,
                                BankAddress5 = a.BankAddress5,
                                BankAccNumber = a.BankAccNumber,
                                SortCode = a.SortCode,
                                BIC = a.BIC,
                                IBAN = a.IBAN,
                                SupplierTypeName = a.SupplierTypes.Name
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Data_Supplier> GetSuppliers(String supplierTypeCode)
        {
            try
            {
                using (NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Suppliers
                            where a.SupplierTypeCode == supplierTypeCode || supplierTypeCode == String.Empty
                            select new Data_Supplier()
                            {
                                SupplierID = a.SupplierID,
                                SupplierTypeCode = a.SupplierTypeCode,
                                FirstName = a.FirstName,
                                Surname = a.Surname,
                                Address1 = a.Address1,
                                Address2 = a.Address2,
                                Address3 = a.Address3,
                                Address4 = a.Address4,
                                Address5 = a.Address5,
                                Phone = a.Phone,
                                Mobile = a.Mobile,
                                PPSVat = a.PPSVat,
                                BankName = a.BankName,
                                BankAddress1 = a.BankAddress1,
                                BankAddress2 = a.BankAddress2,
                                BankAddress3 = a.BankAddress3,
                                BankAddress4 = a.BankAddress4,
                                BankAddress5 = a.BankAddress5,
                                BankAccNumber = a.BankAccNumber,
                                SortCode = a.SortCode,
                                BIC = a.BIC,
                                IBAN = a.IBAN,
                                SupplierTypeName = a.SupplierTypes.Name
                            }).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Data_Supplier GetSupplier(int supplierID)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Suppliers
                            where a.SupplierID == supplierID
                            select new Data_Supplier()
                            {
                                SupplierID = a.SupplierID,
                                SupplierTypeCode = a.SupplierTypeCode,
                                FirstName = a.FirstName,
                                Surname = a.Surname,
                                Address1 = a.Address1,
                                Address2 = a.Address2,
                                Address3 = a.Address3,
                                Address4 = a.Address4,
                                Address5 = a.Address5,
                                Phone = a.Phone,
                                Mobile = a.Mobile,
                                PPSVat = a.PPSVat,
                                BankName = a.BankName,
                                BankAddress1 = a.BankAddress1,
                                BankAddress2 = a.BankAddress2,
                                BankAddress3 = a.BankAddress3,
                                BankAddress4 = a.BankAddress4,
                                BankAddress5 = a.BankAddress5,
                                BankAccNumber = a.BankAccNumber,
                                SortCode = a.SortCode,
                                BIC = a.BIC,
                                IBAN = a.IBAN,
                                SupplierTypeName = a.SupplierTypes.Name
                            }).FirstOrDefault();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static List<Data_Supplier> GetSuppliersBySupplierType(String supplierTypeCode)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    return (from a in ctx.Suppliers
                            where a.SupplierTypeCode == supplierTypeCode
                            select new Data_Supplier()
                            {
                                SupplierID = a.SupplierID,
                                SupplierTypeCode = a.SupplierTypeCode,
                                FirstName = a.FirstName,
                                Surname = a.Surname,
                                Address1 = a.Address1,
                                Address2 = a.Address2,
                                Address3 = a.Address3,
                                Address4 = a.Address4,
                                Address5 = a.Address5,
                                Phone = a.Phone,
                                Mobile = a.Mobile,
                                PPSVat = a.PPSVat,
                                BankName = a.BankName,
                                BankAddress1 = a.BankAddress1,
                                BankAddress2 = a.BankAddress2,
                                BankAddress3 = a.BankAddress3,
                                BankAddress4 = a.BankAddress4,
                                BankAddress5 = a.BankAddress5,
                                BankAccNumber = a.BankAccNumber,
                                SortCode = a.SortCode,
                                BIC = a.BIC,
                                IBAN = a.IBAN,
                                SupplierTypeName = a.SupplierTypes.Name
                            }).ToList();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void SaveSupplier(Data_Supplier supplier)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    Suppliers record = ctx.Suppliers.FirstOrDefault(a => a.SupplierID == supplier.SupplierID);

                    if (record != null)
                    {
                        record.SupplierTypes = ctx.SupplierTypes.FirstOrDefault(a => a.SupplierTypeCode == supplier.SupplierTypeCode);
                        record.FirstName = supplier.FirstName;
                        record.Surname = supplier.Surname;
                        record.Address1 = supplier.Address1;
                        record.Address2 = supplier.Address2;
                        record.Address3 = supplier.Address3;
                        record.Address4 = supplier.Address4;
                        record.Address5 = supplier.Address5;
                        record.Phone = supplier.Phone;
                        record.Mobile = supplier.Mobile;
                        record.PPSVat = supplier.PPSVat;
                        record.BankName = supplier.BankName;
                        record.BankAddress1 = supplier.BankAddress1;
                        record.BankAddress2 = supplier.BankAddress2;
                        record.BankAddress3 = supplier.BankAddress3;
                        record.BankAddress4 = supplier.BankAddress4;
                        record.BankAddress5 = supplier.BankAddress5;
                        record.BankAccNumber = supplier.BankAccNumber;
                        record.SortCode = supplier.SortCode;
                        record.BIC = supplier.BIC;
                        record.IBAN = supplier.IBAN;
                    }
                    else
                    {
                        ctx.Suppliers.Add(new Suppliers()
                        {
                            SupplierTypes = ctx.SupplierTypes.FirstOrDefault(a => a.SupplierTypeCode == supplier.SupplierTypeCode),
                            FirstName = supplier.FirstName,
                            Surname = supplier.Surname,
                            Address1 = supplier.Address1,
                            Address2 = supplier.Address2,
                            Address3 = supplier.Address3,
                            Address4 = supplier.Address4,
                            Address5 = supplier.Address5,
                            Phone = supplier.Phone,
                            Mobile = supplier.Mobile,
                            PPSVat = supplier.PPSVat,
                            BankName = supplier.BankName,
                            BankAddress1 = supplier.BankAddress1,
                            BankAddress2 = supplier.BankAddress2,
                            BankAddress3 = supplier.BankAddress3,
                            BankAddress4 = supplier.BankAddress4,
                            BankAddress5 = supplier.BankAddress5,
                            BankAccNumber = supplier.BankAccNumber,
                            SortCode = supplier.SortCode,
                            BIC = supplier.BIC,
                            IBAN = supplier.IBAN
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

        public static void DeleteSupplier(int supplierID)
        {
            try
            {
                using(NewcourtEntities ctx = new NewcourtEntities())
                {
                    Suppliers supplier = ctx.Suppliers.FirstOrDefault(a => a.SupplierID == supplierID);

                    if (supplier != null)
                    {
                        ctx.Suppliers.Remove(supplier);
                        ctx.SaveChanges();
                    }
                }
            }
            catch(Exception ex)
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
