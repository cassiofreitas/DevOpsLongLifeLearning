namespace Aula14Atividade1;

internal class Program
{
    private static void Main()
    {
        int MenuOptionChoice = -1;
        Student AlunoLocal;
        Course NossoCurso = new Course();
        Company NossaCia = new Company();
        
        do
        {
            AlunoLocal = new Student();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Escolha uma op��o:");
            Console.WriteLine("\n-[ ALUNO ]-\n");
            Console.WriteLine("(1) Cadastrar aluno");
            Console.WriteLine("(2) Remover aluno");
            Console.WriteLine("(3) Atualizar cadastro aluno");
            Console.WriteLine("(4) Lan�ar notas do aluno");
            Console.WriteLine("(5) Listar notas do aluno");
            Console.WriteLine("(6) Listar m�dia das notas do aluno");
            Console.WriteLine("(7) Mostrar situa��o do est�gio do aluno");
            Console.WriteLine("\n-[ FUNCION�RIO ]-\n");
            Console.WriteLine("(8) Cadastrar funcion�rio");
            Console.WriteLine("(9) Remover funcion�rio");
            Console.WriteLine("(10) Atualizar cadastro funcion�rio");
            Console.WriteLine("(11) Mostrar situa��o do est�gio do funcion�rio");
            Console.WriteLine("\n-[ Inscritos ]-\n");
            Console.WriteLine("(12) Listar todos os inscritos [ alunos e funcion�rios ]");
            //Get out.
            Console.WriteLine("\n(13) Sair");
            //
            int.TryParse(Console.ReadLine(), out MenuOptionChoice);
            //
            switch (MenuOptionChoice)
            {
                case 1:
                    AlunoLocal.Registration = 1;
                    AlunoLocal.Name = "joao";
                    AlunoLocal.Surname = "virgulino";
                    AlunoLocal.Phone = "5555-1111";
                    //
                    Console.WriteLine($"Status Matr�cula inicial: {NossoCurso.Register(AlunoLocal)}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 2:
                    //how to unique select with AlunoLocal must be removed?
                    Console.WriteLine($"Status Remo��o: {0}", NossoCurso.Remove(AlunoLocal));
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 3:
                    // how to unique select with AlunoLocal must be updated?
                    AlunoLocal.Update(AlunoLocal);
                    Console.WriteLine($"Update: {AlunoLocal.Name}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 4:
                    // how to unique select with AlunoLocal must have Grades updated?
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(1,10)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(2, 8)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(3, 9)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(4, 7)}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 5:
                    // how to unique select with AlunoLocal must have Grades shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname}:\n{AlunoLocal.ShowGrades()}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 6:
                    // how to unique select with AlunoLocal must have Grades Average shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname} => M�dia: {AlunoLocal.AverageGrade()}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 7:
                    // how to unique select with AlunoLocal must have Status shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname} => Status: {AlunoLocal.IsApproved()}");
                    Console.WriteLine("Ap�s ler as informa��es tecle <espa�o>");
                    Console.ReadKey();
                    break;
                case 8:
                    break;
                case 9:
                    break;
                case 10:
                    break;
                case 11:
                    break;
                case 12:
                    break;
                case 13:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    Environment.Exit(0);
                    break;
                default:
                    MenuOptionChoice = 0;
                    break;
            }
        } while (MenuOptionChoice is not 99);
    }
}