namespace PrimeiraApp.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        public string? Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public string? Email { get; set; }

        public string? EmailConfirmacao { get; set; }

        public int Avaliacao { get; set; }

        public bool Ativo { get; set; }
    }
}
