using System;

namespace PontoDigital.Models
{
    public class Cliente
    {
        public ulong Id {get;set;}
        public string Nome {get;set;}
        public string Senha {get;set;}
        public string Email {get;set;}
        public DateTime DataNascimento {get;set;}
        public DateTime DataCriacao {get;set;}

    }
}