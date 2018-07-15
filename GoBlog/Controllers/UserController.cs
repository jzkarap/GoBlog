using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GoBlog.DALs;
using GoBlog.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoBlog.Controllers
{
	public class UserController : Controller
	{
		UserDAL userDAL = new UserDAL();

		public IActionResult Index()
		{
			IList<User> allUsers = userDAL.GetAllUsers();

			return View(allUsers);
		}

		[HttpGet]
		public IActionResult PostsByUser(string username)
		{
			User user = userDAL.GetUser(username);

			return View(user);
		}

		[HttpGet]
		public IActionResult CreateNewUser()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult CreateNewUser(User newUser)
		{
			return View();
		}
    }
}