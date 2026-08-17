using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    [Authorize(Roles = "User")]
    public class UserController : Controller
    {
        public IActionResult HelloUser()
        {
            Console.WriteLine(Directory.GetCurrentDirectory());
            return View();
        }
    }
}
