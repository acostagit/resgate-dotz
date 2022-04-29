using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Categoria : EntidadeBase
    {
        public Categoria()
        {

        }

        public string Nome { get; set; }
        //public int SubCategoriaId { get; set; }

        //public ICollection<SubCategoria> SubCategorias { get; set; }
        public Categoria(string nome)
        {
            Nome = nome;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }

        public void Validar()
        {
            Validation.Validacoes.ValidarSeVazio(Nome, "O campo Nome não pode estar vazio.");        
        }
    }
}
