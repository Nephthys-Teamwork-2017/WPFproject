using Models;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InsuranceBrokerManagementSystem : DbContext
    {
       
        public InsuranceBrokerManagementSystem()
            : base("name=InsuranceBrokerManagementSystem")
        {
        }

       

        public virtual DbSet<Agent> Agents { get; set; }
        public virtual DbSet<Blank> Blanks { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Income> Incomes { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Policy> Policies{ get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }

    
}
