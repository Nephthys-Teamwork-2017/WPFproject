using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public Product()
        {
            this.Companies = new HashSet<Company>();
            this.Agents = new HashSet<Agent>();
            this.Policies = new HashSet<Policy>();
            this.Blanks = new HashSet<Blank>();
        }
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Agent> Agents { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual int IncomeId { get; set; }
    }
}
