using System.Collections;

namespace WritelineAndReadline;

internal class Program
{
    private static void Main(string[] args)
    {
        var choiceExit = 'N';
        var moedaConverterDe = 0;
        var moedaConverterPara = 0;

        do
        {
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Últimas 5 conversões:\n");
            Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA"); // tem uma classe ou método que só faz isso
            Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
            Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
            Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
            Console.WriteLine("de N,NN MOEDADE para N,NN MOEDAPARA");
            Console.WriteLine("------------------------");
            Console.WriteLine("Moedas disponíveis para conversão:"); //adicionar aqui o return do método
            Console.WriteLine($"-----");
            Console.Write("Converter de: ");
            int.TryParse(Console.ReadLine(), out moedaConverterDe);   //organizar um menu do tipo 1-BRL, 2-USD etc
            Console.Write("\tPara: ");
            int.TryParse(Console.ReadLine(), out moedaConverterPara);   //organizar um menu do tipo 1-BRL, 2-USD etc
            Console.WriteLine("\n----");
            Console.WriteLine("Resultado da conversão: ");  //aqui vai o resultado do método da conversão
            Console.WriteLine("Conversão de xxx\t\tpara yyyy");
            Console.WriteLine("Valor a converter: zzz\t\tResultado da conversão: www\n");
            //
            // 24/06/2022 - cassiofreitas - begin
            var moedas = Tuple.Create("20220623", "BRLGBP", 0.1576m);
            Console.WriteLine("Data: {0}, Par: {1}, Cotacao: {2:C5}", moedas.Item1, moedas.Item2, moedas.Item3);
            //
            //20220623|BRLGBP|0.1576
            //20220623|BRLEUR|0.1837
            //20220623|BRLJPY|25,9875
            //20220623|BRLUSD|0,1929
            //
            var coins = new Hashtable();
            coins.Add(String.Concat("20220623", "BRLUSD"), 0.1929m);
            Console.WriteLine(coins[String.Concat("20220623", "BRLUSD")]);
            Console.WriteLine("\n\n\n");
            // 24/06/2022 - cassiofreitas - end
            //
            Console.WriteLine("Por favor, leia os resultados da conversão.");
            Console.WriteLine("----");
            Console.Write($"[ S ] para SAIR >");
            char.TryParse(Console.ReadLine(), out choiceExit);
        } while (char.ToUpper(choiceExit) is not 'S');
    }
}
