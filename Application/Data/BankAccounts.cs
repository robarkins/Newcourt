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
    
    public partial class BankAccounts
    {
        public BankAccounts()
        {
            this.Payments = new HashSet<Payments>();
        }
    
        public string BankAccountCode { get; set; }
        public string BankAccountName { get; set; }
        public string BIC { get; set; }
        public string IBAN { get; set; }
        public string OIN { get; set; }
    
        public virtual ICollection<Payments> Payments { get; set; }
    }
}