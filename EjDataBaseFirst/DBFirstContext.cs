namespace EjDataBaseFirst
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBFirstContext : DbContext
    {
        public DBFirstContext()
            : base("name=DBFirstContext2")
        {
        }

        public virtual DbSet<InvoiceDetailSet> InvoiceDetailSet { get; set; }
        public virtual DbSet<InvoiceHeaderSet> InvoiceHeaderSet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InvoiceDetailSet>()
                .Property(e => e.Price)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceHeaderSet>()
                .Property(e => e.Total)
                .HasPrecision(18, 0);

            modelBuilder.Entity<InvoiceHeaderSet>()
                .HasMany(e => e.InvoiceDetailSet)
                .WithRequired(e => e.InvoiceHeaderSet)
                .HasForeignKey(e => e.InvoiceHeaderInvoiceHeader_Id)
                .WillCascadeOnDelete(false);
        }
    }
}
