using System;
using System.Collections.Generic;
using System.IO;
using TsukarMVC.Controllers;
using TsukarMVC.Models;



namespace TsukarMVC.Repositorio
{
    public class CadastroRepositorio
    {
        private List<Cadastro> Pedidos = new List<Cadastro>();

        private string Path = "Database/Cadastro.csv";
        public bool Inserir(Cadastro cadastro)
        {
            try
            {
                 if(!File.Exists(Path)){
                    File.Create(Path).Close();
                }

                var linha = $"{cadastro.Id};{cadastro.cliente.Nome};{cadastro.Carro.Marca};{cadastro.Carro.Modelo};{cadastro.Carro.Placa};{cadastro.Moto.Marca};{cadastro.Moto.Modelo};{cadastro.Moto.Placa};{cadastro.DataPedido}";

                File.AppendAllText(Path, linha + "\n");
            }
            catch (Exception e) {
                System.Console.WriteLine("Entrou no catch");
                System.Console.WriteLine(e.StackTrace);
            }
        return true;
        }
    }
}