using Microsoft.AspNetCore.Mvc;
using mvcSys.Models;

namespace mvcSys.Controllers
{
    public class UserController : Controller
    {
        public IActionResult ShowProfile()
        {
            //new User() { Name = "Gaurav", Password = "*****" }
            return View(new User() { Name = "Gaurav", Password = "*****" });
        }
        public IActionResult ChangePassword()
        {
            return View();
        }
    }
}
