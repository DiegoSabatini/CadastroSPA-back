using AutoMapper;
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
            await _escolaridadeAppService.Adicionar(escolaridade);



            return CustomResponse(escolaridade);
        }

    }
}
