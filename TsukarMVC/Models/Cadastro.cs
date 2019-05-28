using System;

namespace TsukarMVC.Models
{
    public class Cadastro
    {
        public ulong Id {get;set;}
        public Cliente cliente {get;set;}
        public Carro Carro {get;set;}
        public Moto Moto {get;set;}
        public DateTime DataPedido {get;set;}
    }
}