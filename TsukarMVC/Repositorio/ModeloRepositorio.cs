using System.Collections.Generic;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class ModeloRepositorio
    {
        private const string PATH = "Database/Modelos.csv";

        private List<ModeloModel> listaDeModelos = new List<ModeloModel>();

        public List<ModeloModel> Listar(){

            string[] modelos = File.ReadAllLines(PATH);

            foreach (var item in modelos)
            {
                if (item != null){
                    
                string[] dados = item.Split(";");
                var modelo = new ModeloModel();
                modelo.Id = int.Parse(dados[0]);
                modelo.Nome = dados[1];

                listaDeModelos.Add(modelo);
                }
            }
            return listaDeModelos;
        }
    }
}