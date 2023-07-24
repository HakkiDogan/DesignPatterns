using Microsoft.EntityFrameworkCore;

namespace DesignPattern.ChainOfResponsibility.DAL
{
	public class Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=H-DOGAN\\SQLEXPRESS01;" +
				"initial catalog =DesignPattern1; integrated security= true");
		}

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
