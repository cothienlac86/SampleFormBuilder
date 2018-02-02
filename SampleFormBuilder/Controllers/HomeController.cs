using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using FormFactory;
using Microsoft.AspNetCore.Mvc;
using SampleFormBuilder.Models;

namespace SampleFormBuilder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new RegisterModel();

            return View(model);
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
