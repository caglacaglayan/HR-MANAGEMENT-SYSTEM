using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.System
{
    public class SysPosition : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public int SyncID { get; set; }
        public int ParentID { get; set; }
    }
}