using Microsoft.AspNetCore.Mvc;
using MVCHello.Models;

namespace MVCHello.Controllers
{
    public class NameController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register(Name name)
        {
            return View(name);
        }
    }
}
