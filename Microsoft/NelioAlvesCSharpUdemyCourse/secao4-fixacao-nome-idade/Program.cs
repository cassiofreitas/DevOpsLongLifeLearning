using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secao4_fixacao_nome_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2; // declaracao

            p1 = new Pessoa(); // instanciacao
            p2 = new Pessoa(); // instanciacao

            Console.WriteLine("Dados da primeira pessoa");
            p1.Nome = Console.ReadLine();
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa");
            p2.Nome = Console.ReadLine();
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
        }
    }
}
