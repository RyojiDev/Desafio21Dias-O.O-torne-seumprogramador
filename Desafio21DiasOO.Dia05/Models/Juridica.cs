using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia05.Models
{
    class Juridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }

        public Juridica(string cnpj, string nomeFantasia)
        {
            Cnpj = cnpj;
            NomeFantasia = nomeFantasia;
        }

        public Juridica(string cnpj,string nomeFantasia,string Nome,string Endereco) : base(Nome,Endereco)
        {
            this.Nome = Nome;
            this.Endereco = Endereco;
        }


    }
}
