using System.Collections.Generic;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class MotoRepositorio
    {
        private const string PATH = "Database/Moto.csv";
        private List<Moto> Motos = new List<Moto>();

        public List<Moto> Listar()
        {
            var registros = File.ReadAllLines(PATH);
            foreach (var item in registros)
            {
                var valores = item.Split(";");
                Moto moto = new Moto();
                moto.Marca = valores[1];
                moto.Modelo = valores[2];
                moto.Placa = valores[3];

                this.Motos.Add(moto);
            }
            return this.Motos;

        }
    }
}