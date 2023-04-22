using Microsoft.EntityFrameworkCore;

namespace L01P02_2019AP650_2019SM601.Models
{
    public class RestauranteDBcontext : DbContext
    {

        public RestauranteDBcontext(DbContextOptions options) : base(options) { 
        

        }
        public DbSet<pedidos> pedidos{ get; set; }

        public DbSet<platos> platos{ get; set; }

        public DbSet<motoristas> motoristas{ get; set; }

        public DbSet<clientes> clientes { get; set; }
    }
}
