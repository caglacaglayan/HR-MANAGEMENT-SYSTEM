using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonLeave : BaseEntity
    {
        public int PersonID { get; set; }
        public Person Person { get; set; }
        public int PersonLeaveTypeID { get; set; }
        public PersonLeaveType PersonLeaveType { get; set; }
        public DateTime StartAt { get; set; }
        public DateTime EndAt { get; set; }
        public short Status { get; set; }
        public string LFile { get; set; }
        public string Note { get; set; }
        public int SyncID { get; set; }
    }
}
