using Microsoft.AspNetCore.Mvc;
using SimplePracticGit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimplePracticGit.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Message()
        {
            var a = new SampleModel();
                a.Msg = "Hello...........";
            return View(a);
        }
        public IActionResult Edit()
        {
            var z = new SampleModel();
            z.str = "Hi.............";
            return View(z);
        }
    }
}
