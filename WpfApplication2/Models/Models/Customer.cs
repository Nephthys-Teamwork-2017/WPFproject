using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public Customer()
        {
            this.Policies = new HashSet<Policy>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
