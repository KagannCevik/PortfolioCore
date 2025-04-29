using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}