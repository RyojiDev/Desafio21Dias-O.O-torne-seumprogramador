using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio21DiasOO.Dia08.
{
    public class Fisica : Pessoa
    {
        public static List<Fisica> Base = new List<Fisica>();
        public Fisica(string nome)
        {
            this.Nome = nome;
            this.NomePersonalizado();
        }

        public Fisica()
        {
        }

       

        public string CPF { get; set; }

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
            foreach(var inst in Fisica.Base)
            {
                if (inst.Nome.Contains(nome))
                {
                    novaLista.Add(inst);
                }
            }

            return novaLista;
        }

        public static void MostrarLista()
        {
            Console.WriteLine("Carregando...");
            
            foreach (Fisica lista in Fisica.Base)
            {
                Console.WriteLine($"Nome: { lista.Nome}, Cpf: {lista.CPF} ");
            }

            return;
        }

        public override void Busca()
        {
            throw new NotImplementedException();
        }

        public override void Excluir()
        {
            throw new NotImplementedException();
        }

        public override void Salvar()
        {
            Fisica.Base.Add(this);
        }
    }
}
