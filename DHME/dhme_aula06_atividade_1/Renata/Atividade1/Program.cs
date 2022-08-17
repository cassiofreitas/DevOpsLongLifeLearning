var nomeDoUsuario = "";
var idadeDoUsuario = 0;
var anoAtual = DateTime.Now.Year;

Console.WriteLine("Digite o seu nome: ");
nomeDoUsuario = Console.ReadLine();
Console.WriteLine("Digite a sua idade: ");
idadeDoUsuario = Convert.ToInt32(Console.ReadLine());
var anoNascimento = (anoAtual - idadeDoUsuario);
Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {anoNascimento} ");

Console.WriteLine();
Console.WriteLine("Responda, quais recursos foram utilizados para resolução desse problema?");
Console.WriteLine("Operadores, variáveis e Console.Write(), Console.Read().");

Console.WriteLine();
Console.WriteLine("Responda, quais tipos de variáveis foram utilizadas nessa atividade?");
Console.WriteLine("string e int");