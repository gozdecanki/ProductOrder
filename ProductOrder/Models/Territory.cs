using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class Territory
    {
        [MaxLength(20)]
        public string Id { get; set; }

        [MaxLength(50)]
        public string TerritoryDescription { get; set; }

        public int RegionId { get; set; }
        public Region Region { get; set; }
        public EmployeeTerritory EmployeeTerritory { get; set; }

    }
}
