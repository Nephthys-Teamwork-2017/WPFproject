using Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class AgentsByPoliciesDTO
    {
        public AgentsByPoliciesDTO(BrokerDbContext context, Agent agent)

        {
            this.PoliciesCount = context.Policies.Where(x => x.Id == agent.Id).Count();
            this.AgentName = agent.Name;
        }

        public int PoliciesCount { get; set; }
        public string AgentName { get; set; }
    }
}
