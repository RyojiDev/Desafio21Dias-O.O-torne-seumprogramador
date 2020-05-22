using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia08
{
    public abstract class Pessoa : IPessoa
    {
        public Pessoa()
        {

        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public abstract void Busca();

        public abstract void Excluir();
        

        public virtual string NomePersonalizado() { return $"{this.Nome} - Aula torne-se um programador"; }

        public abstract void Salvar();
        
    }
}
