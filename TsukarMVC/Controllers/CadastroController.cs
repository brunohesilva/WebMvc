using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using TsukarMVC.Models;
using TsukarMVC.Repositorio;
using TsukarMVC.ViewModels;

namespace TsukarMVC.Controllers
{
    public class CadastroController : Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();
        CarroRepositorio carroRepositorio = new CarroRepositorio();
        MotoRepositorio motoRepositorio = new MotoRepositorio();

        public StringValues Modelo { get; private set; }

        [HttpGet]

        public IActionResult Index()
        {
            var carro = carroRepositorio.Listar();
            var moto = motoRepositorio.Listar();

            CadastroViewModel cadastro = new CadastroViewModel();
            cadastro.Carros = carro;
            cadastro.Motos = moto;

            return View(cadastro);
        }

        [HttpPost]
        public IActionResult Cadastrar(IFormCollection form)
        {
            System.Console.WriteLine(form["modelo"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["carro"]);
            System.Console.WriteLine(form["moto"]);

            Cadastro cadastro = new Cadastro();

            Cliente cliente = new Cliente();
            cliente.Nome = form["modelo"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            Carro carro = new Carro(
                Modelo = form["carro"]
            );
            cadastro.cliente = cliente;

            cadastro.Carro = carro;

            Moto moto = new Moto() {
                Modelo = form["moto"]
            };

            cadastro.Moto = moto;

            cadastro.DataPedido = DateTime.Now;

            cadastroRepositorio.Inserir(cadastro);

            ViewData["Controller"] = "Cadastro";

            return View("Abou");
        }

        // [HttpGet]
        // public IActionResult Listar(){

        // }
    }
}