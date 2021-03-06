using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital.Repositorios;

namespace PontoDigital.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            var usuario = form["email"];
            var senha = form["senha"];

            var cliente = clienteRepositorio.ObterPor(usuario);

            if (cliente != null && cliente.Nome.Equals("Administrador") && cliente.Email.Equals("admin@agoravai.com") && cliente.Senha.Equals("admin"))
            {
                return RedirectToAction("Index", "Admin");  
            }
            
            if (cliente != null && cliente.Email.Equals(usuario) && cliente.Senha.Equals(senha))
            {
                HttpContext.Session.SetString(SESSION_EMAIL, usuario);
                HttpContext.Session.SetString(SESSION_CLIENTE, cliente.Nome);
            
                return RedirectToAction("Index", "Depoimento");
            }else
            {
                return View("Falha");
            }
            
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}