using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

    public class Policy
    {
        public Policy()
        {
            this.Blanks = new HashSet<Blank>();
        }
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PolicyPremium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string Notes { get; set; }    
        public virtual ICollection<Blank> Blanks { get; set; }


    }
}
