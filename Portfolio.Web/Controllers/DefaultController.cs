﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;
using System.Threading.Tasks;

namespace Portfolio.Web.Controllers
{
    public class DefaultController(PortfolioContext context) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(UserMessage message)
        {
            context.UserMessages.Add(message);
            context.SaveChanges();
            await Task.Delay(1000);
            return RedirectToAction("Index");
        }
    }
}
