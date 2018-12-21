﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    public class Set
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public Set()
        {
            this.Jewelry = new HashSet<Jewelry>();
        }
        public virtual ICollection<Jewelry> Jewelry { get; set; }

    }
}
