using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial: ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Testimonials.Count().ToString();

            Random rd = new Random();
            ViewBag.v2 = rd.Next(1, 20);

            ViewBag.v3 = context.Portfolios.Count().ToString();
            ViewBag.v4 = context.Testimonials.Count().ToString();
            return View();
            
        }
    }

}
