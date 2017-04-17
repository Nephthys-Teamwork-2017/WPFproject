using AutoMapper.QueryableExtensions;
using Data.DTO;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class CompanyStore
    {
        public static bool AddCompany(BrokerDbContext context,Company company)
        {

            try
            {


                context.Companies.Add(company);

                context.SaveChanges();

            }
            catch
            {
                return false;
            }

            return true;

        }

        public static IEnumerable<CompanyDTO> GetAllCompanies(BrokerDbContext context)
        {

            return context.Companies.ProjectTo<CompanyDTO>().ToList();


        }


    }
}
