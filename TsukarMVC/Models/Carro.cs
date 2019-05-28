using Microsoft.Extensions.Primitives;

namespace TsukarMVC.Models
{
    public class Carro
    {
        private StringValues Nome;

        public Carro()
        {
        }

        public Carro(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public string Modelo {get;set;}
        public string Marca {get;set;}
        public string Placa {get;set;}
    }
}