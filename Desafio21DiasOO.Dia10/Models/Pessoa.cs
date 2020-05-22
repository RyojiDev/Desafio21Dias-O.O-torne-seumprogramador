using Desafio21DiasOO.Dia10.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia10.Models
{
    public abstract class Pessoa : IPessoa
    {
        public Pessoa()
        {
            
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }

        public static List<IPessoa> Busca()
        {
            return new Servico().Todos();
        }

        public abstract void Excluir();


        public void Salvar()
        {
            Servico.Salvar(this);
        }

    }
}
