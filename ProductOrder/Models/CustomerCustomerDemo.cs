using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class CustomerCustomerDemo
    {


        [Key, MaxLength(5)]
        public string CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }


        [Key, MaxLength(10)]
        public string CustomerTypeId { get; set; }

        [ForeignKey("CustomerTypeId")]
        public CustomerDemographic CustomerDemographic { get; set; }


    }
}
