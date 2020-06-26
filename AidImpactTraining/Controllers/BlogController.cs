using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AidImpactTraining.Models;
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
            return View();
        }

        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            // If isn't valid get back to basic view
            if (!ModelState.IsValid)
                return View();

            // Default values for author and date
            post.Author = User.Identity.Name; // Better than unknown isn't it =)
            post.Posted = DateTime.Now;

            // data base part
            return View(post);
        }
    }
}
