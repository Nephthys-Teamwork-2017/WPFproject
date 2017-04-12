using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Income
    {
        public int Id { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal OfficeIncome { get; set; }
        public decimal AgentCommission { get; set; }
        public string Notes { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int PaymentId { get; set; }
        public virtual int AgentId { get; set; }
    }
}
