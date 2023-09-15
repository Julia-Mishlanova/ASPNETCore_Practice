using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class FlightStatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
