using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Interfaces
{
    public interface IRepositoryBase<TEntity> : IDisposable where TEntity : EntidadeBase
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Remove(int id);        
        //Task<int> SaveChanges();
    }
}
