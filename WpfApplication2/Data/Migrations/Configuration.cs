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
            //Product product1 = new Product()
            //{
            //     Code="123123",
            //     Name="Product1"

            //};
            //Product product2 = new Product()
            //{
            //    Code = "123123",
            //    Name = "Product2"

            //};

            //context.Products.Add(product1);
            //context.Products.Add(product2);

            //context.SaveChanges();


          

        }
    }
}
