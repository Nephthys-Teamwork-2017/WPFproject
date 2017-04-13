using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
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
