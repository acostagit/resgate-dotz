using Dotz.Domain.Entities;
using Dotz.Domain.Interfaces;
using Dotz.Infra.Data.Context;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Dotz.Infra.Data.Repository
{
   public  class PedidoRepository : RepositoryBase<Pedido>, IPedidoRepository
    {
        private readonly ResgateContext context;

        public PedidoRepository(ResgateContext context)
            : base(context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Pedido>> ListagemPedidosEntrega()
        {
            var pedidos = from p in context.Pedidos
                          join c in context.Clientes on p.ClienteId equals c.Id
                          join d in context.Produtos on p.ProdutoId equals d.Id
                          select new
                          {
                              Numero = p.Id,
                              DataCadastro = p.DataCadastro,
                              Descricao = p.Produto.Descricao,
                              Nome = p.Cliente.Nome
                          };

            return (IEnumerable<Pedido>)await pedidos.ToListAsync();
        }

        //PeditoItem
        public void AdicionarItem(PedidoItem pedidoItem)
        {
            context.PedidoItems.Add(pedidoItem);
        }

        public void AtualizarItem(PedidoItem pedidoItem)
        {
            context.PedidoItems.Update(pedidoItem);
        }

        public void RemoverItem(PedidoItem pedidoItem)
        {
            context.PedidoItems.Remove(pedidoItem);
        }
    }
}
