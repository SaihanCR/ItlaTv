﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class BaseBasicEntity
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
    }
}
