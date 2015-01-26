namespace Newcourt.Controls
{
    partial class BankAccountBrowseCtrl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            this.grpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // grpRecords
            // 
            this.grpRecords.Text = "Bank Account Records";
            // 
            // bsRecords
            // 
            this.bsRecords.DataSource = typeof(Newcourt.Data.Data_BankAccounts);
            // 
            // BankAccountBrowseCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "BankAccountBrowseCtrl";
            this.Controls.SetChildIndex(this.grpRecords, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            this.grpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
