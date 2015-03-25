using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newcourt.Data;
using Newcourt.Views;

namespace Newcourt.Controls {
  public partial class BankIdentifierCodesCtrl: MasterBrowseCtrl {
    public BankIdentifierCodesCtrl() {
      InitializeComponent();

      GetRecords();
    }

    protected override void AddRecord() {
      try {
        BankIdentifierCodeDlg frm = new BankIdentifierCodeDlg(Common.FormMode.Add, null);
        if (frm.ShowDialog() == DialogResult.OK) {
          GetRecords();
        }
      } catch (Exception ex) {
        Utils.ShowException(ex);
      }
    }

    protected override void EditRecord() {
      try {
        Data_BankIdentifierCode bic = Utils.GetCurrentRecord<Data_BankIdentifierCode>(bsRecords);

        if (bic != null) {
          Data_BankIdentifierCode record = Data_BankIdentifierCode.GetBankIdentifierCode(bic.ID);

          if (record != null) {
            BankIdentifierCodeDlg frm = new BankIdentifierCodeDlg(Common.FormMode.Edit, record);
            if (frm.ShowDialog() == DialogResult.OK) {
              GetRecords();
            }
          }
        }
      } catch (Exception ex) {
        Utils.ShowException(ex);
      }
    }

    protected override void RefreshRecords() {
      GetRecords();
    }

    protected override void DeleteRecord() {
      try {
        Data_BankIdentifierCode bic = Utils.GetCurrentRecord<Data_BankIdentifierCode>(bsRecords);

        if (bic != null) {
          if (Utils.AskQuestion(String.Format("Are you sure you want to delete BIC {0}?", bic.Code)) == DialogResult.Yes) {
            Data_BankIdentifierCode.DeleteBankIdentifierCode(bic.ID);
            GetRecords();
          }
        }
      } catch (Exception ex) {
        Utils.ShowException(ex);
      }
    }

    private void GetRecords() {
      try {
        Cursor.Current = Cursors.WaitCursor;
        bsRecords.DataSource = Data_BankIdentifierCode.GetBankIdentifierCodes();

      } catch (Exception ex) {
        Utils.ShowException(ex);
      } finally {
        Cursor.Current = Cursors.Default;
      }
    }
  }
}
