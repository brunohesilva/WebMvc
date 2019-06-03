using System;
using System.Collections.Generic;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class RegistroRepositorio
    {
        private const string PATH = "Database/Registro.csv";

        public void InserirNoCSV(RegistroModel registro){
            // int id = 1;

            if (File.Exists(PATH))
            {
                registro.Id = File.ReadAllLines(PATH).Length + 1;
            }else{
                registro.Id = 1;
            }

            StreamWriter sw = new StreamWriter(PATH, true);
            sw.WriteLine($"{registro.Id};{registro.Nome};{registro.Marca.Nome};{registro.Modelo.Nome};{registro.Placa};{DateTime.Now}");
            sw.Close();
        }

        private List<RegistroModel> listaDeRegistro = new List<RegistroModel>();

        public List<RegistroModel> Listar(){
            string[] linhas = File.ReadAllLines(PATH);

            foreach (var item in linhas)
            {
                if (string.IsNullOrEmpty(item))
                {
                    continue;
                }
                string[] dados = item.Split(";");
                var registro = new RegistroModel();
                var modelo = new ModeloModel();
                var marca = new MarcaModel();

                registro.Id = int.Parse(dados[0]);
                registro.Nome = dados[1];
                marca.Nome = dados[2];
                registro.Marca = marca;
                modelo.Nome = dados[3];
                registro.Modelo = modelo;
                registro.Placa = dados[4];
                registro.DataEntrada = DateTime.Parse(dados[5]);

                listaDeRegistro.Add(registro);
            }
            return listaDeRegistro;
        }

        public List<RegistroModel> Filtrar(DateTime data){

            
            List<RegistroModel> listaDeRegistrosFiltrados = new List<RegistroModel>();

            var listaDeRegistro = Listar();
 
            foreach (var item in listaDeRegistro)
            {
                if (item.DataEntrada.ToShortDateString() == data.ToShortDateString()){
                    listaDeRegistrosFiltrados.Add(item);
                }else{
                    continue;
                }
            }
            return listaDeRegistrosFiltrados;
        }
        public List<RegistroModel> Filtrar(string modelo){

            List<RegistroModel> listaDeRegistrosFiltrados = new List<RegistroModel>();

            var listaDeRegistro = Listar();
 
            foreach (var item in listaDeRegistro)
            {
                if (item.Modelo.Nome.Equals(modelo)){
                    listaDeRegistrosFiltrados.Add(item);
                }else{
                    continue;
                }
            }
            return listaDeRegistrosFiltrados;
        }

        public List<RegistroModel> Filtrar(string modelo, DateTime data){

            List<RegistroModel> listaDeRegistrosFiltrados = new List<RegistroModel>();

            var listaDeRegistro = Listar();
 
            foreach (var item in listaDeRegistro)
            {
                if (item.Modelo.Nome.Equals(modelo) && item.DataEntrada.ToShortDateString() == data.ToShortDateString()){
                    listaDeRegistrosFiltrados.Add(item);
                }else{
                    continue;
                }
            }
            return listaDeRegistrosFiltrados;
        }       
    }
}