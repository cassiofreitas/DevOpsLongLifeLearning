namespace aula13_atividade_1
{
    public class Aluno
    {
        public int Matricula;
        public string? Nome;
        public string? Sobrenome;
        public int Telefone;
    }
    public class Escola
    {
        private Dictionary<int,Aluno> Matriculados = new Dictionary<int, Aluno>();
        public bool CadastrarAluno(int NumeroMatricula, string? Nome, string? Sobrenome, int Telefone)
        {
            Aluno NossoAluno = new Aluno();
            NossoAluno.Matricula = NumeroMatricula;
            NossoAluno.Nome = Nome;
            NossoAluno.Sobrenome = Sobrenome;
            NossoAluno.Telefone = Telefone;

            Matriculados.TryAdd(NumeroMatricula, NossoAluno);

            return true;
        }
        public bool RemoverAluno(int NumeroMatricula)
        {
            return Matriculados.Remove(NumeroMatricula);
        }
        public void ListarMatriculas()
        {
            foreach(KeyValuePair<int,Aluno> kvp in Matriculados)
            {
                Console.WriteLine($"Matrícula: {kvp.Value.Matricula} = {kvp.Value.Nome}");
            }
        }
    }
}
