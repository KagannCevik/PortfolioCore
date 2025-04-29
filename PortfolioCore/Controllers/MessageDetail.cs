using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class MessageDetail : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult MessageDetailList()
        {
            var values = context.Messages.ToList();
            return View(values);
        }
        public IActionResult DeleteMessageDetail(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("MessageDetailList");
        }
        public IActionResult IsReadTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("MessageDetailList");
        }
        public IActionResult IsReadFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("MessageDetailList");
        }
    }
}
