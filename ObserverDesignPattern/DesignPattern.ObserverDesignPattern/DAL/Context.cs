
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ObserverDesignPattern.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=H-DOGAN\\SQLEXPRESS01; initial catalog=ObserverDesignPatternDB; integrated security=true;");
        }

        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }
}
