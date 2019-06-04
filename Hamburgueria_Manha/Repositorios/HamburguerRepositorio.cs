using System.Collections.Generic;
using System.IO;
using Hamburgueria_Manha.Models;

namespace Hamburgueria_Manha.Repositorios
{
    public class HamburguerRepositorio
    {
        private const string PATH = "Database/Hamburguer.csv";
        private List<Hamburguer> Hamburgueres = new List<Hamburguer>();

        public List<Hamburguer> Listar() 
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Hamburguer hamburguer = new Hamburguer();
                hamburguer.Nome = valores[1];
                hamburguer.Preco = double.Parse(valores[2]);

                this.Hamburgueres.Add(hamburguer);
            }
            return this.Hamburgueres;
        }

        public double ObterPrecoDe(string nomeHamburguer)
        {
            var lista = Listar();
            var preco = 0.0;

            foreach (var item in lista)
            {
                System.Console.WriteLine($"Item da Lista :{item.Nome} comparando com {nomeHamburguer}");
                if (item.Nome.Equals(nomeHamburguer)) 
                {
                    System.Console.WriteLine("Obteve preco " + item.Preco);
                    preco = item.Preco;
                }
            }

            return preco;
        }
    }
}