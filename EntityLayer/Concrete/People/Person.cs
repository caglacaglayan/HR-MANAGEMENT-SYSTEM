using EntityLayer.Concrete.Connection;
using EntityLayer.Concrete.Inventories;
using EntityLayer.Concrete.System;
using EntityLayer.Concrete.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.People
{
    public class Person : BaseEntity
    {
        public int PersonTypeID { get; set; }
        public PersonType PersonType { get; set; }
        public int PersonFingerID { get; set; }
        //public PersonFinger? PersonFinger { get; set; }
        public string Name { get; set; }
        public short Status { get; set; }
        public int SyncID { get; set; }

        public SysUser SysUser { get; set; }
        public PersonCard PersonCard { get; set; }

        public ICollection<PersonVisa> PersonVisas { get; set; }
        public ICollection<PersonAddress> PersonAddresses { get; set; }
        public ICollection<PersonFinger> PersonFingers { get; set; }
        public ICollection<PersonEdu> PersonEdus { get; set; }
        public ICollection<PersonSocial> PersonSocials { get; set; }
        public ICollection<PersonDocument> PersonDocuments { get; set; }
        public ICollection<PersonLeave> PersonLeaves { get; set; }

        public ICollection<Inventory> Inventories { get; set; }
        public ICollection<PersonConPosition> PersonConPositions { get; set; }
        public ICollection<SysPosition> SysPositions { get; set; }
        public ICollection<PersonConDepartment> PersonConDepartments { get; set; }
    }
}