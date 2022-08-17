// See https://aka.ms/new-console-template for more information
//
// Console.Read() is to read just one char and returns an int
// Console.Readline() is to read chars, but returns a string
//
// Solution: typecast via Convert.
// Note: I want to learn to use types always.

Console.Write("Qual seu nome? ");
string nomeDoUsuario = Console.ReadLine();

Console.Write("Qual sua idade? ");
int idadeDoUsuario = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual o ano atual? ");
int anoAtual = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Olá {nomeDoUsuario}, você nasceu em {anoAtual - idadeDoUsuario}");
