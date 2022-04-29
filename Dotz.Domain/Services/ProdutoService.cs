using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class ProdutoService : ServicoBase<Produto>,  IProdutoRepository
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            :base(produtoRepository)
        {
            this._produtoRepository = produtoRepository;
        }
        //public Task Add(Produto entity)
        //{
        //    return this._produtoRepository.Add(entity);
        //}

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<List<Produto>> GetAll()
        //{
        //    return this._produtoRepository.GetAll();
        //}

        //public Task<Produto> GetById(int id)
        //{
        //    return this._produtoRepository.GetById(id);
        //}

        //public Task Remove(int id)
        //{
        //    return this._produtoRepository.Remove(id);
        //}

        //public Task Update(Produto entity)
        //{
        //    return this._produtoRepository.Update(entity);
        //}
    }
}
