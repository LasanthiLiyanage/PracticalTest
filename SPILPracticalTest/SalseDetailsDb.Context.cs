//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPILPracticalTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Demo2016Entities : DbContext
    {
        public Demo2016Entities()
            : base("name=Demo2016Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<StkItem> StkItems { get; set; }
        public virtual DbSet<ClientDetail> ClientDetails { get; set; }
        public virtual DbSet<SalseDetail> SalseDetails { get; set; }
    }
}
