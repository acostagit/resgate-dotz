using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class ServicoBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntidadeBase
    {
        protected readonly IRepositoryBase<TEntity> repositorio;

        public ServicoBase(IRepositoryBase<TEntity> repositorio)
        {
            this.repositorio = repositorio;
        }
        public Task Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
