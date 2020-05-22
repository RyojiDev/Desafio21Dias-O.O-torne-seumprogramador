using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia13.Models
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
