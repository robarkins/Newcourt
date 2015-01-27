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

namespace Newcourt.Controls
{
    public partial class BankAccountBrowseCtrl : MasterBrowseCtrl
    {
        public BankAccountBrowseCtrl()
        {
            InitializeComponent();

            try
            {
                GetRecords();
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void AddRecord()
        {
            try
            {
                BankAccountDialogFrm frm = new BankAccountDialogFrm(Common.FormMode.Add, null);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    GetRecords();
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void EditRecord()
        {
            try
            {
                Data_BankAccount bankAccount = Utils.GetCurrentRecord<Data_BankAccount>(bsRecords);

                if (bankAccount != null)
                {
                    Data_BankAccount record = Data_BankAccount.GetBankAccount(bankAccount.BankAccountCode);

                    if (record != null)
                    {
                        BankAccountDialogFrm frm = new BankAccountDialogFrm(Common.FormMode.Edit, bankAccount);
                        if (frm.ShowDialog() == DialogResult.OK)
                        {
                            GetRecords();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void DeleteRecord()
        {
            try
            {
                Data_BankAccount bankAccount = Utils.GetCurrentRecord<Data_BankAccount>(bsRecords);

                if (bankAccount != null)
                {
                    if (Utils.AskQuestion(String.Format("Are you sure you want to delete Bank Account {0}?", bankAccount.BankAccountCode)) == DialogResult.Yes)
                    {
                        Data_BankAccount.DeleteBankAccount(bankAccount.BankAccountCode);
                        GetRecords();
                    }
                }
            }
            catch(Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        protected override void RefreshRecords()
        {
            try
            {
                GetRecords();
            }
            catch (Exception ex)
            {
                Utils.ShowException(ex);
            }
        }

        private void GetRecords()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                bsRecords.DataSource = Data_BankAccount.GetBankAccounts();
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

    }
}
