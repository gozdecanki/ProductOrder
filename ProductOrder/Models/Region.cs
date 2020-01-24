using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrder.Models
{
    public class Region
    {
       
        public int Id { get; set; }

        [MaxLength(50)]
        public string RegionDescription { get; set; }

        public Territory Territory { get; set; }
    }
}
