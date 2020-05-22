using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia11.Models
{
    public class Fisica : Pessoa
    {
       public Fisica() { }

        public string Cpf { get; set; }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
