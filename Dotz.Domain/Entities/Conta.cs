using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Conta: EntidadeBase
    {
        public int ClienteId { get; set; }
        public int ProdutoId { get; set; }
        public DateTime DataCompra { get; set; }
        public int Pontos { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Produto Produto { get; set; }
    }
}
