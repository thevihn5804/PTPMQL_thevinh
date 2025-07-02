using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DEMOMVC.Models;

namespace DEMOMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
        public IActionResult Index(string FullName, string Address)
        {
        string strOutput = "Xin chao" + FullName + "Den tu" + Address;
            ViewBag.inforPerson = strOutput;
            return View();
        }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
