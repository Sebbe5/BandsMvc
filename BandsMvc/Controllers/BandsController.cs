using Acme.Models;
using BandsMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BandsMvc.Controllers
{

    public class BandsController : Controller
    {
        DataService dataService = new DataService();
        [HttpGet("")]
        public IActionResult Index()
        {
            Band[] model = dataService.GetAllBands();
            return View(model);
        }
    }
}
