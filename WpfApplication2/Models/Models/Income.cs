using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Income
    {
        [Key]
        [ForeignKey("Payment")]
        public int Id { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal OfficeIncome { get; set; }
        public decimal AgentIncome { get; set; }
        public string Notes { get; set; }
        public virtual Product Product { get; set; }
        public virtual int PaymentId { get; set; }
        public virtual int AgentId { get; set; }

        public virtual Payment Payment { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
