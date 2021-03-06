﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public enum StatusB { Аvailable, Used, Cancelled }
    public class Blank
    {



        public int Id { get; set; }
        [Required]
        public string Number { get; set; }

        [Required]
        public StatusB Status { get; set; }
        public DateTime TakenDate { get; set; }
        public DateTime IssueDate { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int AgentId { get; set; }

        public virtual Agent Agent { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int PolicyId { get; set; }
        public virtual Policy Policy { get; set; }

        public int? PaymentId { get; set; }
        public virtual Payment Payment { get; set; }

        public bool IsDeleted { get; set; } = false;



    }
}
