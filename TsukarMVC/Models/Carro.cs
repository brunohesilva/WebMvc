using Microsoft.Extensions.Primitives;

namespace TsukarMVC.Models
{
    public class Carro
    {
        private StringValues stringValues;

        // public Carro(StringValues stringValues)
        // {
        //     this.stringValues = stringValues;
        // }

        // private StringValues Nome;

        // public Carro()
        // {
        // }

        // public Carro(StringValues Nome)
        // {
        //     this.Nome = Nome;
        // }

        public string Modelo {get;set;}
        public string Marca {get;set;}
        public string Placa {get;set;}
    }
}