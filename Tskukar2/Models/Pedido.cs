using System;

namespace Tskukar2.Models
{
    public class Pedido
    {
        public ulong Id {get;set;}
        public Cliente cliente {get;set;}
        public Marca Marca {get;set;}
        public Modelo Modelo {get;set;}
        public DateTime DataEn {get;set;}
    }
}