using Models;

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class InsuranceBrokerManagementSystem : DbContext
    {
        // Your context has been configured to use a 'InsuranceBrokerManagementSystem' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Data.InsuranceBrokerManagementSystem' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'InsuranceBrokerManagementSystem' 
        // connection string in the application configuration file.
        public InsuranceBrokerManagementSystem()
            : base("name=InsuranceBrokerManagementSystem")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

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