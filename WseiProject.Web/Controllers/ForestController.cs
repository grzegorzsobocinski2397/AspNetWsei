using Microsoft.AspNetCore.Mvc;

namespace WseiProject.Web.Controllers
{
    public class ForestController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
