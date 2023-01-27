﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonLeaveType : BaseEntity
    {
        public short IsPaid { get; set; }
        public short IsDamaged { get; set; }
        public short Status { get; set; }
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
    }
}