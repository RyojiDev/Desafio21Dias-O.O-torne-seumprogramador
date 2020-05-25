using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDesafio21Dias
{
    interface IType : IConnectionString
    {
        public int Id { get; set; }
    }
}
