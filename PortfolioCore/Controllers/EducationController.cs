using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class EducationController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult EducationList()
        {
            var value = context.Educations.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEducation(Education education)
        {
            context.Educations.Add(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        public IActionResult EducationDelete(int id)
        {
            var value = context.Educations.Find(id);
            context.Educations.Remove(value);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }
        [HttpGet]
        public IActionResult EducationUpdate(int id)
        {
            var value = context.Educations.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult EducationUpdate(Education education)
        {
            context.Educations.Update(education);
            context.SaveChanges();
            return RedirectToAction("EducationList");
        }

    }
}
