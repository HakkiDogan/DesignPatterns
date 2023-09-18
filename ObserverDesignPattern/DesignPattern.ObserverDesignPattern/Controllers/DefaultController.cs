using DesignPattern.ObserverDesignPattern.DAL;
using DesignPattern.ObserverDesignPattern.Models;
using DesignPattern.ObserverDesignPattern.ObserverPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ObserverDesignPattern.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

		public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
		{
			_userManager = userManager;
			_observerObject = observerObject;
		}

		[HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appUser = new AppUser()
            {
                Name = model.Name,
                Email = model.Email,
                Surname = model.Surname,
                UserName = model.UserName,
            };
            var result = await _userManager.CreateAsync(appUser,model.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
            }
            return View();
        }
    }
}
