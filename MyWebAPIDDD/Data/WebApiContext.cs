using Microsoft.EntityFrameworkCore;
using MyWebAPI.Entities;

namespace MyWebAPI.Data
{
    public class WebApiContext : DbContext
    {
        public WebApiContext(DbContextOptions<WebApiContext> options) : base(options)
        {

        }


        public DbSet<Produto> Produtos { get; set; }
    }
}
