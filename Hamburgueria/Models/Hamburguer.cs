using Microsoft.Extensions.Primitives;

namespace Hamburgueria.Models 
{
    public class Hamburguer : Produto
    {
        public Hamburguer()
        {

        }
        
        public Hamburguer(string Nome)
        {
            this.Nome = Nome;
        }      
    }
}