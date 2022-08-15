using System.Collections;
using System.Text;

namespace ConversorMoedas
{
    internal class Conversor
    {
        /*
            FROM <COIN> TO BRL: <COIN> units * BRL<COIN>
            FROM BRL TO <COIN>: BRL units / BRL<COIN>
            FROM <COIN1> TO <COIN2>: (<COIN1> units * BRL<COIN1>)/BRL<COIN2>

            where:

            <COIN> = COIN != BRL
            <COIN1>,<COIN2> != BRL
        */
        //Data structures
        Stack<string> Conversoes = new Stack<string>();
        DataSource DS = new DataSource();
        //
        public decimal ConvertCoins(string dateQuote, string coinFrom, string coinTo, decimal unitsCoinFrom)
        {
            decimal conversionValue = -1;           //defaults do FAIL.
            decimal valuePair1;
            decimal valuePair2;
            string keyCoinPair1;
            string keyCoinPair2;
            bool isBRLFrom = false;
            bool isBRLTo = false;

            if (String.IsNullOrEmpty(dateQuote) ||
                String.IsNullOrEmpty(coinFrom) ||
                String.IsNullOrEmpty(coinTo) ||
                unitsCoinFrom < 0.01m)
            {
                conversionValue = -1;
            }
            else if (string.Equals(coinFrom, coinTo, StringComparison.OrdinalIgnoreCase))
            {
                conversionValue = unitsCoinFrom;
            }
            else
            {
                isBRLFrom = string.Equals("BRL", coinFrom, StringComparison.OrdinalIgnoreCase);
                isBRLTo = string.Equals("BRL", coinTo, StringComparison.OrdinalIgnoreCase);

                if (isBRLFrom || isBRLTo)
                {
                    if (isBRLFrom)
                    {
                        keyCoinPair1 = $"{dateQuote.Trim()}{coinFrom.Trim()}{coinTo.Trim()}";
                    }
                    else
                    {
                        keyCoinPair1 = $"{dateQuote.Trim()}{coinTo.Trim()}{coinFrom.Trim()}";
                    }

                    valuePair1 = DS.SearchTradePairs(keyCoinPair1);

                    if (valuePair1 > 0)
                    {
                        if (isBRLFrom)
                        {
                            conversionValue = unitsCoinFrom / valuePair1;
                        }
                        else
                        {
                            conversionValue = unitsCoinFrom * valuePair1;
                        }
                    }
                }
                else
                {
                    keyCoinPair1 = $"{dateQuote.Trim()}BRL{coinFrom.Trim()}";
                    keyCoinPair2 = $"{dateQuote.Trim()}BRL{coinTo.Trim()}";
                    //
                    valuePair1 = DS.SearchTradePairs(keyCoinPair1);
                    valuePair2 = DS.SearchTradePairs(keyCoinPair2);

                    Console.WriteLine($"\t\t\t\t\t{valuePair1};{valuePair2}");

                    if (valuePair1 > 0m && valuePair2 > 0m)
                    {
                        conversionValue = (unitsCoinFrom * valuePair1) / valuePair2;
                    }
                }
            }
            return conversionValue;
        }
        public string AddConversionToStack(string conversionText)
        {
            Conversoes.Push(conversionText);
            return conversionText;
        }
        public string ListConversionToStack(int numberOfItemsToList)
        {
            int addedItens = 0;
            StringBuilder stackList = new StringBuilder();

            numberOfItemsToList = Math.Min(numberOfItemsToList, 10);

            stackList.AppendLine($"Últimas {numberOfItemsToList} conversões:");

            foreach (string stackItem in Conversoes)
            {
                stackList.AppendLine(stackItem);
                if (++addedItens >= numberOfItemsToList)
                {
                    break;
                }
            }
            return stackList.ToString();
        }
    }
}
