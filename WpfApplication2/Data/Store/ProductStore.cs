using AutoMapper.QueryableExtensions;
using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class ProductStore
    {
        public static List<ProductDTO>getAllProductsByCompany(string CompanyName)
        {
            using (var context = new BrokerDbContext())
            {
                return context.CompanyProdComs.Where(x => x.Company.Name == CompanyName).Select(x => x.Product).ProjectTo<ProductDTO>().ToList();
            }

        }
    }
}
