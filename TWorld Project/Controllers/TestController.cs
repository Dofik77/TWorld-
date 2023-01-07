using Microsoft.AspNetCore.Mvc;

namespace TWorld_Project.Controllers
{
    public class TestController : Controller
    {
        //class - ControllerTest. Get this from Program.cs 

        public IActionResult Index()
        {
            return View();
        }
    }
}
