using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using Dotz.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Infra.Data.Repository
{
    public class ContaRepository : RepositoryBase<Conta>, IContaRepository
    {
        private readonly ResgateContext context;

        public ContaRepository(ResgateContext context)
            : base(context)
        {
            this.context = context;
        }
    }
}
