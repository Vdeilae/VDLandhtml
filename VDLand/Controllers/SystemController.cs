using Microsoft.AspNetCore.Mvc;

namespace VDLand.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(string username, string password)
        {
            if (username == "root" && password == "root")
            {
                return View("Views/System/Index.cshtml");

            }
            else if(username == "" && password == "")
            {
                ViewBag.ErrorMessage = "请输入账号密码";
                return View();
            }
            else
            {
                ViewBag.ErrorMessage = "账号或密码错误,请重试。";
                return View();
            }
        }
    }
}
