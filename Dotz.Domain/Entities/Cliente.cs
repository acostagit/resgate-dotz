using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class Cliente: EntidadeBase
    {
        public int EnderecoEntregaId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public EnderecoEntrega EnderecoEntrega { get; set; }
    }
}
