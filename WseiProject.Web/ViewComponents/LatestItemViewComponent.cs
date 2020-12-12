using Microsoft.AspNetCore.Mvc;
using System.Linq;
using WseiProject.Web.Database;

namespace WseiProject.Web.ViewComponents
{
    public class LatestItemViewComponent : ViewComponent
    {
        private readonly ExchangesDbContext _dbContext;

        public LatestItemViewComponent(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            var latestItem = _dbContext.Items.OrderByDescending(x => x.Id).First();

            return View(latestItem);
        }
    }
}
