using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Blank
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime IssueDate { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int AgentId { get; set; }
        public virtual int PolicyId { get; set; }
        public virtual int CompanyId { get; set; }

    }
}
