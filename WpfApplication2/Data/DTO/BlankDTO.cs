using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    
    public class BlankDTO
    {
        public int Id { get; set; }
     
        public string Number { get; set; }

       
        public StatusB Status { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime IssueDate { get; set; }

        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string AgentName { get; set; }

        public string CompanyName { get; set; }
            
        public string PolicyNumber { get; set; }

        


    }
}
