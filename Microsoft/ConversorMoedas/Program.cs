using System.Collections;
using System.Globalization;

namespace ConversorMoedas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ChoiceExit = 'N';
            decimal ValorAConverter;
            decimal ValorConvertido;
            string ? MoedaConverterDe;
            string ? MoedaConverterPara;
            string dataCotacao;
            string statusConversao;
            //
            // This routine simulates an externa DataSource initializing
            // For awhile, it is hard coded at DataSources.cs
            DataSource DataSourceNow = new DataSource();
            DataSourceNow.InitialDataLoad();
            //
            Conversor ConversorNow = new Conversor();
            //
            do
            {
                Console.Clear();
                Console.Beep();
                Console.ForegroundColor = ConsoleColor.Yellow;
                //      
                Console.WriteLine(ConversorNow.ListConversionToStack(3));
                Console.WriteLine("".PadRight(50, '-'));
                //
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Moedas disponíveis para conversão:");
                Console.Write(DataSourceNow.ListSupportedCoins());
                //
                Console.WriteLine("".PadRight(40, '-'));
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Converter");
                Console.Write("DE   (Símbolo): ");
                MoedaConverterDe = Console.ReadLine().ToUpper();
                Console.Write("PARA (Símbolo): ");
                MoedaConverterPara = Console.ReadLine().ToUpper();
                Console.WriteLine("".PadRight(40, '-'));
                //
                Console.Write($"Digite o valor de [ {MoedaConverterDe} ] a converter para [ {MoedaConverterPara} ]: ");
                decimal.TryParse(Console.ReadLine(), out ValorAConverter);
                //
                Console.Write("Digite a data para conversão (YYYYMMDD): ");
                dataCotacao = string.Concat(Console.ReadLine());
                //
                ValorConvertido = ConversorNow.ConvertCoins(dataCotacao, MoedaConverterDe, MoedaConverterPara, ValorAConverter);
                Console.WriteLine();
                //
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;

                if (ValorConvertido < 0)
                {
                    statusConversao = "FALHOU";
                }
                else
                {
                    statusConversao = "OK";
                }
                //
                Console.WriteLine(ConversorNow.AddConversionToStack($"Em [ {dataCotacao} ] [ {ValorAConverter.ToString("N4")} {MoedaConverterDe} ] = [ {ValorConvertido.ToString("N4")} {MoedaConverterPara} ] = [{statusConversao}]"));
                //
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.Black;
                //
                Console.Write("\nPor favor, leia os resultados da conversão. [ S ] para SAIR >");
                char.TryParse(Console.ReadLine(), out ChoiceExit);
            } while (char.ToUpper(ChoiceExit) is not 'S');
        }
    }
}