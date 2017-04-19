using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public Product()
        {

            this.CompaniesProdCom = new HashSet<CompanyProdCom>();
            this.Policies = new HashSet<Policy>();
            this.Blanks = new HashSet<Blank>();
            this.AgentsProdCom = new HashSet<AgentProdCom>();
            this.Incomes = new HashSet<Income>();
        }
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
        public virtual ICollection<AgentProdCom> AgentsProdCom { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual ICollection<Income> Incomes { get; set; }
        public virtual ICollection<CompanyProdCom> CompaniesProdCom { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
