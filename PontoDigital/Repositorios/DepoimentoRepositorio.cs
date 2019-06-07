using System.Collections.Generic;
using System.IO;
using PontoDigital.Models;

namespace PontoDigital.Repositorios
{
    public class DepoimentoRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Depoimento.csv";
        private const string PATH_INDEX = "Database/Depoimento_Id.csv";

        private List<Depoimentos> Depoimentos =  new List<Depoimentos>();

        public List<Depoimentos> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Depoimentos depoimentos = new Depoimentos();
                depoimentos.NomeDepoimento = valores[1];
                depoimentos.Depoimento = valores[2];

                this.Depoimentos.Add(depoimentos);                
            }
            return this.Depoimentos;
        }

         public bool Inserir (Depoimentos depoimentos) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (depoimentos);
            File.AppendAllText (PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV (Depoimentos depoimentos) {
            return $"id={CONT};nome={depoimentos.NomeDepoimento};depoimento={depoimentos.Depoimento};data_depoimento={depoimentos.DataDepoimento};\n";
        }
    }
}