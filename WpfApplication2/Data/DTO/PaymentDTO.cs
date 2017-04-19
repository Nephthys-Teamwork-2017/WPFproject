using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class PaymentDTO
    {
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Premium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }
        public StatusP Status { get; set; }

        public string AgentName { get; set; }

        public string PolicyNumber { get; set; }

        public string BlankNumber { get; set; }
      
        public string CompanyName { get; set; }

        

      
    }
}
