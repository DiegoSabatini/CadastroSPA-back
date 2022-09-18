using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Identidade.API.Extensions;
using CadastroSPA.Identidade.API.Models;
using CadastroSPA.Identidade.API.Models.Alunos;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CadastroSPA.Identidade.API.Controllers
{
    public class AlunoController : ApiController
    {
        private readonly AppSettings _appSettings;
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(IOptions<AppSettings> appSettings, IAlunoRepository alunoRepository)
        {
            _appSettings = appSettings.Value;
            _alunoRepository = alunoRepository;
        }

        [HttpPost("novo-aluno")]
        public async Task<ActionResult> Registrar(AlunosDto aluno)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            _alunoRepository.Adicionar(new Alunos(aluno.Nome, aluno.Sobrenome,aluno.Email, aluno.DataNascimento, aluno.IdEscolaridade));

            return CustomResponse(aluno);
        }
        [HttpPost("atualizar-aluno")]
        public async Task<ActionResult> Atualizar(AlunosDto aluno)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var alunoModel = await _alunoRepository.ObterPorId(aluno.Id);
            alunoModel.Nome = aluno.Nome;
            alunoModel.Sobrenome = aluno.Sobrenome;
            alunoModel.Email = aluno.Email;
            alunoModel.DataNascimento = aluno.DataNascimento;
            alunoModel.IdEscolaridade = aluno.IdEscolaridade;

            _alunoRepository.Atualizar(alunoModel);

            return CustomResponse(aluno);

        }
    


        private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);

    }
}
