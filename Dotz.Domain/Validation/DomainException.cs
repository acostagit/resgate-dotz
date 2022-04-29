using System;
using System.Collections.Generic;
using System.Text;

namespace Dotz.Domain.Validation
{
    public class DomainException: Exception
    {
        public DomainException()
        {

        }

        public DomainException( string message): base(message)
        {

        }
    }
}
