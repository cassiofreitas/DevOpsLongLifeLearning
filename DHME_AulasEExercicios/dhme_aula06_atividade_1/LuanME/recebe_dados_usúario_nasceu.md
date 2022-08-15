Console.Write("Digite seu Nome: ");
var nomeDoUsuario =  Console.ReadLine();

Console.Write("Idade: ");
var idadeDoUsuario = int.Parse(Console.ReadLine());

Console.Write("Ano Atual: ");
var anoAtual = int.Parse(Console.ReadLine());

var anoNasceu =  anoAtual - idadeDoUsuario;

Console.WriteLine("Olá " + nomeDoUsuario + ", você nasceu em " + anoNasceu);