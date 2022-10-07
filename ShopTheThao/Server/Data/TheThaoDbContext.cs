using Microsoft.EntityFrameworkCore;

namespace ShopTheThao.Server.Data
{
    public class TheThaoDbContext : DbContext
    {
        public TheThaoDbContext()
        {

        }
        public TheThaoDbContext(DbContextOptions<TheThaoDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-V4BEME9\\SQLEXPRESS01;Initial Catalog=A_Test_YS;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 

        }
    }
}
