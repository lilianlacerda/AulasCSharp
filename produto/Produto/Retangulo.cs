using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoProduto
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalcularArea()
        {
            return Largura * Altura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Largura + Altura);
        }
    }
}
