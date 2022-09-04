using CadastroSPA.Cadastro.Application.Services.Interface;
using CadastroSPA.Cadastro.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CadastroSPA.Cadastro.API.Controllers
{
    public class EscolaridadeController : ApiController
    {
        private readonly IEscolaridadeAppService _escolaridadeAppService;

        public EscolaridadeController(IEscolaridadeAppService escolaridadeAppService)
        {
            _escolaridadeAppService = escolaridadeAppService;
        }


        [HttpPost("nova-escolaridade")]
        public async Task<ActionResult> Registrar(EscolaridadeViewModel escolaridade)
        {
            if (!ModelState.IsValid) return CustomResponse(ModelState);

            var user = new IdentityUser
            {
                UserName = usuarioRegistro.Email,
                Email = usuarioRegistro.Email,
                EmailConfirmed = true
            };

            var result = await _userManager.CreateAsync(user, usuarioRegistro.Senha);

            if (result.Succeeded)
            {
                return CustomResponse(await GerarJwt(usuarioRegistro.Email));
            }

            foreach (var error in result.Errors)
            {
                AdicionarErroProcessamento(error.Description);
            }

            return CustomResponse();
        }

    }
}
