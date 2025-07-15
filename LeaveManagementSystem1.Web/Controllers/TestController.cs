using LeaveManagementSystem1.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem1.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "Student of MVC Mastery",
                DateOfBirth = new DateTime(1954,12,09)
            };
            return View(data);
        }

        public IActionResult More()
        {
            var data = new MoreViewModel
            {
                Age = 25,
                Address = "Baburayana Koppal"
            };
            return View(data);
        }
    }
}
