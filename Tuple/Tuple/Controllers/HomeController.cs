using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tuple.Models;

namespace Tuple.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var student = new Student { Id = 1, Name = "Ahmad", Age = 70 };
            var course = new Course { CourseId = 1, CourseName = "Data Structure", InstructorName = "Dr Sami" };
            var data = (student, course);
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
