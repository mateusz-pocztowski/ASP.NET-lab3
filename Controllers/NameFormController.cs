using Microsoft.AspNetCore.Mvc;
using ASP.NET_lab3.Models;

namespace ASP.NET_lab3.Controllers
{
    public class NameFormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(NameFormModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Created", model);
            }
            return View(model);
        }
    }
}
