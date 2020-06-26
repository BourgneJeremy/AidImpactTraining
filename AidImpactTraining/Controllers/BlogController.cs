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
        private readonly BlogDataContext _db;

        public BlogController(BlogDataContext _db)
        {
            this._db = _db;
        }

        [Route("")]
        public IActionResult Index()
        {
            // retrieve all the posts and display them
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray();

            return View(posts);
        }

        [Route("{key}/{month:range(1,12)}/{year:min(1950)}")]
        public IActionResult Post(string key, int month, int year)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            return View(post);
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

            _db.Posts.Add(post);
            _db.SaveChanges();

            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }
    }
}
