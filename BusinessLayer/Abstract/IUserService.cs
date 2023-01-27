using EntityLayer.Concrete.Persons;
using EntityLayer.Concrete.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService
    {
        List<SysUser> GetList();
        void AddUser(SysUser user);
        void DeleteUser(SysUser user);
        void UpdateUser(SysUser user);
		SysUser GetByUsername(string p);
		SysUser GetByUsernameAndPassword(SysUser user);
		SysUser GetByID(int id);
    }
}
