using AutoMapper;
using Dotz.Application.DTO;
using Dotz.Application.Interfaces;
using Dotz.Domain.Interfaces;
using Dotz.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.Services
{
    public class PedidoApp : IPedidoApp
    {
        private readonly IPedidoRepository _repositoryPedido;
        private readonly IMapper _mapper;
        public PedidoApp(IMapper mapper, IPedidoRepository repositoryPedido)
        {
            this._repositoryPedido = repositoryPedido;            
            this._mapper = mapper;
        }
        public void Alterar(PedidoDTO entidade)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Excluir(PedidoDTO entidade)
        {
            throw new NotImplementedException();
        }

        public int Incluir(PedidoDTO entidade)
        {
            throw new NotImplementedException();
        }

        public PedidoDTO SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PedidoDTO> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
