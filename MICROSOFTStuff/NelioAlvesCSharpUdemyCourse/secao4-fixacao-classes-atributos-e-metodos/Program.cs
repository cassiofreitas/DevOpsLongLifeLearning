using System.Globalization;

namespace secao4_fixacao_classes_atributos_e_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double porcentagem;
            /*
            Retangulo R = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            R.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            R.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"AREA = {R.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"PERÍMETRO = {R.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"DIAGONAL = {R.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            */

            /*
            Funcionario F = new Funcionario();

            Console.Write("Nome: ");
            F.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            F.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            F.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            
            Console.WriteLine($"\nFuncionario: {F}");
            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            F.AumentarSalario(porcentagem);
            Console.WriteLine($"\nDados Atualizados: {F}",CultureInfo.InvariantCulture);
            */

            Aluno A = new Aluno();

            Console.Write("Nome do aluno: ");
            A.Name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            A.NotasDoAluno[0] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.NotasDoAluno[1] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            A.NotasDoAluno[2] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"NOTA FINAL = {A.CalculaNotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");
            Console.WriteLine(A.IsApproved());
        }
    }
}