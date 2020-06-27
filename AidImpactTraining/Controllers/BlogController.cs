using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AidImpactTraining.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AidImpactTraining.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;

        /// <summary>
        /// Helps us to connect to the local database
        /// </summary>
        /// <param name="_db"></param>
        public BlogController(BlogDataContext _db)
        {
            this._db = _db;
        }

        /// <summary>
        /// Main blog route that displays blog posts with paging functionnality
        /// </summary>
        /// <returns>The post</returns>
        [Route("")]
        public IActionResult Index(int page = 0)
        {
            var pageSize = 2;
            var totalPosts = _db.Posts.Count();
            var totalPages = totalPosts / pageSize;
            var previousPage = page - 1;
            var nextPage = page + 1;

            ViewBag.PreviousPage = previousPage;
            ViewBag.HasPreviousPage = previousPage >= 0;
            ViewBag.NextPage = nextPage;
            ViewBag.HasNextPage = nextPage < totalPages;

            var posts =
                _db.Posts
                    .OrderByDescending(x => x.Posted)
                    .Skip(pageSize * page)
                    .Take(pageSize)
                    .ToArray();

            if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
                return PartialView(posts);

            return View(posts);
        }

        /// <summary>
        /// Route that shows the post thanks to his name followed by the date
        /// Example: "blog/elections-municipales-2020/6/2020"
        /// </summary>
        /// <param name="key">day</param>
        /// <param name="month">month</param>
        /// <param name="year">year</param>
        /// <returns></returns>
        [Route("{key}/{month:range(1,12)}/{year:min(1950)}")]
        public IActionResult Post(string key, int month, int year)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            return View(post);
        }

        /// <summary>
        /// Shows the view to create the post
        /// </summary>
        /// <returns></returns>
        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Get the data from the post creation, saves it into the database and redirect the user to the post
        /// </summary>
        /// <param name="post"></param>
        /// <returns></returns>
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
