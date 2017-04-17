using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
            this.Payments = new HashSet<Payment>();
        }
        public int Id { get; set; }
        public int Number { get; set; }

        public Customer Customer { get; set; }
        public int InsuredId { get; set; }
        public Customer Insured { get; set; }

        public Agent Agent { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }


        public Company Company { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate
        {
            get
            {
                return this.EndDate;
            }
            set
            {
                if (!(value > this.StartDate))
                {
                    throw new ArgumentException("EndDate must be after StartDate!");
                }

                this.EndDate = value;
            }
        }
        public decimal PolicyPremium { get; set; }
        public decimal Tax { get; set; }
        public decimal Price { get; set; }
        public enum Status { Active, Inactive, Cancelled }
        public string Notes { get; set; }

        public virtual ICollection<Blank> Blanks { get; set; }

        public virtual ICollection<Payment> Payments { get; set; }

        public bool IsDeleted { get; set; } = false;


    }
}