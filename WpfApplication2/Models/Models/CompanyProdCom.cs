using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CompanyProdCom
    {
        [Key, Column(Order = 0)]
        public int CompanyId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        public virtual Company Company { get; set; }

        public virtual Product Product { get; set; }
        public decimal Comission { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
