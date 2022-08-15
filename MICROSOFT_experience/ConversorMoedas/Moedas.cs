using System.Collections;

namespace ConversorMoedas
{
    internal class Moedas
    {
        /*
         * Código   Nome	        Símbolo	Cód.País	País	Tipo	
         * 790      REAL BRASIL	    BRL	    01058	    BRASIL	A	
         * 470      IENE	        JPY	    03999	    JAPAO	A	
         * 540      LIBRA ESTERLINA GBP	    0000	    -	    B
         * 220	    DOLAR DOS EUA	USD	    0000	    -	    A
        */
        public readonly int coinCodeBCB;
        public readonly string? coinNameBCB;
        public readonly string? coinSimbolBCB;
        private int coinCodeCountryBCB;
        private string? coinCountryBCB;
        private string? coinTypeBCB;
        public Moedas(int coinCode, string coinName, string coinSimbol, int coinCodeCountry, string coinCountry, string coinType)
        {
            this.coinCodeBCB = coinCode;
            this.coinNameBCB = coinName;
            this.coinSimbolBCB = coinSimbol;
            this.coinCodeCountryBCB = coinCodeCountry;
            this.coinCountryBCB = coinCountry;
            this.coinTypeBCB = coinType;
        }
    }
}
