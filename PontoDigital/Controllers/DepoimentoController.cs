using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PontoDigital.Models;
using PontoDigital.Repositorios;

namespace PontoDigital.Controllers
{
    public class DepoimentoController
    {
        private DepoimentoRepositorio depoimentoRepositorio = new DepoimentoRepositorio();
        // public IActionResult Comentar(IFormCollection form)
        // {
        //     Depoimentos depoimento = new Depoimentos();
        //     depoimento.NomeDepoimento = form["nome"];
        //     depoimento.Depoimento = form["depoimento"];
        //     depoimento.DataDepoimento = DateTime.Now;

        //     depoimentoRepositorio.Inserir(depoimento);
        //     ViewData["Action"] = "Depoimento";
        //     return View();

        // }
    }
}