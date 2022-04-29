using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Infra.Data.Repository
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : EntidadeBase
    {
        private readonly ResgateContext context;

        public RepositoryBase(ResgateContext resgateContext)
        {
            this.context = resgateContext;
        }

        public virtual async Task Add(TEntity entity)
        {
            context.InitTransacao();
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {            
            return await context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await context.Set<TEntity>().FindAsync(id);
        }

        public virtual async Task Remove(int id)
        {
            context.Remove(id);
            await context.SaveChangesAsync();
        }

        public virtual async Task Update(TEntity entity)
        {
            context.InitTransacao();
            context.Set<TEntity>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            //context.SendChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
