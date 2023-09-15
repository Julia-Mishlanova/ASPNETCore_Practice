using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
