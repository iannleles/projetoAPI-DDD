using Microsoft.EntityFrameworkCore;
using MyWebAPI.Domain.Entities;

namespace MyWebAPI.Infra.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {

        }


        public DbSet<Produto> Produtos { get; set; }
    }
}
