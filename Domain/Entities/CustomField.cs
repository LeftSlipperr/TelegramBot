﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CustomField : BaseEntity
    {
        public string Name { get; set; }
        public string Value { get; set; }

    }
}
