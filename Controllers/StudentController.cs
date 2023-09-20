using Microsoft.AspNetCore.Mvc;

namespace UTCLab2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
