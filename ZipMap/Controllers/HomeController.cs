using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZipMap.Model;

namespace ZipMap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
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
            return View();
        }

        public IActionResult Zip()
        {
            return View();
        }

        public IActionResult Map1(ZipLocation location)
        {
            return View(location);
        }

        public IActionResult Map2(ZipLocation location)
        {
            return View(location);
        }

        public IActionResult Map3(ZipLocation location)
        {
            return View(location);
        }

        public IActionResult Map4(ZipLocation location)
        {
            return View(location);
        }


    }
}
