using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newcourt.Data {
  public class Data_BankIdentifierCode {
    public int ID { get; set; }
    public String Code { get; set; }

    public static List<Data_BankIdentifierCode> GetBankIdentifierCodes() {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return (from a in ctx.BankIdentifierCodes
                  select new Data_BankIdentifierCode() {
                    ID = a.ID,
                    Code = a.Code
                  }).OrderBy(a => a.Code).ToList();
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static Data_BankIdentifierCode GetBankIdentifierCode(int id) {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          return (from a in ctx.BankIdentifierCodes
                  where a.ID == id
                  select new Data_BankIdentifierCode() {
                    ID = a.ID,
                    Code = a.Code
                  }).FirstOrDefault();
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static void SaveBankIdentifierCode(Data_BankIdentifierCode bic) {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          BankIdentifierCodes item = ctx.BankIdentifierCodes.FirstOrDefault(a => a.ID == bic.ID);

          if (item != null) {
            item.Code = bic.Code;
          } else {
            ctx.BankIdentifierCodes.Add(new BankIdentifierCodes() {
              Code = bic.Code
            });
          }

          ctx.SaveChanges();
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static void DeleteBankIdentifierCode(int id) {
      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          BankIdentifierCodes item = ctx.BankIdentifierCodes.FirstOrDefault(a => a.ID == id);

          if (item != null) {
            ctx.BankIdentifierCodes.Remove(item);
            ctx.SaveChanges();
          }
        }
      } catch (Exception ex) {
        throw ex;
      }
    }

    public static bool ValidateCode(String code) {
      bool result = false;

      try {
        using (NewcourtEntities ctx = new NewcourtEntities()) {
          result = ctx.BankIdentifierCodes.FirstOrDefault(a => a.Code == code) != null;
        }
      } catch (Exception ex) {
        Utils.ShowException(ex);
      }

      return result;
    }
  }
}
