namespace secao4_fixacao_classes_atributos_e_metodos
{
    internal class Retangulo
    {
        public double Largura;
        public double Altura;
        public double Area()
        {
            return Largura * Altura;
        }
        public double Perimetro()
        {
            return 2 * (Altura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Altura,2) + Math.Pow(Largura,2));
        }

    }
}
