using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia07.Models
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public virtual string NomePersonalizado() { return $"{this.Nome} - Aula torne-se um programador"; }
    }
}
