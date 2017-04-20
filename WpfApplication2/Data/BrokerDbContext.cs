using Models;

namespace Data
{
    using Models.Models;
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
        public virtual DbSet<CompanyProdCom> CompanyProdComs { get; set; }

        public virtual DbSet<AgentProdCom> AgentProdComs { get; set; }



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

            modelBuilder.Entity<Agent>()
                       .HasMany(x => x.Policies)
                       .WithRequired(x => x.Agent)
                       .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                        .HasMany(x => x.Policies)
                        .WithRequired(x => x.Company)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .HasOptional(x => x.Blank)
                .WithOptionalDependent(x => x.Payment);

            modelBuilder.Entity<Blank>()
                .HasRequired(x => x.Policy)
                .WithMany(x => x.Blanks)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Payment>()
                .HasOptional(x => x.Income)
                .WithOptionalDependent(x => x.Payment);

            base.OnModelCreating(modelBuilder);
        }

        

    }

    
}
