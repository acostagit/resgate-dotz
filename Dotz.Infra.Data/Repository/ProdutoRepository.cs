using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using Dotz.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace Dotz.Infra.Data.Repository
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        private readonly ResgateContext context;

        public ProdutoRepository(ResgateContext context)
            : base(context)
        {
            this.context = context;
        }

        //Listagem de produtos disponives para entrega
        public async Task<IEnumerable<Produto>> ListarProdutosDisponiveisParaEntrega()
        {
            var produtos = (from p in context.Produtos
                            group p by p.Descricao into lista
                            select new
                            {
                                lista
                            }).ToListAsync();

            return (IEnumerable<Produto>)await produtos;
        }

        
    }
}
