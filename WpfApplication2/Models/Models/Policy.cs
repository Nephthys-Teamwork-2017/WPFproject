using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public enum Status { Active, Inactive, Cancelled }
    public class Policy
    {
        public Policy()
        {
            this.Blanks = new HashSet<Blank>();
            this.Payments = new HashSet<Payment>();
        }
        public int Id { get; set; }
        public string Number { get; set; }

        public int? CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int? InsuredId { get; set; }
        public virtual Customer Insured { get; set; }

        public int? AgentId { get; set; }
        public virtual Agent Agent { get; set; }

        public int? ProductId { get; set; }
        public virtual Product Product { get; set; }

        public int? CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
      
        public decimal PolicyPremium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }

         
        public Status Status { get; set; }
        public string Notes { get; set; }

        public virtual ICollection<Blank> Blanks { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public bool IsDeleted { get; set; } = false;


    }
}
