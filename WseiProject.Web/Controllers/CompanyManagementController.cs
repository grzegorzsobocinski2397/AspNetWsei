using Microsoft.AspNetCore.Mvc;
using WseiProject.Web.Database;
using WseiProject.Web.Entities;
using WseiProject.Web.Models;
using WseiProject.Web.Models.Responses;

namespace WseiProject.Web.Controllers
{
    [ApiController]
    [Route("api/CompanyManagement")]
    public class CompanyManagementController : ControllerBase
    {
        private readonly ExchangesDbContext _dbContext;

        public CompanyManagementController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public AddNewItemResponse Add(CompanyModel company)
        {
            bool isValid = company.IsValid();
            AddNewItemResponse response = new AddNewItemResponse() { IsSuccess = isValid };

            if (isValid)
            {
                AddCompany(company);
            }

            return response;
        }

        private void AddCompany(CompanyModel company)
        {
            var entity = new CompanyEntity
            {
                Name = company.Name,
                Description = company.Description,
                IsVisible = company.IsVisible
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();
        }
    }
}