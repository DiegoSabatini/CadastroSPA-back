using Microsoft.AspNetCore.Mvc;

namespace CadastroSPA.Cadastro.API.Controllers
{
    public class AlunoController : ApiController
    {
        [HttpPost("listar")]
        public void Listar()
        {
            Task.CompletedTask.Wait();
        }
    }
}
