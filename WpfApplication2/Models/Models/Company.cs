using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public string Address { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [MaxLength(250)]
        public string Notes { get; set; }
        public virtual ICollection<Blank> Blanks { get; set; }
        public virtual ICollection<Policy> Policies { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<CompanyProdCom> CompaniesProdCom { get; set; }

        public bool IsDeleted { get; set; } = false;

    }
}
