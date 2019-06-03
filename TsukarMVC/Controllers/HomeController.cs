using System;
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
        HomeViewModel homeViewModel = new HomeViewModel();

        [HttpGet]
        public IActionResult Index(){

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
        public IActionResult ListarRegistros(){
            var listaDeRegistros = registroRepositorio.Listar();
            var listaDeModelos = modeloRepositorio.Listar();

            if (listaDeRegistros.Count == 0){
                ViewData["mensagem"] = "Nenhum Registro encontrado";
            }
            homeViewModel.Registros = listaDeRegistros;
            homeViewModel.Modelos = listaDeModelos;
            return View(homeViewModel);
        }
        public IActionResult FiltrarRegistros(IFormCollection form){
            var listaDeModelos = modeloRepositorio.Listar();
            var dataFormulario = form["data"];

            string modelo = form["modelo"];

            if(string.IsNullOrEmpty(modelo) && string.IsNullOrEmpty(dataFormulario.ToString())){
                return RedirectToAction("ListarRegistros");
            }else if(string.IsNullOrEmpty(dataFormulario.ToString())){
                DateTime data = DateTime.Parse(dataFormulario);
                homeViewModel.Registros = registroRepositorio.Filtrar(modelo);
            }else{
                homeViewModel.Registros = registroRepositorio.Filtrar(dataFormulario);
            }
            homeViewModel.Modelos = listaDeModelos;

            return View(homeViewModel);
        }
    }
}                           