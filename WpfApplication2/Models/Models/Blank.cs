using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Blank
    {



        public int Id { get; set; }
        [Required]
        public string Number { get; set; }

        [Required]
        public string Status { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime IssueDate { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int AgentId { get; set; }

        public Agent Agent { get; set; }

        public int CompanyId { get; set; }
        public Company Company { get; set; }

        public virtual Policy Policy { get; set; }


        public virtual Payment Payment { get; set; }

        public bool IsDeleted { get; set; } = false;



    }
}
