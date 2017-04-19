using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum StatusP { Paid, Unpaid, Cancelled }
    public class Payment
    {
       
        
        public int Id { get; set; }
        public DateTime DateOfPayment { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Premium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public decimal FinalPrice { get; set; }
        public StatusP Status { get; set; }
        public int AgentId { get; set; }
        public virtual Agent Agent { get; set; }


        public int PolicyId { get; set; }

        public virtual Policy Policy { get; set; }

        public int? BlankId { get; set; }
        
        public virtual Blank Blank { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual Income Income { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
