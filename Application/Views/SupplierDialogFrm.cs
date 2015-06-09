using Newcourt.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Newcourt.Views {
  public partial class SupplierDialogFrm: MasterDialogFrm {
    private Common.FormMode formMode;
    private int supplierID;

    public SupplierDialogFrm(Common.FormMode formMode, Data_Supplier supplier) {
      InitializeComponent();

      try {
        this.formMode = formMode;
        if (Global.HideSensitiveSupplierFields) {
          HideSensitiveFields();
        }

        bsSupplierTypes.DataSource = Data_SupplierType.GetSupplierTypes();
        if (formMode == Common.FormMode.Add) {
          supplierID = -1;
          luSupplierType.SelectedIndex = -1;
        } else {
          BindControls(supplier);

          if (formMode == Common.FormMode.View) {
            Utils.DisableAllControls(this);
            this.Text = String.Format("View Supplier {0} ({1})", supplier.SupplierID, supplier.Name);
            return;
          }

          this.Text = String.Format("Edit Supplier {0} ({1})", supplier.SupplierID, supplier.Name);
        }

      } catch (Exception ex) {
        Utils.ShowException(ex);
      }
    }

    private void btnSave_Click(object sender, EventArgs e) {
      SaveSupplier();
    }

    private void SaveSupplier() {
      try {
        if (String.IsNullOrWhiteSpace(txtFirstName.Text)) {
          Utils.ShowInformation("You must enter a First Name!");
          txtFirstName.Focus();
        } else if (String.IsNullOrWhiteSpace(luSupplierType.Text)) {
          Utils.ShowInformation("You must select a Supplier Type!");
          luSupplierType.Focus();
        } else if (String.IsNullOrWhiteSpace(Address)) {
          Utils.ShowInformation("You must enter an Address!");
          txtAddress1.Focus();
        } else if (String.IsNullOrWhiteSpace(txtBankName.Text)) {
          Utils.ShowInformation("You must enter a Bank Name!");
          txtBankName.Focus();
        } else if (String.IsNullOrWhiteSpace(txtSortCode.Text)) {
          Utils.ShowInformation("You must enter a Sort Code!");
          txtSortCode.Focus();
        } else if (String.IsNullOrWhiteSpace(txtBIC.Text)) {
          Utils.ShowInformation("You must enter a BIC!");
          txtBIC.Focus();
        } else if (String.IsNullOrWhiteSpace(txtIBAN.Text)) {
          Utils.ShowInformation("You must enter an IBAN!");
          txtIBAN.Focus();
        } else {

          if (!Data_BankIdentifierCode.ValidateCode(txtBIC.Text.Trim())) {
            Utils.ShowWarning("WARNING: BIC is not valid!");
          }

          // Perform some validation on IBAN
          String bic = txtIBAN.Text.Trim().Substring(4, 4);
          String sortCode = txtIBAN.Text.Trim().Substring(8, 6);

          if (!txtBIC.Text.Trim().Contains(bic)) {
            Utils.ShowWarning("WARNING: IBAN does not contain BIC entered!");
          } else if (!txtSortCode.Text.Trim().Contains(sortCode)) {
            Utils.ShowWarning("WARNING: IBAN does not contain Sort Code entered!");
          } else if (!Utils.ValidIBAN(txtIBAN.Text.Trim())) {
            Utils.ShowWarning("WARNING: IBAN is not valid!");
          }

          Data_Supplier.SaveSupplier(new Data_Supplier() {
            SupplierID = supplierID,
            SupplierTypeCode = luSupplierType.SelectedValue.ToString(),
            FirstName = txtFirstName.Text.Trim(),
            Surname = txtSurname.Text.Trim(),
            Address1 = txtAddress1.Text.Trim(),
            Address2 = txtAddress2.Text.Trim(),
            Address3 = txtAddress3.Text.Trim(),
            Address4 = txtAddress4.Text.Trim(),
            Address5 = txtAddress5.Text.Trim(),
            Phone = txtPhone.Text.Trim(),
            Mobile = txtMobile.Text.Trim(),
            PPSVat = txtPPSVat.Text.Trim(),
            BankName = txtBankName.Text.Trim(),
            BankAddress1 = txtBankAddress1.Text.Trim(),
            BankAddress2 = txtBankAddress2.Text.Trim(),
            BankAddress3 = txtBankAddress3.Text.Trim(),
            BankAddress4 = txtBankAddress4.Text.Trim(),
            BankAddress5 = txtBankAddress5.Text.Trim(),
            BankAccNumber = txtBankAccNumber.Text.Trim(),
            SortCode = txtSortCode.Text.Trim(),
            BIC = txtBIC.Text.Trim(),
            IBAN = txtIBAN.Text.Trim()
          });

          DialogResult = DialogResult.OK;
        }
      } catch (Exception ex) {
        Utils.ShowException(ex);
      }
    }

    private String Address {
      get {
        return txtAddress1.Text + txtAddress2.Text + txtAddress3.Text + txtAddress4.Text + txtAddress5.Text;
      }
    }

    private String BankAddress {
      get {
        return txtBankAddress1.Text + txtBankAddress2.Text + txtBankAddress3.Text + txtBankAddress4.Text + txtBankAddress5.Text;
      }
    }

    private void BindControls(Data_Supplier supplier) {
      supplierID = supplier.SupplierID;
      txtFirstName.Text = supplier.FirstName;
      txtSurname.Text = supplier.Surname;
      txtAddress1.Text = supplier.Address1;
      txtAddress2.Text = supplier.Address2;
      txtAddress3.Text = supplier.Address3;
      txtAddress4.Text = supplier.Address4;
      txtAddress5.Text = supplier.Address5;
      txtPhone.Text = supplier.Phone;
      txtMobile.Text = supplier.Mobile;
      txtPPSVat.Text = supplier.PPSVat;

      if (!String.IsNullOrWhiteSpace(supplier.SupplierTypeCode)) {
        luSupplierType.SelectedValue = supplier.SupplierTypeCode;
      }

      txtBankName.Text = supplier.BankName;
      txtBankAddress1.Text = supplier.BankAddress1;
      txtBankAddress2.Text = supplier.BankAddress2;
      txtBankAddress3.Text = supplier.BankAddress3;
      txtBankAddress4.Text = supplier.BankAddress4;
      txtBankAddress5.Text = supplier.BankAddress5;
      txtBankAccNumber.Text = supplier.BankAccNumber;
      txtSortCode.Text = supplier.SortCode;
      txtBIC.Text = supplier.BIC;
      txtIBAN.Text = supplier.IBAN;
    }

    private void HideSensitiveFields() {
      txtPhone.Visible = false;
      lblPhone.Visible = false;
      txtMobile.Visible = false;
      lblMobile.Visible = false;
      txtPPSVat.Visible = false;
      lblPPSVat.Visible = false;
      txtBankAccNumber.Visible = false;
      lblBankAccNumber.Visible = false;
      txtBankAddress1.Visible = false;
      lblBankAddress.Visible = false;
      txtBankAddress2.Visible = false;
      txtBankAddress3.Visible = false;
      txtBankAddress4.Visible = false;
      txtBankAddress5.Visible = false;
    }
  }
}
