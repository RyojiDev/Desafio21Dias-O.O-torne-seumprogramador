using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia11.Models
{
    public class Juridica : Pessoa
    {
       public Juridica() { }

        public string Cnpj { get; set; }
        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
