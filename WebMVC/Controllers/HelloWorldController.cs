using Microsoft.AspNetCore.Mvc;

namespace WebMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int vezes = 1)
        {
            ViewData["Mensagem"] = "Óla" + nome;
            ViewData["Vezes"] = vezes;
            
            return View();
        }
    }
}