using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
            System.Console.WriteLine(form["nome"]);
            System.Console.WriteLine(form["endereco"]);
            System.Console.WriteLine(form["telefone"]);
            System.Console.WriteLine(form["email"]);
            System.Console.WriteLine(form["carro"]);
            System.Console.WriteLine(form["moto"]);

            Cadastro cadastro = new Cadastro();

            Cliente cliente = new Cliente();
            cliente.Nome = form["nome"];
            cliente.Endereco = form["endereco"];
            cliente.Telefone = form["telefone"];
            cliente.Email = form["email"];

            Carro carro = new Carro(
                Nome: form["carro"]
            );
            cadastro.cliente = cliente;

            cadastro.Carro = carro;

            Moto moto = new Moto() {
                Nome = form["moto"]
            };

            cadastro.Moto = moto;

            cadastro.DataPedido = DateTime.Now;

            cadastroRepositorio.Inserir(cadastro);

            ViewData["Controller"] = "Cadastro";

            return View("Sucesso");
        }

        // [HttpGet]
        // public IActionResult Listar(){

        // }
    }
}