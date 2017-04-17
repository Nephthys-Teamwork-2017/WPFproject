namespace Data.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.BrokerDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;

           

        }

        protected override void Seed(Data.BrokerDbContext context)
        {
            Customer cust = new Customer() { Name = "ivan", Phone = "123" };

            context.Customers.Add(cust);
            context.SaveChanges();

            var payment = context.Payments.Find(1);
            payment.Policy = context.Policies.Find(1);
           // context.Payments.Add(payment);
            context.SaveChanges();

            //Payment payment = new Payment() { PolicyId = policy.Id, DateOfPayment = new DateTime(2000, 1, 1), Price = 11, FinalPrice = 12 };

            //context.Payments.Add(payment);

            //context.SaveChanges();
        }
    }
}
