using System;
using System.IO;
using TsukarMVC.Models;

namespace TsukarMVC.Repositorio
{
    public class RegistroRepositorio
    {
        private const string PATH = "Database/Registro.csv";

        public void InserirNoCSV(RegistroModel registro){
            int id = 1;

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
    }
}