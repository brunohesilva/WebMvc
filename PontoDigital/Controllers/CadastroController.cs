using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital.Models;
using PontoDigital.Repositorios;

namespace PontoDigital.Controllers
{
    public class CadastroController : Controller
    {
        private ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Cadastro";
            return View();
        }

        public IActionResult Cadastrar(IFormCollection form)
        {
            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Email = form["email"];
            cliente.Senha = form["senha"];
            cliente.DataNascimento = DateTime.Parse(form["data-nascimnto"]);

            clienteRepositorio.Inserir(cliente);
            ViewData["Action"] = "Cadastro";
            return View("Sucesso");
        }
    }
}