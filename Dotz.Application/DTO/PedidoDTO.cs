using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.DTO
{
    public class PedidoDTO: BaseDTO
    {
        public int NomeCliente{ get; set; }
        public int DescricaoProduto{ get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
