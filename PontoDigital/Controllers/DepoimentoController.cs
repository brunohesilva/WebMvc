using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital.Models;
using PontoDigital.Repositorios;

namespace PontoDigital.Controllers
{
    public class DepoimentoController : Controller
    {
        ClienteRepositorio clienteRepositorio = new ClienteRepositorio();
        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        public IActionResult Index()
        {
            ViewData["NomeView"] = "Depoimento";
             return View();
        }
        public IActionResult Comentar(IFormCollection form)
        {
            Depoimento depoimento = new Depoimento();
            depoimento.NomeDepoimento = form["nome"];
            depoimento.Depoimentos = form["depoimento"];
            depoimento.DataDepoimento = DateTime.Now;

            depoimentoRepositorio.Inserir(depoimento);

            ViewData["Action"] = "Depoimento";
            return View("Sucesso");
        }
    }
}