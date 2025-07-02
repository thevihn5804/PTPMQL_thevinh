using DEMOMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DEMOMVC.Controllers
{
    public class personController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Person ps)
        {
            string strOutput = ps.PersonID + "-" + ps.FullName + "-" + ps.Address;
            ViewBag.inforPerson = strOutput;
            return View();
        }
    }
}