using ExDesafio21DiasOO.Dia12.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExDesafio21DiasOO.Dia12.Models
{
    public abstract class Pessoa : IPessoa
    {
        public Pessoa()
        {
            
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public  List<IPessoa> Busca()
        {
            return new Servico(this).Busca();
        }

        public abstract void Excluir();


        public void Salvar()
        {
            Servico.Salvar(this);
        }

        public override string ToString()
        {
            return this.Nome;
        }

    }
}
