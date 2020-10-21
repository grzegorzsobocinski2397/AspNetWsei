using Microsoft.AspNetCore.Mvc;

namespace WseiProject.Web.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}
