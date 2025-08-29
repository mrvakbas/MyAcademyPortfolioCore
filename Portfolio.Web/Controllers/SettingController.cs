using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Portfolio.Web.Context;
using Portfolio.Web.Entities;
using System.Threading.Tasks;

namespace Portfolio.Web.Controllers
{
    public class SettingController(PortfolioContext context) : Controller
    {
        public IActionResult UserList()
        {
            var userList = context.Users.ToList();
            return View(userList);
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            var user = context.Users.Find(id);
            return View(user);
        }

        [HttpPost]
        public IActionResult UpdateUser(User user)
        {

            context.Users.Update(user);
            context.SaveChanges();
            return RedirectToAction("UserList", "Setting");
        }
    }
}
