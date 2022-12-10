using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities.Location;

namespace Template.Domain.Entities.Person
{
    public class Contact : Entity
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public string PhoneCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }


        public int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }
}
