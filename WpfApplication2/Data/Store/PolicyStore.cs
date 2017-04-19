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

        public static IEnumerable<string> GetAllPolicyNumbers()
        {
            using (var context = new BrokerDbContext())
            {
                return context.Policies.Where(x => x.IsDeleted == false).Select(x=>x.Number.ToString()).ToList();
            }

        }

        public static int GetAllPolicyIdByNumber(string Number)
        {
            using (var context = new BrokerDbContext())
            {
                return context.Policies.Where(x => x.IsDeleted == false && x.Number==Number).FirstOrDefault().Id;
            }

        }


    }
}
