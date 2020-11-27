using Microsoft.EntityFrameworkCore;
using WseiProject.Web.Entities;

namespace WseiProject.Web.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<CompanyEntity> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
    }
}
