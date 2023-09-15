using Microsoft.AspNetCore.Mvc;

namespace ASPNETCore_Practice.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
