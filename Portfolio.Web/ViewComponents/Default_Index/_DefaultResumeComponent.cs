using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Context;

namespace Portfolio.Web.ViewComponents.Default_Index
{
    public class _DefaultResumeComponent() : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
          return View();
        }
    }
}
