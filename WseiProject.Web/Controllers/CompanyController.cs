using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WseiProject.Web.Database;
using WseiProject.Web.Models;

namespace WseiProject.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public CompanyController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;

        }

        [HttpGet]
        public IActionResult AddCompany()
        {
            return View("AddCompany");
        }

        [HttpGet]
        public IActionResult List()
        {
            List<CompanyModel> companies = _dbContext.Items.Select(entity => new CompanyModel(entity)).ToList();
            return View("List", companies);
        }

    }
}
