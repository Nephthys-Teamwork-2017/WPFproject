using AutoMapper.QueryableExtensions;
using Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class CustomerStore
    {
        public static IEnumerable<CustomerDTO> GetAllCustomers()
        {
            using (var context = new BrokerDbContext())
            {
                return context.Customers.Where(x => x.IsDeleted == false).ProjectTo<CustomerDTO>().ToList();
            }
        }
    }

}
