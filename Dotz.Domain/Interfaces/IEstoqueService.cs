using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dotz.Domain.Interfaces
{
    public interface IEstoqueService
    {
        Task<bool> DebitarEstoque(int produtoId, int quantidade);
        Task<bool> ReporEstoque(int produtoId, int quantidade);
    }
}
