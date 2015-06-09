using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data {
  public class Data_SystemParameters {
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
    public bool HideSensitiveSupplierFields { get; set; }


    public static Data_SystemParameters GetSystemParameters() {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return (from a in ctx.SystemParameters
                  select new Data_SystemParameters() {
                    DatabaseVersion = a.DatabaseVersion,
                    CompanyName = a.CompanyName,
                    Address1 = a.Address1,
                    Address2 = a.Address2,
                    Address3 = a.Address3,
                    Address4 = a.Address4,
                    Address5 = a.Address5,
                    Phone = a.Phone,
                    VatRegNo = a.VatRegNo,
                    SepaFileCount = a.SepaFileCount ?? 0,
                    HideSensitiveSupplierFields = (a.HideSensitiveSupplierFields == 0 || a.HideSensitiveSupplierFields == null) ? false : true
                  }).FirstOrDefault();
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static void SaveSystemParameters(Data_SystemParameters systemParams) {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          SystemParameters param = ctx.SystemParameters.FirstOrDefault();

          if (param != null) {
            param.CompanyName = systemParams.CompanyName;
            param.Address1 = systemParams.Address1;
            param.Address2 = systemParams.Address2;
            param.Address3 = systemParams.Address3;
            param.Address4 = systemParams.Address4;
            param.Address5 = systemParams.Address5;
            param.Phone = systemParams.Phone;
            param.VatRegNo = systemParams.VatRegNo;
            param.HideSensitiveSupplierFields = systemParams.HideSensitiveSupplierFields == true ? (short)1 : (short)0;
          } else {
            ctx.SystemParameters.Add(new SystemParameters() {
              ID = 1,
              CompanyName = systemParams.CompanyName,
              Address1 = systemParams.Address1,
              Address2 = systemParams.Address2,
              Address3 = systemParams.Address3,
              Address4 = systemParams.Address4,
              Address5 = systemParams.Address5,
              Phone = systemParams.Phone,
              VatRegNo = systemParams.VatRegNo,
              HideSensitiveSupplierFields = systemParams.HideSensitiveSupplierFields == true ? (short)1 : (short)0
            });
          }

          ctx.SaveChanges();
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static String GetCompanyName() {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return ctx.SystemParameters.FirstOrDefault().CompanyName;
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static int GetSepaFileCount() {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return ctx.SystemParameters.FirstOrDefault().SepaFileCount ?? 0;
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static String GetDatabaseVersion() {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return ctx.SystemParameters.FirstOrDefault().DatabaseVersion;
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static String GetPaymentRef() {
      String result = String.Empty;
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          var item = ctx.SystemParameters.FirstOrDefault();

          if (item != null) {
            result = item.PaymentRef;
          }
        }
      } catch (Exception ex) {
        throw ex;
      }

      return result;
    }

    public static void SavePaymentRef(String paymentRef) {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          var item = ctx.SystemParameters.FirstOrDefault();

          if (item != null) {
            item.PaymentRef = paymentRef;
            ctx.SaveChanges();
          }
        }
      } catch (Exception ex) {
        throw ex;
      }
    }
  }
}
