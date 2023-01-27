using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace CILOGLU_COBAN.Controllers
{
    public class UserController : Controller
    {
        Context _context;
        EFUserDal efd;
        UserManager mg;

        public UserController(Context context)
        {
            _context = context;
            efd = new EFUserDal(context);
            mg = new UserManager(efd);
        }
        public IActionResult Index()
        {
            var userValues = mg.GetList();
            return View(userValues);
        }
    }
}
