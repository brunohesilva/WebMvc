using System.Collections.Generic;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class CarroRepositorio
    {
        private const string PATH = "Database/Carro.csv";
        private List<Carro> Carros = new List<Carro>();

        public List<Carro> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Carro carro = new Carro();
                carro.Marca = valores[1];
                carro.Modelo = valores[2];
                carro.Placa = valores[3];

                this.Carros.Add(carro);
            }
            return this.Carros;

        }
    }
}