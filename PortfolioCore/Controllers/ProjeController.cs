using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
	public class ProjeController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult ProjeList()
		{
			var value = context.Portfolios.ToList();
			return View(value);
		}
		[HttpGet]
        public IActionResult ProjeAdd()
		{
			return View();
        }
        [HttpPost]
        public IActionResult ProjeAdd(Portfolio p)
        {
            context.Portfolios.Add(p);
            context.SaveChanges();
            return RedirectToAction("ProjeList");
        }
        public IActionResult ProjeDelete(int id)
        {
            var value = context.Portfolios.Find(id);
            context.Portfolios.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ProjeList");
        }
        [HttpGet]
        public IActionResult ProjeUpdate(int id)
        {
            var value = context.Portfolios.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult ProjeUpdate(Portfolio p)
        {
            context.Portfolios.Update(p);
            context.SaveChanges();
            return RedirectToAction("ProjeList");

        }
    }
}
