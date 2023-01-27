﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonEdu : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int PersonEduTypeID { get; set; }
        public PersonEduType PersonEduType { get; set; }
        public string InstitutionName { get; set; }
        public string SectionName { get; set; }
        public string LFile { get; set; }
        public int EndYear { get; set; }
    }
}