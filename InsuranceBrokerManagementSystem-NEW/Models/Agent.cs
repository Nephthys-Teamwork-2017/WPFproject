﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Agent
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
