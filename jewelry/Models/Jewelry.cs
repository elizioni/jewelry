using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    public class Jewelry
    {
        public double? Weight { get; set; }
        public double Price { get; set; }
        public int? Cart { get; set; }
        public int? Size { get; set; }
        public string Description { get; set; }
        public int? Amount { get; set; }
        public double? Discount { get; set; }
        public int Id { get; set; }
        public bool Diamonds { get; set; }
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int SetId { get; set; }
        


    }
}
