﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities.Location;
using Template.Domain.Entities.Sales;

namespace Template.Domain.Entities.Person
{
    public class Contact : Entity
    {
        public string Name { get; set; }
        public string Nickname { get; set; }

        public string PhoneCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public int AddressId { get; set; }
        public virtual Address Address { get; set; }


    }
}
