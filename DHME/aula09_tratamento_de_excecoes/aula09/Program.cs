double resultado = 0;

double somarValor(double valor) 
{
    resultado = pegarResultadoDaUltimaOperacaoMatematica() + valor;
    definirResultadoDaUltimaOperacaoMatematica(resultado);
    return resultado;
}

double subtrairValor(double valor) 
{
    resultado = pegarResultadoDaUltimaOperacaoMatematica() - valor;
    definirResultadoDaUltimaOperacaoMatematica(resultado);
    return resultado;
}

double dividirValor(double valor)
{
    try
    {
        return pegarResultadoDaUltimaOperacaoMatematica() / resultado;
    }
    catch (Exception erro)
    {
        Console.WriteLine("CodError001 - Divisão por 0 não é possível");
        Console.WriteLine(erro.GetType());
    }

    return resultado;
}

double multiplicarValor(double valor) 
{
    resultado = pegarResultadoDaUltimaOperacaoMatematica() * valor;
    definirResultadoDaUltimaOperacaoMatematica(resultado);
    return resultado;
}

double zerarResultado() 
{
    resultado = 0;
    return pegarResultadoDaUltimaOperacaoMatematica();
}
;

double pegarResultadoDaUltimaOperacaoMatematica() 
{
    return resultado;
}

void definirResultadoDaUltimaOperacaoMatematica(double resultadoDaOperacao) 
{
    resultado = resultadoDaOperacao;
}


int opcao;
double valor;

try
{
    do
    {
        Console.WriteLine(" Qual operãção deseja realizar? \n 0 - Sair \n 1 - Somar \n 2 - Subtrair \n 3 - Multiplicar \n 4 - Dividir \n 5 - Zerar Calculadora");
        opcao = Int32.Parse(Console.ReadLine());

        switch (opcao)
        {

            case 0:
                Console.WriteLine("See You Later, Alligator!\n After A While, Crocodile!\n THX!! BYEE!!!");
                break;

            case 1:
                Console.WriteLine("Você digitou 1 - Somar");
                Console.Write("Qual valor deseja somar?: ");
                valor = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"O resultado é {somarValor(valor)}\n");
                break;

            case 2:
                Console.WriteLine("Você digitou 2 - Subtrair");
                Console.Write("Qual valor deseja subtrair?: ");
                valor = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"O resultado é {subtrairValor(valor)}\n");
                break;

            case 3:
                Console.WriteLine("Você digitou 3 - Multiplicar");
                Console.Write("Qual valor deseja multiplicar?: ");
                valor = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"O resultado é {multiplicarValor(valor)}\n");
                break;

            case 4:
                Console.WriteLine("Você digitou 4 - Dividir");
                Console.Write("Qual valor deseja dividir?: ");
                valor = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"O resultado é {dividirValor(valor)}\n");
                break;

            case 5:
                Console.WriteLine("Você digitou 5 - Zerar Calculadora");
                Console.WriteLine($"A calculadora foi zerada {zerarResultado()} :) \n");
                break;

            default:
                Console.WriteLine("Essa opção não existe!");
                break;
        }

    } while (opcao != 0);
}

catch(Exception erro)
{
    Console.WriteLine("CodError002 - O usuário não pode inserir qualquer valor além de números.");
    Console.WriteLine(erro.GetType());
}