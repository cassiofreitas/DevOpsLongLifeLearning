namespace pre_pos_incremento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0;
            int valor2 = 0;
            int newValue1 = 0;
            int newValue2 = 0;

            Console.WriteLine($"valor1 ANTES de usar valor1++: {valor1}");
            Console.WriteLine($"valor2 ANTES de usar ++valor2: {valor2}");
            Console.WriteLine($"newValue1 ANTES da atribuicao de valor1++: {newValue1}");
            Console.WriteLine($"newValue2 ANTES da atribuicao de ++valor2: {newValue2}");
            newValue1 = valor1++;
            newValue2 = ++valor2;
            Console.WriteLine($"valor1 DEPOIS de usar valor1++: {valor1}");
            Console.WriteLine($"valor2 DEPOIS de usar ++valor2: {valor2}");
            Console.WriteLine($"newValue1 DEPOIS da atribuicao de valor1++: {newValue1}");
            Console.WriteLine($"newValue2 DEPOIS da atribuicao de ++valor2: {newValue2}");
        }
    }
}