﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Domain.Entities.Production;

namespace Template.Domain.Entities.Sales
{
    public class Order : Entity
    {
        public ICollection<OrderProduct> Products { get; set; }
    }
}
