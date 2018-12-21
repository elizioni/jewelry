using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    public class Branch
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double? CoordinateLat { get; set; }
        public double? CoordinateLng { get; set; }
        public int? ManagerId { get; set; }
        public int Id { get; set; }


        public virtual Users Manager { get; set; }

    }

}
