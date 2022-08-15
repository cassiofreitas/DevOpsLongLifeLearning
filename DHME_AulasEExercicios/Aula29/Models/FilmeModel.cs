namespace Aula29.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string? Nome{ get; set; }
        public DateTime DataLancamento{ get; set; }
        public TimeSpan Duracao{ get; set; }
    }
}
