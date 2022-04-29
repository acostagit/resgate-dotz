using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.DTO
{
    public class ContaDTO: BaseDTO
    {
        public int NomeCliente { get; set; }
        public int DescricaoProduto{ get; set; }
        public DateTime DataCompra { get; set; }
        public int Pontos { get; set; }
    }
}
