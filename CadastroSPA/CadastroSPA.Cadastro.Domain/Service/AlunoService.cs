using CadastroSPA.Cadastro.Domain.Models;
using CadastroSPA.Cadastro.Domain.Repository;
using CadastroSPA.Cadastro.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSPA.Cadastro.Domain.Service
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository)
        {
            _alunoRepository = alunoRepository;
        }

        public void Adicionar(Alunos aluno)
        {
            _alunoRepository.Adicionar(aluno);
        }

        public void Atualizar(Alunos aluno)
        {
            _alunoRepository.Atualizar(aluno);
        }

        public async Task<IEnumerable<Alunos>> ObterTodos()
        {
            return await _alunoRepository.ObterTodos();
        }

        public void Dispose()
        {
            _alunoRepository.Dispose();
        }

        public async Task<Alunos> ObterPorId(Guid id)
        {
            return await _alunoRepository.ObterPorId(id);
        }
    }
}
