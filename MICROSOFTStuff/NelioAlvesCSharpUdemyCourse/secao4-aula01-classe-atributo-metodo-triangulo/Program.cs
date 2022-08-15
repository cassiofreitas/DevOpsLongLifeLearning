using System.Globalization;

namespace secao4_aula01_classe_atributo_metodo_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y; // declara as variáveis do tipo Triangulo

            x = new Triangulo(); // instanciação
            y = new Triangulo(); // instanciação

            Console.WriteLine("Entre com os lados do triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com os lados do triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //formula de Heron: area = sqrt(p * (p-a) * (p-b) * (p-c) onde p = ( a + b + c ) /2;

            // DELEGATED a responsabilida pelo cálculo de área para a Classe Triângulo
            // REAPROVEITAMENTO de código, não repetindo fórmulas e cálculos
            //double p = (x.A + x.B + x.C) / 2.0;
            //double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            //p = (y.A + y.B + y.C) / 2.0;
            //double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine($"Área de X = {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Área de Y = {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior área: X");
            } else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}