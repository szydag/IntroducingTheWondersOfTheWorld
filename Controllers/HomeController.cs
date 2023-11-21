using System.Diagnostics;
using IntroducingTheWondersOfTheWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroducingTheWondersOfTheWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Navbar()
        {
            return View();
        }
        public IActionResult Slider()
        {
            return View();
        }
        public IActionResult Content()
        {
            return View();
        }
        public IActionResult Populer()
        {
            return View();
        }
        public IActionResult Footer()
        {
            return View();
        }
    }
}