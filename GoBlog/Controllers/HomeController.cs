using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GoBlog.Models;
using GoBlog.DALs;

namespace GoBlog.Controllers
{
    public class HomeController : Controller
    {
		static PostDAL postDAL = new PostDAL();

		public IActionResult Index()
        {
			IList<Post> allPosts = postDAL.GetAllPosts();
			return View(allPosts);
        }

		[HttpGet]
		public IActionResult FullPost(int id)
		{
			Post post = postDAL.GetPost(id);
			return View(post);
		}

		[HttpGet]
		public IActionResult CreatePost()
		{
			return View();
		}

		[HttpPost]
		public IActionResult CreatePost(Post post)
		{
			postDAL.CreatePost(post);
			// Create temp data "message_created"
			return RedirectToAction("Index");
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
