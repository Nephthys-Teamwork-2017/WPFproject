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

    }
}
