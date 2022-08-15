namespace Aula14Atividade1;

internal class Program
{
    private static void Main()
    {
        int MenuOptionChoice = -1;
        Student AlunoLocal;
        Employee FuncionarioLocal;
        Course NossoCurso = new Course();
        Company NossaCia = new Company();
        
        do
        {
            AlunoLocal = new Student();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.Beep();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("\n-[ ALUNO ]-\n");
            Console.WriteLine("(1) Cadastrar aluno");
            Console.WriteLine("(2) Remover aluno");
            Console.WriteLine("(3) Atualizar cadastro aluno");
            Console.WriteLine("(4) Lançar notas do aluno");
            Console.WriteLine("(5) Listar notas do aluno");
            Console.WriteLine("(6) Listar média das notas do aluno");
            Console.WriteLine("(7) Mostrar situação do estágio do aluno");
            Console.WriteLine("\n-[ FUNCIONÁRIO ]-\n");
            Console.WriteLine("(8) Cadastrar funcionário");
            Console.WriteLine("(9) Remover funcionário");
            Console.WriteLine("(10) Atualizar cadastro funcionário");
            Console.WriteLine("(11) Mostrar situação do estágio do funcionário");
            Console.WriteLine("\n-[ Inscritos ]-\n");
            Console.WriteLine("(12) Listar todos os inscritos [ alunos e funcionários ]");
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
                    Console.WriteLine($"Status Matrícula inicial: {NossoCurso.Register(AlunoLocal)}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 2:
                    //how to unique select with AlunoLocal must be removed?
                    Console.WriteLine($"Status Remoção: {0}", NossoCurso.Remove(AlunoLocal));
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 3:
                    // how to unique select with AlunoLocal must be updated?
                    AlunoLocal.Update(AlunoLocal);
                    Console.WriteLine($"Update: {AlunoLocal.Name}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 4:
                    // how to unique select with AlunoLocal must have Grades updated?
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(1,10)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(2, 8)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(3, 9)}");
                    Console.WriteLine($"Status: {AlunoLocal.SetGrade(4, 7)}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 5:
                    // how to unique select with AlunoLocal must have Grades shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname}:\n{AlunoLocal.ShowGrades()}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 6:
                    // how to unique select with AlunoLocal must have Grades Average shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname} => Média: {AlunoLocal.AverageGrade()}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
                    Console.ReadKey();
                    break;
                case 7:
                    // how to unique select with AlunoLocal must have Status shown?
                    Console.WriteLine($"{AlunoLocal.Name} {AlunoLocal.Surname} => Status: {AlunoLocal.IsApproved()}");
                    Console.WriteLine("Após ler as informações tecle <espaço>");
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