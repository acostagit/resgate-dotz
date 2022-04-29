using Dotz.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.DTO
{
    public class ProdutoDTO: BaseDTO
    {
        public int NomeSubCategoria{ get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int PontuacaoMinima { get; set; }
        public ICollection<SubCategoria> SubCategorias { get; set; }
    }
}
