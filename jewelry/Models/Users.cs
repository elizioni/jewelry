using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jewelry.Models
{
    //  public static DateTime Today { get; }

    public class Users
    {
        private DateTime? creationDate;

        public string Email { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public string Gender { get; set; }
        public int Id { get; set; }
        public string NameId { get; set; }

        public DateTime? CreationDate { get => creationDate; set => creationDate = value; }
        public Users()
        {
            this.Branch = new HashSet<Branch>();
            this.Purchase = new HashSet<Purchase>();
        }
        public ICollection<Branch> Branch { get; set; }
        public virtual ICollection<Purchase> Purchase { get; set; }

    }
}
