using Microsoft.AspNetCore.Mvc;

namespace WebApplication7.Areas.adminkanermin.Controllers
{
    public class HomeController : Controller
    {
        [Area("adminkanermin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
