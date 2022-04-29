using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Produto.Domain
{
    public class Produto
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int PontuacaoMinima { get; set; }

        public Produto(string descricao, decimal valor, DateTime dataCadastro, int quantidadeEstoque, int pontuacaoMinima)
        {
            Descricao = descricao;
            Valor = valor;
            DataCadastro = dataCadastro;
            QuantidadeEstoque = quantidadeEstoque;
            PontuacaoMinima = pontuacaoMinima;
        }

        public void AdicionarProduto(Produto produto)
        {

        }
    }
}
