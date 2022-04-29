using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Pedido: EntidadeBase
    {
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }        
        public DateTime DataCadastro { get; set; }
       // public List<PedidoItem> PedidoItens { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
