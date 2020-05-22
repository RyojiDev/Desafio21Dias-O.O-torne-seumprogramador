using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia05.Models
{
    class Fisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Rg { get; set; }

        public Fisica() : base ()
        {
            
        }

        public Fisica(string cpf, string rg)
        {
            Cpf = cpf;
            Rg = rg;
        }
    }
}
