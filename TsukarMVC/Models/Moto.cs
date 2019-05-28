using Microsoft.Extensions.Primitives;

namespace TsukarMVC.Models
{
    public class Moto
    {
        public string Modelo {get;set;}
        public string Marca {get;set;}
        public string Placa {get;set;}
        public StringValues Nome { get; internal set; }
    }
}