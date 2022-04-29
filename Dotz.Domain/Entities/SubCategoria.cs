using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class SubCategoria : EntidadeBase
    {
        public SubCategoria(string nome)
        {
            Nome = nome;
        }

        public int CategoriaId { get; set; }

        public string Nome { get; set; }
        public ICollection<Categoria> Categorias { get; set; }
       
        public void Validar()
        {
            Validation.Validacoes.ValidarSeVazio(CategoriaId, "O campo CategoriaId não pode estar vazio.");
            Validation.Validacoes.ValidarSeVazio(Nome, "O campo Nome não pode estar vazio.");
            //Validation.Validacoes.ValidarSeVazio(Categorias, "O campo Categoria não pode estar vazio.");
        }
    }
}
