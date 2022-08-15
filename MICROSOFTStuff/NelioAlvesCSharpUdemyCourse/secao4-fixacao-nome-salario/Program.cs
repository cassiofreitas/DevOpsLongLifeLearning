using System.Globalization;

namespace secao4_fixacao_nome_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();
            double SalarioMedio;

            Console.WriteLine("Dados do primeiro funcionário");
            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário");
            Console.Write("Nome: ");
            f2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SalarioMedio = (f1.Salario + f2.Salario) / 2.0;

            Console.WriteLine($"Salário médio = {SalarioMedio}", "C2", CultureInfo.InvariantCulture);
        }
    }
}