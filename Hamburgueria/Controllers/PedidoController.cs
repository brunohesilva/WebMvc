using System;
using Hamburgueria.Models;
using Hamburgueria.Repositorio;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers
{
    public class PedidoController : Controller
    {

        PedidoRepositorio pedidoRepositorio = new PedidoRepositorio();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarPedido(IFormCollection form)
        {
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["hamburguer"]);
            System.Console.WriteLine(form["shake"]);

            Pedido pedido = new Pedido();

            Cliente cliente = new Cliente();
            cliente.Nome = (form["nome"]);
            cliente.Endereco = (form["endereco"]);
            cliente.Telefone = (form["telefone"]);
            cliente.Email = (form["email"]);

            pedido.Cliente = cliente;

            Hamburguer hamburguer = new Hamburguer(
                Nome: form["hammburguer"]
            );

            pedido.Hamburguer = hamburguer;

            Shake shake = new Shake() {
                Nome = form["shake"]
            };

            pedido.Shake = shake;

            pedido.DataPedido = DateTime.Now;

            pedidoRepositorio.Inserir(pedido);

            ViewData["Contoller"] = "Pedido";

            // return RedirectToAction("Index", "Home");
            return View("Sucesso");
        }
    }
}