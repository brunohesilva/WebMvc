using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TsukarMVC.Models;
using TsukarMVC.Repositorio;
using TsukarMVC.ViewModels;

namespace TsukarMVC.Controllers
{
    public class HomeController : Controller
    {
        MarcaRepositorio marcaRepositorio = new MarcaRepositorio();
        ModeloRepositorio modeloRepositorio = new ModeloRepositorio();
        RegistroRepositorio registroRepositorio = new RegistroRepositorio();
        [HttpGet]
        public IActionResult Index(){

            HomeViewModel homeViewModel = new HomeViewModel();

            homeViewModel.Marcas = marcaRepositorio.Listar();
            homeViewModel.Modelos = modeloRepositorio.Listar();

            return View(homeViewModel);
        }
        [HttpPost]
        public IActionResult RegistrarEntrada(IFormCollection form){
            
            var modelo = new ModeloModel();
            modelo.Nome = form["modelo"];
            var marca = new MarcaModel();
            marca.Nome = form["marca"];

            RegistroModel registro = new RegistroModel();
            registro.Nome = form["nome"];
            registro.Modelo = modelo;
            registro.Marca = marca;
            registro.Placa = form ["placa"];

            registroRepositorio.InserirNoCSV(registro);

           return RedirectToAction("Index"); 
        }
    }
}                           