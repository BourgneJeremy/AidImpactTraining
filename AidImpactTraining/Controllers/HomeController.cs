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

        /// <summary>
        /// Main page
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Error page
        /// </summary>
        /// <returns></returns>
        [Route("error")]
        public IActionResult Error()
        {
            return View();
        }
    }
}
