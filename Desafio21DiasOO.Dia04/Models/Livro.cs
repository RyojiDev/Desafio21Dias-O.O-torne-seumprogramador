using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia04.Models
{
     public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private string Descricao { get; set; }

        protected string Autor { get; set; }

        internal string Versao { get; set; }
    }
}
