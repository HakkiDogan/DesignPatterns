using Microsoft.EntityFrameworkCore;

namespace DesignPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=H-DOGAN\\SQLEXPRESS01; initial catalog=DesignPatternCQRS1; integrated security=true;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
