using System.Collections;

namespace tuples_and_hashtables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Declaration, no field names
            (double, int) t1 = (3.5, 9);
            //Declaration, with field names
            (double Sum, int Count) t2 = (20.5, 9);
            //Declation, with field name + arithmetics
            (double SumPlus, int CountPlus) t3 = ((15 * 2) + 9.5, 9 * 10);

            Console.WriteLine($"Tuple t1 = {t1.Item1} e {t1.Item2}"); // using notation tuple.ItemN
            Console.WriteLine($"Tuple t2 = {t2.Sum} e {t2.Count}");  // using notation with field name
            Console.WriteLine($"Tuple t3 = {t3.SumPlus} e {t3.CountPlus}");

            //
            // 24/06/2022 - cassiofreitas - begin
            // Tuple to store a key and a value
            Tuple<string, string, decimal> moedas = Tuple.Create("20220623", "BRLGBP", 0.1576m);
            Console.WriteLine("3-Tuple with data: {0}, Par: {1}, Cotacao: {2:C5}", moedas.Item1, moedas.Item2, moedas.Item3);
            //
            //Imagined model do coins
            //20220623|BRLGBP|0.1576
            //20220623|BRLEUR|0.1837
            //20220623|BRLJPY|25,9875
            //20220623|BRLUSD|0,1929
            //
            Hashtable coins = new Hashtable();
            coins.Add(String.Concat("20220623", "BRLUSD"), 0.1929m);
            coins.Add(String.Concat("20220623", "BRLGBP"), 0.2929m);
            Console.WriteLine(coins[String.Concat("20220623", "BRLUSD")]);
            Console.WriteLine("\n\n\n");
            // 24/06/2022 - cassiofreitas - end
            //
        }
    }
}
