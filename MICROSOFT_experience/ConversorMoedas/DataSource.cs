using System.Collections;
using System.Text;

namespace ConversorMoedas
{
    internal class DataSource
    {
        private static readonly Dictionary<string,decimal> coinsTradePairs = new Dictionary<string,decimal>();
        private static readonly List<Moedas> supportedCoins = new List<Moedas>();
        public void InitialDataLoad()                       //Simulates starting a full data load from external sources
        {
            PopulateSupportedCoinsList();
            PopulateCoinsTradePairs();
        }
        public string ListSupportedCoins()
        {
            StringBuilder ReturnStr = new StringBuilder();
            ReturnStr.Append($"{"Código",-10}{"Nome",-20}{"Símbolo"}\n");
            foreach (Moedas coins in supportedCoins)
            {
                ReturnStr.Append($"{coins.coinCodeBCB.ToString(),-10}{coins.coinNameBCB,-20}{coins.coinSimbolBCB}\n");
            }
            return ReturnStr.ToString();
        }
        private void PopulateSupportedCoinsList()            //Simulates a load from an external source
        {
            supportedCoins.Add(new Moedas(790, "REAL BRASIL", "BRL", 1058, "BRASIL", "A"));
            supportedCoins.Add(new Moedas(470, "IENE", "JPY", 3999, "JAPAO", "A"));
            supportedCoins.Add(new Moedas(790, "LIBRA ESTERLINA", "GBP", 0, "-", "B"));
            supportedCoins.Add(new Moedas(220, "DOLAR DOS EUA", "USD", 0, "-", "A"));
            supportedCoins.Add(new Moedas(978, "EURO", "EUR", 0, "-", "B"));
        }
        public decimal SearchTradePairs(string keyToSearch)
        {
            decimal valueOfKeySearched;

            if (keyToSearch != null && coinsTradePairs.TryGetValue(keyToSearch, out valueOfKeySearched))
            {
                return valueOfKeySearched;
            } else
            {
                return -1;
            }
        }
        private void PopulateCoinsTradePairs()               //Simulates a load from an external source
        {
            coinsTradePairs.Add(String.Concat("20220601", "BRLUSD"), 4.7765m);
            coinsTradePairs.Add(String.Concat("20220602", "BRLUSD"), 4.7879m);
            coinsTradePairs.Add(String.Concat("20220603", "BRLUSD"), 4.7956m);
            coinsTradePairs.Add(String.Concat("20220606", "BRLUSD"), 4.7839m);
            coinsTradePairs.Add(String.Concat("20220607", "BRLUSD"), 4.8909m);
            coinsTradePairs.Add(String.Concat("20220608", "BRLUSD"), 4.8711m);
            coinsTradePairs.Add(String.Concat("20220609", "BRLUSD"), 4.8951m);
            coinsTradePairs.Add(String.Concat("20220610", "BRLUSD"), 4.9836m);
            coinsTradePairs.Add(String.Concat("20220613", "BRLUSD"), 5.1033m);
            coinsTradePairs.Add(String.Concat("20220614", "BRLUSD"), 5.1203m);
            coinsTradePairs.Add(String.Concat("20220615", "BRLUSD"), 5.1119m);
            coinsTradePairs.Add(String.Concat("20220617", "BRLUSD"), 5.1313m);
            coinsTradePairs.Add(String.Concat("20220620", "BRLUSD"), 5.1641m);
            coinsTradePairs.Add(String.Concat("20220621", "BRLUSD"), 5.1462m);
            coinsTradePairs.Add(String.Concat("20220622", "BRLUSD"), 5.1509m);
            coinsTradePairs.Add(String.Concat("20220623", "BRLUSD"), 5.1833m);
            coinsTradePairs.Add(String.Concat("20220624", "BRLUSD"), 5.2334m);
            //
            coinsTradePairs.Add(String.Concat("20220601", "BRLGBP"), 5.9573m);
            coinsTradePairs.Add(String.Concat("20220602", "BRLGBP"), 6.0131m);
            coinsTradePairs.Add(String.Concat("20220603", "BRLGBP"), 5.9921m);
            coinsTradePairs.Add(String.Concat("20220606", "BRLGBP"), 6.2024m);
            coinsTradePairs.Add(String.Concat("20220607", "BRLGBP"), 6.1606m);
            coinsTradePairs.Add(String.Concat("20220608", "BRLGBP"), 6.1191m);
            coinsTradePairs.Add(String.Concat("20220609", "BRLGBP"), 6.1247m);
            coinsTradePairs.Add(String.Concat("20220610", "BRLGBP"), 6.1438m);
            coinsTradePairs.Add(String.Concat("20220613", "BRLGBP"), 6.2112m);
            coinsTradePairs.Add(String.Concat("20220614", "BRLGBP"), 6.1515m);
            coinsTradePairs.Add(String.Concat("20220615", "BRLGBP"), 6.1650m);
            coinsTradePairs.Add(String.Concat("20220617", "BRLGBP"), 6.2617m);
            coinsTradePairs.Add(String.Concat("20220620", "BRLGBP"), 6.3271m);
            coinsTradePairs.Add(String.Concat("20220621", "BRLGBP"), 6.3175m);
            coinsTradePairs.Add(String.Concat("20220622", "BRLGBP"), 6.3243m);
            coinsTradePairs.Add(String.Concat("20220623", "BRLGBP"), 6.3449m);
            coinsTradePairs.Add(String.Concat("20220624", "BRLGBP"), 6.4230m);
            //
            coinsTradePairs.Add(String.Concat("20220601", "BRLEUR"), 5.0851m);
            coinsTradePairs.Add(String.Concat("20220602", "BRLEUR"), 5.1393m);
            coinsTradePairs.Add(String.Concat("20220603", "BRLEUR"), 5.1375m);
            coinsTradePairs.Add(String.Concat("20220606", "BRLEUR"), 5.1183m);
            coinsTradePairs.Add(String.Concat("20220607", "BRLEUR"), 5.2323m);
            coinsTradePairs.Add(String.Concat("20220608", "BRLEUR"), 5.2325m);
            coinsTradePairs.Add(String.Concat("20220609", "BRLEUR"), 5.2167m);
            coinsTradePairs.Add(String.Concat("20220610", "BRLEUR"), 5.2432m);
            coinsTradePairs.Add(String.Concat("20220613", "BRLEUR"), 5.3263m);
            coinsTradePairs.Add(String.Concat("20220614", "BRLEUR"), 5.3343m);
            coinsTradePairs.Add(String.Concat("20220615", "BRLEUR"), 5.3108m);
            coinsTradePairs.Add(String.Concat("20220617", "BRLEUR"), 5.3750m);
            coinsTradePairs.Add(String.Concat("20220620", "BRLEUR"), 5.4430m);
            coinsTradePairs.Add(String.Concat("20220621", "BRLEUR"), 5.4292m);
            coinsTradePairs.Add(String.Concat("20220622", "BRLEUR"), 5.4507m);
            coinsTradePairs.Add(String.Concat("20220623", "BRLEUR"), 5.4440m);
            coinsTradePairs.Add(String.Concat("20220624", "BRLEUR"), 5.5165m);
            //
            coinsTradePairs.Add(String.Concat("20220601", "BRLJPY"), 0.03672m);
            coinsTradePairs.Add(String.Concat("20220602", "BRLJPY"), 0.03688m);
            coinsTradePairs.Add(String.Concat("20220603", "BRLJPY"), 0.03663m);
            coinsTradePairs.Add(String.Concat("20220606", "BRLJPY"), 0.03637m);
            coinsTradePairs.Add(String.Concat("20220607", "BRLJPY"), 0.0369m);
            coinsTradePairs.Add(String.Concat("20220608", "BRLJPY"), 0.03634m);
            coinsTradePairs.Add(String.Concat("20220609", "BRLJPY"), 0.03651m);
            coinsTradePairs.Add(String.Concat("20220610", "BRLJPY"), 0.03714m);
            coinsTradePairs.Add(String.Concat("20220613", "BRLJPY"), 0.03805m);
            coinsTradePairs.Add(String.Concat("20220614", "BRLJPY"), 0.03796m);
            coinsTradePairs.Add(String.Concat("20220615", "BRLJPY"), 0.03801m);
            coinsTradePairs.Add(String.Concat("20220617", "BRLJPY"), 0.03797m);
            coinsTradePairs.Add(String.Concat("20220620", "BRLJPY"), 0.03825m);
            coinsTradePairs.Add(String.Concat("20220621", "BRLJPY"), 0.03777m);
            coinsTradePairs.Add(String.Concat("20220622", "BRLJPY"), 0.03786m);
            coinsTradePairs.Add(String.Concat("20220623", "BRLJPY"), 0.03848m);
            coinsTradePairs.Add(String.Concat("20220624", "BRLJPY"), 0.0387m);
        }
    }
}
