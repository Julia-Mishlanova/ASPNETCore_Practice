using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
