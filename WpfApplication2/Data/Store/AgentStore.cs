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
    public class AgentStore
    {
        public static bool AddAgent(BrokerDbContext context, Agent agent)
        {

            try
            {
                context.Agents.Add(agent);
                context.SaveChanges();

            }
            catch
            {
                return false;
            }
            return true;

        }


        public static IEnumerable<AgentDTO> GetAllAgents()
        {
            using (var context = new BrokerDbContext())
            {
                return context.Agents.Where(x => x.IsDeleted == false).ProjectTo<AgentDTO>().ToList();
            }

        }


    }
}
