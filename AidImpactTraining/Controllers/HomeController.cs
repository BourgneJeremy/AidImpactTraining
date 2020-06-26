using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AidImpactTraining.Controllers
{
    public class HomeController : Controller
    {
        // Every method in a Controller class is an action
        public IActionResult Index()
        {
            return View();
        }
    }
}
