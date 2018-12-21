using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    public class JewelrySet
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public JewelrySet()
        {
           this.Jewelry = new HashSet<Jewelry>();
        }

        public virtual ICollection<Jewelry> Jewelry { get; set; }

    }
}
