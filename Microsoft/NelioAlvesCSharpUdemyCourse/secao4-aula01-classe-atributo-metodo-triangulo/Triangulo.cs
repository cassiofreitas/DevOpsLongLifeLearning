using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao4_aula01_classe_atributo_metodo_triangulo
{
    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
