using Microsoft.AspNetCore.Mvc;

namespace WseiProject.Web.Controllers
{
    public class ExchangesController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }
    }
}
