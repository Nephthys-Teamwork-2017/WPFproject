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
           // AutoMapperConfiguration.AutoMapperConfiguration.Configure();

           // var DueDateReport = context.Payments.Where(x => x.IsDeleted == false).ToList();

           //List<DueDateReportDTO> DueDateReportDTOs = Mapper.Map<List<Payment>, List<DueDateReportDTO>>(DueDateReport);

           //return DueDateReportDTOs;

           List<DueDateReportDTO> ListDTO = new List<DueDateReportDTO>();

           DueDateReportDTO DTOItem1 = new DueDateReportDTO() { CustomerAddress = "Sofia", CustomerName = "Maria", CustomerPhone = "123", DateOfPayment = DateTime.Now, CustomerEmail = "maria@gmail.bg", FinalPrice = 14, Price = 15 };
           DueDateReportDTO DTOItem2 = new DueDateReportDTO() { CustomerAddress = "Varna", CustomerName = "Pesho", CustomerPhone = "088123481", DateOfPayment = new DateTime(2019,1,2), CustomerEmail = "pesho@abv.bg", FinalPrice = 12, Price = 11 };


            ListDTO.Add(DTOItem1);
            ListDTO.Add(DTOItem2);

            return ListDTO;
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
