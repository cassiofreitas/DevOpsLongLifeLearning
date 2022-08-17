Console.WriteLine("Qual é seu nome?");
string nome = Console.ReadLine();

Console.WriteLine("Qual sua idade?");
int idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual é o ano atual?");
int anoAtual = int.Parse(Console.ReadLine());

int anoNascimento = anoAtual - idade;

Console.WriteLine($"Olá {nome}, você nasceu em {anoNascimento}");
