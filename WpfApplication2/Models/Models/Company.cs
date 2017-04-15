﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Company
    {
        public Company()
        {
            this.Blanks = new HashSet<Blank>();
            this.Policies = new HashSet<Policy>();
            this.Payments = new HashSet<Payment>();
            this.CompaniesProdCom = new HashSet<CompanyProdCom>();

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Notes { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<CompanyProdCom> CompaniesProdCom { get; set; }

    }
}
