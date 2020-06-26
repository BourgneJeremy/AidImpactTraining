using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AidImpactTraining.Model;
using Microsoft.AspNetCore.Mvc;

namespace AidImpactTraining.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("{key:range(1, 31)}/{month:range(1,12)}/{year:min(1950)}")]
        public IActionResult Post(int key, int month, int year)
        {
            return new ContentResult { Content = $"Article créé le {key}/{month}/{year}" };
        }

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return new ContentResult { Content = "Create method" };
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            return new ContentResult { Content = $"id :" };
        }
    }
}
