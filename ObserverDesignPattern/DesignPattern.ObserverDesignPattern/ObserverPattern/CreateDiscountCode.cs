using DesignPattern.ObserverDesignPattern.DAL;

namespace DesignPattern.ObserverDesignPattern.ObserverPattern
{
    public class CreateDiscountCode : IObserver
    {
        private readonly IServiceProvider _serviceProvider;
        Context _context = new();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreateNewUser(AppUser appUser)
        {
            _context.Discounts.Add(new Discount
            {
                DiscountCode = "DRGAGUSTOS",
                DiscountAmount = 35,
                DiscountCodeStatus = true
            });
            _context.SaveChanges();
        }
    }
}
