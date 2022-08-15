namespace ProjetoConversorDeMoedas
{
    public static class Conversao
    {
        public static decimal ConverterParaReal(decimal valor, decimal taxa)
        {
            return valor * taxa;
        }

        public static decimal ConverterParaOutraMoeda(decimal valor, decimal taxa)
        {
            return valor / taxa;
        }
    }
}
