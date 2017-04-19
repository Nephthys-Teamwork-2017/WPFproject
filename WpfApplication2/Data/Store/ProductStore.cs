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
                return context.CompanyProdComs.Where(x =>x.IsDeleted==false && x.Company.Name == CompanyName).Select(x => x.Product).ProjectTo<ProductDTO>().ToList();
            }

        }

        public static List<ProductDTO> getAllProducts( )
        {
            using (var context = new BrokerDbContext())
            {
                return context.Products.Where(x => x.IsDeleted==false).ProjectTo<ProductDTO>().ToList();
            }

        }

        public static int getProductIdByName(string Name)
        {
            using (var context = new BrokerDbContext())
            {
                return context.Products.Where(x => x.IsDeleted == false && x.Name==Name).FirstOrDefault().Id;
            }

        }
    }
}
