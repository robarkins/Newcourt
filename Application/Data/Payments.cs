//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Newcourt.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payments
    {
        public int PaymentID { get; set; }
        public int SupplierID { get; set; }
        public string BankAccountCode { get; set; }
        public string Username { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime TimeProcessed { get; set; }
        public Nullable<int> Batch { get; set; }
        public string PaymentRef { get; set; }
    
        public virtual BankAccounts BankAccounts { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual Users Users { get; set; }
    }
}
