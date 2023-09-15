using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class AirportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
