using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class DueDateReportDTO
    {
       
        public DateTime DateOfPayment { get; set; }
     
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerEmail { get; set; }

        

      
    }
}
