using System;
using System.Collections.Generic;
using System.IO;
using Tskukar2.Models;

namespace Tskukar2.Repositorio
{
    public class PedidoRepositorio
    {
        private List<Pedido> Pedidos = new List<Pedido>();

        private string Path = "Database/Cadastro.csv";
        public bool Inserir(Pedido pedido)
        {
            try {
                
                if(!File.Exists(Path)){
                    File.Create(Path).Close();
                }
                
                var linha = $"{pedido.Id};{pedido.cliente.Nome};{pedido.cliente.Endereco};{pedido.cliente.Telefone};{pedido.cliente.Email};{pedido.Marca};{pedido.Modelo};{pedido.Modelo.Placa};{pedido.DataEn}";

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