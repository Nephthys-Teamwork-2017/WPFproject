using Models;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BrokerDbContext : DbContext
    {
       
        public BrokerDbContext()
            : base("name=BrokerDbContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BrokerDbContext>());
        }

       

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Policy> Policies{ get; set; }
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Policy>()
                .HasRequired(p => p.Insured)
                .WithMany(c => c.InsurersPolicies)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Customer>()
                        .Property(p => p.Phone)
                        .HasMaxLength(10)
                        .HasColumnType("char")
                        .IsFixedLength();

            modelBuilder.Entity<Company>()
                        .Property(p => p.Phone)
                        .HasMaxLength(10)
                        .HasColumnType("char")
                        .IsFixedLength();

            modelBuilder.Entity<Agent>()
                        .Property(p => p.Phone)
                        .HasMaxLength(10)
                        .HasColumnType("char")
                        .IsFixedLength();


            base.OnModelCreating(modelBuilder);
        }

        

    }

    
}
