using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AMV.Models;

namespace AMV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Health()
        {
            return View();
        }

        public IActionResult Animal()
        {
            return View();
        }

        public IActionResult Environment()
        {
            return View();
        }

        public IActionResult Veganism()
        {
            return View();
        }

        public IActionResult FoodChanges()
        {
            return View();
        }

        public IActionResult Recipes()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
