using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Entities
{
    public class EnderecoBase : EntidadeBase
    {
        public string Descricao { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
    }
}
