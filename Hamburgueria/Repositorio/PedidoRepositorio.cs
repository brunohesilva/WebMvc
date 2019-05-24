using System;
using System.Collections.Generic;
using System.IO;
using Hamburgueria.Models;

namespace Hamburgueria.Repositorio
{
    public class PedidoRepositorio
    {
        private List<Pedido> Pedidos = new List<Pedido>();

        private string Path = "Database/Pedido.csv";

        public bool Inserir(Pedido pedido)
        {
            try{

            if (!File.Exists(Path)){
                File.Create(Path).Close();
                
            }

            var linha = $"{pedido.Id};{pedido.Cliente.Nome};{pedido.Cliente.Endereco};{pedido.Cliente.Telefone};{pedido.Cliente.Email};{pedido.Hamburguer.Nome};{pedido.Shake.Nome};{pedido.DataPedido}";


            File.AppendAllText("Database/Pedido.csv", linha + "\n");

            }catch(Exception e) {
                System.Console.WriteLine("Entrou no catch");
                System.Console.WriteLine(e.StackTrace);
            }
            return true;
        }
    }
}