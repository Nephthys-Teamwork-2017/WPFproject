using Models;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Utility
{
    public class SeedData : DropCreateDatabaseAlways<BrokerDbContext>
    {
        protected override void Seed(BrokerDbContext context)
        {

            var pesho = new Customer { Name = "pesho", Phone = "0887324567", Email = "pesho@mail.bg" };
            var gosho = new Customer { Name = "gosho", Phone = "0897234567", Email = "gosho@mail.bg" };
            var ivo = new Customer { Name = "ivo", Phone = "0887234927", Email = "ivo@mail.bg" };
            var ivan = new Customer { Name = "ivan", Phone = "0884914567", Email = "ivan@mail.bg" };
            var radko = new Customer { Name = "radko", Phone = "0873934567", Email = "radko@mail.bg" };
            context.Customers.Add(pesho);
            context.Customers.Add(gosho);
            context.Customers.Add(ivo);
            context.Customers.Add(ivan);
            context.Customers.Add(radko);



            var armeec = new Company { Name = "Armeec", Address = "Sofia bul. Bulgaria", Phone = "0988762451", Email = "armeec@gmail.com" };
            var unica = new Company { Name = "Unica", Address = "Sofia bul. Dondukov", Phone = "0898762443", Email = "unica@gmail.com" };
            var dzi = new Company { Name = "DZI", Address = "Sofia ul. Prohodna", Phone = "0898766221", Email = "dzi@gmail.com" };
            var bulins = new Company { Name = "Bulins", Address = "Sofia Bul. Car Osvoboditel", Phone = "0893462451", Email = "bulins@gmail.com" };
            context.Companies.Add(armeec);
            context.Companies.Add(unica);
            context.Companies.Add(dzi);
            context.Companies.Add(bulins);


            var etIvan = new Agent { Name = "ET IVAN", Code = "345", Phone = "0887345678", Email = "ivan@dir.bg" };
            var etKiril = new Agent { Name = "ET Kiril", Code = "346", Phone = "0885375678", Email = "kiril@dir.bg" };
            var etElena = new Agent { Name = "ET Elena", Code = "347", Phone = "0887381978", Email = "elena@dir.bg" };
            var etGabi = new Agent { Name = "ET Gabriela", Code = "348", Phone = "0883015678", Email = "gaby@dir.bg" };
            context.Agents.Add(etIvan);
            context.Agents.Add(etKiril);
            context.Agents.Add(etElena);
            context.Agents.Add(etGabi);


            var kasko = new Product { Name = "Kasko", Code = "481" };
            var grajdanska = new Product { Name = "Grajdanska Otgovornost", Code = "482" };
            var imot = new Product { Name = "Imot", Code = "483" };
            var bolest = new Product { Name = "Zaboliavane", Code = "484" };
            var prStihia = new Product { Name = "Prirodna Stihia", Code = "485" };
            context.Products.Add(kasko);
            context.Products.Add(grajdanska);
            context.Products.Add(imot);
            context.Products.Add(bolest);
            context.Products.Add(prStihia);

            context.SaveChanges();

            var firstCommision = new CompanyProdCom { CompanyId = armeec.Id, ProductId = kasko.Id, Comission = 18.5m };
            var secondCommision = new CompanyProdCom { CompanyId = bulins.Id, ProductId = grajdanska.Id, Comission = 23.4m };
            var thirdCommision = new CompanyProdCom { CompanyId = dzi.Id, ProductId = imot.Id, Comission = 11.7m };
            var fourCommision = new CompanyProdCom { CompanyId = unica.Id, ProductId = prStihia.Id, Comission = 16.8m };
            var fiveCommision = new CompanyProdCom { CompanyId = armeec.Id, ProductId = bolest.Id, Comission = 14.5m };
            context.CompanyProdComs.Add(firstCommision);
            context.CompanyProdComs.Add(secondCommision);
            context.CompanyProdComs.Add(thirdCommision);
            context.CompanyProdComs.Add(fourCommision);
            context.CompanyProdComs.Add(fiveCommision);

            kasko.CompaniesProdCom.Add(firstCommision);
            grajdanska.CompaniesProdCom.Add(secondCommision);
            imot.CompaniesProdCom.Add(thirdCommision);
            bolest.CompaniesProdCom.Add(fiveCommision);
            prStihia.CompaniesProdCom.Add(fourCommision);

            context.SaveChanges();

            var ag1Commision = new AgentProdCom { AgentId = etElena.Id, ProductId = kasko.Id, Comission = 9.23m };
            var ag2Commision = new AgentProdCom { AgentId = etGabi.Id, ProductId = imot.Id, Comission = 11.23m };
            var ag3Commision = new AgentProdCom { AgentId = etIvan.Id, ProductId = prStihia.Id, Comission = 23.23m };
            var ag4Commision = new AgentProdCom { AgentId = etKiril.Id, ProductId = bolest.Id, Comission = 8.23m };
            var ag5Commision = new AgentProdCom { AgentId = etElena.Id, ProductId = imot.Id, Comission = 15.54m };
            var ag6Commision = new AgentProdCom { AgentId = etGabi.Id, ProductId = kasko.Id, Comission = 11.60m };
            context.AgentProdComs.Add(ag1Commision);
            context.AgentProdComs.Add(ag2Commision);
            context.AgentProdComs.Add(ag3Commision);
            context.AgentProdComs.Add(ag4Commision);
            context.AgentProdComs.Add(ag5Commision);
            context.AgentProdComs.Add(ag6Commision);


            etElena.AgentsProdCom.Add(ag1Commision);
            etGabi.AgentsProdCom.Add(ag2Commision);
            etIvan.AgentsProdCom.Add(ag3Commision);
            etKiril.AgentsProdCom.Add(ag4Commision);
            etElena.AgentsProdCom.Add(ag5Commision);
            etGabi.AgentsProdCom.Add(ag6Commision);
            context.SaveChanges();

            var policy1 = new Policy
            {
                Agent = etElena,
                Company = unica,
                Customer = pesho,
                Insured = pesho,
                IssueDate = new DateTime(2016, 3, 17),
                StartDate = new DateTime(2016, 4, 21),
               // DueDate = new DateTime(2016, 5, 14),
                EndDate = new DateTime(2018, 5, 20),
                PolicyPremium = 10.2m,
                Tax = 2.3m,
                Price = 12.5m,
                Number = "1000A",
                Notes = "First Policy",
                Status = Status.Inactive,
                Product = kasko

            };
            var policy2 = new Policy
            {
                AgentId = etGabi.Id,
                CompanyId = bulins.Id,
                CustomerId = gosho.Id,
                InsuredId = gosho.Id,
                IssueDate = new DateTime(2016, 3, 16),
                StartDate = new DateTime(2016, 3, 21),
              //  DueDate = new DateTime(2016, 5, 14),
                EndDate = new DateTime(2018, 5, 20),
                PolicyPremium = 10.2m,
                Tax = 2.3m,
                Price = 12.5m,
                Number = "1001B",
                Notes = "Second Policy",
                Status = Status.Inactive,
                Product = prStihia
            };
            var policy3 = new Policy
            {
                AgentId = etKiril.Id,
                CompanyId = dzi.Id,
                CustomerId = ivan.Id,
                InsuredId = ivan.Id,
                IssueDate = new DateTime(2017, 1, 20),
                StartDate = new DateTime(2017, 1, 27),
              //  DueDate = new DateTime(2017, 6, 14),
                EndDate = new DateTime(2018, 7, 24),
                PolicyPremium = 10.2m,
                Tax = 2.3m,
                Price = 12.5m,
                Number = "C1002G",
                Notes = "Very importаnt Policy :)",
                Status = Status.Inactive,
                Product = bolest
            };
            context.Policies.Add(policy1);
            context.Policies.Add(policy2);
            context.Policies.Add(policy3);
            context.SaveChanges();

            pesho.CustomerPolicies.Add(policy1);
            pesho.InsurersPolicies.Add(policy1);
            gosho.CustomerPolicies.Add(policy2);
            gosho.InsurersPolicies.Add(policy2);
            ivan.CustomerPolicies.Add(policy3);
            ivan.CustomerPolicies.Add(policy3);
            unica.Policies.Add(policy1);
            etElena.Policies.Add(policy1);
            bulins.Policies.Add(policy2);
            etGabi.Policies.Add(policy2);
            etKiril.Policies.Add(policy3);
            dzi.Policies.Add(policy3);
            context.SaveChanges();

            var blank1 = new Blank
            {
                Number = "1a",
                AgentId = etKiril.Id,
                CompanyId = bulins.Id,
                ProductId = kasko.Id,
                TakenDate = new DateTime(2016, 1, 1),
                IssueDate = new DateTime(2016, 1, 2),
                Status = StatusB.Аvailable,
                Policy = policy1
            };
            var blank2 = new Blank
            {
                Number = "2D34",
                AgentId = etGabi.Id,
                CompanyId = dzi.Id,
                ProductId = bolest.Id,
                TakenDate = new DateTime(2016, 1, 1),
                IssueDate = new DateTime(2016, 1, 2),
                Status = StatusB.Аvailable,
                Policy = policy2
            };
            var blank3 = new Blank
            {
                Number = "3g",
                AgentId = etElena.Id,
                CompanyId = unica.Id,
                ProductId = prStihia.Id,
                TakenDate = new DateTime(2016, 1, 1),
                IssueDate = new DateTime(2016, 1, 2),
                Status = StatusB.Аvailable,
                Policy = policy3

            };
            context.Blanks.Add(blank1);
            context.Blanks.Add(blank2);
            context.Blanks.Add(blank3);
            context.SaveChanges();
            etKiril.Blanks.Add(blank1);
            etGabi.Blanks.Add(blank2);
            etElena.Blanks.Add(blank3);
            bulins.Blanks.Add(blank1);
            dzi.Blanks.Add(blank2);
            unica.Blanks.Add(blank3);
            context.SaveChanges();

            var payment1 = new Payment
            {
               // DueDate = policy1.DueDate,
               // DateOfPayment = policy1.DueDate,
                Premium = 23.2m,
                Tax = 6.02m,
                Price = 29m,
                FinalPrice = 34.21m,
                Policy = policy1,
                Company = unica,
                Agent = etElena,
                Blank = blank1,
                Status = StatusP.Unpaid,
            };
            var payment2 = new Payment
            {
             //   DueDate = policy2.DueDate,
             //   DateOfPayment = policy2.DueDate,
                Premium = 23.2m,
                Tax = 6.02m,
                Price = 29m,
                FinalPrice = 34.21m,
                Policy = policy2,
                Company = bulins,
                Agent = etGabi,
                Blank = blank2,
                Status = StatusP.Unpaid,
            };
            var payment3 = new Payment
            {
              //   DueDate = policy3.DueDate,
              //  DateOfPayment = policy3.DueDate,
                Premium = 23.2m,
                Tax = 6.02m,
                Price = 29m,
                FinalPrice = 34.21m,
                Policy = policy3,
                Company = dzi,
                Agent = etKiril,
                Blank = blank3,
                Status = StatusP.Unpaid,
            };
            context.Payments.Add(payment1);
            context.Payments.Add(payment2);
            context.Payments.Add(payment3);
            context.SaveChanges();
            policy1.Payments.Add(payment1);
            policy2.Payments.Add(payment2);
            policy3.Payments.Add(payment3);
            unica.Payments.Add(payment1);
            bulins.Payments.Add(payment2);
            dzi.Payments.Add(payment3);
            etElena.Payments.Add(payment1);
            etGabi.Payments.Add(payment2);
            etKiril.Payments.Add(payment3);
            context.SaveChanges();

            var income1 = new Income
            {
                AgentId = etElena.Id,
                PaymentId = payment1.Id,
                Product = kasko,
                AgentIncome = 24.5m,
                OfficeIncome = 12.34m,
                TotalIncome = 36.84m,
                Payment = payment1
            };
            var income2 = new Income
            {
                AgentId = etGabi.Id,
                PaymentId = payment2.Id,
                Product = bolest,
                AgentIncome = 28.5m,
                OfficeIncome = 12.34m,
                TotalIncome = 38.84m,
                Payment = payment2
            };

            var income3 = new Income
            {
                AgentId = etKiril.Id,
                PaymentId = payment3.Id,
                Product = prStihia,
                AgentIncome = 24.5m,
                OfficeIncome = 16.34m,
                TotalIncome = 40.84m,
                Payment = payment3
            };
            context.Incomes.Add(income1);
            context.Incomes.Add(income2);
            context.Incomes.Add(income3);
            context.SaveChanges();


            base.Seed(context);
        }
    }
}
