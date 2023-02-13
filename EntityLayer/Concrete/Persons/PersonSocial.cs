using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonSocial : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public short CTypeID { get; set; }//sor
        public short STypeID { get; set; }//sor
        public short Status { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}