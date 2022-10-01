using System.ComponentModel.DataAnnotations;

namespace CadastroSPA.Identidade.API.Models.Alunos
{
    public class AlunosDto
    {
        public Guid Id { get; set; } = new Guid();

        [Required(ErrorMessage = "{0} obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        public string Sobrenome { get; set; }

        [Required (ErrorMessage = "{0} obrigatório.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "{0} obrigatório.")]
        public Guid IdEscolaridade { get; set; }

    }
}
