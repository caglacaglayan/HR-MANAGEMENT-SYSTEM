using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonVisa : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int PersonVisaTypeID { get; set; }
        public PersonVisaType PersonVisaType { get; set; }
        public string Title { get; set; }
        public short Status { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime EndedAt { get; set; }
        public int SyncID { get; set; }
    }
}
