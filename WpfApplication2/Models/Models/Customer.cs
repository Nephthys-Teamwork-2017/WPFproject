using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public Customer()
        {
            this.CustomerPolicies = new HashSet<Policy>();
            this.InsurersPolicies = new HashSet<Policy>();
        }
        public int Id { get; set; }


        [InverseProperty("Customer")]
        public ICollection<Policy> CustomerPolicies { get; set; }
        [InverseProperty("Insured")]
        public ICollection<Policy> InsurersPolicies { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }

        public string StatePersonalNumber { get; set; }

    }
}
