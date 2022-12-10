using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities.Location;

namespace Template.Domain.Entities.Person
{
    public class Company : Entity
    {
        public string Name { get; set; }
        public string BusinessName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }


        public int AddressId { get; set; }
        public virtual Address Address { get; set; }


        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
