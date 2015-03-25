using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newcourt.Data;

namespace Newcourt.Views {
  public partial class BankIdentifierCodeDlg: MasterDialogFrm {
    public Data_BankIdentifierCode BIC { get; set; }
    public BankIdentifierCodeDlg(Common.FormMode formMode, Data_BankIdentifierCode bic) {
      InitializeComponent();

      if (formMode == Common.FormMode.Edit) {
        this.Text = "Edit BIC";
        txtCode.Text = bic.Code;
      }

      BIC = bic;
      txtCode.Focus();
    }

    private void btnSave_Click(object sender, EventArgs e) {
      if (String.IsNullOrWhiteSpace(txtCode.Text)) {
        Utils.ShowInformation("You must enter a Code!");
        txtCode.Focus();
      } else {
        int id = 0;
        if (BIC != null)
        {
          id = BIC.ID;
        }

        Data_BankIdentifierCode.SaveBankIdentifierCode(new Data_BankIdentifierCode() {
          ID = id,
          Code = txtCode.Text.Trim()
        });

        DialogResult = DialogResult.OK;
      }
    }
  }
}
