using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;
using WebMVC.Repositorios;

namespace WebMVC.Controllers
{
    public class MusicaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome)
        {
            

            ViewData["Mensagem"] = "Óla " + nome + ", estas são as suas músicas"; 
            return View(MusicaRepositorio.musicas);
        }
    }
}