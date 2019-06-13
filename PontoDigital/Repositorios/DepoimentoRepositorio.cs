using System;
using System.Collections.Generic;
using System.IO;
using PontoDigital.Models;

namespace PontoDigital.Repositorios
{
    public class DepoimentoRepositorio : BaseRepositorio
    {
        public static uint CONT = 0;
        private const string PATH = "Database/Depoimento.csv";
        private const string PATH_INDEX = "Database/Depoimento_Id.csv";

        private List<Depoimento> Depoimentos =  new List<Depoimento>();

        public List<Depoimento> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Depoimento depoimentos = new Depoimento();
                depoimentos.NomeDepoimento = valores[1];
                depoimentos.Depoimentos = valores[1];

                this.Depoimentos.Add(depoimentos);                
            }
            return this.Depoimentos;
        }

         public bool Inserir (Depoimento depoimentos) {
            CONT++;
            File.WriteAllText(PATH_INDEX, CONT.ToString());

            string linha = PrepararRegistroCSV (depoimentos);
            File.AppendAllText (PATH, linha);

            return true;
        }

        private string PrepararRegistroCSV (Depoimento depoimentos) {
            return $"id={CONT};nome={depoimentos.NomeDepoimento};depoimento={depoimentos.Depoimentos};data_depoimento={depoimentos.DataDepoimento};\n";
        }

        // public List<Depoimento> ListarTodos () {
        //     var linhas = ObterRegistrosCSV (PATH);
        //     foreach (var item in linhas){
        //         Depoimento depoimento = ConverterEmOjeto
        //     }
        // }
    }
}