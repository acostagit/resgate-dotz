using Dotz.Application.DTO;
using Dotz.Domain.Entities;
using System.Collections.Generic;

namespace Dotz.Application.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO>
        where TEntidade : EntidadeBase
        where TEntidadeDTO : BaseDTO
    {
        int Incluir(TEntidadeDTO entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();
    }
}
