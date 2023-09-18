using DesignPattern.ObserverDesignPattern.DAL;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateMagazineAnnouncement : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
		Context _context = new();

		public CreateMagazineAnnouncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreateNewUser(AppUser appUser)
        {
            _context.UserProcesses.Add(new UserProcess
            {
                FullName = appUser.Name + " " + appUser.Surname,
                Magazine = "Bilim Dergisi",
                Content = "Bilim Dergimiz Ekim Sayısı  1 Ekimde evinize teslim edilicektir, konular Jupiter ve Mars Gezegeni olacaktır."
            });
            _context.SaveChanges();
        }
    }
}
