using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Application.DTO
{
    public class ClienteDTO: BaseDTO
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }

        public EnderecoEntregaDTO EnderecoEntregaDTO { get; set; }
    }
}
