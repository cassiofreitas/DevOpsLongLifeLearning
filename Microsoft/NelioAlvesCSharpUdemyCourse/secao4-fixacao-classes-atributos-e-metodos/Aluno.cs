using System.Globalization; 

namespace secao4_fixacao_classes_atributos_e_metodos
{
    internal class Aluno
    {
        public string Name;
        public double[] NotasDoAluno = new double[3];
        public double NotaFinalAluno;

        public string IsApproved()
        {
            if ( NotaFinalAluno >= 60)
            {
                return "APROVADO";
            } 
            else
            {
                return $"REPROVADO\nFALTARAM {(60 - NotaFinalAluno).ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }
        public double CalculaNotaFinal()
        {
            NotaFinalAluno = NotasDoAluno[0] + NotasDoAluno[1] + NotasDoAluno[2];
            return NotaFinalAluno;
        }
    }
}
