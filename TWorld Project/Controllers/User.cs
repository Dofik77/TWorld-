using System;
using Microsoft.AspNetCore.Mvc;

namespace TWorld_Project.Controllers
{
	public class User : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Edit()
		{
			return View();
		}
	}
}

