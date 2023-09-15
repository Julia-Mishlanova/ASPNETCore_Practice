using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class FlightController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
