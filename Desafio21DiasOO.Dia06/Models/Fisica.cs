using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia06.Models
{
    public class Fisica : Pessoa
    {

        public string CPF { get; set; }

        
        public Fisica(string nome)
        {
            this.Nome = nome;
            this.NomePersonalizado();
        }

       

        public override string NomePersonalizado()
        {
            return $"teste - {this.Nome}";
        }

        public string NomePersonalizado(string dado)
        {
            return $"{base.NomePersonalizado()} - teste - {dado}";
        }

        public static List<Fisica> BancoEmMemoriaDePessoasFisicas { get; set; }

        public static List<Fisica> Todas()
        {
            return Fisica.BancoEmMemoriaDePessoasFisicas;
        }

        public static void SalvarInstancia(Fisica obj)
        {
            Fisica.BancoEmMemoriaDePessoasFisicas.Add(obj);
        }

        public static List<Fisica> BuscaPorNome(string nome)
        {
            var novaLista = new List<Fisica>();
            foreach(var inst in Fisica.BancoEmMemoriaDePessoasFisicas)
            {
                if (inst.Nome.Contains(nome))
                {
                    novaLista.Add(inst);
                }
            }

            return novaLista;
        }
    }
}
