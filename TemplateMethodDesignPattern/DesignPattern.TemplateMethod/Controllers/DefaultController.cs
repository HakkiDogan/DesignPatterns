using DesignPattern.TemplateMethod.TemplatePattern;
using Microsoft.AspNetCore.Mvc;

namespace DesignPattern.TemplateMethod.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Temel Plan");
            ViewBag.v2 = netflixPlans.CountPerson(1);
            ViewBag.v3 = netflixPlans.Price(75);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi");
            ViewBag.v5 = netflixPlans.Resolution("480px");          
            return View();
        }

        public IActionResult StandartPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Standart Plan");
            ViewBag.v2 = netflixPlans.CountPerson(2);
            ViewBag.v3 = netflixPlans.Price(100);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Animasyon");
            ViewBag.v5 = netflixPlans.Resolution("720px");
            return View();
        }

        public IActionResult UltraPlanIndex()
        {
            NetflixPlans netflixPlans = new BasicPlan();
            ViewBag.v1 = netflixPlans.PlanType("Ultra Plan");
            ViewBag.v2 = netflixPlans.CountPerson(4);
            ViewBag.v3 = netflixPlans.Price(149.50);
            ViewBag.v4 = netflixPlans.Content("Film-Dizi-Animasyon-Futbol");
            ViewBag.v5 = netflixPlans.Resolution("1080px");
            return View();
        }
    }
}
