using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia04.Models
{
    public class Editora
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        private string Descricao { get; set; }

        protected string Autor { get; set; }

        public string Versao { get; set; }

        public void Acao()
        {
            new Livro()
            {
                Versao = "1.0"
            };
        }
    }
}
