using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia13.Models
{
    public class Fisica : Pessoa
    {
       public Fisica() { }

        public string Cpf { get; set; }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public List<Fisica> ToList()
        {
            throw new NotImplementedException();
        }
    }
}
