using Microsoft.AspNetCore.Mvc;
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultMessageComponentPartial: ViewComponent
    {
       
        public IViewComponentResult Invoke()
        {
            return View(new Message());
        }
    }
}
