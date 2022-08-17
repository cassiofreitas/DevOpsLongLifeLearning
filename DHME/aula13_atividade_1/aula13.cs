//Room 3 - 21/06/2022
//
namespace aula13_atividade_1
{
    enum CatalogoErros
    {
        OK = 200,
        Redirecionamento_permanente = 301,
        Redirecionamento_temporario = 302,
        Nao_encontrado = 404,
        Nao_autorizado = 405,
        Servidor_indisponivel = 503,
        Tempo_esgotado = 504
    }
    internal class aula13
    {
        static void Main(string[] args)
        {
            Escola NossaEscola = new Escola();
            int RespostaDoServidor;

            Console.Write("-[ Inserindo novos alunos ");
            NossaEscola.CadastrarAluno(1,"Maria","Jose",555999);
            NossaEscola.CadastrarAluno(2,"Jose","Maria",666888);
            NossaEscola.CadastrarAluno(3, "Joaquim", "Couves", 777555);
            NossaEscola.CadastrarAluno(4, "Pablo", "Picasso", 888444);
            NossaEscola.CadastrarAluno(5, "Hugo", "Sanchez", 999333);
            Console.WriteLine("]-");

            Console.WriteLine("-[ Listando os alunos inseridos");
            NossaEscola.ListarMatriculas();
            Console.WriteLine("]-");

            Console.Write("-[ Removendo aluno com Matrícula = 5: ");
            Console.Write(NossaEscola.RemoverAluno(5));
            Console.WriteLine(" ]-");

            Console.WriteLine("-[ Listando os alunos após a remoção: ");
            NossaEscola.ListarMatriculas();
            Console.WriteLine("]-");

            Console.WriteLine($"-[ Testando Catalogo de Erros para {CatalogoErros.Redirecionamento_permanente}");
            RespostaDoServidor = (int)CatalogoErros.Redirecionamento_permanente;
            Console.Write($"Resposta do Servidor = {RespostaDoServidor}");
            Console.WriteLine(" ]-");
        }
    }
}