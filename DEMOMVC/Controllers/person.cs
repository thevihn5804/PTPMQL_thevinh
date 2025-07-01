using DEMOMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMOMVC.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonModel ps)
        {
            string strOutput = ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.inforPerson = strOutput;
            return View();
        }
    }
}