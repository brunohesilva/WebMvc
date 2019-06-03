using System.Collections.Generic;
using TsukarMVC.Models;

namespace TsukarMVC.ViewModels
{
    public class HomeViewModel
    {
        public List<MarcaModel> Marcas {get;set;}

        public List<ModeloModel> Modelos {get;set;}
        
        public List<RegistroModel> Registros{get;set;}
    }
}