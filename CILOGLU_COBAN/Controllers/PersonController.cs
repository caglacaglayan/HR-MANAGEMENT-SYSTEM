using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Models;
using EntityLayer.Concrete.Persons;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace CILOGLU_COBAN.Controllers
{
    public class PersonController : Controller
    {
        Context _context;
        EFPersonDal efd;
        PersonManager mg;

        public PersonController(Context context)
        {
            _context = context;
            efd = new EFPersonDal(context);
            mg = new PersonManager(efd);
        }

        public IActionResult Index()
        {
            var personValues = mg.GetList();
            return View(personValues);
        }

        [HttpGet]
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            PersonValidator validationRules = new PersonValidator();
            ValidationResult validationResult = validationRules.Validate(person);
            if (validationResult.IsValid)
            {
                mg.AddPerson(person);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validationResult.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeletePerson(int id)
        {
            var personValue = mg.GetByID(id);
            mg.DeletePerson(personValue);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DetailPerson(int id)
        {
            var personValue = mg.GetByID(id);
            return View(personValue);
        }

        [HttpGet]
        public IActionResult UpdatePerson(int id)
        {
            var personValue = mg.GetByID(id);
            return View(personValue);
        }

        [HttpPost]
        public IActionResult UpdatePerson(Person person)
        {
            PersonValidator pv = new PersonValidator();
            ValidationResult results = pv.Validate(person);
            if (results.IsValid)
            {
                mg.UpdatePerson(person);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
