using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newcourt.Data;

namespace Newcourt
{
    public class Global
    {
        public const String FKVIOLATIONMSG = "{0} {1} cannot be deleted as it is currently referenced by another record in the system!";
        public const String DBVERSION = "1.0.0.4";

        public static String Username { get; set; }
        public static bool IsAdmin { get; set; }
        public static String CompanyName { get; set; }
        public static bool HideSensitiveSupplierFields { get; set; }

        public static Uri ReportServer { get; set; }

        public static void InitGlobalVariables(String username, bool isAdmin, String companyName, bool hideSensitiveSupplierFields)
        {
            Username = username;
            IsAdmin = isAdmin;
            CompanyName = companyName;
            HideSensitiveSupplierFields = hideSensitiveSupplierFields;
            ReportServer = new Uri(ConfigurationManager.AppSettings["ReportServer"]);
        }

        public static void RefreshGlobalVariables() {
          try {
            Data_SystemParameters systemParams = Data_SystemParameters.GetSystemParameters();
            if (systemParams != null) {
              CompanyName = systemParams.CompanyName;
              HideSensitiveSupplierFields = systemParams.HideSensitiveSupplierFields;
            }
          } catch (Exception ex) {
            Utils.ShowException(ex);
          }
        }
    }
}