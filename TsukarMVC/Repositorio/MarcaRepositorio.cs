using System.Collections.Generic;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class MarcaRepositorio
    {
        private const string PATH = "Database/Marcas.csv";
        
        private List<MarcaModel> listaDeMarcas = new List<MarcaModel>();

        public List<MarcaModel> Listar(){

            string[] marcas = File.ReadAllLines(PATH);

            foreach (var item in marcas)
            {
                if (item != null){
                string[] dados = item.Split(";");
                var marca = new MarcaModel();
                marca.Id = int.Parse(dados[0]);
                marca.Nome = dados[1];

                listaDeMarcas.Add(marca);
                }//fim IF
            }//Fim Foreach
            return listaDeMarcas;
        }
    }
}