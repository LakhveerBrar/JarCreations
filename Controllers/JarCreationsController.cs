using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JarCreations.Controllers
{
    public class JarCreationsController : Controller
    {
        // 
        // GET: JarCreations

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: JarCreations

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}
