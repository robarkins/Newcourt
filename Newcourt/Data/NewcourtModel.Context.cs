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
    
        public virtual DbSet<BankAccounts> BankAccounts { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SupplierTypes> SupplierTypes { get; set; }
        public virtual DbSet<SystemParameters> SystemParameters { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    
        public virtual ObjectResult<string> GenerateSEPAPaymentXML(Nullable<int> bankAccountID, Nullable<System.DateTime> paymentDate, string username)
        {
            var bankAccountIDParameter = bankAccountID.HasValue ?
                new ObjectParameter("BankAccountID", bankAccountID) :
                new ObjectParameter("BankAccountID", typeof(int));
    
            var paymentDateParameter = paymentDate.HasValue ?
                new ObjectParameter("PaymentDate", paymentDate) :
                new ObjectParameter("PaymentDate", typeof(System.DateTime));
    
            var usernameParameter = username != null ?
                new ObjectParameter("Username", username) :
                new ObjectParameter("Username", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GenerateSEPAPaymentXML", bankAccountIDParameter, paymentDateParameter, usernameParameter);
        }
    }
}