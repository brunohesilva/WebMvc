using System.Collections.Generic;
using TsukarMVC.Models;

namespace TsukarMVC.ViewModels
{
    public class CadastroViewModel
    {
        public List<Carro> Carros {get;set;}
        public List<Moto> Motos {get;set;}
    }
}