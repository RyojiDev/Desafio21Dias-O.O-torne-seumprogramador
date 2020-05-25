using System;
using System.Collections.Generic;
using System.Text;

namespace ORMDesafio21Dias
{
    public abstract class Ctype : IType , IConnectionString
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Salvar()
        {
            new Service(this);
        }
    }
}
