using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
   public class Produto: EntidadeBase
    {
        public int SubCategoriaId { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int PontuacaoMinima { get; set; }
        public ICollection<SubCategoria> SubCategorias { get; set; }

        public void DebitarEstoque(int quantidade)
        {
            if (quantidade < 0) quantidade *= -1;
            this.QuantidadeEstoque -= quantidade;
        }

        public void ReporEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public bool PossuiEstoque(int quantidade)
        {
            return QuantidadeEstoque >= quantidade;
        }

        public void Validar()
        {
            Validation.Validacoes.ValidarSeVazio(Descricao, "O campo Descrição não pode estar vazio.");
            Validation.Validacoes.ValidarSeVazio(SubCategoriaId, "O campo SubCategoria não pode estar vazio.");
            Validation.Validacoes.ValidarSeVazio(QuantidadeEstoque, "O campo QuantidadeEstoque não pode estar vazio.");
            Validation.Validacoes.ValidarSeSaldoMenor(QuantidadeEstoque, "Saldo não pode ser menor ou igual a zero.");
            Validation.Validacoes.ValidarSePontuacaoMinima(PontuacaoMinima, "Pontuação minima ncessário para resgatar o produto");
        }
    }

}
