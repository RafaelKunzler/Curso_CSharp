using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula155.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {

        public DomainExceptions(string message) : base(message)
        {
        }

    }
}
