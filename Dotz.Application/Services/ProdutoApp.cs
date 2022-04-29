using AutoMapper;
using Dotz.Application.DTO;
using Dotz.Application.Interfaces;
using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using Dotz.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Application.Services
{
    public class ProdutoApp: IProdutoApp
    {
        private readonly IProdutoRepository _produtoService;
        private readonly IEstoqueService _estoqueService;
        private readonly IMapper _mapper;
        public ProdutoApp(IMapper mapper, IProdutoRepository produtoService, IEstoqueService estoqueService)            
        {
            this._produtoService = produtoService;
            this._estoqueService = estoqueService;
            this._mapper = mapper;
        }

        public void Alterar(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _produtoService.Update(produto);            
        }

        public void Excluir(int id)
        {
            _produtoService.Remove(id);
        }

        public void Excluir(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            _produtoService.Remove(produtoDTO.Id);
        }

        public int Incluir(ProdutoDTO produtoDTO)
        {
            var produto = _mapper.Map<Produto>(produtoDTO);
            return _produtoService.Add(produto).Id;

            //await _produtoRepository.UnitOfWork.Commit();

          
        }

        public ProdutoDTO SelecionarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutoDTO> SelecionarTodos()
        {
            throw new NotImplementedException();
        }

        public async Task<ProdutoDTO> ReporEstoque(int id, int quantidade)
        {
            if (!_estoqueService.ReporEstoque(id, quantidade).Result)
            {
                throw new DomainException("Falha ao repor estoque");
            }

            return _mapper.Map<ProdutoDTO>(await _produtoService.GetById(id));
        }

        public async Task<ProdutoDTO> DebitarEstoque(int id, int quantidade)
        {
            if (!_estoqueService.DebitarEstoque(id, quantidade).Result)
            {
                throw new DomainException("Falha ao debitar estoque");
            }

            return _mapper.Map<ProdutoDTO>(await _produtoService.GetById(id));
        }
    }
}
