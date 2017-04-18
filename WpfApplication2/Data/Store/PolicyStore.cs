using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Store
{
    public class PolicyStore
    {
        public static bool AddPolicy(Policy policy)
        {

            using (var context = new BrokerDbContext())
            {
                try
                {
                    context.Policies.Add(policy);
                    context.SaveChanges();
                    
                }
                catch
                {
                    return false;
                }
            }
            return true;

        }


    }
}
