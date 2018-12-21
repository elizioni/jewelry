using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    public class Category
    {

        public Category()
        {
            this.Jewelry = new HashSet<Jewelry>();
        }
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual ICollection<Jewelry> Jewelry { get; set; }


    }
}
