using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Validation
{
    public class Validacoes
    {
        public static void ValidarSeIgual(object obj1, object objt2, string mensagem)
        {
            if (!obj1.Equals(objt2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeDiferente(object obj1, object objt2, string mensagem)
        {
            if (obj1.Equals(objt2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length ==0)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeVazio(object valor, string mensagem)
        {
            if (valor == null)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeSaldoMenor(double valor, string mensagem)
        {
            if (valor <= 0)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSePontuacaoMinima(int valor, string mensagem)
        {
            if (valor <= 0)
            {
                throw new DomainException(mensagem);
            }
        }
    }
}
