using Microsoft.AspNetCore.Mvc;
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
        public IActionResult UpdateUserMessage(int id)
        {
            var userMessage = context.UserMessages.Find(id);
            return View(userMessage);
        }
        [HttpPost]
        public IActionResult UpdateUserMessage(UserMessage userMessage)
        {
            context.UserMessages.Update(userMessage);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
