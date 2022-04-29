using Dotz.Domain.Interfaces;
using Dotz.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Services
{
    public class EstoqueService : IEstoqueService
    {
        //IoC aqui
        private readonly IProdutoRepository _produtoRepository;

        public EstoqueService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public async Task<bool> DebitarEstoque(int produtoId, int quantidade)
        {
            if (!await DebitarItemEstoque(produtoId, quantidade)) return false;

            return  true;
            //return await _produtoRepository.Add(new Entities.Produto());
            //return await _produtoRepository.UnitOfWork.Commit();
        }

        public Task<bool> ReporEstoque(int produtoId, int quantidade)
        {
            throw new NotImplementedException();
        }

        private async Task<bool> DebitarItemEstoque(int produtoId, int quantidade)
        {
            var produto = await _produtoRepository.GetById(produtoId);

            if (produto == null) return false;

            if (!produto.PossuiEstoque(quantidade))
            {
                //await _mediatorHandler.PublicarNotificacao(new DomainNotification("Estoque", $"Produto - {produto.Nome} sem estoque"));
                return false;
            }

            produto.DebitarEstoque(quantidade);

            // TODO: 10 pode ser parametrizavel em arquivo de configuração. Ver regra de negocio
            if (produto.QuantidadeEstoque < 10)
            {
                //await _mediatorHandler.PublicarDomainEvent(new ProdutoAbaixoEstoqueEvent(produto.Id, produto.QuantidadeEstoque));
                Validacoes.ValidarSeSaldoMenor(produto.QuantidadeEstoque, "Estoque menor!!");
            }

            await _produtoRepository.Update(produto);
            return true;
        }
    }
}
