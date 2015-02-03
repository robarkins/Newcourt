namespace Newcourt.Controls
{
    partial class MasterEnquiryCtrl
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
            this.components = new System.ComponentModel.Container();
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpRecords = new System.Windows.Forms.GroupBox();
            this.bsRecords = new System.Windows.Forms.BindingSource(this.components);
            this.pnlToolStrip = new System.Windows.Forms.Panel();
            this.grdRecords = new Newcourt.Controls.UCDataGridView();
            this.grpRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpOptions.Location = new System.Drawing.Point(0, 0);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(841, 83);
            this.grpOptions.TabIndex = 0;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpRecords
            // 
            this.grpRecords.Controls.Add(this.grdRecords);
            this.grpRecords.Controls.Add(this.pnlToolStrip);
            this.grpRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRecords.Location = new System.Drawing.Point(0, 83);
            this.grpRecords.Name = "grpRecords";
            this.grpRecords.Size = new System.Drawing.Size(841, 469);
            this.grpRecords.TabIndex = 1;
            this.grpRecords.TabStop = false;
            this.grpRecords.Text = "Records";
            // 
            // pnlToolStrip
            // 
            this.pnlToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolStrip.Location = new System.Drawing.Point(3, 16);
            this.pnlToolStrip.Name = "pnlToolStrip";
            this.pnlToolStrip.Size = new System.Drawing.Size(835, 36);
            this.pnlToolStrip.TabIndex = 0;
            // 
            // grdRecords
            // 
            this.grdRecords.AllowUserToAddRows = false;
            this.grdRecords.AllowUserToDeleteRows = false;
            this.grdRecords.AllowUserToResizeRows = false;
            this.grdRecords.DataSource = this.bsRecords;
            this.grdRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdRecords.Location = new System.Drawing.Point(3, 52);
            this.grdRecords.Name = "grdRecords";
            this.grdRecords.ReadOnly = true;
            this.grdRecords.RowHeadersVisible = false;
            this.grdRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdRecords.Size = new System.Drawing.Size(835, 414);
            this.grdRecords.TabIndex = 1;
            // 
            // MasterEnquiryCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpRecords);
            this.Controls.Add(this.grpOptions);
            this.Name = "MasterEnquiryCtrl";
            this.Size = new System.Drawing.Size(841, 552);
            this.grpRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.GroupBox grpOptions;
        protected System.Windows.Forms.GroupBox grpRecords;
        protected UCDataGridView grdRecords;
        protected System.Windows.Forms.Panel pnlToolStrip;
        private System.Windows.Forms.BindingSource bsRecords;

    }
}
