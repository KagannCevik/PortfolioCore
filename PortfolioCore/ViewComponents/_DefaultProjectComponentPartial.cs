using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
	{ 
        PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke(int? id = null)
		{
			var values = context.Portfolios.AsQueryable();
			if (id != null)
			{
				values = values.Include(p => p.Category).Where(p => p.CategoryId == id);
			}
			return View(values.ToList());
		}

	}
}
