using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    [Route("MessageController")]
    public class MessageController : Controller
    {
        PortfolioContext context = new PortfolioContext();
		[HttpGet]
		[Route("CreateMessage")]
		public IActionResult CreateMessage()
		{
			return View();

		}
		[HttpPost]
		[Route("CreateMessage")]
		public IActionResult CreateMessage(Message message)
		{
			context.Messages.Add(message);
			context.SaveChanges();
			TempData["Success"] = "Gönderim İşlemi Başarılı!";
			return RedirectToAction("Index", "Default");
		}

	}
}
