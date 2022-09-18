using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Cadastro.Domain.Service.Interface;
using CadastroSPA.Identidade.API.Extensions;
using CadastroSPA.Identidade.API.Models;
using CadastroSPA.Identidade.API.Models.Escolaridade;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CadastroSPA.Identidade.API.Controllers
{
    public class EscolaridadeController : ApiController
    {
        private readonly AppSettings _appSettings;
        private readonly IEscolaridadeService _escolaridadeService;

        public EscolaridadeController(IOptions<AppSettings> appSettings, IEscolaridadeService escolaridadeService)
        {
            _appSettings = appSettings.Value;
            _escolaridadeService = escolaridadeService;
        }

        [HttpPost("nova-escolaridade")]
        public async Task<ActionResult> Registrar(EscolaridadeDto escolaridade)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            await _escolaridadeService.Adicionar(new Escolaridade(escolaridade.Descricao));


            return CustomResponse();
        }

        [HttpGet("listar-escolaridade")]
        public async Task<ActionResult> Listar()
        {
            return CustomResponse(await _escolaridadeService.ObterTodos());
        }


        private static long ToUnixEpochDate(DateTime date)
            => (long)Math.Round((date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, TimeSpan.Zero)).TotalSeconds);

    }
}
