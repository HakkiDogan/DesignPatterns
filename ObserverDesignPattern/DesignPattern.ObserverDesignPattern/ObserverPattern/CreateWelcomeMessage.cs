using DesignPattern.ObserverDesignPattern.DAL;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateWelcomeMessage : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
		Context _context = new();

		public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.WelcomeMessages.Add(new WelcomeMessage
            {
                FullName = appUser.Name + " " + appUser.Surname,
                Content = "Dergi bültenimize Kayıt Olduğunuz İçin Teşekkür ederiz. Dergilerimize Web Sitemizden Ulaşabilirsiniz"               
            });
            _context.SaveChanges();
        }
    }
}
