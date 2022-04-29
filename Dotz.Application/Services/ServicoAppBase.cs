using AutoMapper;
using Dotz.Application.DTO;
using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.Services
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        protected readonly IRepositoryBase<TEntidade> servico;
        protected readonly IMapper mapper;

        public void Alterar(TEntidadeDTO entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            throw new NotImplementedException();
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            throw new NotImplementedException();
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
