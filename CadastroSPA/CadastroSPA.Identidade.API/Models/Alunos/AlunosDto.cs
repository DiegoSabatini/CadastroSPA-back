namespace CadastroSPA.Identidade.API.Models.Alunos
{
    public class AlunosDto
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public Guid IdEscolaridade { get; set; }

        public string ArquivoBase64 { get; set; }
    }
}
