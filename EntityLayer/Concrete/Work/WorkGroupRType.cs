﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Work
{
    public class WorkGroupRType : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<WorkGroup> WorkGroups { get; set; }
    }
}