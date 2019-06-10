using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital.Models;
using PontoDigital.Repositorios;

namespace PontoDigital.Controllers
{
    public class DepoimentoController : Controller
    {
        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        public IActionResult Comentar(IFormCollection form)
        {
            Depoimento depoimento = new Depoimento();
            depoimento.NomeDepoimento = form["nome"];
            depoimento.Depoimentos = form["depoimento"];
            depoimento.DataDepoimento = DateTime.Now;

            depoimentoRepositorio.Inserir(depoimento);
            ViewData["Action"] = "Comentario";
            return View("Sucsso");

        }
    }
}