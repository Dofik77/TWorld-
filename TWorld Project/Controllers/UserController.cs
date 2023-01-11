using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using TWorld_Project.Model;

namespace TWorld_Project.Controllers
{
	public class UserController : Controller
	{
		[HttpGet]
		public IActionResult Index(UserInfo ?model)
		{
			ViewData["User_Name"] = model.User_Name;
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Save(UserInfo model)
		{
			Index(model);
			return RedirectToAction("Index", model);
        }
    }
}

