using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVia { get; set; }
        public double Freight { get; set; }
        [MaxLength(40)]
        public string ShipName { get; set; }
        [MaxLength(60)]
        public string ShipAddress { get; set; }
        [MaxLength(15)]
        public string ShipCity { get; set; }
        [MaxLength(15)]
        public string ShipRegion { get; set; }
        [MaxLength(10)]
        public string ShipPostalCode { get; set; }
        [MaxLength(15)]
        public string ShipCountry { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }


        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
