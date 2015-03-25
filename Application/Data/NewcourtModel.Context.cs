﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NewcourtEntities : DbContext
    {
        public NewcourtEntities()
            : base("name=NewcourtEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SupplierTypes> SupplierTypes { get; set; }
        public virtual DbSet<SystemParameters> SystemParameters { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<BankAccounts> BankAccounts { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentStaging> PaymentStaging { get; set; }
        public virtual DbSet<BankIdentifierCodes> BankIdentifierCodes { get; set; }
    
        public virtual ObjectResult<string> GenerateSEPAPaymentXML(string bankAccountCode, Nullable<System.DateTime> paymentDate, string paymentRef, string username, ObjectParameter batch)
        {
            var bankAccountCodeParameter = bankAccountCode != null ?
                new ObjectParameter("BankAccountCode", bankAccountCode) :
                new ObjectParameter("BankAccountCode", typeof(string));
    
            var paymentDateParameter = paymentDate.HasValue ?
                new ObjectParameter("PaymentDate", paymentDate) :
                new ObjectParameter("PaymentDate", typeof(System.DateTime));
    
            var paymentRefParameter = paymentRef != null ?
                new ObjectParameter("PaymentRef", paymentRef) :
                new ObjectParameter("PaymentRef", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GenerateSEPAPaymentXML", bankAccountCodeParameter, paymentDateParameter, paymentRefParameter, usernameParameter, batch);
        }
    }
}
