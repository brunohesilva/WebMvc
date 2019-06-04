using Microsoft.Extensions.Primitives;

namespace Hamburgueria_Manha.Models
{
    public class Hamburguer : Produto
    {

        public Hamburguer()
        {

        }

        public Hamburguer(StringValues Nome)
        {
            this.Nome = Nome;
        }

        public Hamburguer(string Nome, double Preco)
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }
    }
}