using System;

namespace ORMDesafio21Dias
{
    public class Service
    {
        private string connectionString;
        private IType iType;

        public Service()
        {

        }

        public Service(IType _iType)
        {
            this.connectionString = iType.ConnectionString;
        }
    }
}
