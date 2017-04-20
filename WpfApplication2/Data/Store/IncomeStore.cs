using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Data.DTO;
using Models;

using System.Windows;

namespace Data.Store
{
    public class IncomeStore
    {
        public static void GenerateIncome(Payment payment)
        {


            using (var context = new BrokerDbContext())
            {
                Income income = new Income()
                {
                    IsDeleted = false,
                    TotalIncome = context.CompanyProdComs.Find(payment.CompanyId, context.Policies.Find(payment.PolicyId).ProductId).Comission * payment.Premium,
                    AgentIncome = 5M,//context.AgentProdComs.Find(payment.AgentId, payment.CompanyId).Comission * payment.Premium,
                OfficeIncome = 5M,
                    PaymentId = payment.Id,
                    AgentId = payment.AgentId
                };
                income.OfficeIncome = income.TotalIncome - income.AgentIncome;
                context.Incomes.Add(income);
                
                context.SaveChanges();
                


            }
            
        }
    }
}
