using Microsoft.AspNetCore.Mvc;

namespace FilemakerWebPortal.Controllers
{
    public class AttendanceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
