using Microsoft.AspNetCore.Mvc;

namespace PontoDigital.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Admin";
            return View();
        }
    }
}