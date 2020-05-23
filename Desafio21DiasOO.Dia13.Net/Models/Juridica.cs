using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia13.Net.Models
{
    public class Juridica : Pessoa
    {
       public Juridica() { }

        public string Cnpj { get; set; }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        internal object ToList()
        {
            throw new NotImplementedException();
        }
    }
}
