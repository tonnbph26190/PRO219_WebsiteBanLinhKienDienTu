using AppData.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class SalesEntity:BaseEntity
    {
        public Guid Id { get; set; }
        public decimal ReducedAmount { get; set; }

        public DateTime? FromDate { get; set; }

        public DateTime? ToDate{ get; set; }

        public string? Note { get; set; }

        public int Status { get; set; }

        
    }
}
