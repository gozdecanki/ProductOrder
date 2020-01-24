using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class Shipper
    {
        public int Id { get; set; }

        [MaxLength(40)]
        public string CompanyName { get; set; }

        [MaxLength(24)]
        public string Phone { get; set; }

        public Order Order { get; set; }
    }
}
