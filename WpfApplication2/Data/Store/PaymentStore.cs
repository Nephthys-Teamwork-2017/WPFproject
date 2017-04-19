using AutoMapper;
using Data.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class PaymentStore
    {
        public static IEnumerable<DueDateReportDTO> DueDateReport(BrokerDbContext context)
        {
           

            var DueDateReport = context.Payments.Where(x => x.IsDeleted == false).OrderBy(x=>x.DateOfPayment).ThenBy(x=>x.Policy.EndDate).ToList();

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
                try
                {
                    context.Payments.Add(payment);

                    context.SaveChanges();

                    return true;
                }
                catch
                {

                    return false;
                }

            }

          
        }


    }
}
