using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;

namespace Portfolio.Web.Controllers
{
    public class UserMessageController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            var userMessage = context.UserMessages.ToList();
            return View(userMessage);
        }
        public IActionResult CreateUserMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUserMessage(UserMessage userMessage)
        {
            context.UserMessages.Add(userMessage);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteUserMessage(int id)
        {
            var userMessage = context.UserMessages.Find(id);
            context.UserMessages.Remove(userMessage);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeMessageIsReadToTrue(int id)
        {
            var value = context.UserMessages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeMessageIsReadToFalse(int id)
        {
            var value = context.UserMessages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult DetailCard(int id)
        {
            var model = context.UserMessages.Find(id);
            return PartialView("DetailCard", model);
        }

    }
}
