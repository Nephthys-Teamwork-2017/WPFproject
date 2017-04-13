using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Premium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }
        public string Status { get; set; }
        public virtual int AgentId { get; set; }
        public virtual int CompanyId { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }


    }
}
