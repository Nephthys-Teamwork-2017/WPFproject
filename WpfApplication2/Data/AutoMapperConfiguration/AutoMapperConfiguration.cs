using AutoMapper;
using Data.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.AutoMapperConfiguration
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.CreateMap<Payment, DueDateReportDTO>()
                .ForMember(dto => dto.CustomerName, opt => opt.MapFrom(src => src.Policy.Customer.Name))
                .ForMember(dto => dto.CustomerEmail, opt => opt.MapFrom(src => src.Policy.Customer.Email))
                .ForMember(dto => dto.CustomerPhone, opt => opt.MapFrom(src => src.Policy.Customer.Phone))
                .ForMember(dto => dto.CustomerAddress, opt => opt.MapFrom(src => src.Policy.Customer.Address))
                .ForMember(dto => dto.DateOfPayment, opt => opt.MapFrom(src => src.DateOfPayment))
                .ForMember(dto => dto.FinalPrice, opt => opt.MapFrom(src => src.FinalPrice));

                    cfg.CreateMap<Company, CompanyDTO>();
                    cfg.CreateMap<Agent, AgentDTO>();
                }

               );

        }

    }
}
