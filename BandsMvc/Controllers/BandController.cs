using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{
    public class BandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
