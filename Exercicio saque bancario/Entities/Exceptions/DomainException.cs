using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_saque_bancario.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }
    }
}
