using CadastroSPA.Cadastro.Application.Services.Interface;
using CadastroSPA.Cadastro.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Application.Services
{
    public class AlunoAppService : IAlunoAppService
    {
        public async Task<bool> Adicionar(AlunoViewModel produto)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Atualizar(AlunoViewModel produto)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AlunoViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}
