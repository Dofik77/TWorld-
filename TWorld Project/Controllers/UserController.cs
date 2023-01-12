using System;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using TWorld_Project.Model;

namespace TWorld_Project.Controllers
{
	public class UserController : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Save(UserInfo model)
		{
			return View("Index", model);
        }
    }
}

