using DesignPattern.ChainOfResponsibility.ChainOfResponsibility;
using DesignPattern.ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.ChainOfResponsibility.Controllers
{
	public class Default : Controller
	{
		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Index(CustomerProcessViewModel model)
		{
			Employee treasuer = new Treasurer();
			Employee managerAssistant = new ManagerAssistant();
			Employee manager = new Manager();
			Employee areaDirector = new AreaDirector();

			treasuer.SetNextApprover(managerAssistant);
			managerAssistant.SetNextApprover(manager);
			manager.SetNextApprover(areaDirector);
			treasuer.ProcessRequest(model);
			return View();
		}
	}
}
