using Microsoft.AspNetCore.Mvc;
using VDLand.Models;

namespace VDLand.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {

            var user = new User();
            user.Id = 1;
            user.Name = "test";

            ViewData["Name"] = user;

            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
