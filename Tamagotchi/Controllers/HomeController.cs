using Microsoft.AspNetCore.Mvc;

namespace Tamagotchese.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
