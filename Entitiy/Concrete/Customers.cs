﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitiy.Concrete
{
    public class Customers : IEntity
    {
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
