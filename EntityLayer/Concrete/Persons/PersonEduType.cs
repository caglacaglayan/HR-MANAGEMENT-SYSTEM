using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Persons
{
    public class PersonEduType : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<PersonEdu> PersonEdus { get; set; }
    }
}
