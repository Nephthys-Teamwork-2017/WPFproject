using AutoMapper;
using Data.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Data.Store
{
    public class PaymentStore
    {
        public static IEnumerable<DueDateReportDTO> DueDateReport(BrokerDbContext context)
        {
           

            var DueDateReport = context.Payments.Where(x => x.IsDeleted == false && x.Policy.Customer.IsDeleted==false).OrderBy(x=>x.DateOfPayment).ThenBy(x=>x.Policy.EndDate).ToList();

            List<DueDateReportDTO> DueDateReportDTOs = Mapper.Map<List<Payment>, List<DueDateReportDTO>>(DueDateReport);

            return DueDateReportDTOs;


        }


        public static IEnumerable<PaymentDTO> getAllPayments( )
        {

            using (var context = new BrokerDbContext())
            {
                var payments = context.Payments.Where(x => x.IsDeleted == false).ToList();
                List<PaymentDTO> paymentDTOs = Mapper.Map<List<Payment>, List<PaymentDTO>>(payments);
                return paymentDTOs;
            }
            
        }

        public static bool AddPayment(Payment payment)
        {
             
            using (var context = new BrokerDbContext())
            {
                
                {
                    context.Payments.Add(payment);

                    context.SaveChanges();


                    var income2 = new Income
                    {
                        AgentId = 1,
                        PaymentId = 1,
                        Product = context.Products.FirstOrDefault(),
                        AgentIncome = 1928.5m,
                        OfficeIncome = 1912.34m,
                        TotalIncome = 1938.84m,
                        Payment = context.Payments.FirstOrDefault(),
                        Id=123
                    };

                    context.Incomes.Add(income2);
                    
                    context.SaveChanges();

                    return true;
                }
                
                {

                    return false;
                }

            }

          
        }


    }
}
