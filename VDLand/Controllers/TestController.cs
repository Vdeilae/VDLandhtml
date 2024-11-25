using Microsoft.AspNetCore.Mvc;
using VDLand.Models;

namespace VDLand.Controllers
{
    public class TestController : Controller
    {
        private IConfiguration Configuration;

        public TestController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IActionResult Index()
        {

            var user = new User();
            user.Id = 1;
            user.Name = "test";

            var DateBaseHost = Configuration["DataBase:Host"];
            var DateBasePort = Configuration["DataBase:Port"];
            var DateBaseUserName = Configuration["DataBase:UserName"];
            var DateBasePassWord = Configuration["DataBase:PassWord"];

            ViewData["Name"] = user;

            return View(user);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
